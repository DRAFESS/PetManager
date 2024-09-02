namespace PetManager.Works;


internal class Consulta
{
    private static int ProximoId = 1;

    private static List<Consulta> consultaList = new List<Consulta>();
    public int Id { get; set; }
    public Pet Pet { get; set; }
    public Dono Dono { get; set; }
    public DateTime DataConsulta { get; set; }
    public string Diagnostico { get; set; }
    public string TratamentoRecomendado { get; set; }

    public Consulta(int id, Pet pet, Dono dono, DateTime dataConsulta, string diagnostico, string tratamentoRecomendado)
    {
        Id = id;
        Pet = pet;
        Dono = dono;
        DataConsulta = GerarDataAleatoria(); ;
        Diagnostico = diagnostico;
        TratamentoRecomendado = tratamentoRecomendado;
    }

    private DateTime GerarDataAleatoria()
    {
        Random random = new Random();
        DateTime hoje = DateTime.Today;
        int diasAtras = random.Next(0, 365);
        return hoje.AddDays(-diasAtras);
    }

    public static int GerarNovoId()
    {
        return ProximoId++;
    }

    public static void AdicionarConsulta(Consulta consulta)
    {
        consultaList.Add(consulta);
    }

    public static Consulta BuscarConsultaPorId(int id)
    {
        return consultaList.FirstOrDefault(c => c.Id == id);
    }

    public void ExibirDetalhesConsulta()
    {
        Console.WriteLine($"Consulta ID: {Id}");
        Console.WriteLine($"Pet: {Pet.Nome} ({Pet.Animal})");
        Console.WriteLine($"Dono: {Dono.Nome}");
        Console.WriteLine($"Data da Consulta: {DataConsulta.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Diagnóstico: {Diagnostico}");
        Console.WriteLine($"Tratamento Recomendado: {TratamentoRecomendado}");
        SistemaMedico sistemaMedico = new SistemaMedico();
        Medico medicoAleatorio = sistemaMedico.SelecionarMedicoAleatorio();

        Console.WriteLine("Médico selecionado para a consulta:");
        Console.WriteLine($"Nome: {medicoAleatorio.Nome}");
        Console.WriteLine($"Especialidade: {medicoAleatorio.Especialidade}");
        Console.WriteLine($"CRM: {medicoAleatorio.CRM}");
    }

    public void FuturaConsulta()
    {
        Console.Write("Digite o Id da sua consulta: ");
        int Idescolhido = int.Parse(Console.ReadLine()!);

        Consulta consultaEscolhida = consultaList.FirstOrDefault(c => c.Id == Idescolhido);

        if (consultaEscolhida != null)
        {
            consultaEscolhida.ExibirDetalhesConsulta();
        }
        else
        {
            Console.WriteLine("Consulta não encontrada.");
        }
    }
}