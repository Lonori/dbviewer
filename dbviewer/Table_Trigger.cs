using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    class Table_Trigger : CustomTable
    {
        public Table_Trigger(TableLayoutPanel element) : base(element, new string[] { "Имя", "Время", "Событие", "Действия" }) { }

        public void AddRow(string trigger_name, string trigger_time, string trigger_event)
        {
            AddRow(new Control[] {
                create_label_table(SystemColors.Control, trigger_name),
                create_label_table(SystemColors.GradientInactiveCaption, trigger_time),
                create_label_table(SystemColors.Control, trigger_event)
            });
        }

        private Label create_label_table(Color backcolor, string text)
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = backcolor,
                Margin = new Padding(0),
                Text = text
            };
        }
    }
}
