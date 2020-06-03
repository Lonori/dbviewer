using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class Table_Procedure : CustomTable
    {
        public Table_Procedure(TableLayoutPanel element) : base(element, new string[] { "Имя", "Тип", "Действия" }) { }

        public void AddRow(string procedure_name, string procedure_type)
        {
            AddRow(new Control[] {
                create_linklabel_table(SystemColors.Control, procedure_name),
                create_label_table(SystemColors.GradientInactiveCaption, procedure_type)
            });
        }

        private LinkLabel create_linklabel_table(Color backcolor, string text)
        {
            return new LinkLabel()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = backcolor,
                Margin = new Padding(0),
                Text = text
            };
        }

        private Label create_label_table(Color backcolor, string text)
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = backcolor,
                Margin = new Padding(0),
                Text = text
            };
        }
    }
}
