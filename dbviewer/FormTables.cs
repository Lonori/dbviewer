using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class Table1 : CustomTable
    {
        public Table1(TableLayoutPanel element) : base(element) { }
        public Table1(TableLayoutPanel element, string[] columns) : base(element, columns) { }

        public void AddRow(string table_name, string table_collation, string engine, string table_rows)
        {
            base.AddRow(new Control[] {
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

    class Table2 : CustomTableIndexed
    {
        public Table2(TableLayoutPanel element) : base(element) { }
        public Table2(TableLayoutPanel element, string[] columns) : base(element, columns) { }

        public void AddRow()
        {
            base.AddRow(new Control[] {
                create_textbox_table(),
                create_combobox_table(new object[] { "INT", "FLOAT", "VARCHAR", "TEXT", "DATE" }),
                create_textbox_table(),
                create_combobox_table(new object[] { "---", "PRIMARY", "INDEX" }),
                create_textbox_table()
            });
        }

        private ComboBox create_combobox_table(object[] collection)
        {
            ComboBox elem = new ComboBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Margin = new Padding(4, 0, 4, 0)
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
                Margin = new Padding(4, 0, 4, 0)
            };
        }
    }
}
