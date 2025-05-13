using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Kafe_Proje.GirisFormlari
{
    public partial class AnaForm: Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new();
            girisForm.Show();
            this.Hide();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new();
            kayitForm.Show();
            this.Hide();
        }
    }
}
