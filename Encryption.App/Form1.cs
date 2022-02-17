using System;
using System.Windows.Forms;
using mhcb.syd.Encryption;

namespace Encryption.App
{
    public partial class Form1 : Form
    {
        //LS_Krypting.Encryption _encryption = new LS_Krypting.Encryption();

        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptClick(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbInput.Text))
            {
                try
                {
                    string text = Krypting.Encrypt(tbInput.Text);
					tbOutput.Text = text;
                }
                catch
                {                 
                }
            }
        }

        private void DecryptClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbInput.Text))
            {
                try
                {
                    string text = Krypting.Decrypt(tbInput.Text);
                    tbOutput.Text = text;
                }
                catch
                {                   
                }
            }
        }
    }
}
