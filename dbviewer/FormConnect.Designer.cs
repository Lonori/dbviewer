namespace dbviewer
{
    partial class FormConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnect));
            this.label_host = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.input_host = new System.Windows.Forms.TextBox();
            this.input_user = new System.Windows.Forms.TextBox();
            this.input_pass = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.save_login_check = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_host.Location = new System.Drawing.Point(0, 0);
            this.label_host.Margin = new System.Windows.Forms.Padding(0);
            this.label_host.Name = "label_host";
            this.label_host.Padding = new System.Windows.Forms.Padding(4);
            this.label_host.Size = new System.Drawing.Size(162, 40);
            this.label_host.TabIndex = 0;
            this.label_host.Text = "Хост:";
            this.label_host.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_user.Location = new System.Drawing.Point(0, 40);
            this.label_user.Margin = new System.Windows.Forms.Padding(0);
            this.label_user.Name = "label_user";
            this.label_user.Padding = new System.Windows.Forms.Padding(4);
            this.label_user.Size = new System.Drawing.Size(162, 40);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "Пользователь:";
            this.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_pass.Location = new System.Drawing.Point(0, 80);
            this.label_pass.Margin = new System.Windows.Forms.Padding(0);
            this.label_pass.Name = "label_pass";
            this.label_pass.Padding = new System.Windows.Forms.Padding(4);
            this.label_pass.Size = new System.Drawing.Size(162, 40);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Пароль:";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_host
            // 
            this.input_host.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.input_host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_host.Location = new System.Drawing.Point(165, 4);
            this.input_host.Name = "input_host";
            this.input_host.Size = new System.Drawing.Size(296, 32);
            this.input_host.TabIndex = 2;
            // 
            // input_user
            // 
            this.input_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.input_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_user.Location = new System.Drawing.Point(165, 44);
            this.input_user.Name = "input_user";
            this.input_user.Size = new System.Drawing.Size(296, 32);
            this.input_user.TabIndex = 2;
            // 
            // input_pass
            // 
            this.input_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.input_pass.Location = new System.Drawing.Point(165, 84);
            this.input_pass.Name = "input_pass";
            this.input_pass.Size = new System.Drawing.Size(296, 32);
            this.input_pass.TabIndex = 2;
            this.input_pass.UseSystemPasswordChar = true;
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.connect.Dock = System.Windows.Forms.DockStyle.Right;
            this.connect.FlatAppearance.BorderSize = 0;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Location = new System.Drawing.Point(317, 221);
            this.connect.Margin = new System.Windows.Forms.Padding(4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(143, 32);
            this.connect.TabIndex = 3;
            this.connect.Text = "Вперед";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.label_status, 2);
            this.label_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(0, 150);
            this.label_status.Margin = new System.Windows.Forms.Padding(0);
            this.label_status.MaximumSize = new System.Drawing.Size(464, 0);
            this.label_status.Name = "label_status";
            this.label_status.Padding = new System.Windows.Forms.Padding(4);
            this.label_status.Size = new System.Drawing.Size(464, 67);
            this.label_status.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.connect, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_host, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_user, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.input_pass, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_pass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.input_user, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.input_host, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.save_login_check, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 257);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // save_login_check
            // 
            this.save_login_check.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.save_login_check, 2);
            this.save_login_check.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_login_check.Location = new System.Drawing.Point(264, 120);
            this.save_login_check.Margin = new System.Windows.Forms.Padding(0);
            this.save_login_check.Name = "save_login_check";
            this.save_login_check.Padding = new System.Windows.Forms.Padding(4);
            this.save_login_check.Size = new System.Drawing.Size(200, 30);
            this.save_login_check.TabIndex = 5;
            this.save_login_check.Text = "Запомнить данные";
            this.save_login_check.UseVisualStyleBackColor = true;
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox input_host;
        private System.Windows.Forms.TextBox input_user;
        private System.Windows.Forms.TextBox input_pass;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox save_login_check;
    }
}