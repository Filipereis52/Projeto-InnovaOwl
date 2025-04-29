using Aula_15_04.conexao;
using Aula_15_04.DAL;
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
    public partial class listaDeCursos : UserControl
    {
        public listaDeCursos()
        {
            InitializeComponent();
            dgv_Lista.DataSource = ConsultaCursos.ListarCursos();
        }

     

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_Lista.DataSource = ConsultaCursos.BuscarCursos(txt_pesquisar.Text);
        }
    }
}
