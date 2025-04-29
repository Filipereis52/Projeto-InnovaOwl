using Aula_15_04.conexao;
using Aula_15_04.Controles;

namespace Aula_15_04
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }


        private void btn_Artigos_Click_1(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            listaDeArtigos listaDeArtigos = new listaDeArtigos();
            pnl_Conteudo.Controls.Add(listaDeArtigos);
            listaDeArtigos.Dock = DockStyle.Fill;

        }

        private void btn_Cursos_Click_1(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            listaDeCursos listaDeCursosTech = new listaDeCursos();
            pnl_Conteudo.Controls.Add(listaDeCursosTech);
            listaDeCursosTech.Dock = DockStyle.Fill;
        }

        private void btn_cardsCursos_Click(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();

            ControllsDeListagemDeCursosDeCards cardsDeCursosTech = new ControllsDeListagemDeCursosDeCards();
            pnl_Conteudo.Controls.Add(cardsDeCursosTech);
            cardsDeCursosTech.Dock = DockStyle.Fill;
        }

        private void btn_listaDeProfessores_Click(object sender, EventArgs e)
        {
            pnl_Conteudo.Controls.Clear();
            ControlesDeProfessores controlesDeProfessores = new ControlesDeProfessores();
            pnl_Conteudo.Controls.Add(controlesDeProfessores);
            controlesDeProfessores.Dock = DockStyle.Fill;
        }
    }
}
