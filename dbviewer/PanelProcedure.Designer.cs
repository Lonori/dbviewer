
namespace dbviewer
{
    partial class PanelProcedure
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_proc_create = new System.Windows.Forms.Button();
            this.table_procedure = new dbviewer.Table();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.button_proc_create, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(700, 40);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // button_proc_create
            // 
            this.button_proc_create.AutoSize = true;
            this.button_proc_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_proc_create.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_proc_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_proc_create.FlatAppearance.BorderSize = 0;
            this.button_proc_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proc_create.Image = global::dbviewer.Properties.Resources.b_routine_add;
            this.button_proc_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_proc_create.Location = new System.Drawing.Point(4, 4);
            this.button_proc_create.Margin = new System.Windows.Forms.Padding(0);
            this.button_proc_create.Name = "button_proc_create";
            this.button_proc_create.Size = new System.Drawing.Size(204, 32);
            this.button_proc_create.TabIndex = 0;
            this.button_proc_create.Text = "    Добавить процедуру";
            this.button_proc_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_proc_create.UseVisualStyleBackColor = false;
            this.button_proc_create.Click += new System.EventHandler(this.button_proc_create_Click);
            // 
            // table_procedure
            // 
            this.table_procedure.BackColor = System.Drawing.Color.White;
            this.table_procedure.ColorHeader = System.Drawing.SystemColors.ActiveCaption;
            this.table_procedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_procedure.Location = new System.Drawing.Point(0, 40);
            this.table_procedure.Margin = new System.Windows.Forms.Padding(0);
            this.table_procedure.Name = "table_procedure";
            this.table_procedure.Size = new System.Drawing.Size(700, 460);
            this.table_procedure.TabIndex = 3;
            // 
            // PanelProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_procedure);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelProcedure";
            this.Size = new System.Drawing.Size(700, 500);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_proc_create;
        private Table table_procedure;
    }
}
