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
    public partial class ControlesDeProfessores : UserControl
    {
        public ControlesDeProfessores()
        {
            InitializeComponent();
            dgv_listaDeProfessores.DataSource = ConsultaProfessores.ListarTodosOsProfessores();
        }

    }
}
