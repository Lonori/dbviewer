namespace dbviewer
{
    partial class FormTrigger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrigger));
            this.panel_main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trig_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.trig_table = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.trig_time = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.trig_event = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.trig_body = new System.Windows.Forms.TextBox();
            this.trig_create = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Controls.Add(this.tableLayoutPanel1);
            this.panel_main.Controls.Add(this.trig_create);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(584, 361);
            this.panel_main.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trig_name, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(136, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название триггера";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trig_name
            // 
            this.trig_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trig_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trig_name.Location = new System.Drawing.Point(140, 14);
            this.trig_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trig_name.MaxLength = 100;
            this.trig_name.Name = "trig_name";
            this.trig_name.Size = new System.Drawing.Size(440, 31);
            this.trig_name.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.trig_table, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(584, 40);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Size = new System.Drawing.Size(136, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Таблица";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trig_table
            // 
            this.trig_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trig_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trig_table.FormattingEnabled = true;
            this.trig_table.Location = new System.Drawing.Point(140, 5);
            this.trig_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.trig_table.Name = "trig_table";
            this.trig_table.Size = new System.Drawing.Size(440, 31);
            this.trig_table.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.trig_time, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(584, 40);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Size = new System.Drawing.Size(136, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Время";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trig_time
            // 
            this.trig_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trig_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trig_time.FormattingEnabled = true;
            this.trig_time.Items.AddRange(new object[] {
            "BEFORE",
            "AFTER"});
            this.trig_time.Location = new System.Drawing.Point(140, 5);
            this.trig_time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.trig_time.Name = "trig_time";
            this.trig_time.Size = new System.Drawing.Size(440, 31);
            this.trig_time.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.trig_event, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 140);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(584, 40);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Size = new System.Drawing.Size(136, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Событие";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trig_event
            // 
            this.trig_event.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trig_event.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trig_event.FormattingEnabled = true;
            this.trig_event.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.trig_event.Location = new System.Drawing.Point(140, 5);
            this.trig_event.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.trig_event.Name = "trig_event";
            this.trig_event.Size = new System.Drawing.Size(440, 31);
            this.trig_event.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.trig_body, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 180);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(584, 149);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Size = new System.Drawing.Size(136, 149);
            this.label5.TabIndex = 0;
            this.label5.Text = "Определение";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trig_body
            // 
            this.trig_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trig_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trig_body.Location = new System.Drawing.Point(136, 0);
            this.trig_body.Margin = new System.Windows.Forms.Padding(0);
            this.trig_body.MaxLength = 100;
            this.trig_body.Multiline = true;
            this.trig_body.Name = "trig_body";
            this.trig_body.Size = new System.Drawing.Size(448, 149);
            this.trig_body.TabIndex = 1;
            // 
            // trig_create
            // 
            this.trig_create.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.trig_create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trig_create.FlatAppearance.BorderSize = 0;
            this.trig_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trig_create.Location = new System.Drawing.Point(0, 329);
            this.trig_create.Name = "trig_create";
            this.trig_create.Size = new System.Drawing.Size(584, 32);
            this.trig_create.TabIndex = 1;
            this.trig_create.Text = "Вперед";
            this.trig_create.UseVisualStyleBackColor = false;
            this.trig_create.Click += new System.EventHandler(this.trig_create_Click);
            // 
            // FormTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormTrigger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Триггер";
            this.Load += new System.EventHandler(this.FormTrigger_Load);
            this.panel_main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trig_name;
        private System.Windows.Forms.ComboBox trig_table;
        private System.Windows.Forms.ComboBox trig_time;
        private System.Windows.Forms.ComboBox trig_event;
        private System.Windows.Forms.TextBox trig_body;
        private System.Windows.Forms.Button trig_create;
    }
}