namespace bdviewer
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
            this.label_host = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.input_host = new System.Windows.Forms.TextBox();
            this.input_user = new System.Windows.Forms.TextBox();
            this.input_pass = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(15, 16);
            this.label_host.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(55, 23);
            this.label_host.TabIndex = 0;
            this.label_host.Text = "Хост:";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(15, 54);
            this.label_user.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(136, 23);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "Пользователь:";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(15, 92);
            this.label_pass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(77, 23);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Пароль:";
            // 
            // input_host
            // 
            this.input_host.Location = new System.Drawing.Point(160, 13);
            this.input_host.Name = "input_host";
            this.input_host.Size = new System.Drawing.Size(294, 32);
            this.input_host.TabIndex = 2;
            this.input_host.Text = "localhost";
            // 
            // input_user
            // 
            this.input_user.Location = new System.Drawing.Point(160, 51);
            this.input_user.Name = "input_user";
            this.input_user.Size = new System.Drawing.Size(294, 32);
            this.input_user.TabIndex = 2;
            this.input_user.Text = "test";
            // 
            // input_pass
            // 
            this.input_pass.Location = new System.Drawing.Point(160, 89);
            this.input_pass.Name = "input_pass";
            this.input_pass.Size = new System.Drawing.Size(294, 32);
            this.input_pass.TabIndex = 2;
            this.input_pass.Text = "!Qwerty123";
            this.input_pass.UseSystemPasswordChar = true;
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.LightGreen;
            this.connect.FlatAppearance.BorderSize = 0;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Location = new System.Drawing.Point(311, 196);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(143, 42);
            this.connect.TabIndex = 3;
            this.connect.Text = "Вперед";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.SystemColors.Control;
            this.label_status.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(16, 128);
            this.label_status.Margin = new System.Windows.Forms.Padding(4);
            this.label_status.MaximumSize = new System.Drawing.Size(435, 0);
            this.label_status.MinimumSize = new System.Drawing.Size(435, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(435, 16);
            this.label_status.TabIndex = 4;
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 250);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.input_pass);
            this.Controls.Add(this.input_user);
            this.Controls.Add(this.input_host);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_host);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}