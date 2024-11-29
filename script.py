import json  # Importa o módulo JSON para conversão de dados em formato JSON.

def ler_dados():
    try:
        # Abre o arquivo 'dados.txt' para leitura
        with open('dados.txt', 'r') as arquivo:
            dados = []  # Inicializa uma lista para armazenar os dados

           
            for linha in arquivo: # Percorre cada linha do arquivo
                linha = linha.strip()  # Remove espaços extras do começo e fim da linha

                if linha:  # Só processa a linha se não estiver vazia
                    # Converte a linha em um dicionário, dividindo por vírgula e depois por ": "
                    partes = dict(item.split(": ") for item in linha.split(", "))
                    dados.append(partes)  # Adiciona o dicionário à lista

            # Converte a lista de dicionários em JSON e retorna
            return json.dumps(dados, indent=4)

    except FileNotFoundError:
        return "Erro: O arquivo 'dados.txt' não foi encontrado."  # Retorna mensagem de erro se o arquivo não for encontrado
    except Exception as e:
        return f"Erro ao ler o arquivo: {str(e)}"  # Retorna mensagem de erro  em caso de outros erros

# Chama a função e imprime o resultado
if __name__ == "__main__":
    print(ler_dados())
