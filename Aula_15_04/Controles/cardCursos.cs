using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_15_04.DTOs;

namespace Aula_15_04.Controles
{
    public partial class cardCursos : UserControl
    {
        public cardCursos()
        {
            InitializeComponent();
        }

        public cardCursos(CursoDTOs curso)
        {
            InitializeComponent();
            lbl_nomeCard.Text = curso.nome;
            lbl_descricao.Text = curso.descricao;
            lbl_categoriaCursos.Text = curso.nome_categoria;


            switch (curso.id_categoria)
            {
                case 1:
                    pnl_Header.BackColor = Color.Blue;
                    break;
                case 2:
                    pnl_Header.BackColor = Color.Red;
                 break;
                case 3:
                   pnl_Header.BackColor = Color.Violet;
                 break;
                case 4:
                    pnl_Header.BackColor = Color.Orange;
                 ; break;
                default:
                  //nada ainda
                break;


            }

        }
    }
}
