using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Renomear_Arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nomes_originais; // variavel auxiliar apenas para ver no textbox o conteudo da var nomes_originais_lista

        ArrayList nomes_originais_lista = new ArrayList();      //lista com nomes originais
        ArrayList extensao_originais_lista = new ArrayList();   //lista extensoes originais
        ArrayList nomes_mod_lista = new ArrayList();            //nome final 

        ArrayList nomes_com_caracteres_menor = new ArrayList(); //armazena nome dos arquivos que não seram alterados por ter a quantidade de caracteres inferior a quantidade solicitada que será removida.
        
        int quant_caracter_inferior = 0;
        int arquivos_com_mesmo_nome = 0;


        //Escolher diretório
        private void button_diretorio_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox_diretorio.Text = dialog.FileName;
            }

            // Se escolher um diretório e não selecionar um formaro, define: .PDF
            if (comboBox_formatos.SelectedIndex == -1)      
            {
                comboBox_formatos.SelectedIndex = comboBox_formatos.FindStringExact(".PDF");
            }
            else
            {
                nomes_arquivos();
            }
        }


        public void nomes_arquivos()
        {
            // Valida se o diretório é valido
            if (textBox_diretorio.Text == "" || Path.IsPathRooted(textBox_diretorio.Text) == false)                       
            {
                MessageBox.Show("c um diretório valido!");
                return;
            }
                      
            // Limpa as variaveis
            nomes_originais = "";
            nomes_originais_lista.Clear();
            extensao_originais_lista.Clear();
            nomes_mod_lista.Clear();

            DirectoryInfo directory = new DirectoryInfo(textBox_diretorio.Text);
            FileInfo[] files;
 
            if (comboBox_formatos.Text == "+MAIS")
            {
                files = directory.GetFiles("*" + textBox_outro_formato.Text);           //Se escolher *MAIS, utiliza a extensão do textbox
            }
            else
            {
                files = directory.GetFiles("*" + comboBox_formatos.Text);               //Se não, utilizara o conteudo selecionado do comboBox
            }

            foreach (var file in files)     // repete ate o total de arquivo que existe na pasta, conforme a extensão
            {
                var name = file.Name.ToString();                                        //var aux com o nome
                var exten = Path.GetExtension(directory.ToString() +"/"+ file);         //var aux com a extensão

                nomes_originais += name + Environment.NewLine;                          //arquivo.txt       -apenas para usar no textbox
                nomes_originais_lista.Add(name.Remove(name.Length - exten.Length));     //arquivo           -array
                extensao_originais_lista.Add(exten);                                    //.txt              -array
            }

            if (nomes_originais != "")  //Se localizar algo add
            {
                nomes_originais = nomes_originais.Remove(nomes_originais.Length - 1);   //Remove 2 ultimos caracteres, em branco        
                textBox_nomes_originais.Text = nomes_originais;
            }
            else                        //Se não localiar arquivos, informar:
            {
                if (comboBox_formatos.SelectedIndex == 12)
                {
                    MessageBox.Show("No local selecionado não contem arquivos com a extensão: " + textBox_outro_formato.Text);
                }
                else
                {
                    MessageBox.Show("No local selecionado não contem arquivos com a extensão: " + comboBox_formatos.Text);
                }
                textBox_nomes_originais.Text = ""; // limpa o txtbox
            }
        }

        // BOTÃO ATUALIZAR- os nomes dos arquivos no diretório
        private void button_atualizar_Click(object sender, EventArgs e)
        {
            nomes_arquivos();
        }

        //Habilita/Desabilita o textbox(extensão) e o botão de atualizar, se selecionar +MAIS no comboBox
        private void comboBox_formatos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_formatos.SelectedIndex == 12)
            {
                textBox_outro_formato.Enabled = true;
                button_atualizar2.Enabled = true;
            }
            else
            {
                textBox_outro_formato.Enabled = false;
                button_atualizar2.Enabled = false;
            }

            if (textBox_diretorio.Text != "")
            {
                nomes_arquivos();
            }
        }

        // botao remover
        private void button1_Click(object sender, EventArgs e)
        {
            // verifica se o campo textBox_quant_remover_caracteres é um numero e é acima de 0
            bool isNumber = int.TryParse(textBox_quant_remover_caracteres.Text, out _);
            if (isNumber == false || Convert.ToInt32(textBox_quant_remover_caracteres.Text) <= 0)
            {
                MessageBox.Show("Favor, informar uma quantidade caracteres acima de 0\nPara poder remover do final do nome do arquivo!");
                return;
            }
            nomes_arquivos();

            // Limpa as variaveis 
            textBox_nomes_modificados.Text = "";  //LIMPA TELA DIREITA
            nomes_mod_lista.Clear();
            nomes_com_caracteres_menor.Clear();
            quant_caracter_inferior = 0;
            arquivos_com_mesmo_nome = 0;

            // Quantidade de caracteres que será removido no final do nome do arquivo
            int quant_remover = Convert.ToInt32(textBox_quant_remover_caracteres.Text);


            for (int i = 0; i < nomes_originais_lista.Count; i++)       // LOOP PELOS NOMES DA LISTA ORIGINAL
            {
                string nome = nomes_originais_lista[i].ToString();      // VAR AUX:NOME QUE RECEBE O NOME DO ARQUIVO

                if (nome.Length > quant_remover)    // Se o nome for maior que quantidade caracter a ser removido
                {
                    if (nomes_mod_lista.Count > 0)
                    {
                        //função verificar se o nome final ja existe(duplicado). E faz a correção add   _1   _2   _3
                        var nome_final_renomeado = verificar_duplicado_1(nome.Remove(nome.Length - quant_remover), extensao_originais_lista[i].ToString(), 0);

                        nomes_mod_lista.Add(nome_final_renomeado);
                        textBox_nomes_modificados.Text += nomes_mod_lista[i ] + Environment.NewLine; //i-1...
                    }
                    else        //primeiro da lista, só add ele sem verificar nada, desdeq tenha o nome maios que 0 caracteres
                    {
                        nomes_mod_lista.Add(nome.Remove(nome.Length - quant_remover) + extensao_originais_lista[i]);
                        textBox_nomes_modificados.Text += nomes_mod_lista[i ] + Environment.NewLine; //i-1 testar
                    }
                }
                else    //SE A QUANTIDADE DE CARACTERES QUE SERÁ REMOVIDO É MAIOR QUE O PROPRIO NOME DO ARQUIVO
                {
                    quant_caracter_inferior += 1;
                    nomes_com_caracteres_menor.Add(nomes_originais_lista[i].ToString() + extensao_originais_lista[i].ToString());
                    nomes_mod_lista.Add(nomes_originais_lista[i].ToString() + extensao_originais_lista[i].ToString()); // O NOME FINAL VAI SER O MESMO, NAO ALTERAR. Menssagem posteriormente avisando
                }
            }

            //verificar se algum arquivo não será renomeado por: ser menor que a quantidade de caracteres selecionado
            verificar_nao_modificados();

            if (arquivos_com_mesmo_nome == 1)
            {
                MessageBox.Show("1 arquivo tinha o nome final idêntico a outro, e esse\nfoi renomeado com um número no final:  _1");
            }
            if (arquivos_com_mesmo_nome > 1)
            {
                MessageBox.Show(arquivos_com_mesmo_nome + " arquivos tinham o nome final idêntico a outro, e esses\nforam renomeados com uma numeração no final _1 _2 _3 ...");
            }
        }



        private string verificar_duplicado_1(string nome, string extencao, int contar_repeticao)
        {
            var resultado = verificar_duplicado_2(nome, extencao, contar_repeticao);
            string novo_nome = resultado.nome;
            string nova_extencao = resultado.extencao;
            int contar = resultado.contar_repeticao;

            while (resultado.boleano == true)
            {
                arquivos_com_mesmo_nome += 1;

                resultado = verificar_duplicado_2(novo_nome, nova_extencao, contar+1);
                novo_nome = resultado.nome;
                nova_extencao = resultado.extencao;
                contar = resultado.contar_repeticao;
            }
            if (contar == 0)
            {
                return nome + extencao;
            }
            else
            {
                return nome + "_" + contar + extencao;
            }
        }

        private (bool boleano, string nome, string extencao, int contar_repeticao) verificar_duplicado_2(string nome, string extencao, int contar_repeticao)
        {
            for (int j = 0; j < nomes_mod_lista.Count; j++)
            {
                if (contar_repeticao == 0)
                {
                    if (nome+extencao == nomes_mod_lista[j].ToString())
                    {
                        return (true,nome, extencao, contar_repeticao);
                    }     
                }
                else
                {
                    if (nome +'_'+ contar_repeticao + extencao == nomes_mod_lista[j].ToString())
                    {
                        return (true, nome, extencao, contar_repeticao);
                    }
                }
            }
            return (false, nome, extencao, contar_repeticao);
        }



        private void verificar_nao_modificados() //Verificar se a quantidade de caractes não ficará negativa ou =0
        {
            string mensagem_dialog = string.Empty;
            if (quant_caracter_inferior > 0)
            {              
                foreach (var nome in nomes_com_caracteres_menor)
                {
                    mensagem_dialog += nome + Environment.NewLine;
                }

                var aux1 = "Exite: 1 Arquivo!\nCom a quantidade de caracteres inferior ao selecionado(" + textBox_quant_remover_caracteres.Text + ")" +
                    "\nSendo assim é impossível renomear um arquivo com menos de 1 caracter." +
                    "\nEsse arquivo listado abaixo não será alterado!";

                if (quant_caracter_inferior > 1)
                {
                    aux1 = "Existem: " + quant_caracter_inferior + " Arquivos!\nCom a quantidade de caracteres inferior ao selecionado( " + textBox_quant_remover_caracteres.Text + " )" +
                    "\nSendo assim é impossível renomear um arquivo com menos de 1 caracter." +
                    "\nEsses arquivos listados abaixo não serão alterados!";
                }

                var dialogTipo = typeof(Form).Assembly.GetType("System.Windows.Forms.PropertyGridInternal.GridErrorDlg");

                // Instancia o dialog
                var dialog = (Form)Activator.CreateInstance(dialogTipo, new PropertyGrid());

                // Populate relevant properties on the dialog instance.
                dialog.Text = "Observações - Importantes!";
                dialogTipo.GetProperty("Message").SetValue(dialog, aux1, null);
                dialogTipo.GetProperty("Details").SetValue(dialog, mensagem_dialog, null);

                // Remove o botão cancelar
                var botao_cancelar = dialog.Controls.Find("cancelBtn", true);
                botao_cancelar[0].Visible = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dialog.Close();
                }
            }
        }




        //Botão adicionar +texto ao nome do arquivo
        private void button_adicionar_Click(object sender, EventArgs e)
        {
            if (textBox_adicionar_caracteres.Text == "")
            {
                MessageBox.Show("Favor escrever algo no campo ao lado,\npara ser adicionado ao final do nome do arquivo!");
                return;
            }
            nomes_arquivos();

            textBox_nomes_modificados.Text = "";  
            nomes_mod_lista.Clear();

            for (int i = 0; i < nomes_originais_lista.Count; i++)       // LOOP PELOS NOMES DA LISTA ORIGINAL
            {
                string nome = nomes_originais_lista[i].ToString() + textBox_adicionar_caracteres.Text + extensao_originais_lista[i].ToString();

                nomes_mod_lista.Add(nome);
                textBox_nomes_modificados.Text += nomes_mod_lista[i] + Environment.NewLine;
            }
        }



        //BOTÃO APLICAR MUDANÇAS, RENOMEIAS OS ARQUIVOS
        private void button_aplicar_mudancas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nomes_originais_lista.Count; i++)
            {
                if (!File.Exists(textBox_diretorio.Text + "\\" + nomes_mod_lista[i]))
                {
                    File.Move(textBox_diretorio.Text + "\\" + nomes_originais_lista[i] + extensao_originais_lista[i], textBox_diretorio.Text + "\\" + nomes_mod_lista[i]);
                }
            }

            if (nomes_mod_lista.Count == 1)
            {
                MessageBox.Show("1 Arquivo foi renomeado no diretório:\n" + textBox_diretorio.Text);
            }
            if (nomes_mod_lista.Count > 1)
            {
                MessageBox.Show(nomes_mod_lista.Count - quant_caracter_inferior +
                    " Arquivos foram renomeados no diretório:\n" + textBox_diretorio.Text);
            }
        }


        //Botão limpar
        private void button_Limpar(object sender, EventArgs e)
        {
            textBox_nomes_modificados.Text = "";
            nomes_mod_lista.Clear();
            nomes_com_caracteres_menor.Clear();
            quant_caracter_inferior = 0;
            arquivos_com_mesmo_nome = 0;
            textBox_diretorio.Text = "";
            textBox_quant_remover_caracteres.Text = "";
            textBox_adicionar_caracteres.Text = "";
            textBox_outro_formato.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielSvoboda");
        }
    }
}
