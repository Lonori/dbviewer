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
            this.panel_tables = new System.Windows.Forms.Panel();
            this.panel_table_create = new System.Windows.Forms.Panel();
            this.table_creator = new System.Windows.Forms.TableLayoutPanel();
            this.button_add_column = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_table_list = new System.Windows.Forms.Panel();
            this.table_tables = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_crdb = new System.Windows.Forms.Panel();
            this.create_database = new System.Windows.Forms.Button();
            this.name_new_db = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.log_panel.SuspendLayout();
            this.panel_table.SuspendLayout();
            this.panel_tables.SuspendLayout();
            this.panel_table_create.SuspendLayout();
            this.panel_table_list.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_crdb.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 58);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(275, 553);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 466);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Базы данных:";
            // 
            // log_panel
            // 
            this.log_panel.AutoScroll = true;
            this.log_panel.BackColor = System.Drawing.SystemColors.Window;
            this.log_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_panel.Controls.Add(this.log_label);
            this.log_panel.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_panel.Location = new System.Drawing.Point(282, 492);
            this.log_panel.Margin = new System.Windows.Forms.Padding(0);
            this.log_panel.Name = "log_panel";
            this.log_panel.Size = new System.Drawing.Size(702, 119);
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
            this.label3.Location = new System.Drawing.Point(286, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Лог:";
            // 
            // create_bd
            // 
            this.create_bd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_bd.FlatAppearance.BorderSize = 0;
            this.create_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_bd.Location = new System.Drawing.Point(0, 28);
            this.create_bd.Margin = new System.Windows.Forms.Padding(0);
            this.create_bd.Name = "create_bd";
            this.create_bd.Size = new System.Drawing.Size(275, 30);
            this.create_bd.TabIndex = 6;
            this.create_bd.Text = "Создать БД";
            this.create_bd.UseVisualStyleBackColor = false;
            this.create_bd.Click += new System.EventHandler(this.create_bd_Click);
            // 
            // panel_table
            // 
            this.panel_table.Controls.Add(this.dataGridView1);
            this.panel_table.Location = new System.Drawing.Point(282, 0);
            this.panel_table.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(702, 466);
            this.panel_table.TabIndex = 7;
            this.panel_table.Visible = false;
            // 
            // panel_tables
            // 
            this.panel_tables.Controls.Add(this.panel_table_create);
            this.panel_tables.Controls.Add(this.panel_table_list);
            this.panel_tables.Controls.Add(this.toolStrip1);
            this.panel_tables.Controls.Add(this.textBox1);
            this.panel_tables.Location = new System.Drawing.Point(282, 0);
            this.panel_tables.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel_tables.Name = "panel_tables";
            this.panel_tables.Size = new System.Drawing.Size(702, 466);
            this.panel_tables.TabIndex = 8;
            this.panel_tables.Visible = false;
            // 
            // panel_table_create
            // 
            this.panel_table_create.AutoScroll = true;
            this.panel_table_create.Controls.Add(this.table_creator);
            this.panel_table_create.Controls.Add(this.button_add_column);
            this.panel_table_create.Controls.Add(this.button1);
            this.panel_table_create.Controls.Add(this.label14);
            this.panel_table_create.Controls.Add(this.textBox2);
            this.panel_table_create.Location = new System.Drawing.Point(0, 28);
            this.panel_table_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_create.Name = "panel_table_create";
            this.panel_table_create.Size = new System.Drawing.Size(702, 438);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(404, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = false;
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
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(132, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 32);
            this.textBox2.TabIndex = 1;
            // 
            // panel_table_list
            // 
            this.panel_table_list.AutoScroll = true;
            this.panel_table_list.Controls.Add(this.table_tables);
            this.panel_table_list.Location = new System.Drawing.Point(0, 28);
            this.panel_table_list.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_list.Name = "panel_table_list";
            this.panel_table_list.Size = new System.Drawing.Size(702, 438);
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
            this.table_tables.Size = new System.Drawing.Size(702, 30);
            this.table_tables.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(57, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::bdviewer.Properties.Resources.b_props;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Структура";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::bdviewer.Properties.Resources.b_table_add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Создать таблицу";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(514, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 28);
            this.textBox1.TabIndex = 1;
            // 
            // panel_crdb
            // 
            this.panel_crdb.Controls.Add(this.create_database);
            this.panel_crdb.Controls.Add(this.name_new_db);
            this.panel_crdb.Controls.Add(this.label1);
            this.panel_crdb.Location = new System.Drawing.Point(282, 0);
            this.panel_crdb.Margin = new System.Windows.Forms.Padding(0);
            this.panel_crdb.Name = "panel_crdb";
            this.panel_crdb.Size = new System.Drawing.Size(702, 466);
            this.panel_crdb.TabIndex = 9;
            this.panel_crdb.Visible = false;
            // 
            // create_database
            // 
            this.create_database.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_database.FlatAppearance.BorderSize = 0;
            this.create_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_database.Location = new System.Drawing.Point(402, 58);
            this.create_database.Name = "create_database";
            this.create_database.Size = new System.Drawing.Size(104, 32);
            this.create_database.TabIndex = 2;
            this.create_database.Text = "Создать";
            this.create_database.UseVisualStyleBackColor = false;
            this.create_database.Click += new System.EventHandler(this.create_database_Click);
            // 
            // name_new_db
            // 
            this.name_new_db.Location = new System.Drawing.Point(0, 58);
            this.name_new_db.Name = "name_new_db";
            this.name_new_db.Size = new System.Drawing.Size(396, 32);
            this.name_new_db.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создать базу данных:";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_crdb);
            this.panel_main.Controls.Add(this.panel_tables);
            this.panel_main.Controls.Add(this.panel_table);
            this.panel_main.Controls.Add(this.log_panel);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.create_bd);
            this.panel_main.Controls.Add(this.treeView1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(984, 611);
            this.panel_main.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel_main);
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
            this.panel_tables.ResumeLayout(false);
            this.panel_tables.PerformLayout();
            this.panel_table_create.ResumeLayout(false);
            this.panel_table_create.PerformLayout();
            this.panel_table_list.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_crdb.ResumeLayout(false);
            this.panel_crdb.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
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
        private System.Windows.Forms.Panel panel_tables;
        private System.Windows.Forms.Panel panel_crdb;
        private System.Windows.Forms.Button create_database;
        private System.Windows.Forms.TextBox name_new_db;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_table_list;
        private System.Windows.Forms.TableLayoutPanel table_tables;
        private System.Windows.Forms.Panel panel_table_create;
        private System.Windows.Forms.TableLayoutPanel table_creator;
        private System.Windows.Forms.Button button_add_column;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
    }
}

