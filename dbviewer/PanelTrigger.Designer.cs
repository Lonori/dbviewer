
namespace dbviewer
{
    partial class PanelTrigger
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_trig_create = new System.Windows.Forms.Button();
            this.table_trigger = new dbviewer.Table();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.button_trig_create, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(700, 40);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button_trig_create
            // 
            this.button_trig_create.AutoSize = true;
            this.button_trig_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_trig_create.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_trig_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_trig_create.FlatAppearance.BorderSize = 0;
            this.button_trig_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trig_create.Image = global::dbviewer.Properties.Resources.b_trigger_add;
            this.button_trig_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trig_create.Location = new System.Drawing.Point(4, 4);
            this.button_trig_create.Margin = new System.Windows.Forms.Padding(0);
            this.button_trig_create.Name = "button_trig_create";
            this.button_trig_create.Size = new System.Drawing.Size(176, 32);
            this.button_trig_create.TabIndex = 0;
            this.button_trig_create.Text = "    Добавить триггер";
            this.button_trig_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_trig_create.UseVisualStyleBackColor = false;
            this.button_trig_create.Click += new System.EventHandler(this.button_trig_create_Click);
            // 
            // table_trigger
            // 
            this.table_trigger.BackColor = System.Drawing.Color.White;
            this.table_trigger.ColorHeader = System.Drawing.SystemColors.ActiveCaption;
            this.table_trigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_trigger.Location = new System.Drawing.Point(0, 40);
            this.table_trigger.Margin = new System.Windows.Forms.Padding(0);
            this.table_trigger.Name = "table_trigger";
            this.table_trigger.Size = new System.Drawing.Size(700, 460);
            this.table_trigger.TabIndex = 3;
            // 
            // PanelTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_trigger);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelTrigger";
            this.Size = new System.Drawing.Size(700, 500);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_trig_create;
        private Table table_trigger;
    }
}
