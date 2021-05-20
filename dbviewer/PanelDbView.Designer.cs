
namespace dbviewer
{
    partial class PanelDbView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.search_container = new System.Windows.Forms.Panel();
            this.search_input = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.tool_panel = new System.Windows.Forms.ToolStrip();
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
            this.tool_panel_container = new System.Windows.Forms.TableLayoutPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.search_container.SuspendLayout();
            this.tool_panel.SuspendLayout();
            this.tool_panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_container
            // 
            this.search_container.BackColor = System.Drawing.SystemColors.Window;
            this.search_container.Controls.Add(this.search_input);
            this.search_container.Controls.Add(this.button_search);
            this.search_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_container.Location = new System.Drawing.Point(490, 0);
            this.search_container.Margin = new System.Windows.Forms.Padding(0);
            this.search_container.Name = "search_container";
            this.search_container.Padding = new System.Windows.Forms.Padding(4);
            this.search_container.Size = new System.Drawing.Size(210, 32);
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
            this.search_input.Size = new System.Drawing.Size(180, 24);
            this.search_input.TabIndex = 4;
            this.search_input.Tag = "";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Window;
            this.button_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Image = global::dbviewer.Properties.Resources.search;
            this.button_search.Location = new System.Drawing.Point(184, 4);
            this.button_search.Margin = new System.Windows.Forms.Padding(0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(22, 24);
            this.button_search.TabIndex = 5;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
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
            this.tool_panel.Size = new System.Drawing.Size(490, 32);
            this.tool_panel.TabIndex = 3;
            this.tool_panel.Text = "toolStrip2";
            // 
            // tool_panel_tsb1
            // 
            this.tool_panel_tsb1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb1.Image = global::dbviewer.Properties.Resources.b_save;
            this.tool_panel_tsb1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb1.Name = "tool_panel_tsb1";
            this.tool_panel_tsb1.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb1.Text = "Сохранить";
            this.tool_panel_tsb1.Click += new System.EventHandler(this.tool_panel_tsb1_Click);
            // 
            // tool_panel_tsb2
            // 
            this.tool_panel_tsb2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb2.Image = global::dbviewer.Properties.Resources.b_browse;
            this.tool_panel_tsb2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb2.Name = "tool_panel_tsb2";
            this.tool_panel_tsb2.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb2.Text = "Обзор";
            this.tool_panel_tsb2.Click += new System.EventHandler(this.tool_panel_tsb2_Click);
            // 
            // tool_panel_tsb3
            // 
            this.tool_panel_tsb3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb3.Image = global::dbviewer.Properties.Resources.b_props;
            this.tool_panel_tsb3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb3.Name = "tool_panel_tsb3";
            this.tool_panel_tsb3.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb3.Text = "Структура";
            this.tool_panel_tsb3.Click += new System.EventHandler(this.tool_panel_tsb3_Click);
            // 
            // tool_panel_tsb4
            // 
            this.tool_panel_tsb4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb4.Image = global::dbviewer.Properties.Resources.b_table_add;
            this.tool_panel_tsb4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb4.Name = "tool_panel_tsb4";
            this.tool_panel_tsb4.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb4.Text = "Создать таблицу";
            this.tool_panel_tsb4.Click += new System.EventHandler(this.tool_panel_tsb4_Click);
            // 
            // tool_panel_tsb5
            // 
            this.tool_panel_tsb5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb5.Image = global::dbviewer.Properties.Resources.b_sql;
            this.tool_panel_tsb5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb5.Name = "tool_panel_tsb5";
            this.tool_panel_tsb5.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb5.Text = "SQL";
            this.tool_panel_tsb5.Click += new System.EventHandler(this.tool_panel_tsb5_Click);
            // 
            // tool_panel_tsb6
            // 
            this.tool_panel_tsb6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb6.Image = global::dbviewer.Properties.Resources.b_insrow;
            this.tool_panel_tsb6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb6.Name = "tool_panel_tsb6";
            this.tool_panel_tsb6.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb6.Text = "Вставить";
            this.tool_panel_tsb6.Click += new System.EventHandler(this.tool_panel_tsb6_Click);
            // 
            // tool_panel_tsb7
            // 
            this.tool_panel_tsb7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb7.Image = global::dbviewer.Properties.Resources.b_routines;
            this.tool_panel_tsb7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb7.Name = "tool_panel_tsb7";
            this.tool_panel_tsb7.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb7.Text = "Процедуры";
            this.tool_panel_tsb7.Click += new System.EventHandler(this.tool_panel_tsb7_Click);
            // 
            // tool_panel_tsb8
            // 
            this.tool_panel_tsb8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb8.Image = global::dbviewer.Properties.Resources.b_triggers;
            this.tool_panel_tsb8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb8.Name = "tool_panel_tsb8";
            this.tool_panel_tsb8.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb8.Text = "Тригеры";
            this.tool_panel_tsb8.Click += new System.EventHandler(this.tool_panel_tsb8_Click);
            // 
            // tool_panel_tsb9
            // 
            this.tool_panel_tsb9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb9.Image = global::dbviewer.Properties.Resources.b_deltbl;
            this.tool_panel_tsb9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb9.Name = "tool_panel_tsb9";
            this.tool_panel_tsb9.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb9.Text = "Удалить таблицу";
            this.tool_panel_tsb9.Click += new System.EventHandler(this.tool_panel_tsb9_Click);
            // 
            // tool_panel_tsb10
            // 
            this.tool_panel_tsb10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_panel_tsb10.Image = global::dbviewer.Properties.Resources.db_remove;
            this.tool_panel_tsb10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_panel_tsb10.Name = "tool_panel_tsb10";
            this.tool_panel_tsb10.Size = new System.Drawing.Size(23, 29);
            this.tool_panel_tsb10.Text = "Удалить базу данных";
            this.tool_panel_tsb10.Click += new System.EventHandler(this.tool_panel_tsb10_Click);
            // 
            // tool_panel_container
            // 
            this.tool_panel_container.AutoSize = true;
            this.tool_panel_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.tool_panel_container.Size = new System.Drawing.Size(700, 32);
            this.tool_panel_container.TabIndex = 5;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 32);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(700, 468);
            this.panelContainer.TabIndex = 6;
            // 
            // PanelDbView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.tool_panel_container);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelDbView";
            this.Size = new System.Drawing.Size(700, 500);
            this.search_container.ResumeLayout(false);
            this.search_container.PerformLayout();
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.tool_panel_container.ResumeLayout(false);
            this.tool_panel_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel search_container;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ToolStrip tool_panel;
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
        private System.Windows.Forms.TableLayoutPanel tool_panel_container;
        private System.Windows.Forms.Panel panelContainer;
    }
}
