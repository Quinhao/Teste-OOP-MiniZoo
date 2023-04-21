using System;
using System.Collections.Generic;

public class MiniZoo
{
    private List<Animal> _animais;

    public MiniZoo()
    {
        _animais = new List<Animal>();
    }

    public void AdicionarAnimal(Animal animal)
    {
        _animais.Add(animal);
    }

    public void EmitirSomDeTodosOsAnimais()
    {
        foreach (var animal in _animais)
        {
            animal.EmitirSom();
        }
    }

    public void ImprimirTodosOsAnimais()
    {
        foreach (var animal in _animais)
        {
            Console.WriteLine(animal.GetType().Name);
            Console.WriteLine(animal.Idade);      
        }
    }

}
