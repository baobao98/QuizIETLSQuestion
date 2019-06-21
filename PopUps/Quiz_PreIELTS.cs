using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PopUps.BAL;

namespace PopUps
{
    public partial class Quiz_PreIELTS : Form
    {
        List<string> listQuestion;
        int Length;
        Random random = new Random();
        public Quiz_PreIELTS(string path )
        {
            InitializeComponent();
            listQuestion = ReadFileTXT.ReadlineText(path);
            Length = listQuestion.Count();
        }

      
        private void BtnNext_Click(object sender, EventArgs e)
        {
            int num = random.Next(0, Length);
            lblQuestion.Text = listQuestion[num];
        }
    }
}
