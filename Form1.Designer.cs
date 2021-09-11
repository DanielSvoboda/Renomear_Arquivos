namespace Renomear_Arquivos
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_diretorio = new System.Windows.Forms.TextBox();
            this.button_diretorio = new System.Windows.Forms.Button();
            this.textBox_nomes_originais = new System.Windows.Forms.TextBox();
            this.textBox_nomes_modificados = new System.Windows.Forms.TextBox();
            this.textBox_outro_formato = new System.Windows.Forms.TextBox();
            this.button_remover = new System.Windows.Forms.Button();
            this.comboBox_formatos = new System.Windows.Forms.ComboBox();
            this.groupBox_Formato = new System.Windows.Forms.GroupBox();
            this.button_atualizar2 = new System.Windows.Forms.Button();
            this.groupBox_Remover = new System.Windows.Forms.GroupBox();
            this.button_aplicar_mudancas = new System.Windows.Forms.Button();
            this.textBox_quant_remover_caracteres = new System.Windows.Forms.TextBox();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox_Adicionar = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox_adicionar_caracteres = new System.Windows.Forms.TextBox();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_sobre1 = new System.Windows.Forms.Label();
            this.groupBox_Formato.SuspendLayout();
            this.groupBox_Remover.SuspendLayout();
            this.groupBox_Adicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_diretorio
            // 
            this.textBox_diretorio.Location = new System.Drawing.Point(41, 12);
            this.textBox_diretorio.Name = "textBox_diretorio";
            this.textBox_diretorio.Size = new System.Drawing.Size(700, 20);
            this.textBox_diretorio.TabIndex = 1;
            // 
            // button_diretorio
            // 
            this.button_diretorio.Location = new System.Drawing.Point(747, 10);
            this.button_diretorio.Name = "button_diretorio";
            this.button_diretorio.Size = new System.Drawing.Size(31, 23);
            this.button_diretorio.TabIndex = 2;
            this.button_diretorio.Text = ". . .";
            this.button_diretorio.UseVisualStyleBackColor = true;
            this.button_diretorio.Click += new System.EventHandler(this.button_diretorio_Click);
            // 
            // textBox_nomes_originais
            // 
            this.textBox_nomes_originais.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomes_originais.Location = new System.Drawing.Point(12, 38);
            this.textBox_nomes_originais.Multiline = true;
            this.textBox_nomes_originais.Name = "textBox_nomes_originais";
            this.textBox_nomes_originais.ReadOnly = true;
            this.textBox_nomes_originais.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_nomes_originais.Size = new System.Drawing.Size(380, 400);
            this.textBox_nomes_originais.TabIndex = 3;
            // 
            // textBox_nomes_modificados
            // 
            this.textBox_nomes_modificados.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.textBox_nomes_modificados.Location = new System.Drawing.Point(398, 38);
            this.textBox_nomes_modificados.Multiline = true;
            this.textBox_nomes_modificados.Name = "textBox_nomes_modificados";
            this.textBox_nomes_modificados.ReadOnly = true;
            this.textBox_nomes_modificados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_nomes_modificados.Size = new System.Drawing.Size(380, 400);
            this.textBox_nomes_modificados.TabIndex = 4;
            // 
            // textBox_outro_formato
            // 
            this.textBox_outro_formato.Enabled = false;
            this.textBox_outro_formato.Location = new System.Drawing.Point(87, 19);
            this.textBox_outro_formato.Name = "textBox_outro_formato";
            this.textBox_outro_formato.Size = new System.Drawing.Size(50, 20);
            this.textBox_outro_formato.TabIndex = 5;
            this.textBox_outro_formato.Text = ".pdf";
            // 
            // button_remover
            // 
            this.button_remover.Location = new System.Drawing.Point(6, 21);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(75, 23);
            this.button_remover.TabIndex = 8;
            this.button_remover.Text = "REMOVER";
            this.button_remover.UseVisualStyleBackColor = true;
            this.button_remover.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_formatos
            // 
            this.comboBox_formatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_formatos.FormattingEnabled = true;
            this.comboBox_formatos.Items.AddRange(new object[] {
            ".PDF",
            ".TIF",
            ".TIFF",
            ".PNG",
            ".JPG",
            ".GIF",
            ".TXT",
            ".DOC",
            ".DOCX",
            ".XLS",
            ".XLSX",
            ".MP4",
            "+MAIS"});
            this.comboBox_formatos.Location = new System.Drawing.Point(6, 19);
            this.comboBox_formatos.Name = "comboBox_formatos";
            this.comboBox_formatos.Size = new System.Drawing.Size(75, 21);
            this.comboBox_formatos.TabIndex = 9;
            this.comboBox_formatos.SelectedIndexChanged += new System.EventHandler(this.comboBox_formatos_SelectedIndexChanged_1);
            // 
            // groupBox_Formato
            // 
            this.groupBox_Formato.Controls.Add(this.button_atualizar2);
            this.groupBox_Formato.Controls.Add(this.textBox_outro_formato);
            this.groupBox_Formato.Controls.Add(this.comboBox_formatos);
            this.groupBox_Formato.Location = new System.Drawing.Point(792, 12);
            this.groupBox_Formato.Name = "groupBox_Formato";
            this.groupBox_Formato.Size = new System.Drawing.Size(177, 52);
            this.groupBox_Formato.TabIndex = 11;
            this.groupBox_Formato.TabStop = false;
            this.groupBox_Formato.Text = "FORMATO";
            // 
            // button_atualizar2
            // 
            this.button_atualizar2.Enabled = false;
            this.button_atualizar2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_atualizar2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar2.Location = new System.Drawing.Point(143, 17);
            this.button_atualizar2.Name = "button_atualizar2";
            this.button_atualizar2.Size = new System.Drawing.Size(23, 23);
            this.button_atualizar2.TabIndex = 14;
            this.button_atualizar2.Text = "⟳";
            this.button_atualizar2.UseVisualStyleBackColor = true;
            this.button_atualizar2.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // groupBox_Remover
            // 
            this.groupBox_Remover.Controls.Add(this.button_aplicar_mudancas);
            this.groupBox_Remover.Controls.Add(this.textBox_quant_remover_caracteres);
            this.groupBox_Remover.Controls.Add(this.button_remover);
            this.groupBox_Remover.Location = new System.Drawing.Point(792, 99);
            this.groupBox_Remover.Name = "groupBox_Remover";
            this.groupBox_Remover.Size = new System.Drawing.Size(177, 80);
            this.groupBox_Remover.TabIndex = 12;
            this.groupBox_Remover.TabStop = false;
            this.groupBox_Remover.Text = "REMOVER CARACTERES";
            // 
            // button_aplicar_mudancas
            // 
            this.button_aplicar_mudancas.Location = new System.Drawing.Point(6, 49);
            this.button_aplicar_mudancas.Name = "button_aplicar_mudancas";
            this.button_aplicar_mudancas.Size = new System.Drawing.Size(160, 23);
            this.button_aplicar_mudancas.TabIndex = 11;
            this.button_aplicar_mudancas.Text = "APLICAR MUDANÇAS";
            this.button_aplicar_mudancas.UseVisualStyleBackColor = true;
            this.button_aplicar_mudancas.Click += new System.EventHandler(this.button_aplicar_mudancas_Click);
            // 
            // textBox_quant_remover_caracteres
            // 
            this.textBox_quant_remover_caracteres.Location = new System.Drawing.Point(87, 23);
            this.textBox_quant_remover_caracteres.Name = "textBox_quant_remover_caracteres";
            this.textBox_quant_remover_caracteres.Size = new System.Drawing.Size(79, 20);
            this.textBox_quant_remover_caracteres.TabIndex = 9;
            // 
            // button_atualizar
            // 
            this.button_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_atualizar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.Location = new System.Drawing.Point(12, 10);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(23, 23);
            this.button_atualizar.TabIndex = 13;
            this.button_atualizar.Text = "⟳";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(791, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "LIMPAR TODOS OS CAMPOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Limpar);
            // 
            // groupBox_Adicionar
            // 
            this.groupBox_Adicionar.Controls.Add(this.button5);
            this.groupBox_Adicionar.Controls.Add(this.textBox_adicionar_caracteres);
            this.groupBox_Adicionar.Controls.Add(this.button_adicionar);
            this.groupBox_Adicionar.Location = new System.Drawing.Point(792, 214);
            this.groupBox_Adicionar.Name = "groupBox_Adicionar";
            this.groupBox_Adicionar.Size = new System.Drawing.Size(177, 80);
            this.groupBox_Adicionar.TabIndex = 15;
            this.groupBox_Adicionar.TabStop = false;
            this.groupBox_Adicionar.Text = "ADICIONAR CARACTERES";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "APLICAR MUDANÇAS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_aplicar_mudancas_Click);
            // 
            // textBox_adicionar_caracteres
            // 
            this.textBox_adicionar_caracteres.Location = new System.Drawing.Point(87, 22);
            this.textBox_adicionar_caracteres.Name = "textBox_adicionar_caracteres";
            this.textBox_adicionar_caracteres.Size = new System.Drawing.Size(79, 20);
            this.textBox_adicionar_caracteres.TabIndex = 13;
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(6, 19);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 12;
            this.button_adicionar.Text = "ADICIONAR";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(795, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/DanielSvoboda";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_sobre1
            // 
            this.label_sobre1.AutoSize = true;
            this.label_sobre1.Location = new System.Drawing.Point(811, 412);
            this.label_sobre1.Name = "label_sobre1";
            this.label_sobre1.Size = new System.Drawing.Size(137, 13);
            this.label_sobre1.TabIndex = 17;
            this.label_sobre1.Text = "Criado por: Daniel Svoboda\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.label_sobre1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox_Adicionar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.groupBox_Remover);
            this.Controls.Add(this.groupBox_Formato);
            this.Controls.Add(this.textBox_nomes_modificados);
            this.Controls.Add(this.textBox_nomes_originais);
            this.Controls.Add(this.button_diretorio);
            this.Controls.Add(this.textBox_diretorio);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENOMEAR ARQUIVOS";
            this.groupBox_Formato.ResumeLayout(false);
            this.groupBox_Formato.PerformLayout();
            this.groupBox_Remover.ResumeLayout(false);
            this.groupBox_Remover.PerformLayout();
            this.groupBox_Adicionar.ResumeLayout(false);
            this.groupBox_Adicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_diretorio;
        private System.Windows.Forms.Button button_diretorio;
        private System.Windows.Forms.TextBox textBox_nomes_originais;
        private System.Windows.Forms.TextBox textBox_nomes_modificados;
        private System.Windows.Forms.TextBox textBox_outro_formato;
        private System.Windows.Forms.Button button_remover;
        private System.Windows.Forms.ComboBox comboBox_formatos;
        private System.Windows.Forms.GroupBox groupBox_Formato;
        private System.Windows.Forms.GroupBox groupBox_Remover;
        private System.Windows.Forms.TextBox textBox_quant_remover_caracteres;
        private System.Windows.Forms.Button button_aplicar_mudancas;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_atualizar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox_Adicionar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox_adicionar_caracteres;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_sobre1;
    }
}

