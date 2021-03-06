using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Renomear_Arquivos
{
    public partial class Renomear_Arquivos : Form
    {
        public Renomear_Arquivos()
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

        string aux_diretorio;                                   //recebe textBox_diretorio: evitar erros...

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
            if (Directory.Exists(textBox_diretorio.Text) == false)                       
            {
                MessageBox.Show("Escolha um diretório valido!");
                return;
            }
                      
            // Limpa as variaveis
            nomes_originais = "";
            nomes_originais_lista.Clear();
            extensoes_originais_lista.Clear();

            nomes_modificados_lista.Clear();
            textBox_nomes_modificados.Text = "";

            aux_diretorio = textBox_diretorio.Text;

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

            foreach (var file in files)     // Repete ate o total de arquivo que existe na pasta, conforme a extensão
            {
                var name = file.Name.ToString();                                        //var aux com o nome
                var exten = Path.GetExtension(directory.ToString() +"/"+ file);         //var aux com a extensão

                nomes_originais += name + Environment.NewLine;                          //arquivo.txt       -apenas para usar no textbox
                
                
                if (exten != "")            
                {
                    nomes_originais_lista.Add(name.Remove(name.Length - exten.Length)); //arquivo           -array
                }
                else    // Se o arquivo não tiver extensão
                {
                    nomes_originais_lista.Add(name);                                    //arquivo           -array
                }
                
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
                textBox_nomes_originais.Text = "";              // limpa o txtBox da esquerda- originais
                textBox_nomes_modificados.Text = "";            // limpa o txtBox da direita- modificados
                label_quantidade_original.Text = "0 arquivos";  // limpa texto com a quantidade de arquivos
            }
            label_quantidade_original.Text = nomes_originais_lista.Count.ToString() + " arquivos";  // informa a quantidade de arquivos originais no canto inferior esquerdo
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

            if (Directory.Exists(textBox_diretorio.Text) == true)  //se escolher algo no comboBox e o diretorio for valido, visualizar os arquivos
            {
                nomes_arquivos();
            }
        }

        // Botao remover
        private void button_remover_Click(object sender, EventArgs e)
        {
            // se alguns dos 2 campos (REMOVER antes/depois) estiverem em branco, é preenchido com 0
            if (textBox_quant_remover_caracteres_antes.Text == "")
            {
                textBox_quant_remover_caracteres_antes.Text = "0";
            }
            if (textBox_quant_remover_caracteres_depois.Text == "")
            {
                textBox_quant_remover_caracteres_depois.Text = "0";
            }

            // Verifica se o campo textBox_quant_remover_caracteres_antes/depois é um número
            bool num_remover_antes = int.TryParse(textBox_quant_remover_caracteres_antes.Text, out _);
            bool num_remover_depois = int.TryParse(textBox_quant_remover_caracteres_depois.Text, out _);

            if (num_remover_antes == false ^ num_remover_depois == false)   // Parar se não localizar um números no 1campo ou no 2campo
            {
                MessageBox.Show("Favor, informar uma quantidade caracteres (numero)\nNos campos da area 'REMOVER CARACTERES(quantidade)'");
                return;
            }

            // É inferior a 0 ?
            if (Convert.ToInt32(textBox_quant_remover_caracteres_antes.Text) < 0  ^ Convert.ToInt32(textBox_quant_remover_caracteres_depois.Text) < 0)
            {
                MessageBox.Show("Favor, informar um número 'positivo' - acima de 0\nPara poder remover do final do nome do arquivo!");
                return;
            }

            // Valida se o diretório é valido
            if (Directory.Exists(textBox_diretorio.Text) == false)
            {
                MessageBox.Show("Escolha um diretório valido!");
                return;
            }

            nomes_arquivos();

            // Quantidade de caracteres que será removido no inicio/final do nome do arquivo
            int quant_remover_antes =  Convert.ToInt32(textBox_quant_remover_caracteres_antes.Text);
            int quant_remover_depois = Convert.ToInt32(textBox_quant_remover_caracteres_depois.Text);

            // Limpa as variaveis 
            textBox_nomes_modificados.Text = ""; 
            nomes_modificados_lista.Clear();
            nomes_nao_alterados_menores.Clear();
            quantidade_nomes_nao_alterados = 0;
            arquivos_com_mesmo_nome = 0;

            for (int i = 0; i < nomes_originais_lista.Count; i++)       // LOOP PELOS NOMES DA LISTA ORIGINAL
            {
                string nome = nomes_originais_lista[i].ToString();      // VAR AUX QUE RECEBE O NOME DO ARQUIVO

                if (nome.Length > quant_remover_antes + quant_remover_depois)    // Se o nome for maior que quantidade total de caracter a ser removido
                {
                    if (nomes_modificados_lista.Count > 0)
                    {
                        // primeiro apenas remove o começo
                        string nome_final_renomeado;
                        if (quant_remover_antes > 0)
                        {
                            nome_final_renomeado = nome.Remove(0, quant_remover_antes);
                        }
                        else        //se for 0 (quant_remover_antes), a var recebe apenas o nome inteiro
                        {
                            nome_final_renomeado = nome;
                        }

                        //função verificar se o nome final ja existe(duplicado). E faz a correção add   _1  _2  _3
                        // verificar_duplicado_1(string nome, string extencao, int contar_repeticao)
                        if (quant_remover_depois > 0)
                        {
                            nome_final_renomeado = verificar_duplicado_1(nome_final_renomeado.Remove(nome_final_renomeado.Length - quant_remover_depois), extensoes_originais_lista[i].ToString(), 0);
                        }
                        else
                        {
                            nome_final_renomeado = verificar_duplicado_1(nome_final_renomeado, extensoes_originais_lista[i].ToString(), 0);
                        }

                        nomes_modificados_lista.Add(nome_final_renomeado);
                        textBox_nomes_modificados.Text += nomes_modificados_lista[i] + Environment.NewLine;
                    }
                    else    //Primeiro da lista, só add ele sem verificar nada, desde que tenha o nome maios que 0 caracteres
                    {
                        string nome_final_renomeado2;
                        if (quant_remover_antes > 0)
                        {
                            nome_final_renomeado2 = nome.Remove(0, quant_remover_antes);
                        }
                        else
                        {
                            nome_final_renomeado2 = nome;
                        }

                        if (quant_remover_depois > 0)
                        {
                            nome_final_renomeado2 = nome_final_renomeado2.Remove(nome_final_renomeado2.Length - quant_remover_depois);
                        }

                        nomes_modificados_lista.Add(nome_final_renomeado2 + extensoes_originais_lista[i]);
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
                MessageBox.Show(arquivos_com_mesmo_nome + " arquivos ficaram com o nome idêntico a outro, e esses\nforam renomeados com uma numeração sequencial no final\nExemplo: nome nome_1 nome_2 . . .");
            }
        }

        // Função que valida se o novo nome já existe (duplicado) e adiciona _1 _2 _3 no final
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

        // verificar duplicado parte 2 
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
                else                                                            //+ de 1 verificar: nome_NUN.extensao       arquivo_1.txt
                {
                    if (nome +'_'+ contar_repeticao + extensao == nomes_modificados_lista[j].ToString())
                    {
                        return (true, nome, extensao, contar_repeticao);
                    }
                }
            }
            return (false, nome, extensao, contar_repeticao);
        }


        //verificar se algum arquivo não será renomeado por: ser menor que a quantidade de caracteres selecionado
        private void verificar_nao_modificados() 
        {
            string mensagem_dialog = string.Empty;
            if (quantidade_nomes_nao_alterados > 0)
            {              
                foreach (var nome in nomes_nao_alterados_menores)
                {
                    mensagem_dialog += nome + Environment.NewLine;
                }

                int totalQuantidadeCaracRemover = (Convert.ToInt32(textBox_quant_remover_caracteres_antes.Text) + Convert.ToInt32(textBox_quant_remover_caracteres_depois.Text));
                
                var aux1 = "Exite: 1 Arquivo!\nCom a quantidade de caracteres inferior ao selecionado(" + totalQuantidadeCaracRemover + ")" +
                    "\nSendo impossível renomear um arquivo com menos de 1 caracter." +
                    "\nEsse arquivo listado abaixo não será alterado!";

                if (quantidade_nomes_nao_alterados > 1)
                {
                    aux1 = "Existem: " + quantidade_nomes_nao_alterados + " Arquivos!\nCom a quantidade de caracteres inferior ao selecionado( " + totalQuantidadeCaracRemover + " )" +
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
            maiusculas_minusculas_add("add");
        }

        // Botão letras MAIúSCULAS
        private void button_maiusculas_Click(object sender, EventArgs e)
        {
            maiusculas_minusculas_add("maiusculas");
        }

        // Botão letras minúsculas
        private void button_minusculas_Click(object sender, EventArgs e)
        {
            maiusculas_minusculas_add("minusculas");
        }

        // Função que pode realizar as 3 opções: maiusculas / minusculas / adicionar
        public void maiusculas_minusculas_add(string opcao)
        {
            // Valida se o diretório é valido
            if (Directory.Exists(textBox_diretorio.Text) == false)
            {
                MessageBox.Show("Escolha um diretório valido!");
                return;
            }

            nomes_arquivos();

            textBox_nomes_modificados.Text = "";
            nomes_modificados_lista.Clear();

            for (int i = 0; i < nomes_originais_lista.Count; i++)       // LOOP PELOS NOMES DA LISTA ORIGINAL
            {
                string add = textBox_adicionar_caracteres_antes.Text + nomes_originais_lista[i].ToString() + textBox_adicionar_caracteres_depois.Text + extensoes_originais_lista[i].ToString();
                string maiusculas = nomes_originais_lista[i].ToString().ToUpper() + extensoes_originais_lista[i].ToString();
                string minusculas = nomes_originais_lista[i].ToString().ToLower() + extensoes_originais_lista[i].ToString();

                if (opcao == "add")
                {
                    nomes_modificados_lista.Add(add);
                }
                if (opcao == "maiusculas")
                {
                    nomes_modificados_lista.Add(maiusculas);
                }
                if (opcao == "minusculas")
                {
                    nomes_modificados_lista.Add(minusculas);
                }
                textBox_nomes_modificados.Text += nomes_modificados_lista[i] + Environment.NewLine;
            }
        }


        //BOTÃO APLICAR MUDANÇAS, RENOMEIAS OS ARQUIVOS
        private void button_aplicar_mudancas_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            if (nomes_modificados_lista.Count > 0)          // só vai prosseguir se tiver algo para ser alterado...  :)
            {
                if (aux_diretorio != textBox_diretorio.Text)
                {
                    const string mensagem = "O campo do diretório foi alterado ! ! !\nE não é o mesmo selecionado inicialmente\n\nAperte em:\nSIM - Para corrigir automaticamente e salvar os arquivos\nOU\nNÃO - E verifique manualmente o diretório correto!";
                    var result = MessageBox.Show(mensagem, "ATENÇÃO!!!",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        textBox_diretorio.Text = aux_diretorio;
                    }
                    else
                    {
                        this.Enabled = true;
                        return;
                    }
                }


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
            else
            {
                MessageBox.Show("Este botão vai renomear os arquivos,\nMas primeiro escolha umas das opções!");
            }
            this.Enabled = true;
        }


        //Botão limpar
        private void button_Limpar(object sender, EventArgs e)
        {
            textBox_nomes_originais.Text = "";
            textBox_nomes_modificados.Text = "";

            textBox_diretorio.Text = "";
            aux_diretorio = "";

            label_quantidade_original.Text = "0 arquivos";

            textBox_adicionar_caracteres_antes.Text = "";
            textBox_adicionar_caracteres_depois.Text = "";

            textBox_quant_remover_caracteres_antes.Text = "";
            textBox_quant_remover_caracteres_depois.Text = "";

            comboBox_formatos.SelectedIndex = -1;
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