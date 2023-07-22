namespace CadastroPessoa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgPessoa = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            txtCpf = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(12, 246);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.RowTemplate.Height = 25;
            dgPessoa.Size = new Size(681, 144);
            dgPessoa.TabIndex = 0;
            dgPessoa.CellContentClick += dgPessoa_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            label1.Click += txtID_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(12, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(152, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(152, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += textNOME_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "CPF";
            label3.Click += label3_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(248, 192);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(84, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(338, 192);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(428, 192);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(84, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 135);
            txtCpf.Mask = "###.###.###-##";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(152, 23);
            txtCpf.TabIndex = 12;
            txtCpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 402);
            Controls.Add(txtCpf);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgPessoa);
            Name = "Form1";
            Text = "Crud de pessoa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        #endregion

        private DataGridView dgPessoa;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
        private MaskedTextBox txtCpf;
    }
}