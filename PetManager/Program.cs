//Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

using PetManager.Works;

Console.WriteLine("       \\`*-.                    \r\n        )  _`-.                 \r\n       .  : `. .                \r\n       : _   '  \\               \r\n       ; *` _.   `*-._          \r\n       `-.-'          `-.       \r\n         ;       `       `.     \r\n         :.       .        \\    \r\n         . \\  .   :   .-'   .   \r\n         '  `+.;  ;  '      :   \r\n         :  '  |    ;       ;-. \r\n         ; '   : :`-:     _.`* ;\r\n     .*' /  .*' ; .*`- +'  `*'  \r\n      `*-*   `*-*  `*-*'        ");
static void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

static void MenuPrincipal()
{
    ExibirTituloDaOpcao("SEJA BEM-VINDO AO TERMINAL DO PETMANAGER, OS MELHORES CUIDADOS PARA O SEU MELHOR AMIGO");
    Console.WriteLine("Por favor, selecione uma das opções abaixo\n");
    Console.WriteLine("Digite 1 para registrar o seu pet para uma consulta");
    Console.WriteLine("Digite 2 para exibir detalhes de uma consulta futura");
    Console.WriteLine("Digite 3 para validar os diagnósticos passados pelo médico (caso já tenha realizado uma consulta)");
    Console.WriteLine("Digite 4 para sair");
    Console.Write("\nDigite sua opção escolhida : ");
    string opcaoMenu = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcaoMenu);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarPet();
            break;


        case 2:
            ExibirConsultaPorId();
            break;

        case 3:
            consultaExibicao();
            break;

        case 4:
            Console.WriteLine("Digite qualquer tecla para encerrar o programa");
            Console.ReadKey();
            Console.Clear();
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            MenuPrincipal();
            break;
    }

}

static void futuraConsulta()
{
    Consulta consulta = new Consulta(0, new Pet("", "", "", "", ""), new Dono("", 0, "", 0), DateTime.Now, "", "");
    consulta.FuturaConsulta();
}
static void RegistrarPet()
{
    Pet pet = new Pet("", "", "", "", ""); 
    pet.RegistroDePet();
    AgendarConsulta(pet);

    MenuPrincipal();
    
}

static void AgendarConsulta(Pet pet)
{
    Dono dono = new Dono("", 0, "", 0); 
    DateTime dataConsulta = DateTime.Now.AddDays(7);
    int novoId = Consulta.GerarNovoId();
    Consulta consulta = new Consulta(1, pet, dono, dataConsulta, "Diagnóstico pendente", "Tratamento pendente");
    consulta.ExibirDetalhesConsulta();
    Consulta.AdicionarConsulta(consulta);
}


static void ExibirConsultaPorId() // Mudança: nova função para exibir consulta por ID
{
    Console.Write("Digite o ID da consulta que deseja visualizar: ");
    int id = int.Parse(Console.ReadLine()!);
    Consulta consulta = Consulta.BuscarConsultaPorId(id);

    if (consulta != null)
    {
        consulta.ExibirDetalhesConsulta();
    }
    else
    {
        Console.WriteLine("Consulta não encontrada.");
    }

    MenuPrincipal();
}

static void consultaExibicao()
{
    //exemplo para Pet e Dono
    Pet petExemplo = new Pet("Cachorro", "Rex", "Cachorro de porte médio", "s", "Alergia a grama");
    Dono donoExemplo = new Dono("Carlos Silva", 123456789, "carlos.silva@email.com", 1234567890);

    //consulta com valores fictícia
    Consulta consulta = new Consulta(
        id: 1,
        pet: petExemplo,
        dono: donoExemplo,
        dataConsulta: DateTime.Now,
        diagnostico: "Alergia leve",
        tratamentoRecomendado: "Medicamento anti-histamínico"
    );

    consulta.ExibirDetalhesConsulta();

    MenuPrincipal();

}

MenuPrincipal();

 