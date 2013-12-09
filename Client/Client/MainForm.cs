using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(inputText.Text);
            }
            catch
            {
                inputText.Text = "Не число";
                return;
            }
            try
            {
                ServiceReference.ServiceClient c = new ServiceReference.ServiceClient();
                converselyText.Text = c.To2(value);
                capitalText.Text = c.To8(value);
                deleteNumberText.Text = c.To16(value);
                c.Close();
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                inputText.Text = "Не удалось установить подключение с сервером";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
