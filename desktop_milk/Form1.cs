using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace desktop_milk
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            clearform(); 
        }

       
        public void clearform()
        {
            textEdit1.EditValue = "";
           // textEdit2.EditValue = "";
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
           // var sVal = simpleButton1.Text;
            string s = (sender as DevExpress.XtraEditors.SimpleButton).Text;
            textEdit1.EditValue = textEdit1.Text + s; 
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            string  slogin = textEdit1.Text;

            MessageBox.Show(slogin);
            clearform(); 
           // this.Hide();
            index f1 = new index(); //this is the change, code for redirect  
            f1.ShowDialog(); 
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            clearform(); 
        }
    }
}
