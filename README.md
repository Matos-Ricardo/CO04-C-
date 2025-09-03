# CO04-C-

Processador de Arquivos TXTEste é um pequeno projeto em C# desenvolvido para processar arquivos de texto (.txt) em uma pasta especificada. O programa conta o número de linhas e palavras em cada arquivo e gera um relatório final.FuncionalidadesBusca de Arquivos: Localiza todos os arquivos com a extensão .txt em um diretório fornecido.Processamento Assíncrono: Processa múltiplos arquivos de forma paralela e assíncrona, otimizando o tempo de execução.Geração de Relatório: Cria um arquivo de relatório chamado relatorio.txt na pasta export, contendo o nome do arquivo, a contagem de linhas e a contagem de palavras para cada arquivo processado.Como UsarCompile o código-fonte usando um compilador C# compatível (por exemplo, .NET SDK).Execute o programa a partir do terminal.O programa solicitará o caminho da pasta que contém os arquivos .txt.Digite o caminho completo da pasta e pressione Enter.O programa listará os arquivos encontrados, processará cada um deles e, ao final, informará onde o arquivo de relatório foi salvo.Exemplo de Saída=== Processador de Arquivos TXT ===

Digite o caminho da pasta: C:\Users\usuario\Documentos\meus-arquivos

Arquivos encontrados:
- arquivo1.txt
- documento2.txt

Iniciando processamento...

Processando arquivo arquivo1.txt...
Finalizado: arquivo1.txt - 15 linhas - 120 palavras
Processando arquivo documento2.txt...
Finalizado: documento2.txt - 50 linhas - 350 palavras

Processamento concluído! Relatório gerado em: C:\caminho\do\projeto\export\relatorio.txt
Observação: A pasta export é criada automaticamente no mesmo diretório do executável.
