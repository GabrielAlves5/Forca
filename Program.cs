string letra, palavrasecreta;
Console.WriteLine ("Qual a palavra:");
palavrasecreta = Console.ReadLine().ToUpper();
Console.WriteLine ("Fala uma letra");
letra = Console.ReadLine().ToUpper();
Console.WriteLine($"Essa letra {letra} esta em {palavrasecreta}? \n{palavrasecreta.Contains(letra)}");
