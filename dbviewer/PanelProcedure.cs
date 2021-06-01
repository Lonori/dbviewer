using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class PanelProcedure : UserControl
    {
        private DBtool DB;
        private Logger Logger;

        public delegate void EventOnProcedureRun();
        public event EventOnProcedureRun OnProcedureRun;

        public PanelProcedure(DBtool database, Logger logger)
        {
            DB = database;
            Logger = logger;
            InitializeComponent();
            table_procedure.TableInit(
                new string[] { "Имя", "Тип", "Действия" },
                new float[] { 25, 25, 50 }
            );
        }

        public void AddRow(string procedure_name, string procedure_type)
        {
            table_procedure.AddRow(new Control[] {
                create_label_table(procedure_name),
                create_label_table(procedure_type),
                create_panel_table(table_procedure.Length)
            });
        }

        private NoEventLabel create_label_table(string text)
        {
            return new NoEventLabel()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                Text = text
            };
        }

        private Panel create_panel_table(int ind)
        {
            TableLayoutPanel elem = new TableLayoutPanel()
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
            };
            elem.ColumnCount = 3;
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            elem.RowCount = 1;
            elem.RowStyles.Add(new RowStyle());
            elem.Controls.Add(create_button_table(Properties.Resources.circled_play, "Запустить", ind, new EventHandler(click_run)), 0, 0);
            elem.Controls.Add(create_button_table(Properties.Resources.no_entry, "Удалить", ind, new EventHandler(click_remove)), 1, 0);
            return elem;
        }

        private Button create_button_table(Image img, string text, int ind, EventHandler handler)
        {
            Button elem = new Button()
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                Image = img,
                ImageAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0),
                Padding = new Padding(0),
                Tag = ind,
                Text = "    " + text,
                TextAlign = ContentAlignment.MiddleRight
            };
            elem.Click += handler;
            elem.FlatAppearance.BorderSize = 0;
            return elem;
        }

        private void click_run(object sender, EventArgs e)
        {
            string sql = "CALL `" + ((Label)table_procedure[(int)((Button)sender).Tag][0]).Text + "`";
            SqlQueryStatus result = DB.ReadIntoCache(sql);
            if (result != SqlQueryStatus.Error)
            {
                if (result == SqlQueryStatus.Ok) OnProcedureRun?.Invoke();
                Logger.Log(sql);
            }
            else
            {
                Logger.Error("Ошибка запроса");
                Logger.Log(DB.Error);
            }
        }
        private void click_remove(object sender, EventArgs e)
        {
            if (!Logger.Confirm("Вы действительно хотите удалить данную процедуру?")) return;
            string sql_text = "DROP PROCEDURE `" + ((Label)table_procedure[(int)((Button)sender).Tag][0]).Text + "`";
            if (DB.Write(sql_text))
            {
                UpdateProcedureList();
                Logger.Log(sql_text);
            }
            else
            {
                Logger.Error("Ошибка удаления процедуры");
                Logger.Log(DB.Error);
                return;
            }
        }

        private void button_proc_create_Click(object sender, EventArgs e)
        {
            FormProcedure fp = new FormProcedure(DB);
            fp.ShowDialog();
            if (fp.Sql != "")
            {
                UpdateProcedureList();
                Logger.Log(fp.Sql);
            }
            fp.Dispose();
        }

        public void UpdateProcedureList()
        {
            table_procedure.Clear();
            using (MySqlDataReader reader = DB.Read("SHOW PROCEDURE STATUS WHERE `Db`='" + DB.Database + "'"))
            {
                while (reader.Read()) AddRow(reader.GetString(1), reader.GetString(2));
            }
        }
    }
}
