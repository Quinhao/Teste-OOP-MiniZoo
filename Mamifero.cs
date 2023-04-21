public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    public override void EmitirSom(){
        Console.WriteLine("Rawr"); 
    }
}
