using Atividade4.Services;

while (true)
{
    Console.WriteLine("Favor escolher uma senha:");
    var senha = Console.ReadLine();
    var erros = new List<string>();

    // Implementar métodos estáticos abaixo na classe SenhaService.
    // Se um requisito não for cumprido na senha, adicionar uma mensagem de erro em "erros"
    // explicando o que está errado

    // A senha deve conter:
    // - no minimo 8 caracteres
    // - no maximo 16 caracteres
    // - no minimo 1 caractere maiúsculo
    // - no minimo 1 caractere minúsculo
    // - no minimo 1 caractere numérico
    // - no minimo 1 caractere especial

    SenhaService.ValidarComprimento(senha, erros);
    SenhaService.ValidarMaiusculoMinusculo(senha, erros);
    SenhaService.ValidarCaractereNumerico(senha, erros);
    SenhaService.ValidarCaractereEspecial(senha, erros);

    if (true)   //substituir true pela validação de se há algum erro
    {
        // apresentar ao usuário o que estava errado com a senha
        continue;
    }

    Console.WriteLine("Parabéns, senha aceita!");
    break;
}