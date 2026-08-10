namespace ListaPOO
{
    partial class FrmCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTel = new Label();
            maskedtxtTel = new MaskedTextBox();
            btCadastrar2 = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(169, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(84, 37);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(84, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(84, 123);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(55, 15);
            lblTel.TabIndex = 4;
            lblTel.Text = "Telefone:";
            // 
            // maskedtxtTel
            // 
            maskedtxtTel.Location = new Point(169, 123);
            maskedtxtTel.Name = "maskedtxtTel";
            maskedtxtTel.Size = new Size(100, 23);
            maskedtxtTel.TabIndex = 5;
            // 
            // btCadastrar2
            // 
            btCadastrar2.Location = new Point(329, 348);
            btCadastrar2.Name = "btCadastrar2";
            btCadastrar2.Size = new Size(75, 23);
            btCadastrar2.TabIndex = 6;
            btCadastrar2.Text = "Cadastrar";
            btCadastrar2.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCadastrar2);
            Controls.Add(maskedtxtTel);
            Controls.Add(lblTel);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Name = "FrmCadastrar";
            Text = "FrmCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTel;
        private MaskedTextBox maskedtxtTel;
        private Button btCadastrar2;
    }
}