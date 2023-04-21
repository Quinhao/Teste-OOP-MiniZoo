class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();
        Animal leao = new Leao("Leão", 10, 10);
        Animal cobra = new Cobra("Cobra", 10, 10);
        miniZoo.AdicionarAnimal(leao);
        miniZoo.AdicionarAnimal(cobra);
        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();
    }




}
