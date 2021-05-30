using System;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormProcedure : Form
    {
        private DBtool DB;
        private string _Sql = "";

        public string Sql
        {
            get { return _Sql; }
        }

        public FormProcedure(DBtool DB)
        {
            this.DB = DB;
            InitializeComponent();
            table1.TableInit(
                new string[] { "Направление", "Имя", "Тип", "Размер", "" },
                new float[] { 20, 20, 20, 20, 20 }
            );
            AddRow();
        }

        public void AddRow()
        {
            table1.AddRow(new Control[] {
                create_combobox_table(new object[] {"IN","OUT","INOUT"}),
                create_textbox_table(),
                create_combobox_table(new object[] { "INT", "FLOAT", "VARCHAR", "TEXT", "DATE" }),
                create_textbox_table(),
                create_button_table(table1.Length)
            });
        }

        private void proc_button_create_Click(object sender, EventArgs e)
        {
            string sql = "CREATE PROCEDURE";
            if (proc_name.TextLength == 0)
            {
                InfoShow.Warning("Имя процедуры не может быть пустым");
                return;
            }
            sql += " `" + proc_name.Text + "`(";
            for (int i = 0; i < table1.Length; i++)
            {
                sql += ((ComboBox)table1[i][0]).Text;
                if (((TextBox)table1[i][1]).TextLength == 0)
                {
                    InfoShow.Warning("Не указано имя переменной");
                    ((TextBox)table1[i][1]).Focus();
                    return;
                }
                sql += " `" + ((TextBox)table1[i][1]).Text + "` " + ((ComboBox)table1[i][2]).Text;
                if (((TextBox)table1[i][3]).TextLength > 0)
                {
                    try
                    {
                        sql += "(" + int.Parse(((TextBox)table1[i][3]).Text) + ")";
                    }
                    catch
                    {
                        InfoShow.Warning("Неверно указан размер поля");
                        ((TextBox)table1[i][3]).Focus();
                        return;
                    }
                }
                if (i < table1.Length - 1) sql += ",";
            }
            sql += ")";
            if (!proc_resul_type.Checked) sql += " NOT";
            if (proc_body.TextLength == 0)
            {
                InfoShow.Warning("Тело процедуры не может быть пустым");
                return;
            }
            sql += " DETERMINISTIC " + proc_access_sql.Text + " SQL SECURITY INVOKER " + proc_body.Text;
            if (!DB.Write(sql))
            {
                InfoShow.Error(DB.Error);
                return;
            }
            this._Sql = sql;
            Close();
        }

        private void proc_add_param_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private ComboBox create_combobox_table(object[] collection)
        {
            ComboBox elem = new ComboBox()
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Margin = new Padding(4, 5, 4, 4)
            };
            elem.Items.AddRange(collection);
            elem.SelectedIndex = 0;
            return elem;
        }

        private TextBox create_textbox_table()
        {
            return new TextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(4)
            };
        }

        private Button create_button_table(int num_row)
        {
            Button elem = new Button()
            {
                Anchor = AnchorStyles.Left,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Image = Properties.Resources.b_drop,
                ImageAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(4),
                Size = new Size(86, 31),
                Tag = num_row,
                Text = "удалить",
                TextAlign = ContentAlignment.MiddleRight
            };
            elem.Click += new EventHandler(remove_Click);
            elem.FlatAppearance.BorderSize = 0;
            return elem;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            table1.RemoveAt((int)((Button)sender).Tag);
            for (int i = 0; i < table1.Length; i++) ((Button)table1[i][4]).Tag = i;
        }
    }
}
