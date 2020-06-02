namespace dbviewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.db_tree_list = new System.Windows.Forms.TreeView();
            this.tree_list_icon = new System.Windows.Forms.ImageList(this.components);
            this.table_query_result = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_database = new System.Windows.Forms.Panel();
            this.panel_table_data = new System.Windows.Forms.Panel();
            this.panel_table_list = new System.Windows.Forms.Panel();
            this.table_tables = new System.Windows.Forms.TableLayoutPanel();
            this.panel_sql = new System.Windows.Forms.Panel();
            this.sql_input = new System.Windows.Forms.TextBox();
            this.panel_table_create = new System.Windows.Forms.Panel();
            this.table_creator = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_table_name = new System.Windows.Forms.TextBox();
            this.button_add_column = new System.Windows.Forms.Button();
            this.button_table_create = new System.Windows.Forms.Button();
            this.tool_panel_container = new System.Windows.Forms.TableLayoutPanel();
            this.tool_panel = new System.Windows.Forms.ToolStrip();
            this.search_container = new System.Windows.Forms.Panel();
            this.search_input = new System.Windows.Forms.TextBox();
            this.panel_db_create = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.create_database = new System.Windows.Forms.Button();
            this.name_new_db = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.main_split = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sub_split = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_menu_strip = new System.Windows.Forms.MenuStrip();
            this.mms_tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_sql_execute = new System.Windows.Forms.Button();
            this.log_box = new System.Windows.Forms.TextBox();
            this.create_bd = new System.Windows.Forms.Button();
            this.tool_panel_tsb1 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb2 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb3 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb4 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb5 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb6 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb7 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb8 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb9 = new System.Windows.Forms.ToolStripButton();
            this.tool_panel_tsb10 = new System.Windows.Forms.ToolStripButton();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_query_result)).BeginInit();
            this.panel_database.SuspendLayout();
            this.panel_table_data.SuspendLayout();
            this.panel_table_list.SuspendLayout();
            this.panel_sql.SuspendLayout();
            this.panel_table_create.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tool_panel_container.SuspendLayout();
            this.tool_panel.SuspendLayout();
            this.search_container.SuspendLayout();
            this.panel_db_create.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_split)).BeginInit();
            this.main_split.Panel1.SuspendLayout();
            this.main_split.Panel2.SuspendLayout();
            this.main_split.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub_split)).BeginInit();
            this.sub_split.Panel1.SuspendLayout();
            this.sub_split.Panel2.SuspendLayout();
            this.sub_split.SuspendLayout();
            this.panel2.SuspendLayout();
            this.main_menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_tree_list
            // 
            this.db_tree_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_tree_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_tree_list.ImageIndex = 0;
            this.db_tree_list.ImageList = this.tree_list_icon;
            this.db_tree_list.Location = new System.Drawing.Point(0, 62);
            this.db_tree_list.Margin = new System.Windows.Forms.Padding(0);
            this.db_tree_list.Name = "db_tree_list";
            this.db_tree_list.SelectedImageIndex = 2;
            this.db_tree_list.Size = new System.Drawing.Size(198, 473);
            this.db_tree_list.TabIndex = 1;
            this.db_tree_list.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tree_list_icon
            // 
            this.tree_list_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tree_list_icon.ImageStream")));
            this.tree_list_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.tree_list_icon.Images.SetKeyName(0, "database.png");
            this.tree_list_icon.Images.SetKeyName(1, "b_browse.png");
            this.tree_list_icon.Images.SetKeyName(2, "play.png");
            // 
            // table_query_result
            // 
            this.table_query_result.BackgroundColor = System.Drawing.SystemColors.Control;
            this.table_query_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_query_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_query_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_query_result.Location = new System.Drawing.Point(0, 0);
            this.table_query_result.Margin = new System.Windows.Forms.Padding(0);
            this.table_query_result.Name = "table_query_result";
            this.table_query_result.Size = new System.Drawing.Size(780, 389);
            this.table_query_result.TabIndex = 2;
            this.table_query_result.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.table_query_result_DataError);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 4, 4);
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Базы данных:";
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
            // panel_database
            // 
            this.panel_database.BackColor = System.Drawing.Color.Transparent;
            this.panel_database.Controls.Add(this.panel_sql);
            this.panel_database.Controls.Add(this.panel_table_data);
            this.panel_database.Controls.Add(this.panel_table_list);
            this.panel_database.Controls.Add(this.panel_table_create);
            this.panel_database.Controls.Add(this.tool_panel_container);
            this.panel_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_database.Location = new System.Drawing.Point(0, 0);
            this.panel_database.Margin = new System.Windows.Forms.Padding(0);
            this.panel_database.Name = "panel_database";
            this.panel_database.Size = new System.Drawing.Size(780, 421);
            this.panel_database.TabIndex = 7;
            this.panel_database.Visible = false;
            // 
            // panel_table_data
            // 
            this.panel_table_data.Controls.Add(this.table_query_result);
            this.panel_table_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_data.Location = new System.Drawing.Point(0, 32);
            this.panel_table_data.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_data.Name = "panel_table_data";
            this.panel_table_data.Size = new System.Drawing.Size(780, 389);
            this.panel_table_data.TabIndex = 4;
            this.panel_table_data.Visible = false;
            // 
            // panel_table_list
            // 
            this.panel_table_list.AutoScroll = true;
            this.panel_table_list.Controls.Add(this.table_tables);
            this.panel_table_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_list.Location = new System.Drawing.Point(0, 32);
            this.panel_table_list.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_list.Name = "panel_table_list";
            this.panel_table_list.Size = new System.Drawing.Size(780, 389);
            this.panel_table_list.TabIndex = 2;
            this.panel_table_list.Visible = false;
            // 
            // table_tables
            // 
            this.table_tables.BackColor = System.Drawing.Color.Transparent;
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
            this.table_tables.Size = new System.Drawing.Size(780, 30);
            this.table_tables.TabIndex = 0;
            // 
            // panel_sql
            // 
            this.panel_sql.Controls.Add(this.sql_input);
            this.panel_sql.Controls.Add(this.button_sql_execute);
            this.panel_sql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sql.Location = new System.Drawing.Point(0, 32);
            this.panel_sql.Margin = new System.Windows.Forms.Padding(0);
            this.panel_sql.Name = "panel_sql";
            this.panel_sql.Size = new System.Drawing.Size(780, 389);
            this.panel_sql.TabIndex = 5;
            this.panel_sql.Visible = false;
            // 
            // sql_input
            // 
            this.sql_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sql_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sql_input.Location = new System.Drawing.Point(0, 0);
            this.sql_input.Multiline = true;
            this.sql_input.Name = "sql_input";
            this.sql_input.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sql_input.Size = new System.Drawing.Size(780, 357);
            this.sql_input.TabIndex = 0;
            // 
            // panel_table_create
            // 
            this.panel_table_create.AutoScroll = true;
            this.panel_table_create.Controls.Add(this.table_creator);
            this.panel_table_create.Controls.Add(this.tableLayoutPanel2);
            this.panel_table_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_table_create.Location = new System.Drawing.Point(0, 32);
            this.panel_table_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_table_create.Name = "panel_table_create";
            this.panel_table_create.Size = new System.Drawing.Size(780, 389);
            this.panel_table_create.TabIndex = 2;
            this.panel_table_create.Visible = false;
            // 
            // table_creator
            // 
            this.table_creator.BackColor = System.Drawing.Color.Transparent;
            this.table_creator.ColumnCount = 5;
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.table_creator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_creator.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_creator.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_creator.Location = new System.Drawing.Point(0, 40);
            this.table_creator.Margin = new System.Windows.Forms.Padding(0);
            this.table_creator.Name = "table_creator";
            this.table_creator.RowCount = 1;
            this.table_creator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_creator.Size = new System.Drawing.Size(780, 30);
            this.table_creator.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textbox_table_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_add_column, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_table_create, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 40);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(0, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 32);
            this.label14.TabIndex = 2;
            this.label14.Text = "Имя таблицы:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_table_name
            // 
            this.textbox_table_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_table_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_table_name.Location = new System.Drawing.Point(134, 4);
            this.textbox_table_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_table_name.Name = "textbox_table_name";
            this.textbox_table_name.Size = new System.Drawing.Size(352, 32);
            this.textbox_table_name.TabIndex = 1;
            // 
            // button_add_column
            // 
            this.button_add_column.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_add_column.FlatAppearance.BorderSize = 0;
            this.button_add_column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_column.Location = new System.Drawing.Point(594, 4);
            this.button_add_column.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_column.Name = "button_add_column";
            this.button_add_column.Size = new System.Drawing.Size(182, 32);
            this.button_add_column.TabIndex = 3;
            this.button_add_column.Text = "Добавить поле";
            this.button_add_column.UseVisualStyleBackColor = false;
            this.button_add_column.Click += new System.EventHandler(this.button_add_column_Click);
            // 
            // button_table_create
            // 
            this.button_table_create.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_table_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_table_create.FlatAppearance.BorderSize = 0;
            this.button_table_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_table_create.Location = new System.Drawing.Point(494, 4);
            this.button_table_create.Margin = new System.Windows.Forms.Padding(4);
            this.button_table_create.Name = "button_table_create";
            this.button_table_create.Size = new System.Drawing.Size(92, 32);
            this.button_table_create.TabIndex = 3;
            this.button_table_create.Text = "Создать";
            this.button_table_create.UseVisualStyleBackColor = false;
            this.button_table_create.Click += new System.EventHandler(this.button_table_create_Click);
            // 
            // tool_panel_container
            // 
            this.tool_panel_container.ColumnCount = 2;
            this.tool_panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tool_panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tool_panel_container.Controls.Add(this.tool_panel, 0, 0);
            this.tool_panel_container.Controls.Add(this.search_container, 1, 0);
            this.tool_panel_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_panel_container.Location = new System.Drawing.Point(0, 0);
            this.tool_panel_container.Margin = new System.Windows.Forms.Padding(0);
            this.tool_panel_container.Name = "tool_panel_container";
            this.tool_panel_container.RowCount = 1;
            this.tool_panel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tool_panel_container.Size = new System.Drawing.Size(780, 32);
            this.tool_panel_container.TabIndex = 5;
            // 
            // tool_panel
            // 
            this.tool_panel.BackColor = System.Drawing.Color.Transparent;
            this.tool_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tool_panel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool_panel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tool_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_panel_tsb1,
            this.tool_panel_tsb2,
            this.tool_panel_tsb3,
            this.tool_panel_tsb4,
            this.tool_panel_tsb5,
            this.tool_panel_tsb6,
            this.tool_panel_tsb7,
            this.tool_panel_tsb8,
            this.tool_panel_tsb9,
            this.tool_panel_tsb10});
            this.tool_panel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tool_panel.Location = new System.Drawing.Point(0, 0);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Padding = new System.Windows.Forms.Padding(0);
            this.tool_panel.Size = new System.Drawing.Size(546, 32);
            this.tool_panel.TabIndex = 3;
            this.tool_panel.Text = "toolStrip2";
            // 
            // search_container
            // 
            this.search_container.BackColor = System.Drawing.SystemColors.Window;
            this.search_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_container.Controls.Add(this.search_input);
            this.search_container.Controls.Add(this.button_search);
            this.search_container.Location = new System.Drawing.Point(546, 0);
            this.search_container.Margin = new System.Windows.Forms.Padding(0);
            this.search_container.Name = "search_container";
            this.search_container.Padding = new System.Windows.Forms.Padding(4);
            this.search_container.Size = new System.Drawing.Size(234, 32);
            this.search_container.TabIndex = 4;
            // 
            // search_input
            // 
            this.search_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.search_input.Location = new System.Drawing.Point(4, 4);
            this.search_input.Margin = new System.Windows.Forms.Padding(0);
            this.search_input.MaxLength = 100;
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(202, 25);
            this.search_input.TabIndex = 4;
            this.search_input.Tag = "";
            // 
            // panel_db_create
            // 
            this.panel_db_create.BackColor = System.Drawing.Color.Transparent;
            this.panel_db_create.Controls.Add(this.tableLayoutPanel1);
            this.panel_db_create.Controls.Add(this.label1);
            this.panel_db_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_db_create.Location = new System.Drawing.Point(0, 0);
            this.panel_db_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_db_create.Name = "panel_db_create";
            this.panel_db_create.Size = new System.Drawing.Size(780, 421);
            this.panel_db_create.TabIndex = 9;
            this.panel_db_create.Visible = false;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 32);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // create_database
            // 
            this.create_database.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_database.FlatAppearance.BorderSize = 0;
            this.create_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_database.Location = new System.Drawing.Point(595, 0);
            this.create_database.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.create_database.Name = "create_database";
            this.create_database.Size = new System.Drawing.Size(175, 32);
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
            this.name_new_db.Size = new System.Drawing.Size(585, 32);
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
            // main_split
            // 
            this.main_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_split.Location = new System.Drawing.Point(0, 24);
            this.main_split.Margin = new System.Windows.Forms.Padding(0);
            this.main_split.Name = "main_split";
            // 
            // main_split.Panel1
            // 
            this.main_split.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.main_split.Panel1.Controls.Add(this.panel1);
            this.main_split.Panel1MinSize = 140;
            // 
            // main_split.Panel2
            // 
            this.main_split.Panel2.Controls.Add(this.sub_split);
            this.main_split.Panel2MinSize = 200;
            this.main_split.Size = new System.Drawing.Size(984, 537);
            this.main_split.SplitterDistance = 200;
            this.main_split.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.db_tree_list);
            this.panel1.Controls.Add(this.create_bd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 537);
            this.panel1.TabIndex = 7;
            // 
            // sub_split
            // 
            this.sub_split.BackColor = System.Drawing.Color.Transparent;
            this.sub_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_split.Location = new System.Drawing.Point(0, 0);
            this.sub_split.Margin = new System.Windows.Forms.Padding(0);
            this.sub_split.Name = "sub_split";
            this.sub_split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sub_split.Panel1
            // 
            this.sub_split.Panel1.Controls.Add(this.panel_database);
            this.sub_split.Panel1.Controls.Add(this.panel_db_create);
            this.sub_split.Panel1MinSize = 200;
            // 
            // sub_split.Panel2
            // 
            this.sub_split.Panel2.Controls.Add(this.panel2);
            this.sub_split.Panel2MinSize = 100;
            this.sub_split.Size = new System.Drawing.Size(780, 537);
            this.sub_split.SplitterDistance = 421;
            this.sub_split.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.log_box);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 112);
            this.panel2.TabIndex = 6;
            // 
            // main_menu_strip
            // 
            this.main_menu_strip.BackColor = System.Drawing.Color.Transparent;
            this.main_menu_strip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_tsmi1,
            this.mms_tsmi2});
            this.main_menu_strip.Location = new System.Drawing.Point(0, 0);
            this.main_menu_strip.Name = "main_menu_strip";
            this.main_menu_strip.Size = new System.Drawing.Size(984, 24);
            this.main_menu_strip.TabIndex = 3;
            this.main_menu_strip.Text = "menuStrip1";
            // 
            // mms_tsmi1
            // 
            this.mms_tsmi1.Name = "mms_tsmi1";
            this.mms_tsmi1.Size = new System.Drawing.Size(65, 20);
            this.mms_tsmi1.Text = "Справка";
            // 
            // mms_tsmi2
            // 
            this.mms_tsmi2.Name = "mms_tsmi2";
            this.mms_tsmi2.Size = new System.Drawing.Size(94, 20);
            this.mms_tsmi2.Text = "О программе";
            // 
            // button_sql_execute
            // 
            this.button_sql_execute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_sql_execute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_sql_execute.FlatAppearance.BorderSize = 0;
            this.button_sql_execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sql_execute.Location = new System.Drawing.Point(0, 357);
            this.button_sql_execute.Name = "button_sql_execute";
            this.button_sql_execute.Size = new System.Drawing.Size(780, 32);
            this.button_sql_execute.TabIndex = 1;
            this.button_sql_execute.Text = "Выпонить";
            this.button_sql_execute.UseVisualStyleBackColor = false;
            this.button_sql_execute.Click += new System.EventHandler(this.button_sql_execute_Click);
            // 
            // log_box
            // 
            this.log_box.BackColor = System.Drawing.SystemColors.Window;
            this.log_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_box.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_box.Location = new System.Drawing.Point(0, 23);
            this.log_box.Margin = new System.Windows.Forms.Padding(0);
            this.log_box.Multiline = true;
            this.log_box.Name = "log_box";
            this.log_box.ReadOnly = true;
            this.log_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_box.Size = new System.Drawing.Size(778, 87);
            this.log_box.TabIndex = 1;
            // 
            // create_bd
            // 
            this.create_bd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_bd.Dock = System.Windows.Forms.DockStyle.Top;
            this.create_bd.FlatAppearance.BorderSize = 0;
            this.create_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_bd.Image = global::dbviewer.Properties.Resources.b_newdb;
            this.create_bd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create_bd.Location = new System.Drawing.Point(0, 32);
            this.create_bd.Margin = new System.Windows.Forms.Padding(0);
            this.create_bd.Name = "create_bd";
            this.create_bd.Size = new System.Drawing.Size(198, 30);
            this.create_bd.TabIndex = 6;
            this.create_bd.Text = "Создать БД";
            this.create_bd.UseVisualStyleBackColor = false;
            this.create_bd.Click += new System.EventHandler(this.create_bd_Click);
            // 
            // tool_panel_tsb1
            // 
            this.tool_panel_tsb1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb1.Image = global::dbviewer.Properties.Resources.b_save;
            this.tool_panel_tsb1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb1.Name = "tool_panel_tsb1";
            this.tool_panel_tsb1.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb1.Text = "Сохранить";
            this.tool_panel_tsb1.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb2
            // 
            this.tool_panel_tsb2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb2.Image = global::dbviewer.Properties.Resources.b_browse;
            this.tool_panel_tsb2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb2.Name = "tool_panel_tsb2";
            this.tool_panel_tsb2.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb2.Text = "Обзор";
            this.tool_panel_tsb2.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb3
            // 
            this.tool_panel_tsb3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb3.Image = global::dbviewer.Properties.Resources.b_props;
            this.tool_panel_tsb3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb3.Name = "tool_panel_tsb3";
            this.tool_panel_tsb3.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb3.Text = "Структура";
            this.tool_panel_tsb3.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb4
            // 
            this.tool_panel_tsb4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb4.Image = global::dbviewer.Properties.Resources.b_table_add;
            this.tool_panel_tsb4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb4.Name = "tool_panel_tsb4";
            this.tool_panel_tsb4.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb4.Text = "Создать таблицу";
            this.tool_panel_tsb4.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb5
            // 
            this.tool_panel_tsb5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb5.Image = global::dbviewer.Properties.Resources.b_sql;
            this.tool_panel_tsb5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb5.Name = "tool_panel_tsb5";
            this.tool_panel_tsb5.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb5.Text = "SQL";
            this.tool_panel_tsb5.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb6
            // 
            this.tool_panel_tsb6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb6.Image = global::dbviewer.Properties.Resources.b_insrow;
            this.tool_panel_tsb6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb6.Name = "tool_panel_tsb6";
            this.tool_panel_tsb6.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb6.Text = "Вставить";
            this.tool_panel_tsb6.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb7
            // 
            this.tool_panel_tsb7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb7.Image = global::dbviewer.Properties.Resources.b_routines;
            this.tool_panel_tsb7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb7.Name = "tool_panel_tsb7";
            this.tool_panel_tsb7.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb7.Text = "Процедуры";
            this.tool_panel_tsb7.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb8
            // 
            this.tool_panel_tsb8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb8.Image = global::dbviewer.Properties.Resources.b_triggers;
            this.tool_panel_tsb8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb8.Name = "tool_panel_tsb8";
            this.tool_panel_tsb8.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb8.Text = "Тригеры";
            this.tool_panel_tsb8.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb9
            // 
            this.tool_panel_tsb9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb9.Image = global::dbviewer.Properties.Resources.b_deltbl;
            this.tool_panel_tsb9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb9.Name = "tool_panel_tsb9";
            this.tool_panel_tsb9.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb9.Text = "Удалить таблицу";
            this.tool_panel_tsb9.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // tool_panel_tsb10
            // 
            this.tool_panel_tsb10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb10.Image = global::dbviewer.Properties.Resources.db_remove;
            this.tool_panel_tsb10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb10.Name = "tool_panel_tsb10";
            this.tool_panel_tsb10.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb10.Text = "Удалить базу данных";
            this.tool_panel_tsb10.Click += new System.EventHandler(this.tool_panel_tsb_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Window;
            this.button_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Image = global::dbviewer.Properties.Resources.b_search;
            this.button_search.Location = new System.Drawing.Point(206, 4);
            this.button_search.Margin = new System.Windows.Forms.Padding(0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(22, 22);
            this.button_search.TabIndex = 5;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.main_split);
            this.Controls.Add(this.main_menu_strip);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menu_strip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_query_result)).EndInit();
            this.panel_database.ResumeLayout(false);
            this.panel_table_data.ResumeLayout(false);
            this.panel_table_list.ResumeLayout(false);
            this.panel_sql.ResumeLayout(false);
            this.panel_sql.PerformLayout();
            this.panel_table_create.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tool_panel_container.ResumeLayout(false);
            this.tool_panel_container.PerformLayout();
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.search_container.ResumeLayout(false);
            this.search_container.PerformLayout();
            this.panel_db_create.ResumeLayout(false);
            this.panel_db_create.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.main_split.Panel1.ResumeLayout(false);
            this.main_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_split)).EndInit();
            this.main_split.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sub_split.Panel1.ResumeLayout(false);
            this.sub_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sub_split)).EndInit();
            this.sub_split.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.main_menu_strip.ResumeLayout(false);
            this.main_menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView db_tree_list;
        private System.Windows.Forms.DataGridView table_query_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_bd;
        private System.Windows.Forms.Panel panel_database;
        private System.Windows.Forms.Panel panel_db_create;
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
        private System.Windows.Forms.SplitContainer main_split;
        private System.Windows.Forms.SplitContainer sub_split;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_table_data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tool_panel_container;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip tool_panel;
        private System.Windows.Forms.Panel panel_sql;
        private System.Windows.Forms.TextBox sql_input;
        private System.Windows.Forms.ImageList tree_list_icon;
        private System.Windows.Forms.Panel search_container;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb1;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb2;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb3;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb4;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb5;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb6;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb7;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb8;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb9;
        private System.Windows.Forms.ToolStripButton tool_panel_tsb10;
        private System.Windows.Forms.MenuStrip main_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi1;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi2;
        private System.Windows.Forms.Button button_sql_execute;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.Button button_search;
    }
}

