using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string comboValue;
            string richTextBoxValue;
            string combinedValue;

            comboValue = comboBoxAction.SelectedItem.ToString();
            richTextBoxValue = richTextBoxDesc.Text;
            combinedValue = comboValue + "-" + richTextBoxValue;
            MessageBox.Show(combinedValue);
       }
    }
}
