using System;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class Table_ProcedureParams : CustomTableIndexed
    {
        public Table_ProcedureParams(TableLayoutPanel element) : base(element, new string[] { "Направление", "Имя", "Тип", "Размер" }) { }

        public void AddRow()
        {
            base.AddRow(new Control[] {
                create_combobox_table(new object[] {"IN","OUT","INOUT"}),
                create_textbox_table(),
                create_combobox_table(new object[] { "INT", "FLOAT", "VARCHAR", "TEXT", "DATE" }),
                create_textbox_table(),
                create_button_table(rows.Count)
            });
        }

        public new void AddRow(Control[] controls)
        {
            if (controls.Length > element.ColumnCount) throw new Exception("Column overflow");
            element.RowCount += 1;
            element.RowStyles.Add(new RowStyle(SizeType.Absolute, row_height));
            element.Height += row_height;
            for (int i = 0; i < controls.Length; i++)
                element.Controls.Add(controls[i], i, element.RowCount - 1);
        }

        public new void Clear()
        {
            if (element.RowCount == 1) return;
            element.RowStyles.Clear();
            element.Controls.Clear();
            element.Height = 30;
            element.RowCount = 1;
            element.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            AddNameColumns();
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
            rows.RemoveAt((int)((Button)sender).Tag);
            Clear();
            for (int i = 0; i < rows.Count; i++)
            {
                ((Button)rows[i][4]).Tag = i;
                AddRow(rows[i]);
            }
        }
    }
}
