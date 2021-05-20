
namespace dbviewer
{
    partial class PanelTableData
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
            this.table_query_result = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_query_result)).BeginInit();
            this.SuspendLayout();
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
            this.table_query_result.Size = new System.Drawing.Size(700, 500);
            this.table_query_result.TabIndex = 2;
            this.table_query_result.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.table_query_result_DataError);
            // 
            // PanelTableData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_query_result);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelTableData";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.table_query_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView table_query_result;
    }
}
