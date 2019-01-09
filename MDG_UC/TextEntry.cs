using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMS
{
    public partial class TextEntry : UserControl
    {
        public TextEntry()
        {
            InitializeComponent();
        }

        private void TextEntry_Load(object sender, EventArgs e)
        {
            
        }

        [Description("The description of the textbox"),Category("Data")]
        public string Title
        {
            get
            {
                return LblTitle.Text;
            }
            set
            {
                LblTitle.Text = value;
            }
        }

        [Description("The initial value of the textbox"), Category("Data")]
        public string Value
        {
            get
            {
                return TxtEntry.Text;
            }
            set
            {
                TxtEntry.Text = value;
            }
        }
        
        [Description("Determines if text is editable"), Category("Behavior")]
        public bool Editable
        {
            get
            {
                return TxtEntry.Enabled;
            }

            set
            {
                TxtEntry.Enabled = value;
            }
        }
    }
}
