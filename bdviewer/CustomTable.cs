using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace bdviewer
{
    class CustomTable
    {
        protected TableLayoutPanel element;
        protected string[] columns;
        protected int row_height = 30;

        public int RowHeight
        {
            get { return row_height; }
            set
            {
                if (value < 0) throw new Exception("Height < 0");
                row_height = value;
            }
        }

        public CustomTable(TableLayoutPanel element)
        {
            this.element = element;
        }

        public CustomTable(TableLayoutPanel element, string[] columns) : this(element)
        {
            SetColumns(columns);
        }

        public virtual void AddRow(Control[] controls)
        {
            if (controls.Length > element.ColumnCount) throw new Exception("Column overflow");
            element.RowCount += 1;
            element.RowStyles.Add(new RowStyle(SizeType.Absolute, row_height));
            element.Height += row_height;
            for (int i = 0; i < controls.Length; i++)
                element.Controls.Add(controls[i], i, element.RowCount - 1);
        }

        public void SetColumns(string[] columns)
        {
            if (columns.Length > element.ColumnCount) throw new Exception("Column overflow");
            this.columns = columns;
            AddNameColumns();
        }

        public void Clear()
        {
            if (element.RowCount == 1) return;
            element.RowStyles.Clear();
            element.Controls.Clear();
            element.Height = 30;
            element.RowCount = 1;
            element.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            AddNameColumns();
        }

        protected void AddNameColumns()
        {
            for (int i = 0; i < element.ColumnCount && i < columns.Length; i++)
                element.Controls.Add(CreateLabel(columns[i]), i, 0);
        }

        private Label CreateLabel(string name)
        {
            return new Label()
            {
                BackColor = SystemColors.ActiveCaption,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }
    }

    class CustomTableIndexed : CustomTable
    {
        protected List<Control[]> rows = new List<Control[]>();

        public Control[] this[int index]
        {
            get
            {
                if (index < 0 || index > rows.Count) throw new Exception("Invalid index (" + index + ")");
                return rows[index];
            }
        }
        public int Length
        {
            get { return rows.Count; }
        }

        public CustomTableIndexed(TableLayoutPanel element) : base(element) { }
        public CustomTableIndexed(TableLayoutPanel element, string[] columns) : base(element, columns) { }

        public override void AddRow(Control[] controls)
        {
            if (controls.Length < columns.Length) throw new Exception("Column amount error");
            base.AddRow(controls);
            rows.Add(controls);
        }

        public new void Clear()
        {
            base.Clear();
            rows.Clear();
        }
    }
}
