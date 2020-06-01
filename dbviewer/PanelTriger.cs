using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdviewer
{
    class PanelTriger
    {
        private Panel[] panels;

        public PanelTriger(Panel[] panels)
        {
            this.panels = panels;
        }

        public void ChangeActivePanel(Panel panel)
        {
            bool triger = false;
            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i].Equals(panel))
                {
                    panels[i].Visible = true;
                    triger = true;
                }
                else
                {
                    panels[i].Visible = false;
                }
            }
            if (triger == false) throw new Exception("Panel '" + panel.Name + "' not found this PanelTriger");
        }
    }
}
