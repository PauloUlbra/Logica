Console.WriteLine("Digite o nome do herói");
string heroi = Console.ReadLine();

System.Console.WriteLine("Digite a quantidade de XP do herói");
int xp = Convert.ToInt32(Console.ReadLine());

if (xp <= 1000)
{
    string classificacao = "Ferro";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
else if (xp >=1001 && xp <= 2000)
{
    string classificacao = "Bronze";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
else if (xp >=2001 && xp <= 5000)
{
    string classificacao = "Prata";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
else if (xp >=5001 && xp <= 7000)
{
    string classificacao = "Ouro";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
else if (xp >=7001 && xp <= 8000)
{
    string classificacao = "Platina";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
else if (xp >=8001 && xp <= 9000)
{
    string classificacao = "Ascendente";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
else if (xp >=9001 && xp <= 10000)
{
    string classificacao = "Imortal";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
else    
{
    string classificacao = "Radiante";
    Console.WriteLine($"O Herói de nome {heroi} está no nível de {classificacao}");
}
