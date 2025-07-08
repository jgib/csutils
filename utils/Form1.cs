using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            utils.verbose.Size(1000, 1000);
            utils.verbose.Title("Tesssst");
            utils.verbose.ShowInTaskbar(true);
            utils.verbose.ShowIcon(true);
            utils.verbose.FormFont(new System.Drawing.Font("Lucida Console", 8.25f, FontStyle.Bold));
            utils.verbose.TextFont(new System.Drawing.Font("Microsoft Sans Serif", 4, FontStyle.Underline));
            utils.verbose.Icon(new MemoryStream(Convert.FromBase64String("AAABAAIAICAQAAAAAADoAgAAJgAAABAQEAAAAAAAKAEAAA4DAAAoAAAAIAAAAEAAAAABAAQAAAAAAIACAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgAAAgAAAAICAAIAAAACAAIAAgIAAAICAgADAwMAAAAD/AAD/AAAA//8A/wAAAP8A/wD//wAA////AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADw8AAAAAAAAAAAAAAAAAAA/w//AAAAAAAAAAAAAAAAD/8P///wAAAAAAAAAAAAAA//8P////8AAAAAAAAAAAAAAPD///////8AAAAAAAAAAAAA//////////AAAAAAAAAAAP///////////wAAAAAAAAD/////////////8AAAAAAA////////AAAAAAAAAAAAAAAAAAAAAA//8P8P8AAAAAAAAAAAAAAAD//w/wAAAAAAAAAAAAAAAAAP//AAAAAAAAAAAAAAAAAAAA/wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP8P8AAAAAAAAAAAAAAAAA/w/w/wAAAAAAAAAAAAAAD/D/D/AAAAAAAAAAAAAAAP8P8P8PAAAAAAAAAAAAAA/w/w/w/wAAAAAAAAAAAAAP//D/D/AAAAAAAAAAAAAA////8P8AAAAAAAAAAAAAAP/////wAAAAAAAAAAAAAA//////AAAAAAAAAAAAAAAP////8AAAAAAAAAAAAAAAD/////8AAAAAAAAAAAAAAP////////8AAAAAAAAAAAD///////AAAAAAAAAAAAAAD///8AAAAAAAAAAAAAAAAAAP/wAAAAAAAAAAAAAAAA///////////H////gP///4Af//8AA///AAA//wAAB//wAAD/+AAAH/gAAAP4AAAA+AAAA///4Af///gP///+D/8n/5/+Af/f/AD///gB///wAP//4AD//+AB///AA///wAf//4AP//+AH///gAH//wAA//8AAP//wA////D///8oAAAAEAAAACAAAAABAAQAAAAAAMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgAAAgAAAAICAAIAAAACAAIAAgIAAAICAgADAwMAAAAD/AAD/AAAA//8A/wAAAP8A/wD//wAA////AAAAAAAAAAAAAAAAAAAAAAAPDwAAAAAAAAAP//AAAAAAAA/////wAAAAD///8A//AAAAAAAA//8AAAAAAAAA8AAAAPDwAAAAAAAPDw8AAAAAAPDw8AAAAAAA/w8PAAAAAA//8PAAAAAAD////wAAAAAP//8AAAAAAAAAAAAAAAAA//8AAA//AAAB/wAAAB8AAMADAADAAAAAwAEAAPXDAADg8wAAwH8AAID/AACAfwAAAP8AAAB/AACA/wAAw/8AAA==")));
            utils.verbose.CreateForm();
            utils.verbose.Write("test asdfiosadfj ((SDFY(sd9as7fddd");

            utils.verbose.Append("t");
            utils.verbose.Clear();
            utils.verbose.Append("test 1".Truncate(3));
            
        }
    }
}
