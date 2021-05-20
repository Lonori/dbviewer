
namespace dbviewer
{
    partial class PanelSql
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
            this.sql_input = new System.Windows.Forms.TextBox();
            this.button_sql_execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sql_input
            // 
            this.sql_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sql_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sql_input.Location = new System.Drawing.Point(0, 0);
            this.sql_input.Multiline = true;
            this.sql_input.Name = "sql_input";
            this.sql_input.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sql_input.Size = new System.Drawing.Size(700, 468);
            this.sql_input.TabIndex = 0;
            // 
            // button_sql_execute
            // 
            this.button_sql_execute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_sql_execute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_sql_execute.FlatAppearance.BorderSize = 0;
            this.button_sql_execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sql_execute.Location = new System.Drawing.Point(0, 468);
            this.button_sql_execute.Name = "button_sql_execute";
            this.button_sql_execute.Size = new System.Drawing.Size(700, 32);
            this.button_sql_execute.TabIndex = 1;
            this.button_sql_execute.Text = "Выпонить";
            this.button_sql_execute.UseVisualStyleBackColor = false;
            this.button_sql_execute.Click += new System.EventHandler(this.button_sql_execute_Click);
            // 
            // PanelSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sql_input);
            this.Controls.Add(this.button_sql_execute);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelSql";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sql_input;
        private System.Windows.Forms.Button button_sql_execute;
    }
}
