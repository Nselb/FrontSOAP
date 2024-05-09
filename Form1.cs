using FrontSOAP.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontSOAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Service1Client sClient = new Service1Client();
            string response = sClient.GetData(5);
            MessageBox.Show(response);
            CompositeType compositeType = new CompositeType
            {
                BoolValue = true
            };
            CompositeType response2 = sClient.GetDataUsingDataContract(compositeType);
            MessageBox.Show(response2.StringValue);
        }
    }
}
