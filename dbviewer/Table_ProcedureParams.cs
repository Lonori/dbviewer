using System;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class Table_ProcedureParams : CustomTable
    {
        public Table_ProcedureParams(TableLayoutPanel element) : base(element, new string[] { "Направление", "Имя", "Тип", "Размер", "" }) { }

        public void AddRow()
        {
            AddRow(new Control[] {
                create_combobox_table(new object[] {"IN","OUT","INOUT"}),
                create_textbox_table(),
                create_combobox_table(new object[] { "INT", "FLOAT", "VARCHAR", "TEXT", "DATE" }),
                create_textbox_table(),
                create_button_table(rows.Count)
            });
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
            RemoveRow((int)((Button)sender).Tag);
            for (int i = 0; i < rows.Count; i++) ((Button)rows[i][4]).Tag = i;
        }
    }
}
