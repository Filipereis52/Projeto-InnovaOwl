using Aula_15_04.conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_15_04.Controles
{
    public partial class listaDeArtigos : UserControl
    {
        public listaDeArtigos()
        {
            // desenha controle na tela
            InitializeComponent();

            //preenche infrmações na tabela
            dgv_Lista.DataSource = consultaArtigos.listarArtigos();

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_Lista.DataSource = consultaArtigos.buscarArtigos(txt_pesquisar.Text);
        }

        private void listaDeArtigos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
