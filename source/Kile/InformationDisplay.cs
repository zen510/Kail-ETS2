using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kile
{
    public partial class InformationDisplay : UserControl
    {
        public InformationDisplay()
        {
            InitializeComponent();
        }

        public bool ShowAirPressure
        {
            get
            {
                return airpressure.Visible;
            }
            set
            {
                airpressure.Visible = value;
            }
        }

        public string speed
        {
            get;set;
            
        }
    }
}
