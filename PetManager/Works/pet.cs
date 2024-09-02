using System;
using System.Globalization;

namespace PetManager.Works;
internal class Pet
{
    public List<Pet> pets = new List<Pet>();
    public List<string> alertas = new List<string>();

    public string Animal { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Alerta { get; set; }
    public string AlertaDesc { get; set; }

    public Pet(string animal, string nome, string descricao, string alerta, string alertaDesc)
    {
        Animal = animal;
        Nome = nome;
        Descricao = descricao;
        Alerta = alerta;
        AlertaDesc = alertaDesc;

    }


    public void RegistroDePet()
    { 
      Console.WriteLine("\nQue ótimo que você decidiu contar conosco para cuidarmos do seu amiguinho");
      Console.Write("Por favor nos informe o nome do seu pet : ");
      string nome = Console.ReadLine()!;
      Console.Write($"Infome qual animal o/a {nome} é : ");
      string animal = Console.ReadLine()!;
      Console.Write($"O/A {nome} possui alguma deficiência ou alergia ? (Digite s/n): ");
      string alerta = Console.ReadLine()!;

      string alertaDesc = string.Empty;

        if (alerta.ToLower() == "s")
        {
            Console.Write($"Por favor, nos informe caso {nome} possua algum tipo de deficiência ou alergia: ");
            alertaDesc = Console.ReadLine()!;
            alertas.Add(alertaDesc);
            Console.Write($"Ótimo, agora poderia nos informar oque ocorre com o/a {nome} ? : ");
            string descricao = Console.ReadLine()!;
            pets.Add(new Pet(animal, nome, descricao, alerta, alertaDesc));

        }
        else if (alerta.ToLower() == "n")
        {
            Console.Write($"Ótimo, agora poderia nos informar oque ocorre com o/a {nome} ? : ");
            string descricao = Console.ReadLine()!;
            pets.Add(new Pet(animal, nome, descricao, alerta, alertaDesc));

        }
        RegistrarDono();


        static void RegistrarDono()
        {
            Dono dono = new Dono("", 0 , "", 0 );
            dono.RegistroDono();

        }
    }
    

}