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
    [DefaultEvent("Click")]
    public partial class card_conteudo : UserControl
    {
        [Category("# Opções do Card")]
        public string nomeCard
        {

            get { return lbl_nomeCard.Text; }

            set { lbl_nomeCard.Text = value; }

        }


        [Category("# Opções do Card")]
        public string descricaoCard
        {

            get { return lbl_descricao.Text; }

            set { lbl_descricao.Text = value; }

        }

        [Category("# Opções do Card")]
        public string categoriaCard
        {

            get { return lbl_categoria.Text; }

            set { lbl_categoria.Text = value; }

        }

        [Category("# Opções do Card")]
        public string urlDaImagemCard
        {

            get { return img_card.ImageLocation; }

            set { img_card.ImageLocation = value; }

        }

        [Category("# Opções do Card")]
        public Image blobDaImagemCard
        {

            get { return img_card.Image; }

            set { img_card.Image = value; }

        }

        [Category("# Opções do Card")]
        public Color corCard

        {

            get { return pnl_Header.BackColor; }

            set { pnl_Header.BackColor = value; }

        }

        public card_conteudo()
        {
            InitializeComponent();
        }
    }
}
