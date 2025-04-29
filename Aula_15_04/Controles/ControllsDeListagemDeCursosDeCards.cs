using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_15_04.DAL;

namespace Aula_15_04.Controles
{
    public partial class ControllsDeListagemDeCursosDeCards : UserControl
    {
        public ControllsDeListagemDeCursosDeCards()
        {
            InitializeComponent();
            
            flp_listaDeCursos.AutoScroll = true;
            flp_listaDeCursos.Controls.Clear();

            foreach (var item in ConsultaCursos.ListarTodosOsCursosDTO())
            {
                cardCursos cardCursosrun = new cardCursos(item);
                cardCursosrun.Text = item.nome;
                flp_listaDeCursos.Controls.Add(cardCursosrun);

            }
        }
        public ControllsDeListagemDeCursosDeCards(int id_categoria)
        {
            InitializeComponent();

            flp_listaDeCursos.AutoScroll = true;
            flp_listaDeCursos.Controls.Clear();

            foreach (var item in ConsultaCursos.ListarTodosOsCursosDTO().Where(item => item.id_categoria == id_categoria) )
            {
                cardCursos cardCursosrun = new cardCursos(item);
                cardCursosrun.Text = item.nome;
                flp_listaDeCursos.Controls.Add(cardCursosrun);

            }
        }

    }
}
