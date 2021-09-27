# Renomear_Arquivos
•DOWNLOAD: https://github.com/DanielSvoboda/Renomear_Arquivos/raw/main/Renomear_Arquivos.exe
<br><br>
Programa em C# windows forms .NET Framework 4.7.2
  <img width="900" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_1.png">
  <br><br>
Com o objetivo de renomear vários arquivos de uma pasta conforme sua extensão
<br><br>
3 Funções: Remover & Adicionar & MAIÚSCULAS/minúsculas
<br><br>
  •Remover uma quantidade de caracteres no início/final do nome dos arquivos
  <br>
  Exemplo: No diretório 'C:\tmp' existem os arquivos:
  <br>
  "Daniel.pdf e Aprovação.pdf" Então removo 2 caracteres no final, ficará: <br>
  "Dani.pdf e Aprovaç.pdf"
  <br><br>
  •Adicionar um texto no início/final dos nomes dos arquivos
  <br>
  Exemplo: No diretório 'C:\tmp' existem os arquivos:
  <br>
  "Daniel.pdf e Aprovação.pdf" Então adiciono a frase:"_OK" no final, ficará: <br>
  "Daniel_OK.pdf e Aprovação_OK.pdf"
  <br><br>
  •MAIÚSCULAS/minúsculas: altera todas as letras do nome dos arquivos
  <br><br>
  
  •Sendo possível selecionar uma extensão na lista, ou escrever outra não listada com a opção +Mais.
  <br>
  <img width="200" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_0.png">
  <br>
  Se selecionar +Mais e deixar o campo em branco é possível visualizar todos os arquivos da pasta independente da extensão (CUIDADO!), ou se copiando e colando o diretório no campo, não será considerado a extensão se for a 1° vez...
  <br><br>
   Na lista da esquerda, é possível visualizar os nomes dos arquivos do diretório escolhido.
  <br>
  Ao apertar em 'REMOVER' ou 'ADICIONAR' ou 'MAIÚSCULAS/minúsculas' é possível pré-visualizar na lista da direita como vai ficar.
  <br>
  Ambas as funções só alterarão os arquivos após apertar o botão "Aplicar Mudanças" que renomeia os arquivos.
  <br><br>
  
  
  Tratativas de 'possíveis erros'
---------  

  •Se remover uma quantidade de caracteres inferior a 1, tendo o nome em branco ou negativo será informado os arquivo que não serão renomeados por esse motivo. Conforme o print abaixo:
  <br>
  <img width="900" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_2.png">
  <br><br>
  •Os arquivos com o nome final igual a outro já existe será renomeando com: _1   no final, se tiver vários o numero terá continuidade, Conforme o print abaixo, exemplo:
  <br>
  arquivoA.txt, arquivoB.txt, arquivoC.txt - removendo 1 caractere ficará:  arquivo.txt, arquivo_1.txt, arquivo_2.txt
  <img width="900" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_3.png">
  <br><br> 

  Exemplos
---------  
  •Remover uma quantidade de caracteres no início/final dos nomes dos arquivos
  <br>
  <img width="900" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_1.png">
  <br><br>
  •Adicionar um texto no início/final dos nomes dos arquivos
  <br>
  <img width="900" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_4.png">
  <br><br> 
  •MAIÚSCULAS/minúsculas: altera todas as letras do nome dos arquivos
  <br>
  <img width="900" alt="portfolio_view" src="https://raw.githubusercontent.com/DanielSvoboda/Renomear_Arquivos/main/print_5.png">
  <br><br> 
  
  Dependência 
---------  
  <br>
  •Microsoft.WindowsAPICodePack-Core https://www.nuget.org/packages/Microsoft.WindowsAPICodePack-Core/1.1.0.2
  <br>
  •Costura.Fody https://www.nuget.org/packages/Costura.Fody
