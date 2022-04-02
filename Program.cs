double nota1, nota2, nota3, nota4, media;
string Resultado;


Console.Write("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());

bool notas = (nota1 < 0 || nota1 > 10
            ||nota2 < 0 || nota2 > 10
            ||nota3 < 0 || nota3 > 10
            ||nota4 < 0 || nota4 > 10);

if(notas)
{   
   Console.WriteLine("Digite somente notas entre 0 e 10");
}

else 
{   
    media = nota1 + nota2 + nota3 + nota4/4;


if(media < 5)
{   
   Resultado = "Reprovado"; 
}

else if(media > 6)
{   
   Resultado = "Aprovado";
}

else

    Resultado = "Recuperação ";

Console.WriteLine($"Você ficou com média {media:n1}. Resultado {Resultado}");
}
