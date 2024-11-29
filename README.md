# Estagio

Como rodar cada parte:
 - HTML, CSS e Javascript: foi codado no aplicativo Visual Studio Code. Para o código rodar ele deve ser salvo em um arquivo .html. O arquivo HTML pode ser aberto diretamente no navegador(Google Chrome, etc).
 - PHP: Deve-se usar um servidor web com suporte a PHP, nesse código foi usado o XAMPP, para rodar o script. Inicie o Apache, no caso de usar XAMPP, para rodar o servidor PHP. Crie um arquivo no diretório do XAMPP ou um diretório no seu servidor web. Através do navegador, acesse o fomulário HTML e envie os dados. O PHP será executado no servidor, e os dados serão gravados em um arquivo de texto.
 - Python: Salve o código em um arquivo. Execute o script Python no terminal com o comando python script.py. O código irá processar o arquivo dados.txt e gerar um JSON e exibi-lo no console.
 - C#: Salve o código em um arquivo que suporte C#. O aplicativo usado foi o Visual Studio Code. Tenha o arquivo gerado pelo script Python e Compile e execute on código, o C# irá carregar o JSON e exibir as informações no console.

O que fo feito em cada parte do código:
 - HTML, CC, avaScript: Foi feito um formulário de contato em HTMl com campos para Nome, E-mail e Mensagem. O JavaScript valida se todos os campos são preenchidos corretamente antes do envio (nome com pelo menos três caracteres, e-mail válido, e mensagem com pelo menos dez caracteres). Se a validação ocorrer bem, um alerta é mostrado na tela mostrando os dados inseridos.
 - PHP: Quando o formulário é enviado , o PHP coleta os dados e verifica se todos os campos estão preenchidos. Se ele estiverem preenchidos corretamente, os dados são armazenados em um arquivo de texto(dados.txt). Caso contrário, uma mensagem de erro é exibida.
 - Python: O código Python lê o arquivo de texto gerado pelo PHP e conveete on conteúdo em formato JSON. Cada linha do arquivo de texto é assumida como uma mensagem, conm os dados (nome, e-mail e mensagem) extraídos e convcertidos para um objeto JSON e então, o conteúdo JSON é exibido no console.
 - C#: O código C# lê o arquivo JSON gerado pelo Python e desserializa o conteúdo em objetos(torna possível ser manipulado), no final, ele conta o númeron total de mensagens e exibe os nomes de quem enviou as mensagens.
