namespace PetManager.Works;

internal class Medico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }
    public string CRM { get; set; } 

    public Medico(string nome, string especialidade, string crm)
    {
        Nome = nome;
        Especialidade = especialidade;
        CRM = crm;
    }
}

internal class SistemaMedico
{
    private List<Medico> medicos = new List<Medico>();

    public SistemaMedico()
    {
        medicos.Add(new Medico("Dr. João Silva", "Clínica e Laboratorial", "123456"));
        medicos.Add(new Medico("Dra. Maria Oliveira", "Clínica e Laboratorial", "654321"));
        medicos.Add(new Medico("Dr. Carlos Pereira", "Clínica e Laboratorial", "112233"));
    }

    public Medico SelecionarMedicoAleatorio()
    {
        Random rand = new Random();
        int index = rand.Next(medicos.Count); 
        return medicos[index];
    }
}
