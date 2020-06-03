using System;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormProcedure : Form
    {
        private Table_ProcedureParams ct_params;
        private DBtool DB;
        private string sql = "";

        public string Sql
        {
            get { return sql; }
        }

        public FormProcedure(DBtool DB)
        {
            this.DB = DB;
            InitializeComponent();
        }

        private void FormProcedure_Load(object sender, EventArgs e)
        {
            ct_params = new Table_ProcedureParams(proc_table_params);
            ct_params.HeaderColor = Color.Transparent;
            ct_params.RowHeight = 38;
            ct_params.Clear();
            ct_params.AddRow();
            proc_type.SelectedIndex = 0;
            proc_access_sql.SelectedIndex = 0;
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
            for (int i = 0; i < ct_params.Length; i++)
            {
                sql += ((ComboBox)ct_params[i][0]).Text;
                if (((TextBox)ct_params[i][1]).TextLength == 0)
                {
                    InfoShow.Warning("Не указано имя переменной");
                    ((TextBox)ct_params[i][1]).Focus();
                    return;
                }
                sql += " `" + ((TextBox)ct_params[i][1]).Text + "` " + ((ComboBox)ct_params[i][2]).Text;
                if (((TextBox)ct_params[i][3]).TextLength > 0)
                {
                    try
                    {
                        sql += "(" + int.Parse(((TextBox)ct_params[i][3]).Text) + ")";
                    }
                    catch
                    {
                        InfoShow.Warning("Неверно указан размер поля");
                        ((TextBox)ct_params[i][3]).Focus();
                        return;
                    }
                }
                if (i < ct_params.Length - 1) sql += ",";
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
            this.sql = sql;
            Close();
        }

        private void proc_add_param_Click(object sender, EventArgs e)
        {
            ct_params.AddRow();
        }
    }
}
