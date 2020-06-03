using System.Windows.Forms;

namespace dbviewer
{
    class Table_CreateTable : CustomTableIndexed
    {
        protected new int row_height = 40;

        public Table_CreateTable(TableLayoutPanel element) : base(element, new string[] { "Имя", "Тип", "Размер", "Индекс", "Подпись" }) { }

        public void AddRow()
        {
            base.AddRow(new Control[] {
                create_textbox_table(),
                create_combobox_table(new object[] { "INT", "FLOAT", "VARCHAR", "TEXT", "DATE" }),
                create_textbox_table(),
                create_combobox_table(new object[] { "---", "PRIMARY" }),
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
