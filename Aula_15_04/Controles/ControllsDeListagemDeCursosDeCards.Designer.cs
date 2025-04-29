namespace Aula_15_04.Controles
{
    partial class ControllsDeListagemDeCursosDeCards
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_cabecalho = new Panel();
            flp_listaDeCursos = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pnl_cabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_cabecalho
            // 
            pnl_cabecalho.BackColor = Color.FromArgb(255, 128, 0);
            pnl_cabecalho.Controls.Add(button3);
            pnl_cabecalho.Controls.Add(button2);
            pnl_cabecalho.Controls.Add(button1);
            pnl_cabecalho.Dock = DockStyle.Top;
            pnl_cabecalho.Location = new Point(0, 0);
            pnl_cabecalho.Name = "pnl_cabecalho";
            pnl_cabecalho.Size = new Size(823, 100);
            pnl_cabecalho.TabIndex = 0;
            // 
            // flp_listaDeCursos
            // 
            flp_listaDeCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flp_listaDeCursos.AutoScroll = true;
            flp_listaDeCursos.BorderStyle = BorderStyle.FixedSingle;
            flp_listaDeCursos.Location = new Point(16, 119);
            flp_listaDeCursos.Margin = new Padding(16);
            flp_listaDeCursos.Name = "flp_listaDeCursos";
            flp_listaDeCursos.Size = new Size(791, 413);
            flp_listaDeCursos.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(31, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(269, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(615, 56);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // ControllsDeListagemDeCursosDeCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_listaDeCursos);
            Controls.Add(pnl_cabecalho);
            Name = "ControllsDeListagemDeCursosDeCards";
            Size = new Size(823, 548);
            pnl_cabecalho.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_cabecalho;
        private FlowLayoutPanel flp_listaDeCursos;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
