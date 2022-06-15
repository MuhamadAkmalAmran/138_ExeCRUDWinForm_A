using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _138_ExeCRUDWinForm_A
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            
        }


        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var ps = db.insertSiswa(int.Parse(textNIM.Text), textSiswa.Text, textAlamat.Text); 

        }
    }
}
