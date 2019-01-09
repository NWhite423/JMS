using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMS.UC
{
    public partial class JobInformation : UserControl
    {
        public JobInformation()
        {
            InitializeComponent();
        }

        private void ResizeControls()
        {
            int formwidth = Width;
            int edgeBuffer = 4;
            int centerBuffer = 8;
            int itemWidth = (formwidth - edgeBuffer - edgeBuffer - centerBuffer) / 2;
            TEName.Width = itemWidth;
            TEAddress.Width = itemWidth;

            TEAddress.Location = new Point(edgeBuffer + itemWidth + centerBuffer - 1, TEAddress.Location.Y);
        }

        private void JobInformation_Load(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void JobInformation_SizeChanged(object sender, EventArgs e)
        {
            ResizeControls();
        }
    }
}
