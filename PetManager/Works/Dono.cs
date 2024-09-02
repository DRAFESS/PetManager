using System.Security.Cryptography.X509Certificates;

namespace PetManager.Works;

internal class Dono
{
    public List<Dono> DonoLista = new List<Dono>();
    public string Nome { get; set; }
    public int Telefone { get; set; }
    public string Email { get; set; }
    public int Cpf { get; set; }


    public Dono(string nome, int telefone , string email, int cpf)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Cpf = cpf;

    }

    public void RegistroDono()
    {
        Console.WriteLine("\nO cadastro do seu Pet foi realizado com sucesso, iremos prosseguir para o seu cadastro como responsavel");
        Console.Write("Por favor, nos informe seu nome : ");
        string nome = Console.ReadLine()!;
        Console.Write($"Ótimo {nome}, por favor, nos informe seu número de contato : ");
        int telefone = int.Parse( Console.ReadLine()!);
        Console.Write("Nos informe o seu e-mail de contato : ");
        string email = Console.ReadLine()!;
        Console.Write($"Perfeito {nome}, finalizando, nos informe o seu Cpf : ");
        int cpf = int.Parse( Console.ReadLine()!);

        DonoLista.Add(new Dono(nome, telefone, email, cpf));

        Console.WriteLine($"\nSegue a validação de dados registrados : Nome - {nome} | Telefone - {telefone} | Email - {email} | Cpf - {cpf} ");
        Console.WriteLine("Aguarde o nosso contato para o agendamento da consulta\n");
    }

}