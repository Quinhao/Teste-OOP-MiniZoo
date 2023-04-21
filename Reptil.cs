public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade){}

    public override void EmitirSom(){
        Console.WriteLine("Psss");
    }
}