using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teclado_Russo
{
    public partial class frmTeclado : Form
    {
        public Boolean upper = true;
        public String key = "";

        public frmTeclado()
        {
            InitializeComponent();
            txtFrase.Select();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            if (btnTipo.Text == "Maiúsculas")
            {
                upper = false;
                btnTipo.Text = "minúsculas";
                btn1.Text = btn1.Text.ToLower();
                lbl1.Text = lbl1.Text.ToLower();
                btn2.Text = btn2.Text.ToLower();
                lbl2.Text = lbl2.Text.ToLower();
                btn3.Text = btn3.Text.ToLower();
                lbl3.Text = lbl3.Text.ToLower();
                btn4.Text = btn4.Text.ToLower();
                lbl4.Text = lbl4.Text.ToLower();
                btn5.Text = btn5.Text.ToLower();
                lbl5.Text = lbl5.Text.ToLower();
                btn6.Text = btn6.Text.ToLower();
                lbl6.Text = lbl6.Text.ToLower();
                btn7.Text = btn7.Text.ToLower();
                lbl7.Text = lbl7.Text.ToLower();
                btn8.Text = btn8.Text.ToLower();
                lbl8.Text = lbl8.Text.ToLower();
                btn9.Text = btn9.Text.ToLower();
                lbl9.Text = lbl9.Text.ToLower();
                btn10.Text = btn10.Text.ToLower();
                lbl10.Text = lbl10.Text.ToLower();
                btn11.Text = btn11.Text.ToLower();
                lbl11.Text = lbl11.Text.ToLower();
                btn12.Text = btn12.Text.ToLower();
                lbl12.Text = lbl12.Text.ToLower();
                btn13.Text = btn13.Text.ToLower();
                lbl13.Text = lbl13.Text.ToLower();
                btn14.Text = btn14.Text.ToLower();
                lbl14.Text = lbl14.Text.ToLower();
                btn15.Text = btn15.Text.ToLower();
                lbl15.Text = lbl15.Text.ToLower();
                btn16.Text = btn16.Text.ToLower();
                lbl16.Text = lbl16.Text.ToLower();
                btn17.Text = btn17.Text.ToLower();
                lbl17.Text = lbl17.Text.ToLower();
                btn18.Text = btn18.Text.ToLower();
                lbl18.Text = lbl18.Text.ToLower();
                btn19.Text = btn19.Text.ToLower();
                lbl19.Text = lbl19.Text.ToLower();
                btn20.Text = btn20.Text.ToLower();
                lbl20.Text = lbl20.Text.ToLower();
                btn21.Text = btn21.Text.ToLower();
                lbl21.Text = lbl21.Text.ToLower();
                btn22.Text = btn22.Text.ToLower();
                lbl22.Text = lbl22.Text.ToLower();
                btn23.Text = btn23.Text.ToLower();
                lbl23.Text = lbl23.Text.ToLower();
                btn24.Text = btn24.Text.ToLower();
                lbl24.Text = lbl24.Text.ToLower();
                btn25.Text = btn25.Text.ToLower();
                lbl25.Text = lbl25.Text.ToLower();
                btn26.Text = btn26.Text.ToLower();
                lbl26.Text = lbl26.Text.ToLower();
                btn27.Text = btn27.Text.ToLower();
                lbl27.Text = lbl27.Text.ToLower();
                btn28.Text = btn28.Text.ToLower();
                //lbl28.Text = lbl28.Text.ToLower();
                btn29.Text = btn29.Text.ToLower();
                lbl29.Text = lbl29.Text.ToLower();
                btn30.Text = btn30.Text.ToLower();
                //lbl30.Text = lbl30.Text.ToLower();
                btn31.Text = btn31.Text.ToLower();
                lbl31.Text = lbl31.Text.ToLower();
                btn32.Text = btn32.Text.ToLower();
                lbl32.Text = lbl32.Text.ToLower();
                btn33.Text = btn33.Text.ToLower();
                lbl33.Text = lbl33.Text.ToLower();
            }
            else
            {
                upper = true;
                btnTipo.Text = "Maiúsculas";
                btn1.Text = btn1.Text.ToUpper();
                lbl1.Text = lbl1.Text.ToUpper();
                btn2.Text = btn2.Text.ToUpper();
                lbl2.Text = lbl2.Text.ToUpper();
                btn3.Text = btn3.Text.ToUpper();
                lbl3.Text = lbl3.Text.ToUpper();
                btn4.Text = btn4.Text.ToUpper();
                lbl4.Text = lbl4.Text.ToUpper();
                btn5.Text = btn5.Text.ToUpper();
                lbl5.Text = lbl5.Text.ToUpper();
                btn6.Text = btn6.Text.ToUpper();
                lbl6.Text = lbl6.Text.ToUpper();
                btn7.Text = btn7.Text.ToUpper();
                lbl7.Text = lbl7.Text.ToUpper();
                btn8.Text = btn8.Text.ToUpper();
                lbl8.Text = lbl8.Text.ToUpper();
                btn9.Text = btn9.Text.ToUpper();
                lbl9.Text = lbl9.Text.ToUpper();
                btn10.Text = btn10.Text.ToUpper();
                lbl10.Text = lbl10.Text.ToUpper();
                btn11.Text = btn11.Text.ToUpper();
                lbl11.Text = lbl11.Text.ToUpper();
                btn12.Text = btn12.Text.ToUpper();
                lbl12.Text = lbl12.Text.ToUpper();
                btn13.Text = btn13.Text.ToUpper();
                lbl13.Text = lbl13.Text.ToUpper();
                btn14.Text = btn14.Text.ToUpper();
                lbl14.Text = lbl14.Text.ToUpper();
                btn15.Text = btn15.Text.ToUpper();
                lbl15.Text = lbl15.Text.ToUpper();
                btn16.Text = btn16.Text.ToUpper();
                lbl16.Text = lbl16.Text.ToUpper();
                btn17.Text = btn17.Text.ToUpper();
                lbl17.Text = lbl17.Text.ToUpper();
                btn18.Text = btn18.Text.ToUpper();
                lbl18.Text = lbl18.Text.ToUpper();
                btn19.Text = btn19.Text.ToUpper();
                lbl19.Text = lbl19.Text.ToUpper();
                btn20.Text = btn20.Text.ToUpper();
                lbl20.Text = lbl20.Text.ToUpper();
                btn21.Text = btn21.Text.ToUpper();
                lbl21.Text = lbl21.Text.ToUpper();
                btn22.Text = btn22.Text.ToUpper();
                lbl22.Text = lbl22.Text.ToUpper();
                btn23.Text = btn23.Text.ToUpper();
                lbl23.Text = lbl23.Text.ToUpper();
                btn24.Text = btn24.Text.ToUpper();
                lbl24.Text = lbl24.Text.ToUpper();
                btn25.Text = btn25.Text.ToUpper();
                lbl25.Text = lbl25.Text.ToUpper();
                btn26.Text = btn26.Text.ToUpper();
                lbl26.Text = lbl26.Text.ToUpper();
                btn27.Text = btn27.Text.ToUpper();
                lbl27.Text = lbl27.Text.ToUpper();
                btn28.Text = btn28.Text.ToUpper();
                //lbl28.Text = lbl28.Text.ToUpper();
                btn29.Text = btn29.Text.ToUpper();
                lbl29.Text = lbl29.Text.ToUpper();
                btn30.Text = btn30.Text.ToUpper();
                //lbl30.Text = lbl30.Text.ToUpper();
                btn31.Text = btn31.Text.ToUpper();
                lbl31.Text = lbl31.Text.ToUpper();
                btn32.Text = btn32.Text.ToUpper();
                lbl32.Text = lbl32.Text.ToUpper();
                btn33.Text = btn33.Text.ToUpper();
                lbl33.Text = lbl33.Text.ToUpper();
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtFrase.Text);
            txtFrase.Select();
        }

        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            if (txtFrase.Text.Trim() != "")
            {
                System.Diagnostics.Process.Start("chrome.exe", "https://translate.google.com.br/#view=home&op=translate&sl=auto&tl=pt&text=" + txtFrase.Text.Trim().Replace(" ", "+") );
            }
            else {
                MessageBox.Show("Digite o termo");
            }
        }
        
        private void btnEspaco_Click(object sender, EventArgs e)
        {
            txtFrase.AppendText(" ");
            txtFrase.Select();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrase.Text = "";
            txtFrase.Select();
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtFrase.Text.Length > 0) {
                txtFrase.Text = txtFrase.Text.Substring(0, txtFrase.Text.Length - 1);
            }
            //txtFrase.Select();
            txtFrase.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "A";
            } 
            else 
            {
                key = "a";
            }
            txtFrase.AppendText( key );
            txtFrase.Select();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Б";
            }
            else
            {
                key = "б";
            }
            txtFrase.AppendText(key); 
            txtFrase.Select();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "В";
            }
            else
            {
                key = "в";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Г";
            }
            else
            {
                key = "г";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Д";
            }
            else
            {
                key = "д";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Е";
            }
            else
            {
                key = "е";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ё";
            }
            else
            {
                key = "ё";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ж";
            }
            else
            {
                key = "ж";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "З";
            }
            else
            {
                key = "з";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "И";
            }
            else
            {
                key = "и";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Й";
            }
            else
            {
                key = "й";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "К";
            }
            else
            {
                key = "к";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Л";
            }
            else
            {
                key = "л";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "М";
            }
            else
            {
                key = "м";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Н";
            }
            else
            {
                key = "н";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "О";
            }
            else
            {
                key = "о";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "П";
            }
            else
            {
                key = "п";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Р";
            }
            else
            {
                key = "р";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "С";
            }
            else
            {
                key = "с";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Т";
            }
            else
            {
                key = "т";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "У";
            }
            else
            {
                key = "у";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ф";
            }
            else
            {
                key = "ф";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Х";
            }
            else
            {
                key = "х";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ц";
            }
            else
            {
                key = "ц";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ч";
            }
            else
            {
                key = "ч";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ш";
            }
            else
            {
                key = "ш";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Щ";
            }
            else
            {
                key = "щ";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ъ";
            }
            else
            {
                key = "ъ";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ы";
            }
            else
            {
                key = "ы";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ь";
            }
            else
            {
                key = "ь";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Э";
            }
            else
            {
                key = "э";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Ю";
            }
            else
            {
                key = "ю";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (upper == true)
            {
                key = "Я";
            }
            else
            {
                key = "я";
            }
            txtFrase.AppendText(key);
            txtFrase.Select();
        }
        
    }
}
