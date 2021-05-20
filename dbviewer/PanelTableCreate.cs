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
    public partial class PanelTableCreate : UserControl
    {
        private DBtool DB;
        private InfoShow Logger;

        public delegate void EventOnTableCreate();
        public event EventOnTableCreate OnTableCreate;

        public PanelTableCreate(DBtool database, InfoShow logger)
        {
            DB = database;
            Logger = logger;
            InitializeComponent();
            table1.TableInit(
                new string[] { "Имя", "Тип", "Размер", "Индекс", "Подпись" },
                new float[] { 20, 20, 20, 20, 20 }
            );
            AddRow();
        }

        public void AddRow()
        {
            table1.AddRow(new Control[] {
                create_textbox_table(),
                create_combobox_table(new object[] { "INT", "FLOAT", "VARCHAR", "TEXT", "DATE" }),
                create_textbox_table(),
                create_combobox_table(new object[] { "---", "PRIMARY" }),
                create_textbox_table()
            });
        }

        public void Clear()
        {
            textbox_table_name.Clear();
            table1.Clear();
            AddRow();
        }

        private ComboBox create_combobox_table(object[] collection)
        {
            ComboBox elem = new ComboBox()
            {
                Dock = DockStyle.Top,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Margin = new Padding(4)
            };
            elem.Items.AddRange(collection);
            elem.SelectedIndex = 0;
            return elem;
        }

        private TextBox create_textbox_table()
        {
            return new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Top,
                Margin = new Padding(4)
            };
        }

        private void button_table_create_Click(object sender, EventArgs e)
        {
            if (textbox_table_name.TextLength == 0)
            {
                InfoShow.Warning("Название таблицы не может быть пустым");
                return;
            }
            int amount = 0;
            for (int i = 0; i < table1.Length; i++) if (table1[i][0].Text.Length > 0) amount++;
            if (amount <= 0)
            {
                InfoShow.Warning("Таблица не содержит ни одного поля");
                return;
            }
            List<string> ind_primary = new List<string>();
            string sql = "CREATE TABLE";
            sql += " `" + textbox_table_name.Text + "` (";
            for (int i = 0; i < table1.Length; i++)
            {
                if (table1[i][0].Text.Length <= 0) continue;
                sql += "`" + table1[i][0].Text + "` " + ((ComboBox)table1[i][1]).SelectedItem.ToString();
                if (table1[i][2].Text.Length > 0)
                {
                    try
                    {
                        sql += "(" + int.Parse(table1[i][2].Text) + ")";
                    }
                    catch
                    {
                        InfoShow.Warning("Неверно указан размер поля");
                        return;
                    }
                }
                sql += " NOT NULL";
                switch (((ComboBox)table1[i][3]).SelectedItem.ToString())
                {
                    case "PRIMARY": ind_primary.Add(table1[i][0].Text); break;
                }
                if (table1[i][4].Text.Length > 0)
                {
                    sql += " COMMENT '" + table1[i][4].Text + "'";
                }
                sql += ",";
            }
            sql = sql.Remove(sql.Length - 1);
            if (ind_primary.Count > 0) sql += ", PRIMARY KEY (`" + string.Join("`,`", ind_primary) + "`)";
            sql += ") ENGINE = InnoDB";
            if (DB.Write(sql))
            {
                OnTableCreate?.Invoke();
                Logger.Log(sql);
            }
            else
            {
                InfoShow.Error("Ошибка создания таблицы");
                Logger.Log(DB.Error);
            }
        }

        private void button_add_column_Click(object sender, EventArgs e)
        {
            AddRow();
        }
    }
}
