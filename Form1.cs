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

        ArrayList nomes_originais_lista = new ArrayList();       //lista com nomes originais
        ArrayList extensoes_originais_lista = new ArrayList();   //lista extensoes originais
        ArrayList nomes_modificados_lista = new ArrayList();     //nome final 

        ArrayList nomes_nao_alterados_menores = new ArrayList(); //nome dos arquivos que não seram alterados por ter a quantidade de caracteres inferior a quantidade solicitada que será removida. 
        int quantidade_nomes_nao_alterados = 0;

        int arquivos_com_mesmo_nome = 0;


        //Escolher diretório com: WindowsAPICodePack
        private void button_diretorio_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox_diretorio.Text = dialog.FileName;
            }

            // Se escolher um diretório e não selecionar uma extensão, define o formato como: .PDF
            if (comboBox_formatos.SelectedIndex == -1)      
            {
                comboBox_formatos.SelectedIndex = comboBox_formatos.FindStringExact(".PDF");    //ao selecionar o combobox, já executa o nomes_arquivos();
            }
            else
            {
                nomes_arquivos();
            }
        }


        public void nomes_arquivos()        //Função que busca e armazena os nomes dos arquivos
        {
            // Valida se o diretório é valido
            if (Path.IsPathRooted(textBox_diretorio.Text) == false)                       
            {
                MessageBox.Show("Escolha um diretório valido!");
                return;
            }
                      
            // Limpa as variaveis
            nomes_originais = "";
            nomes_originais_lista.Clear();
            extensoes_originais_lista.Clear();
            nomes_modificados_lista.Clear();

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

            foreach (var file in files)     //Repete ate o total de arquivo que existe na pasta, conforme a extensão
            {
                var name = file.Name.ToString();                                        //var aux com o nome
                var exten = Path.GetExtension(directory.ToString() +"/"+ file);         //var aux com a extensão

                nomes_originais += name + Environment.NewLine;                          //arquivo.txt       -apenas para usar no textbox
                nomes_originais_lista.Add(name.Remove(name.Length - exten.Length));     //arquivo           -array
                extensoes_originais_lista.Add(exten);                                   //.txt              -array
            }

            if (nomes_originais != "")  //Se localizar algo add
            {
                nomes_originais = nomes_originais.Remove(nomes_originais.Length - 1);   //Remove o ultimos em branco...
                textBox_nomes_originais.Text = nomes_originais;
            }
            else                        //Se não localizar arquivos, informar:
            {
                if (comboBox_formatos.SelectedIndex == 12)
                {
                    MessageBox.Show("No local selecionado não contem arquivos com a extensão:  " + textBox_outro_formato.Text);
                }
                else
                {
                    MessageBox.Show("No local selecionado não contem arquivos com a extensão:  " + comboBox_formatos.Text);
                }
                textBox_nomes_originais.Text = ""; // limpa o txtBox
            }
        }

        // BOTÃO ATUALIZAR- nomes dos arquivos no diretório
        private void button_atualizar_Click(object sender, EventArgs e)
        {
            nomes_arquivos();
        }

        //Ao escolher algo no comboBox        
        private void comboBox_formatos_SelectedIndexChanged_1(object sender, EventArgs e)
        {   //Habilita/Desabilita o textBox(extensão) e o botão de atualizar, se selecionar +MAIS no comboBox
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

            if (Path.IsPathRooted(textBox_diretorio.Text) == true)  //se escolher algo no comboBox e o diretorio for valido, visualizar os arquivos
            {
                nomes_arquivos();
            }
        }

        // Botao remover
        private void button1_Click(object sender, EventArgs e)
        {

            // Verifica se o campo textBox_quant_remover_caracteres é um numero e é acima de 0
            bool isNumber = int.TryParse(textBox_quant_remover_caracteres.Text, out _);
            if (isNumber == false || Convert.ToInt32(textBox_quant_remover_caracteres.Text) <= 0)
            {
                MessageBox.Show("Favor, informar uma quantidade caracteres acima de 0\nPara poder remover do final do nome do arquivo!");
                return;
            }
            nomes_arquivos();

            // Quantidade de caracteres que será removido no final do nome do arquivo
            int quant_remover = Convert.ToInt32(textBox_quant_remover_caracteres.Text);

            // Limpa as variaveis 
            textBox_nomes_modificados.Text = ""; 
            nomes_modificados_lista.Clear();
            nomes_nao_alterados_menores.Clear();
            quantidade_nomes_nao_alterados = 0;
            arquivos_com_mesmo_nome = 0;

            for (int i = 0; i < nomes_originais_lista.Count; i++)       // LOOP PELOS NOMES DA LISTA ORIGINAL
            {
                string nome = nomes_originais_lista[i].ToString();      // VAR AUX QUE RECEBE O NOME DO ARQUIVO

                if (nome.Length > quant_remover)    // Se o nome for maior que quantidade caracter a ser removido
                {
                    if (nomes_modificados_lista.Count > 0)
                    {
                            //função verificar se o nome final ja existe(duplicado). E faz a correção add   _1   _2   _3
                        var nome_final_renomeado = verificar_duplicado_1(nome.Remove(nome.Length - quant_remover), extensoes_originais_lista[i].ToString(), 0); // verificar_duplicado_1(string nome, string extencao, int contar_repeticao)

                        nomes_modificados_lista.Add(nome_final_renomeado);
                        textBox_nomes_modificados.Text += nomes_modificados_lista[i] + Environment.NewLine; 
                    }
                    else    //Primeiro da lista, só add ele sem verificar nada, desde que tenha o nome maios que 0 caracteres
                    {
                        nomes_modificados_lista.Add(nome.Remove(nome.Length - quant_remover) + extensoes_originais_lista[i]);
                        textBox_nomes_modificados.Text += nomes_modificados_lista[i] + Environment.NewLine;
                    }
                }
                else    //Se a quantidade de caracteres que será removido for maior que o proprio nome do arquivo
                {
                    quantidade_nomes_nao_alterados += 1;
                    nomes_nao_alterados_menores.Add(nomes_originais_lista[i].ToString() + extensoes_originais_lista[i].ToString());
                    nomes_modificados_lista.Add(nomes_originais_lista[i].ToString() + extensoes_originais_lista[i].ToString()); // O NOME FINAL VAI SER O MESMO, NAO ALTERAR. Menssagem posteriormente avisando
                }
            }

            //verificar se algum arquivo não será renomeado por: ser menor que a quantidade de caracteres selecionado
            verificar_nao_modificados();

            if (arquivos_com_mesmo_nome == 1)
            {
                MessageBox.Show("1 arquivo ficou com o nome idêntico a outro,\ne esse foi renomeado no final com:     _1");
            }
            if (arquivos_com_mesmo_nome > 1)
            {
                MessageBox.Show(arquivos_com_mesmo_nome + " arquivos ficaram o nome idêntico a outro, e esses\nforam renomeados com uma numeração sequencial no final\nExemplo: ABC_1 ABC_2 ABC_3 . . .");
            }
        }


        private string verificar_duplicado_1(string nome, string extensao, int contar_repeticao)
        {
            var resultado = verificar_duplicado_2(nome, extensao, contar_repeticao);
            string novo_nome = resultado.nome;
            string nova_extensao = resultado.extensao;
            int novo_contar = resultado.contar_repeticao;

            while (resultado.boleano == true)        //se já existir um nome igual +1 contar
            {
                arquivos_com_mesmo_nome += 1;

                resultado = verificar_duplicado_2(novo_nome, nova_extensao, novo_contar+1);
                novo_nome = resultado.nome;
                nova_extensao = resultado.extensao;
                novo_contar = resultado.contar_repeticao;
            }
            if (novo_contar == 0)
            {
                return nome + extensao;
            }
            else
            {
                return nome + "_" + novo_contar + extensao;
            }
        }

        private (bool boleano, string nome, string extensao, int contar_repeticao) verificar_duplicado_2(string nome, string extensao, int contar_repeticao)
        {
            for (int j = 0; j < nomes_modificados_lista.Count; j++)
            {
                if (contar_repeticao == 0)
                {
                    if (nome+extensao == nomes_modificados_lista[j].ToString()) //1° vez verificar: nome.extensao           arquivo.txt
                    {
                        return (true,nome, extensao, contar_repeticao);
                    }     
                }
                else                                                            //+ de 1 verificar: nome_nun.extensao       arquivo_1.txt
                {
                    if (nome +'_'+ contar_repeticao + extensao == nomes_modificados_lista[j].ToString())
                    {
                        return (true, nome, extensao, contar_repeticao);
                    }
                }
            }
            return (false, nome, extensao, contar_repeticao);
        }


        private void verificar_nao_modificados() //Verificar se a quantidade de caractes não ficará negativa ou =0
        {
            string mensagem_dialog = string.Empty;
            if (quantidade_nomes_nao_alterados > 0)
            {              
                foreach (var nome in nomes_nao_alterados_menores)
                {
                    mensagem_dialog += nome + Environment.NewLine;
                }

                var aux1 = "Exite: 1 Arquivo!\nCom a quantidade de caracteres inferior ao selecionado(" + textBox_quant_remover_caracteres.Text + ")" +
                    "\nSendo impossível renomear um arquivo com menos de 1 caracter." +
                    "\nEsse arquivo listado abaixo não será alterado!";

                if (quantidade_nomes_nao_alterados > 1)
                {
                    aux1 = "Existem: " + quantidade_nomes_nao_alterados + " Arquivos!\nCom a quantidade de caracteres inferior ao selecionado( " + textBox_quant_remover_caracteres.Text + " )" +
                    "\nSendo impossível renomear um arquivo com menos de 1 caracter." +
                    "\nEsses arquivos listados abaixo não serão alterados!";
                }

                var dialogTipo = typeof(Form).Assembly.GetType("System.Windows.Forms.PropertyGridInternal.GridErrorDlg");

                // Instancia o dialog
                var dialog = (Form)Activator.CreateInstance(dialogTipo, new PropertyGrid());

                // Preenche o dialog 
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
            nomes_modificados_lista.Clear();

            for (int i = 0; i < nomes_originais_lista.Count; i++)       // LOOP PELOS NOMES DA LISTA ORIGINAL
            {
                string nome = nomes_originais_lista[i].ToString() + textBox_adicionar_caracteres.Text + extensoes_originais_lista[i].ToString();

                nomes_modificados_lista.Add(nome);
                textBox_nomes_modificados.Text += nomes_modificados_lista[i] + Environment.NewLine;
            }
        }


        //BOTÃO APLICAR MUDANÇAS, RENOMEIAS OS ARQUIVOS
        private void button_aplicar_mudancas_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < nomes_originais_lista.Count; i++)
            {
                if (!File.Exists(textBox_diretorio.Text + "\\" + nomes_modificados_lista[i]))
                {
                    File.Move(textBox_diretorio.Text + "\\" + nomes_originais_lista[i] + extensoes_originais_lista[i], textBox_diretorio.Text + "\\" + nomes_modificados_lista[i]);
                }
            }

            if (nomes_modificados_lista.Count == 1)
            {
                MessageBox.Show("1 Arquivo foi renomeado no diretório:\n" + textBox_diretorio.Text);
            }
            if (nomes_modificados_lista.Count > 1)
            {
                MessageBox.Show(nomes_modificados_lista.Count - quantidade_nomes_nao_alterados +
                    " Arquivos foram renomeados no diretório:\n" + textBox_diretorio.Text);
            }
        }


        //Botão limpar
        private void button_Limpar(object sender, EventArgs e)
        {
            textBox_nomes_originais.Text = "";
            textBox_nomes_modificados.Text = "";

            textBox_diretorio.Text = "";

            textBox_quant_remover_caracteres.Text = "";
            textBox_adicionar_caracteres.Text = "";
            textBox_outro_formato.Text = "";

            nomes_modificados_lista.Clear();
            nomes_nao_alterados_menores.Clear();
            quantidade_nomes_nao_alterados = 0;
            arquivos_com_mesmo_nome = 0;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielSvoboda");
        }
    }
}