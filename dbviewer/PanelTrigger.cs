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
    public partial class PanelTrigger : UserControl
    {
        private DBtool DB;
        private Logger Logger;

        public PanelTrigger(DBtool database, Logger logger)
        {
            DB = database;
            Logger = logger;
            InitializeComponent();
            table_trigger.TableInit(
                new string[] { "Имя", "Время", "Событие", "Действия" },
                new float[] { 20, 20, 20, 40 }
            );
        }

        public void AddRow(string v1, string v2, string v3)
        {
            table_trigger.AddRow(new Control[] {
                create_label_table(v1),
                create_label_table(v2),
                create_label_table(v3),
                create_panel_table(table_trigger.Length)
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
            elem.ColumnCount = 2;
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            elem.RowCount = 1;
            elem.RowStyles.Add(new RowStyle());
            elem.Controls.Add(create_button_table(Properties.Resources.no_entry, "Удалить", ind, new EventHandler(click_remove)), 0, 0);
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

        private void click_remove(object sender, EventArgs e)
        {
            if (!Logger.Confirm("Вы действительно хотите удалить данный триггер?")) return;
            string sql_text = "DROP TRIGGER IF EXISTS `" + ((Label)table_trigger[(int)((Button)sender).Tag][0]).Text + "`";
            if (DB.Write(sql_text))
            {
                UpdateTriggerList();
                Logger.Log(sql_text);
            }
            else
            {
                Logger.Error("Ошибка удаления триггера");
                Logger.Log(DB.Error);
                return;
            }
        }

        private void button_trig_create_Click(object sender, EventArgs e)
        {
            FormTrigger ft = new FormTrigger(DB);
            ft.ShowDialog();
            if (ft.Sql != "")
            {
                UpdateTriggerList();
                Logger.Log(ft.Sql);
            }
            ft.Dispose();
        }

        public void UpdateTriggerList()
        {
            table_trigger.Clear();
            using (MySqlDataReader reader = DB.Read("SHOW TRIGGERS FROM `" + DB.Database + "`"))
            {
                if (reader == null) return;
                while (reader.Read()) AddRow(reader.GetString(0), reader.GetString(4), reader.GetString(1));
            }
        }
    }
}
