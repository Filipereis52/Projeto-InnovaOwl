namespace Aula_15_04.Controles
{
    partial class cardCursos
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
            img_cardCursos = new PictureBox();
            pnl_Header = new FlowLayoutPanel();
            lbl_categoriaCursos = new Label();
            lbl_descricao = new Label();
            lbl_nomeCard = new Label();
            btn_card = new Button();
            ((System.ComponentModel.ISupportInitialize)img_cardCursos).BeginInit();
            pnl_Header.SuspendLayout();
            SuspendLayout();
            // 
            // img_cardCursos
            // 
            img_cardCursos.BackColor = Color.White;
            img_cardCursos.Dock = DockStyle.Top;
            img_cardCursos.Location = new Point(0, 32);
            img_cardCursos.Margin = new Padding(0);
            img_cardCursos.Name = "img_cardCursos";
            img_cardCursos.Size = new Size(313, 165);
            img_cardCursos.SizeMode = PictureBoxSizeMode.Zoom;
            img_cardCursos.TabIndex = 7;
            img_cardCursos.TabStop = false;
            // 
            // pnl_Header
            // 
            pnl_Header.BackColor = Color.FromArgb(47, 146, 187);
            pnl_Header.Controls.Add(lbl_categoriaCursos);
            pnl_Header.Dock = DockStyle.Top;
            pnl_Header.Location = new Point(0, 0);
            pnl_Header.Margin = new Padding(0);
            pnl_Header.Name = "pnl_Header";
            pnl_Header.Size = new Size(313, 32);
            pnl_Header.TabIndex = 5;
            // 
            // lbl_categoriaCursos
            // 
            lbl_categoriaCursos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_categoriaCursos.AutoEllipsis = true;
            lbl_categoriaCursos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_categoriaCursos.ForeColor = Color.White;
            lbl_categoriaCursos.Location = new Point(16, 4);
            lbl_categoriaCursos.Margin = new Padding(16, 4, 16, 4);
            lbl_categoriaCursos.Name = "lbl_categoriaCursos";
            lbl_categoriaCursos.Size = new Size(288, 24);
            lbl_categoriaCursos.TabIndex = 0;
            lbl_categoriaCursos.Text = "Categoria:";
            // 
            // lbl_descricao
            // 
            lbl_descricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_descricao.AutoEllipsis = true;
            lbl_descricao.Location = new Point(16, 234);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(271, 95);
            lbl_descricao.TabIndex = 9;
            lbl_descricao.Text = "Desc:";
            // 
            // lbl_nomeCard
            // 
            lbl_nomeCard.AutoEllipsis = true;
            lbl_nomeCard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nomeCard.Location = new Point(8, 205);
            lbl_nomeCard.Margin = new Padding(8);
            lbl_nomeCard.Name = "lbl_nomeCard";
            lbl_nomeCard.Size = new Size(279, 21);
            lbl_nomeCard.TabIndex = 8;
            lbl_nomeCard.Text = "Nome:";
            // 
            // btn_card
            // 
            btn_card.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_card.AutoSize = true;
            btn_card.BackColor = Color.LightSkyBlue;
            btn_card.FlatAppearance.BorderSize = 0;
            btn_card.FlatStyle = FlatStyle.Flat;
            btn_card.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_card.Location = new Point(26, 346);
            btn_card.Margin = new Padding(8);
            btn_card.Name = "btn_card";
            btn_card.Size = new Size(261, 32);
            btn_card.TabIndex = 6;
            btn_card.Text = "Acessar";
            btn_card.UseVisualStyleBackColor = false;
            // 
            // cardCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(img_cardCursos);
            Controls.Add(pnl_Header);
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_nomeCard);
            Controls.Add(btn_card);
            Name = "cardCursos";
            Size = new Size(313, 386);
            ((System.ComponentModel.ISupportInitialize)img_cardCursos).EndInit();
            pnl_Header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox img_cardCursos;
        private FlowLayoutPanel pnl_Header;
        private Label lbl_categoriaCursos;
        private Label lbl_descricao;
        private Label lbl_nomeCard;
        private Button btn_card;
    }
}
