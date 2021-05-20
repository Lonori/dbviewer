
namespace dbviewer
{
    partial class PanelDbCreate
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.create_database = new System.Windows.Forms.Button();
            this.name_new_db = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.create_database, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_new_db, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 43);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // create_database
            // 
            this.create_database.AutoSize = true;
            this.create_database.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.create_database.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.create_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_database.FlatAppearance.BorderSize = 0;
            this.create_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_database.Location = new System.Drawing.Point(530, 5);
            this.create_database.Margin = new System.Windows.Forms.Padding(5);
            this.create_database.Name = "create_database";
            this.create_database.Size = new System.Drawing.Size(165, 33);
            this.create_database.TabIndex = 2;
            this.create_database.Text = "Создать";
            this.create_database.UseVisualStyleBackColor = false;
            this.create_database.Click += new System.EventHandler(this.create_database_Click);
            // 
            // name_new_db
            // 
            this.name_new_db.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_new_db.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_new_db.Location = new System.Drawing.Point(6, 6);
            this.name_new_db.Margin = new System.Windows.Forms.Padding(6);
            this.name_new_db.Name = "name_new_db";
            this.name_new_db.Size = new System.Drawing.Size(513, 31);
            this.name_new_db.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(17, 18, 17, 7);
            this.label1.Size = new System.Drawing.Size(218, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создать базу данных:";
            // 
            // PanelDbCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelDbCreate";
            this.Size = new System.Drawing.Size(700, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button create_database;
        private System.Windows.Forms.TextBox name_new_db;
        private System.Windows.Forms.Label label1;
    }
}
