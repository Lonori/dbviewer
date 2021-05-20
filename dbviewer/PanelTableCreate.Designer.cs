
namespace dbviewer
{
    partial class PanelTableCreate
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_table_name = new System.Windows.Forms.TextBox();
            this.button_add_column = new System.Windows.Forms.Button();
            this.button_table_create = new System.Windows.Forms.Button();
            this.table1 = new dbviewer.Table();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textbox_table_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_add_column, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_table_create, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(700, 41);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(4);
            this.label14.Size = new System.Drawing.Size(130, 41);
            this.label14.TabIndex = 2;
            this.label14.Text = "Имя таблицы:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_table_name
            // 
            this.textbox_table_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_table_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_table_name.Location = new System.Drawing.Point(134, 4);
            this.textbox_table_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_table_name.Name = "textbox_table_name";
            this.textbox_table_name.Size = new System.Drawing.Size(323, 31);
            this.textbox_table_name.TabIndex = 1;
            // 
            // button_add_column
            // 
            this.button_add_column.AutoSize = true;
            this.button_add_column.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_add_column.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_add_column.FlatAppearance.BorderSize = 0;
            this.button_add_column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_column.Location = new System.Drawing.Point(557, 4);
            this.button_add_column.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_column.Name = "button_add_column";
            this.button_add_column.Size = new System.Drawing.Size(139, 33);
            this.button_add_column.TabIndex = 3;
            this.button_add_column.Text = "Добавить поле";
            this.button_add_column.UseVisualStyleBackColor = false;
            this.button_add_column.Click += new System.EventHandler(this.button_add_column_Click);
            // 
            // button_table_create
            // 
            this.button_table_create.AutoSize = true;
            this.button_table_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_table_create.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_table_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_table_create.FlatAppearance.BorderSize = 0;
            this.button_table_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_table_create.Location = new System.Drawing.Point(465, 4);
            this.button_table_create.Margin = new System.Windows.Forms.Padding(4);
            this.button_table_create.Name = "button_table_create";
            this.button_table_create.Size = new System.Drawing.Size(84, 33);
            this.button_table_create.TabIndex = 3;
            this.button_table_create.Text = "Создать";
            this.button_table_create.UseVisualStyleBackColor = false;
            this.button_table_create.Click += new System.EventHandler(this.button_table_create_Click);
            // 
            // table1
            // 
            this.table1.BackColor = System.Drawing.Color.White;
            this.table1.ColorHeader = System.Drawing.SystemColors.ActiveCaption;
            this.table1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1.Location = new System.Drawing.Point(0, 41);
            this.table1.Margin = new System.Windows.Forms.Padding(0);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(700, 459);
            this.table1.TabIndex = 5;
            // 
            // PanelTableCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelTableCreate";
            this.Size = new System.Drawing.Size(700, 500);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textbox_table_name;
        private System.Windows.Forms.Button button_add_column;
        private System.Windows.Forms.Button button_table_create;
        private Table table1;
    }
}
