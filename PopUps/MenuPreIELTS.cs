using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopUps
{
    public partial class MenuPreIELTS : Form
    {
        //Properties
        string path;

        //Constructor
        public MenuPreIELTS()
        {
            InitializeComponent();
        }
        public void OpenWindow(string path,string title)
        {
            Quiz_PreIELTS window = new Quiz_PreIELTS(path);
            window.Text = title;
            window.ShowDialog();
        }

        //Buttons
        private void BtnSession1_Click(object sender, EventArgs e)
        {
            path = @".\Pre_IELTS\Session1.txt";
            OpenWindow(path,"Session 1");
        }
        private void BtnSession3_Click(object sender, EventArgs e)
        {
            path = @".\Pre_IELTS\Session3.txt";
            OpenWindow(path,"Session 3");
        }

        private void BtnSession5_Click(object sender, EventArgs e)
        {
            path = @".\Pre_IELTS\Session5.txt";
            OpenWindow(path,"Session 5");

        }
        private void BtnSession9_Click(object sender, EventArgs e)
        {
            path = @".\Pre_IELTS\Session9.txt";
            OpenWindow(path,"Session 9");
        }

    }
}
