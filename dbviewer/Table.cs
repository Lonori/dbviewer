using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class Table : Control
    {
        private Color _ColorHeader = SystemColors.ActiveCaption;
        private Color _ColorRowHover = Color.LightSteelBlue;
        private Color _ColorRowEven = Color.AliceBlue;
        private Color _ColorRowOdd = Color.Lavender;
        private int _HeaderHeight = 40;
        private bool _Hoverable = false;

        private Panel TableHeader;
        private Panel TableBody;
        private TableLayoutPanel ColumnHeader;
        private TableLayoutPanel ColumnRows;

        private int column_amount = 0;
        private int row_amount = 0;
        private float[] columns_size;
        private List<Control[]> rows = new List<Control[]>();

        public delegate void ClickOnRowEvent(int row_num, Control[] data);
        public event ClickOnRowEvent RowClick;
        public event ClickOnRowEvent RowDoubleClick;

        public Control[] this[int index]
        {
            get
            {
                if (0 > index || index > rows.Count) throw new IndexOutOfRangeException();
                return rows[index];
            }
        }

        public int Length
        {
            get { return rows.Count; }
        }

        [Category("Color")]
        [Description("Цвет шапки таблицы")]
        [DefaultValue(typeof(SystemColors), "ActiveCaption")]
        public Color ColorHeader
        {
            get { return _ColorHeader; }
            set
            {
                _ColorHeader = value;
                Invalidate();
            }
        }

        [Category("Color")]
        [Description("Цвет строки при наведении")]
        [DefaultValue(typeof(Color), "LightSteelBlue")]
        public Color ColorRowHover
        {
            get { return _ColorRowHover; }
            set
            {
                _ColorRowHover = value;
                Invalidate();
            }
        }

        [Category("Color")]
        [Description("Цвет четных строк")]
        [DefaultValue(typeof(Color), "AliceBlue")]
        public Color ColorRowEven
        {
            get { return _ColorRowEven; }
            set
            {
                _ColorRowEven = value;
                Invalidate();
            }
        }

        [Category("Color")]
        [Description("Цвет нечетных строк")]
        [DefaultValue(typeof(Color), "Lavender")]
        public Color ColorRowOdd
        {
            get { return _ColorRowOdd; }
            set
            {
                _ColorRowOdd = value;
                Invalidate();
            }
        }

        [Description("Высота заголовка таблицы")]
        [DefaultValue(40)]
        public int HeaderHeight
        {
            get { return _HeaderHeight; }
            set
            {
                if (value < 0)
                {
                    _HeaderHeight = 0;
                }
                else
                {
                    _HeaderHeight = value;
                }
                Invalidate();
            }
        }

        [Description("Выделяются ли строки при наведении")]
        [DefaultValue(false)]
        public bool Hoverable
        {
            get { return _Hoverable; }
            set { _Hoverable = value; }
        }

        [Browsable(false)]
        [ReadOnly(true)]
        public override string Text { get; set; }

        private void InitializeComponent()
        {
            TableHeader = new Panel();
            TableBody = new Panel();
            ColumnHeader = new TableLayoutPanel();
            ColumnRows = new TableLayoutPanel();

            TableHeader.Controls.Add(ColumnHeader);
            TableHeader.Dock = DockStyle.Top;
            TableHeader.Margin = new Padding(0);
            TableHeader.TabIndex = 1;

            ColumnHeader.BackColor = Color.Transparent;
            ColumnHeader.ColumnCount = 1;
            ColumnHeader.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            ColumnHeader.Dock = DockStyle.Fill;
            ColumnHeader.Margin = new Padding(0);
            ColumnHeader.RowCount = 1;
            ColumnHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ColumnHeader.TabIndex = 0;

            TableBody.AutoScroll = true;
            TableBody.BackColor = Color.Transparent;
            TableBody.Controls.Add(ColumnRows);
            TableBody.Dock = DockStyle.Fill;
            TableBody.Margin = new Padding(0);
            TableBody.TabIndex = 2;

            ColumnRows.AutoSize = true;
            ColumnRows.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ColumnRows.BackColor = Color.Transparent;
            ColumnRows.ColumnCount = 1;
            ColumnRows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ColumnRows.Dock = DockStyle.Top;
            ColumnRows.Margin = new Padding(0);
            ColumnRows.RowCount = 1;
            ColumnRows.RowStyles.Add(new RowStyle());
            ColumnRows.TabIndex = 0;

            Controls.Add(TableBody);
            Controls.Add(TableHeader);
            BackColor = Color.White;
            Margin = new Padding(0);
            Size = new Size(400, 200);
        }

        public Table()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            TableHeader.BackColor = _ColorHeader;
            TableHeader.Size = new Size(TableHeader.Width, _HeaderHeight);
        }

        public void TableInit(string[] column_name, float[] columns_size)
        {
            if (column_name.Length != columns_size.Length) throw new Exception("Количество колонок не совпадают");

            column_amount = column_name.Length;
            this.columns_size = columns_size;
            ColumnHeader.Controls.Clear();
            ColumnHeader.ColumnStyles.Clear();
            ColumnHeader.ColumnCount = column_name.Length;
            for (int i = 0; i < column_name.Length; i++)
            {
                ColumnHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columns_size[i]));
                ColumnHeader.Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0),
                    Text = column_name[i],
                    TextAlign = ContentAlignment.MiddleCenter
                }, i, 0);
            }
        }

        public void AddRow(Control[] row_controls)
        {
            AddRow(row_controls, 30);
        }

        public void AddRow(Control[] row_controls, int row_heigth)
        {
            if (column_amount == 0) throw new Exception("Таблица не инициализирована");
            if (column_amount < row_controls.Length) throw new Exception("Количество колонок с данными не соответствует настройкам");

            if (row_amount == 0)
            {
                ColumnRows.Controls.Clear();
                ColumnRows.RowStyles.Clear();
            }

            rows.Add(row_controls);
            TableLayoutPanel table_row = new TableLayoutPanel()
            {
                AutoSize = true,
                BackColor = row_amount % 2 == 0 ? _ColorRowEven : _ColorRowOdd,
                Cursor = _Hoverable ? Cursors.Hand : Cursors.Default,
                Dock = DockStyle.Top,
                Margin = new Padding(0),
                Padding = new Padding(0, 2, 0, 2)
            };
            table_row.Click += new EventHandler(TableRow_Click);
            table_row.DoubleClick += new EventHandler(TableRow_DoubleClick);
            if (_Hoverable)
            {
                table_row.MouseEnter += new EventHandler(TableBody_MouseEnter);
                table_row.MouseLeave += new EventHandler(TableBody_MouseLeave);
            }
            table_row.RowCount = 1;
            table_row.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            table_row.ColumnCount = column_amount;
            for (int i = 0; i < column_amount; i++)
            {
                table_row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columns_size[i]));
                if (i >= row_controls.Length) continue;
                table_row.Controls.Add(row_controls[i], i, 0);
            }
            ColumnRows.RowCount = row_amount + 1;
            ColumnRows.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            ColumnRows.Controls.Add(table_row, 0, row_amount);
            row_amount++;
        }

        public void Clear()
        {
            row_amount = 0;
            ColumnRows.Controls.Clear();
            ColumnRows.RowCount = 0;
            rows.Clear();
        }

        public void RemoveAt(int index)
        {
            if (0 > index || index > rows.Count) throw new IndexOutOfRangeException();
            ColumnRows.Controls.RemoveAt(index);
            ColumnRows.ColumnCount = rows.Count - 1;
            rows.RemoveAt(index);
        }

        private void TableRow_Click(object sender, EventArgs e)
        {
            int row_num = ColumnRows.GetRow((TableLayoutPanel)sender);
            RowClick?.Invoke(row_num, rows[row_num]);
        }

        private void TableRow_DoubleClick(object sender, EventArgs e)
        {
            int row_num = ColumnRows.GetRow((TableLayoutPanel)sender);
            RowDoubleClick?.Invoke(row_num, rows[row_num]);
        }

        private void TableBody_MouseEnter(object sender, EventArgs e)
        {
            TableLayoutPanel row = (TableLayoutPanel)sender;
            row.BackColor = _ColorRowHover;
        }

        private void TableBody_MouseLeave(object sender, EventArgs e)
        {
            TableLayoutPanel row = (TableLayoutPanel)sender;
            row.BackColor = ColumnRows.GetRow(row) % 2 == 0 ? _ColorRowEven : _ColorRowOdd;
        }
    }

    public class NoEventLabel : Label
    {
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTTRANSPARENT = (-1);

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
