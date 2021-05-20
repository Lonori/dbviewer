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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.main_split = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_bd = new System.Windows.Forms.Button();
            this.sub_split = new System.Windows.Forms.SplitContainer();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.log_box = new System.Windows.Forms.TextBox();
            this.main_menu_strip = new System.Windows.Forms.MenuStrip();
            this.mms_tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_tsmi11 = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_tsmi12 = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_tsmi21 = new System.Windows.Forms.ToolStripMenuItem();
            this.mms_tsmi22 = new System.Windows.Forms.ToolStripMenuItem();
            this.file_open_dialog = new System.Windows.Forms.OpenFileDialog();
            this.file_save_dialog = new System.Windows.Forms.SaveFileDialog();
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
            this.db_tree_list.Location = new System.Drawing.Point(0, 61);
            this.db_tree_list.Margin = new System.Windows.Forms.Padding(0);
            this.db_tree_list.Name = "db_tree_list";
            this.db_tree_list.SelectedImageIndex = 2;
            this.db_tree_list.Size = new System.Drawing.Size(198, 476);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Базы данных";
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
            this.main_split.SplitterDistance = 198;
            this.main_split.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.db_tree_list);
            this.panel1.Controls.Add(this.create_bd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 537);
            this.panel1.TabIndex = 7;
            // 
            // create_bd
            // 
            this.create_bd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_bd.Dock = System.Windows.Forms.DockStyle.Top;
            this.create_bd.FlatAppearance.BorderSize = 0;
            this.create_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_bd.Image = global::dbviewer.Properties.Resources.b_newdb;
            this.create_bd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create_bd.Location = new System.Drawing.Point(0, 31);
            this.create_bd.Margin = new System.Windows.Forms.Padding(0);
            this.create_bd.Name = "create_bd";
            this.create_bd.Size = new System.Drawing.Size(198, 30);
            this.create_bd.TabIndex = 6;
            this.create_bd.Text = "Создать БД";
            this.create_bd.UseVisualStyleBackColor = false;
            this.create_bd.Click += new System.EventHandler(this.OpenDbCreate_Click);
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
            this.sub_split.Panel1.Controls.Add(this.panelContainer);
            this.sub_split.Panel1MinSize = 200;
            // 
            // sub_split.Panel2
            // 
            this.sub_split.Panel2.Controls.Add(this.panel2);
            this.sub_split.Panel2MinSize = 100;
            this.sub_split.Size = new System.Drawing.Size(782, 537);
            this.sub_split.SplitterDistance = 421;
            this.sub_split.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(782, 421);
            this.panelContainer.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.log_box);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 112);
            this.panel2.TabIndex = 6;
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
            this.log_box.Size = new System.Drawing.Size(782, 89);
            this.log_box.TabIndex = 1;
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
            this.main_menu_strip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.main_menu_strip.Size = new System.Drawing.Size(984, 24);
            this.main_menu_strip.TabIndex = 3;
            this.main_menu_strip.Text = "menuStrip1";
            // 
            // mms_tsmi1
            // 
            this.mms_tsmi1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_tsmi11,
            this.mms_tsmi12});
            this.mms_tsmi1.Name = "mms_tsmi1";
            this.mms_tsmi1.Size = new System.Drawing.Size(87, 20);
            this.mms_tsmi1.Text = "База данных";
            // 
            // mms_tsmi11
            // 
            this.mms_tsmi11.Name = "mms_tsmi11";
            this.mms_tsmi11.Size = new System.Drawing.Size(207, 22);
            this.mms_tsmi11.Text = "Резервное копирование";
            this.mms_tsmi11.Click += new System.EventHandler(this.mms_tsmi11_Click);
            // 
            // mms_tsmi12
            // 
            this.mms_tsmi12.Name = "mms_tsmi12";
            this.mms_tsmi12.Size = new System.Drawing.Size(207, 22);
            this.mms_tsmi12.Text = "Восстановление";
            this.mms_tsmi12.Click += new System.EventHandler(this.mms_tsmi12_Click);
            // 
            // mms_tsmi2
            // 
            this.mms_tsmi2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mms_tsmi21,
            this.mms_tsmi22});
            this.mms_tsmi2.Name = "mms_tsmi2";
            this.mms_tsmi2.Size = new System.Drawing.Size(65, 20);
            this.mms_tsmi2.Text = "Справка";
            // 
            // mms_tsmi21
            // 
            this.mms_tsmi21.Name = "mms_tsmi21";
            this.mms_tsmi21.Size = new System.Drawing.Size(195, 22);
            this.mms_tsmi21.Text = "Просмотреть справку";
            this.mms_tsmi21.Click += new System.EventHandler(this.mms_tsmi21_Click);
            // 
            // mms_tsmi22
            // 
            this.mms_tsmi22.Name = "mms_tsmi22";
            this.mms_tsmi22.Size = new System.Drawing.Size(195, 22);
            this.mms_tsmi22.Text = "О программе";
            this.mms_tsmi22.Click += new System.EventHandler(this.mms_tsmi22_Click);
            // 
            // file_open_dialog
            // 
            this.file_open_dialog.DefaultExt = "sql";
            this.file_open_dialog.Filter = "Sql Files(*.sql)|*.sql";
            this.file_open_dialog.Title = "Открыть";
            // 
            // file_save_dialog
            // 
            this.file_save_dialog.DefaultExt = "sql";
            this.file_save_dialog.Filter = "Sql Files(*.sql)|*.sql";
            this.file_save_dialog.Title = "Сохранение";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.main_split);
            this.Controls.Add(this.main_menu_strip);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menu_strip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_bd;
        private System.Windows.Forms.SplitContainer main_split;
        private System.Windows.Forms.SplitContainer sub_split;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList tree_list_icon;
        private System.Windows.Forms.MenuStrip main_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi1;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi2;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi11;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi12;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi21;
        private System.Windows.Forms.ToolStripMenuItem mms_tsmi22;
        private System.Windows.Forms.OpenFileDialog file_open_dialog;
        private System.Windows.Forms.SaveFileDialog file_save_dialog;
        private System.Windows.Forms.Panel panelContainer;
    }
}

