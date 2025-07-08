using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            utils.verbose.CreateForm();
            utils.verbose.Write("test asdfiosadfj ((SDFY(sd9as7fddd");

            utils.verbose.Append("t");
            utils.verbose.Clear();
            utils.verbose.Append("test 1".Truncate(3));
            
        }
    }
}
