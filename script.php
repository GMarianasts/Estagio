<?php
// Verifica se o método de requisição é POST
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Coleta os dados do formulário dos campos 'nome', 'email' e 'mensagem'
    $nome = $_POST['nome'];
    $email = $_POST['email'];
    $mensagem = $_POST['mensagem'];

    // Verifica se os campos não estão vazios
    if (!empty($nome) && !empty($email) && !empty($mensagem)) {
        // Se todos os campos foram preenchidos, cria uma string com os dados salvos
        $dados = "Nome: $nome, Email: $email, Mensagem: $mensagem\n";  // Formato de linha a ser salvo no arquivo
        
        // Salva no arquivo "dados.txt"
        file_put_contents("dados.txt", $dados, FILE_APPEND); // Escreve no arquivo "dados.txt" (adiciona o novo dado no final)

        // Exibe uma mensagem de sucesso dizendo que a mensagem foi enviada corretamente
        echo "<p>Mensagem enviada com sucesso!</p>"; // Exibe na tela falando que a mensagem foi enviada com sucesso
    } else {
         // Caso algum dos campos não esteja preenchido, exibe uma mensagem de erro
        echo "<p>Erro: Por favor, preencha todos os campos.</p>"; // Informa ao usuário que os campos não estão completos
    }
} else {
     // Caso o formulário não seja enviado corretamente exibe uma mensagem de erro
    echo "<p>Erro: Formulário não foi enviado corretamente.</p>";
}
?>
