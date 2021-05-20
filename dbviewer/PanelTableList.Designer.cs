
namespace dbviewer
{
    partial class PanelTableList
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
            this.table_tablelist = new dbviewer.Table();
            this.SuspendLayout();
            // 
            // table_tablelist
            // 
            this.table_tablelist.BackColor = System.Drawing.Color.White;
            this.table_tablelist.ColorHeader = System.Drawing.SystemColors.ActiveCaption;
            this.table_tablelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_tablelist.Hoverable = true;
            this.table_tablelist.Location = new System.Drawing.Point(0, 0);
            this.table_tablelist.Margin = new System.Windows.Forms.Padding(0);
            this.table_tablelist.Name = "table_tablelist";
            this.table_tablelist.Size = new System.Drawing.Size(700, 500);
            this.table_tablelist.TabIndex = 0;
            // 
            // PanelTableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_tablelist);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelTableList";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private Table table_tablelist;
    }
}
