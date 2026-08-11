namespace ListaPOO
{
    partial class FrmEditor
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
            components = new System.ComponentModel.Container();
            lblID = new Label();
            lblNome2 = new Label();
            lblTel2 = new Label();
            lblEmail2 = new Label();
            lblIDx = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNome2 = new TextBox();
            txtEmail2 = new TextBox();
            maskedtxtTel2 = new MaskedTextBox();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(70, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblNome2
            // 
            lblNome2.AutoSize = true;
            lblNome2.Location = new Point(70, 83);
            lblNome2.Name = "lblNome2";
            lblNome2.Size = new Size(43, 15);
            lblNome2.TabIndex = 1;
            lblNome2.Text = "Nome:";
            // 
            // lblTel2
            // 
            lblTel2.AutoSize = true;
            lblTel2.Location = new Point(70, 161);
            lblTel2.Name = "lblTel2";
            lblTel2.Size = new Size(55, 15);
            lblTel2.TabIndex = 2;
            lblTel2.Text = "Telefone:";
            // 
            // lblEmail2
            // 
            lblEmail2.AutoSize = true;
            lblEmail2.Location = new Point(70, 244);
            lblEmail2.Name = "lblEmail2";
            lblEmail2.Size = new Size(44, 15);
            lblEmail2.TabIndex = 3;
            lblEmail2.Text = "E-Mail:";
            // 
            // lblIDx
            // 
            lblIDx.AutoSize = true;
            lblIDx.Location = new Point(97, 9);
            lblIDx.Name = "lblIDx";
            lblIDx.Size = new Size(14, 15);
            lblIDx.TabIndex = 4;
            lblIDx.Text = "X";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNome2
            // 
            txtNome2.Location = new Point(149, 80);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(100, 23);
            txtNome2.TabIndex = 6;
            // 
            // txtEmail2
            // 
            txtEmail2.Location = new Point(149, 241);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(100, 23);
            txtEmail2.TabIndex = 7;
            // 
            // maskedtxtTel2
            // 
            maskedtxtTel2.Location = new Point(149, 153);
            maskedtxtTel2.Mask = "(00) 00000-0000";
            maskedtxtTel2.Name = "maskedtxtTel2";
            maskedtxtTel2.Size = new Size(100, 23);
            maskedtxtTel2.TabIndex = 8;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(275, 379);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // FrmEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSalvar);
            Controls.Add(maskedtxtTel2);
            Controls.Add(txtEmail2);
            Controls.Add(txtNome2);
            Controls.Add(lblIDx);
            Controls.Add(lblEmail2);
            Controls.Add(lblTel2);
            Controls.Add(lblNome2);
            Controls.Add(lblID);
            Name = "FrmEditor";
            Text = "FrmEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNome2;
        private Label lblTel2;
        private Label lblEmail2;
        private Label lblIDx;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNome2;
        private TextBox txtEmail2;
        private MaskedTextBox maskedtxtTel2;
        private Button btSalvar;
    }
}