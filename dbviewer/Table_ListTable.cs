using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class Table_ListTable : CustomTable
    {
        public Table_ListTable(TableLayoutPanel element) : base(element, new string[] { "Таблица", "Сравнение", "Тип", "Строки", "Действия" }) { }

        public void AddRow(string table_name, string table_collation, string engine, string table_rows)
        {
            AddRow(new Control[] {
                create_linklabel_table(SystemColors.Control, table_name),
                create_label_table(ContentAlignment.MiddleLeft, SystemColors.GradientInactiveCaption, table_collation),
                create_label_table(ContentAlignment.MiddleLeft, SystemColors.Control, engine),
                create_label_table(ContentAlignment.MiddleRight, SystemColors.GradientInactiveCaption, table_rows)
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

        private Label create_label_table(ContentAlignment textalign, Color backcolor, string text)
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = textalign,
                BackColor = backcolor,
                Margin = new Padding(0),
                Text = text
            };
        }
    }
}
