using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroserviceSolution
{
    public partial class WizardInputForm : Form
    {
        public WizardInputForm()
        {
            InitializeComponent();
        }

        public string InputMessage { get; set; } = "MyDomain";

        private void button1_Click(object sender, EventArgs e)
        {
            InputMessage = this.textBox1.Text;
        }
    }
}
