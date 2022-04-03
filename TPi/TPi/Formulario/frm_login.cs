using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPi.Formulario;

namespace TPi.Formulario
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_usuario.Text == " ") 
            {
                MessageBox.Show("Ingrese un usuario");
                txt_usuario.Focus();
                return;
            }
            if (txt_contraseña.Text == "" || txt_contraseña.Text == " ") 
            {
                MessageBox.Show("Ingrese un contraseña");
                txt_contraseña.Focus();
                return;
            }
            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;
            MessageBox.Show("Usuario: " + usuario + "\n" + "Contraseña: " + contraseña);
            this.Close();
        }
    }
}
