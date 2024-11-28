using System;

class Program {
  public static void Main (string[] args) {
    double salario;
    double bonus;
    const double taxa = 0.1;
    string nome;
    Double salarioFinal;
    
    Console.WriteLine ("Nome do funcionario: ");
    nome = Console.ReadLine();

    Console.WriteLine("Informe o seu salario atual: ");
    salario = double.Parse(Console.ReadLine());


    bonus = salario * taxa;
    salarioFinal = salario + bonus;

    Console.WriteLine("Salario Base: R$ " + salario);
    Console.WriteLine("Bonus de " + taxa + " : R$" + bonus);
    Console.WriteLine("Salario Final: " + salarioFinal);
  }
}