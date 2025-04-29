namespace Aula_15_04.Controles
{
    partial class listaDeCursos
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
            dgv_Lista = new DataGridView();
            btn_pesquisar = new Button();
            txt_pesquisar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Lista).BeginInit();
            SuspendLayout();
            // 
            // dgv_Lista
            // 
            dgv_Lista.AllowUserToAddRows = false;
            dgv_Lista.AllowUserToDeleteRows = false;
            dgv_Lista.AllowUserToOrderColumns = true;
            dgv_Lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Lista.BackgroundColor = Color.White;
            dgv_Lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Lista.Location = new Point(32, 100);
            dgv_Lista.Margin = new Padding(32);
            dgv_Lista.Name = "dgv_Lista";
            dgv_Lista.ReadOnly = true;
            dgv_Lista.Size = new Size(784, 393);
            dgv_Lista.TabIndex = 7;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisar.BackColor = Color.FromArgb(47, 146, 187);
            btn_pesquisar.BackgroundImageLayout = ImageLayout.None;
            btn_pesquisar.FlatStyle = FlatStyle.Flat;
            btn_pesquisar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_pesquisar.Location = new Point(696, 40);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(120, 30);
            btn_pesquisar.TabIndex = 6;
            btn_pesquisar.Text = "pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = false;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_pesquisar.Location = new Point(375, 42);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.PlaceholderText = "Pesquisar Cursos...";
            txt_pesquisar.Size = new Size(315, 23);
            txt_pesquisar.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 4;
            label1.Text = "Lista de Cursos:";
            // 
            // listaDeCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(dgv_Lista);
            Controls.Add(btn_pesquisar);
            Controls.Add(txt_pesquisar);
            Controls.Add(label1);
            Name = "listaDeCursos";
            Size = new Size(848, 525);
            ((System.ComponentModel.ISupportInitialize)dgv_Lista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Lista;
        private Button btn_pesquisar;
        private TextBox txt_pesquisar;
        private Label label1;
    }
}
