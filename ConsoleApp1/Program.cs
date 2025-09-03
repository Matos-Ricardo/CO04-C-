using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static async Task Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("=== Processador de Arquivos TXT ===\n");

        Console.Write("Digite o caminho da pasta: ");
        string? pasta = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(pasta) || !Directory.Exists(pasta))
        {
            Console.WriteLine("Diretório inválido.");
            return;
        }

        // Buscar arquivos .txt
        string[] arquivos = Directory.GetFiles(pasta, "*.txt", SearchOption.TopDirectoryOnly);

        if (arquivos.Length == 0)
        {
            Console.WriteLine("Nenhum arquivo .txt encontrado.");
            return;
        }

        Console.WriteLine("\nArquivos encontrados:");
        foreach (var arquivo in arquivos)
        {
            Console.WriteLine($"- {Path.GetFileName(arquivo)}");
        }

        Console.WriteLine("\nIniciando processamento...\n");

        // Processamento assíncrono paralelo
        var resultados = await Task.WhenAll(arquivos.Select(ProcessarArquivoAsync));

        // Criar pasta export
        string pastaExport = Path.Combine(AppContext.BaseDirectory, "export");
        Directory.CreateDirectory(pastaExport);

        string caminhoRelatorio = Path.Combine(pastaExport, "relatorio.txt");

        // Salvar relatório
        await File.WriteAllLinesAsync(caminhoRelatorio, resultados);

        Console.WriteLine($"\nProcessamento concluído! Relatório gerado em: {caminhoRelatorio}");
    }

    static async Task<string> ProcessarArquivoAsync(string caminho)
    {
        string nomeArquivo = Path.GetFileName(caminho);
        Console.WriteLine($"Processando arquivo {nomeArquivo}...");

        string[] linhas = await File.ReadAllLinesAsync(caminho);

        int qtdLinhas = linhas.Length;
        int qtdPalavras = linhas.Sum(l => l.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);

        string resultado = $"{nomeArquivo} - {qtdLinhas} linhas - {qtdPalavras} palavras";
        Console.WriteLine($"Finalizado: {resultado}");

        return resultado;
    }
}
