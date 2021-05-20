using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class CustomTable
    {
        protected List<Control[]> rows = new List<Control[]>();
        protected Color header_color = SystemColors.ActiveCaption;
        protected int row_height = 30;
        protected TableLayoutPanel element;
        protected Control[] columns;

        public Control[] this[int index]
        {
            get
            {
                if (index < 0 || index > rows.Count) throw new Exception("Invalid index (" + index + ")");
                return rows[index];
            }
        }
        public int RowHeight
        {
            get { return row_height; }
            set
            {
                if (value < 0) throw new Exception("Height < 0");
                row_height = value;
            }
        }
        public Color HeaderColor
        {
            get { return header_color; }
            set { header_color = value; }
        }
        public int Length
        {
            get { return rows.Count; }
        }

        public CustomTable(TableLayoutPanel element)
        {
            this.element = element;
        }
        public CustomTable(TableLayoutPanel element, string[] columns) : this(element)
        {
            SetColumns(columns);
        }

        public void AddRow(Control[] controls)
        {
            AddRowVisible(controls);
            rows.Add(controls);
        }

        public void RemoveRow(int index)
        {
            if (0 > index || index >= rows.Count) throw new Exception("Null index");
            rows.RemoveAt(index);
            ClearVisible();
            AddNameColumns();
            for (int i = 0; i < rows.Count; i++) AddRowVisible(rows[i]);
        }

        public void SetColumns(string[] columns)
        {
            if (columns.Length != element.ColumnCount) throw new Exception("Column amount error");
            this.columns = new Control[columns.Length];
            for (int i = 0; i < columns.Length; i++) this.columns[i] = CreateLabel(columns[i]);
            AddNameColumns();
        }

        public void Clear()
        {
            ClearVisible();
            AddNameColumns();
            rows.Clear();
        }

        private void AddNameColumns()
        {
            for (int i = 0; i < columns.Length; i++) element.Controls.Add(columns[i], i, 0);
        }

        private void AddRowVisible(Control[] controls)
        {
            if (controls.Length > element.ColumnCount) throw new Exception("Column amount error");
            element.RowCount += 1;
            element.RowStyles.Add(new RowStyle(SizeType.Absolute, row_height));
            element.Height += row_height;
            for (int i = 0; i < controls.Length; i++)
                element.Controls.Add(controls[i], i, element.RowCount - 1);
        }

        private void ClearVisible()
        {
            if (element.RowCount == 1) return;
            element.RowStyles.Clear();
            element.Controls.Clear();
            element.Height = 30;
            element.RowCount = 1;
            element.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
        }

        private Label CreateLabel(string name)
        {
            return new Label()
            {
                BackColor = header_color,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }
    }
}
