namespace bdviewer
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.log_panel = new System.Windows.Forms.Panel();
            this.log_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_bd = new System.Windows.Forms.Button();
            this.panel_table = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_table_create = new System.Windows.Forms.Panel();
            this.table_creator = new System.Windows.Forms.TableLayoutPanel();
            this.button_add_column = new System.Windows.Forms.Button();
            this.button_table_create = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_table_name = new System.Windows.Forms.TextBox();
            this.panel_table_list = new System.Windows.Forms.Panel();
            this.table_tables = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.panel_crdb = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.create_database = new System.Windows.Forms.Button();
            this.name_new_db = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.log_panel.SuspendLayout();
            this.panel_table.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_table_create.SuspendLayout();
            this.panel_table_list.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel_crdb.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 61);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(239, 550);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 418);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Базы данных:";
            // 
            // log_panel
            // 
            this.log_panel.AutoScroll = true;
            this.log_panel.BackColor = System.Drawing.SystemColors.Window;
            this.log_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_panel.Controls.Add(this.log_label);
            this.log_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_panel.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_panel.Location = new System.Drawing.Point(0, 23);
            this.log_panel.Margin = new System.Windows.Forms.Padding(0);
            this.log_panel.Name = "log_panel";
            this.log_panel.Size = new System.Drawing.Size(741, 134);
            this.log_panel.TabIndex = 4;
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_label.Location = new System.Drawing.Point(4, 4);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(0, 16);
            this.log_label.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Лог:";
            // 
            // create_bd
            // 
            this.create_bd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_bd.Dock = System.Windows.Forms.DockStyle.Top;
            this.create_bd.FlatAppearance.BorderSize = 0;
            this.create_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_bd.Location = new System.Drawing.Point(0, 31);
            this.create_bd.Margin = new System.Windows.Forms.Padding(0);
            this.create_bd.Name = "create_bd";
            this.create_bd.Size = new System.Drawing.Size(239, 30);
            this.create_bd.TabIndex = 6;
            this.create_bd.Text = "Создать БД";
            this.create_bd.UseVisualStyleBackColor = false;
            this.create_bd.Click += new System.EventHandler(this.create_bd_Click);
            // 
            // panel_table
            // 
            this.panel_table.Controls.Add(this.panel1);
            this.panel_table.Controls.Add(this.panel_table_create);
            this.panel_table.Controls.Add(this.panel_table_list);
            this.panel_table.Controls.Add(this.toolStrip2);
            this.panel_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table.Location = new System.Drawing.Point(0, 0);
            this.panel_table.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(741, 450);
            this.panel_table.TabIndex = 7;
            this.panel_table.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 418);
            this.panel1.TabIndex = 4;
            // 
            // panel_table_create
            // 
            this.panel_table_create.AutoScroll = true;
            this.panel_table_create.Controls.Add(this.table_creator);
            this.panel_table_create.Controls.Add(this.button_add_column);
            this.panel_table_create.Controls.Add(this.button_table_create);
            this.panel_table_create.Controls.Add(this.label14);
            this.panel_table_create.Controls.Add(this.textbox_table_name);
            this.panel_table_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_create.Location = new System.Drawing.Point(0, 32);
            this.panel_table_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_create.Name = "panel_table_create";
            this.panel_table_create.Size = new System.Drawing.Size(741, 418);
            this.panel_table_create.TabIndex = 2;
            this.panel_table_create.Visible = false;
            // 
            // table_creator
            // 
            this.table_creator.BackColor = System.Drawing.SystemColors.Control;
            this.table_creator.ColumnCount = 5;
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_creator.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_creator.Location = new System.Drawing.Point(0, 41);
            this.table_creator.Margin = new System.Windows.Forms.Padding(0);
            this.table_creator.Name = "table_creator";
            this.table_creator.RowCount = 1;
            this.table_creator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_creator.Size = new System.Drawing.Size(702, 30);
            this.table_creator.TabIndex = 0;
            // 
            // button_add_column
            // 
            this.button_add_column.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_add_column.FlatAppearance.BorderSize = 0;
            this.button_add_column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_column.Location = new System.Drawing.Point(504, 4);
            this.button_add_column.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.button_add_column.Name = "button_add_column";
            this.button_add_column.Size = new System.Drawing.Size(198, 33);
            this.button_add_column.TabIndex = 3;
            this.button_add_column.Text = "Добавить поле";
            this.button_add_column.UseVisualStyleBackColor = false;
            this.button_add_column.Click += new System.EventHandler(this.button_add_column_Click);
            // 
            // button_table_create
            // 
            this.button_table_create.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_table_create.FlatAppearance.BorderSize = 0;
            this.button_table_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_table_create.Location = new System.Drawing.Point(404, 4);
            this.button_table_create.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.button_table_create.Name = "button_table_create";
            this.button_table_create.Size = new System.Drawing.Size(96, 32);
            this.button_table_create.TabIndex = 3;
            this.button_table_create.Text = "Создать";
            this.button_table_create.UseVisualStyleBackColor = false;
            this.button_table_create.Click += new System.EventHandler(this.button_table_create_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Имя таблицы:";
            // 
            // textbox_table_name
            // 
            this.textbox_table_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_table_name.Location = new System.Drawing.Point(132, 4);
            this.textbox_table_name.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.textbox_table_name.Name = "textbox_table_name";
            this.textbox_table_name.Size = new System.Drawing.Size(268, 32);
            this.textbox_table_name.TabIndex = 1;
            // 
            // panel_table_list
            // 
            this.panel_table_list.AutoScroll = true;
            this.panel_table_list.Controls.Add(this.table_tables);
            this.panel_table_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_list.Location = new System.Drawing.Point(0, 32);
            this.panel_table_list.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_list.Name = "panel_table_list";
            this.panel_table_list.Size = new System.Drawing.Size(741, 418);
            this.panel_table_list.TabIndex = 2;
            this.panel_table_list.Visible = false;
            // 
            // table_tables
            // 
            this.table_tables.BackColor = System.Drawing.SystemColors.Control;
            this.table_tables.ColumnCount = 5;
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_tables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_tables.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_tables.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_tables.Location = new System.Drawing.Point(0, 0);
            this.table_tables.Margin = new System.Windows.Forms.Padding(0);
            this.table_tables.Name = "table_tables";
            this.table_tables.RowCount = 1;
            this.table_tables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_tables.Size = new System.Drawing.Size(741, 30);
            this.table_tables.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripTextBox1,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(741, 32);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::bdviewer.Properties.Resources.b_browse;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::bdviewer.Properties.Resources.b_props;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 32);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::bdviewer.Properties.Resources.b_sql;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // panel_crdb
            // 
            this.panel_crdb.Controls.Add(this.tableLayoutPanel1);
            this.panel_crdb.Controls.Add(this.label1);
            this.panel_crdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_crdb.Location = new System.Drawing.Point(0, 0);
            this.panel_crdb.Margin = new System.Windows.Forms.Padding(0);
            this.panel_crdb.Name = "panel_crdb";
            this.panel_crdb.Size = new System.Drawing.Size(741, 450);
            this.panel_crdb.TabIndex = 9;
            this.panel_crdb.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.create_database, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_new_db, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 32);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // create_database
            // 
            this.create_database.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_database.FlatAppearance.BorderSize = 0;
            this.create_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_database.Location = new System.Drawing.Point(565, 0);
            this.create_database.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.create_database.Name = "create_database";
            this.create_database.Size = new System.Drawing.Size(166, 32);
            this.create_database.TabIndex = 2;
            this.create_database.Text = "Создать";
            this.create_database.UseVisualStyleBackColor = false;
            this.create_database.Click += new System.EventHandler(this.create_database_Click);
            // 
            // name_new_db
            // 
            this.name_new_db.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_new_db.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_new_db.Location = new System.Drawing.Point(0, 0);
            this.name_new_db.Margin = new System.Windows.Forms.Padding(0);
            this.name_new_db.Name = "name_new_db";
            this.name_new_db.Size = new System.Drawing.Size(555, 32);
            this.name_new_db.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(14, 34, 4, 4);
            this.label1.Size = new System.Drawing.Size(214, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создать базу данных:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.create_bd);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 611);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel_crdb);
            this.splitContainer2.Panel1.Controls.Add(this.panel_table);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.log_panel);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Size = new System.Drawing.Size(741, 611);
            this.splitContainer2.SplitterDistance = 450;
            this.splitContainer2.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.log_panel.ResumeLayout(false);
            this.log_panel.PerformLayout();
            this.panel_table.ResumeLayout(false);
            this.panel_table.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_table_create.ResumeLayout(false);
            this.panel_table_create.PerformLayout();
            this.panel_table_list.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel_crdb.ResumeLayout(false);
            this.panel_crdb.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel log_panel;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_bd;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.Panel panel_crdb;
        private System.Windows.Forms.Button create_database;
        private System.Windows.Forms.TextBox name_new_db;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_table_list;
        private System.Windows.Forms.TableLayoutPanel table_tables;
        private System.Windows.Forms.Panel panel_table_create;
        private System.Windows.Forms.TableLayoutPanel table_creator;
        private System.Windows.Forms.Button button_add_column;
        private System.Windows.Forms.Button button_table_create;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textbox_table_name;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

