using System; // Para usar classes fundamentais de manipulação de entradas/saídas
using System.Collections.Generic; // Para usar coleções
using System.IO; // Para realizar operações de entrada/saída de arquivo (como ler arquivos)
using Newtonsoft.Json; // Biblioteca para trabalhar com JSON em C#

class Program
{
    // Define a classe 'Mensagem' para armazenar os dados das mensagens
    public class Mensagem
    {
        public string Nome { get; set; } // Armazena o nome do remetente
        public string Email { get; set; } // Armazena o e-mail do remetente
        public string MensagemTexto { get; set; } // Armazena o texto da mensagem
    }

    static void Main(string[] args)
    {
        // Define o caminho do arquivo JSON que contém as mensagens
        string caminhoJson = "dados.json";

         // Verifica se o arquivo existe no sistema
        if (File.Exists(caminhoJson))
        {
              // Se o arquivo existir, lê todo o conteúdo do arquivo JSON e armazena em 'jsonConteudo'
            string jsonConteudo = File.ReadAllText(caminhoJson);

            // Desserializa(transforma uma string que está no formato JSON de volta para um objeto que possa ser manipulado) o conteúdo do JSON para uma lista de objetos 'Mensagem'
            var mensagens = JsonConvert.DeserializeObject<List<Mensagem>>(jsonConteudo);

            // Exibe o total de mensagens lidas do arquivo
            Console.WriteLine($"Total de mensagens enviadas: {mensagens.Count}");
             // Exibe uma mensagem indicando a lista de nomes de quem enviaram mensagens
            Console.WriteLine("Lista de nomes que enviaram mensagens:");

            // Percorre sobre cada linha de mensagem da lista e exibe o nome do remetente
            foreach (var mensagem in mensagens)
            {
                // Exibe o nome do remetente no console
                Console.WriteLine($"- {mensagem.Nome}");
            }
        }
        else
        {
            // Se o arquivo não existir, exibe uma mensagem de erro
            Console.WriteLine("Erro: O arquivo JSON não foi encontrado.");
        }
    }
}
