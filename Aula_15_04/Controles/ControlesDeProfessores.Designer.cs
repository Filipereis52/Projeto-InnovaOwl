namespace Aula_15_04.Controles
{
    partial class ControlesDeProfessores
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
            dgv_listaDeProfessores = new DataGridView();
            btn_adicionarProfessores = new Button();
            btn_removerProfessores = new Button();
            btn_editarProfessores = new Button();
            pnl_cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeProfessores).BeginInit();
            SuspendLayout();
            // 
            // pnl_cabecalho
            // 
            pnl_cabecalho.BackColor = Color.FromArgb(255, 128, 0);
            pnl_cabecalho.Controls.Add(btn_editarProfessores);
            pnl_cabecalho.Controls.Add(btn_removerProfessores);
            pnl_cabecalho.Controls.Add(btn_adicionarProfessores);
            pnl_cabecalho.Dock = DockStyle.Top;
            pnl_cabecalho.Location = new Point(0, 0);
            pnl_cabecalho.Margin = new Padding(0);
            pnl_cabecalho.Name = "pnl_cabecalho";
            pnl_cabecalho.Size = new Size(928, 100);
            pnl_cabecalho.TabIndex = 0;
            // 
            // dgv_listaDeProfessores
            // 
            dgv_listaDeProfessores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listaDeProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaDeProfessores.Location = new Point(16, 116);
            dgv_listaDeProfessores.Margin = new Padding(16);
            dgv_listaDeProfessores.Name = "dgv_listaDeProfessores";
            dgv_listaDeProfessores.Size = new Size(896, 475);
            dgv_listaDeProfessores.TabIndex = 1;
            // 
            // btn_adicionarProfessores
            // 
            btn_adicionarProfessores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_adicionarProfessores.Location = new Point(487, 31);
            btn_adicionarProfessores.Name = "btn_adicionarProfessores";
            btn_adicionarProfessores.Size = new Size(153, 23);
            btn_adicionarProfessores.TabIndex = 0;
            btn_adicionarProfessores.Text = "Adicionar Professores";
            btn_adicionarProfessores.UseVisualStyleBackColor = true;
            // 
            // btn_removerProfessores
            // 
            btn_removerProfessores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_removerProfessores.Location = new Point(646, 31);
            btn_removerProfessores.Name = "btn_removerProfessores";
            btn_removerProfessores.Size = new Size(142, 23);
            btn_removerProfessores.TabIndex = 1;
            btn_removerProfessores.Text = "Remover Professores";
            btn_removerProfessores.UseVisualStyleBackColor = true;
            // 
            // btn_editarProfessores
            // 
            btn_editarProfessores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editarProfessores.Location = new Point(794, 31);
            btn_editarProfessores.Name = "btn_editarProfessores";
            btn_editarProfessores.Size = new Size(118, 23);
            btn_editarProfessores.TabIndex = 2;
            btn_editarProfessores.Text = "Editar Professores";
            btn_editarProfessores.UseVisualStyleBackColor = true;
            // 
            // ControlesDeProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgv_listaDeProfessores);
            Controls.Add(pnl_cabecalho);
            Name = "ControlesDeProfessores";
            Size = new Size(928, 607);
            pnl_cabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeProfessores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_cabecalho;
        private Button btn_editarProfessores;
        private Button btn_removerProfessores;
        private Button btn_adicionarProfessores;
        private DataGridView dgv_listaDeProfessores;
    }
}
