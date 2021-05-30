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
    public partial class PanelTableList : UserControl
    {
        private DBtool DB;
        private InfoShow Logger;

        public delegate void EventOnTableDelete();
        public delegate void EventOnTableClick(string table_name);
        public event EventOnTableDelete OnTableDelete;
        public event EventOnTableClick OnTableClick;

        public PanelTableList(DBtool database, InfoShow logger)
        {
            DB = database;
            Logger = logger;
            InitializeComponent();
            table_tablelist.TableInit(
                new string[] { "Таблица", "Сравнение", "Тип", "Строки", "Действия" },
                new float[] { 30, 26, 12, 12, 20 }
            );
            table_tablelist.RowClick += ClickTable;
        }

        public void ClickTable(int ind, Control[] row)
        {
            OnTableClick?.Invoke(((NoEventLabel)row[0]).Text);
        }

        public void AddRow(string table_name, string v1, string v2, string v3)
        {
            table_tablelist.AddRow(new Control[] {
                create_lable_table(table_name),
                create_lable_table(v1),
                create_lable_table(v2),
                create_lable_table(v3),
                create_panel_table(table_tablelist.Length),
            });
        }

        private NoEventLabel create_lable_table(string text)
        {
            return new NoEventLabel()
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                Margin = new Padding(0),
                Padding = new Padding(4),
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
            elem.Controls.Add(create_button_table(Properties.Resources.b_drop, "Удалить", ind, new EventHandler(remove_Click)), 0, 0);
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

        private void remove_Click(object sender, EventArgs e)
        {
            if (!InfoShow.Confirm("Вы действительно хотите удалить данную таблицу?")) return;
            string sql_text = "DROP TABLE `" + ((Label)table_tablelist[(int)((Button)sender).Tag][0]).Text + "`";
            if (DB.Write(sql_text))
            {
                OnTableDelete?.Invoke();
                Logger.Log(sql_text);
            }
            else
            {
                InfoShow.Error("Ошибка удаления таблицы");
                Logger.Log(DB.Error);
                return;
            }
        }

        public void Clear()
        {
            table_tablelist.Clear();
        }
    }
}
