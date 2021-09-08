# Renomear_Arquivos
•DOWNLOAD: https://github.com/DanielSvoboda/Renomear_Arquivos/raw/main/Renomear_Arquivos.exe
<br><br>
  <img width="800" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_1.png">
  <br><br>
Programa em C# windows forms .NET Framework 4.7.2
<br><br>
Com o objetivo de renomear vários arquivos de uma pasta conforme sua extensão:
<br><br>
  •Removendo uma quantidade de caracteres no final do nome dos arquivos
  <br>
  Exemplo: No diretório 'C:\tmp' existe os arquivos:
  <br>
  "Daniel.pdf e Aprovação.pdf" então removo 2 caracteres ficará: "Dani.pdf e Aprovaç.pdf"
  <br><br>
  •Adicionar um texto no final dos nome dos arquivos
  <br>
  Exemplo: No diretório 'C:\tmp' existe o arquivo Daniel.pdf
  <br>
  Então adiciono a frase:'_OK' ficando Daniel_OK.pdf
  <br><br>
  •Sendo possível selecionar uma extensão na lista, ou escrever outra não listada com a opção +Mais.
  <br>
  <img width="150" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_0.png">
  <br>
  Se seleciona +Mais e deixar o campo em branco é possível visualizar todos as arquivos da pasta independente da extensão(CUIDADO!)
  <br><br>
  Ambas as funções se aplicação a todos os arquivos, renomeando todos apenas apos apertar o botão "Aplicar Mudanças".
  <br>
  Na lista da esquerda, é possível visualizar os nomes dos arquivos do diretório escolhido.
  <br>
  Ao apertar em 'REMOVER' ou 'ADICIONAR' é possível pré-visualizar na lista da direita como vai ficar.
  <br><br>
  •Se remover uma quantidade de caracteres inferior a 1, tendo o nome em branco ou negativo será informado os arquivo que não serão renomeados por esse motivo. Conforme o print abaixo:
  <br>
  <img width="800" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_2.png">
  <br><br>
  •Os arquivos com o nome final igual a outro já existe será renomeando com: _1   no final, se tiver varios o numero terá continuidade, Conforme o print abaixo, exemplo:
  <br>
  arquivoA.pdf, arquivoB.pdf, arquivoC.pdf - removendo 1 caractere ficará:  arquivo.pdf, arquivo_1.pdf, arquivo_2.pdf
  <img width="800" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_3.png">
  <br><br> 
  •No exemplo abaixo,é possivel adicionando um texto ao final do nome dos arquivos:
  <br>
  <img width="800" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_4.png">
  <br><br> 
  
  Dependência 
---------  
  <br>
  •Microsoft.WindowsAPICodePack-Core https://www.nuget.org/packages/Microsoft.WindowsAPICodePack-Core/1.1.0.2?_src=template
  <br>
  •Costura.Fody https://www.nuget.org/packages/Costura.Fody
<br><br><br>
  
