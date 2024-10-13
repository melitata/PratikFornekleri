
//SORU1
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini yaparım");
}
//SORU2
for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{i}");
}

//soru3
for (int i = 0; i < 20; i += 2)
{
    Console.WriteLine($"{i}");
}

//SORU4
double toplam = 0;
for (int i = 50; i < 150; i++)
{
    toplam = toplam + i;

}
Console.WriteLine(toplam);
Console.ReadKey();

//soru 5(tek sayı toplamı)

double top = 0;
for (int i = 1; i < 120; i += 2)
{
    top = top + i;
}
Console.WriteLine(top);

//soru6(çift sayı toplamı)
double topi = 0;
for (int i = 0; i < 120; i += 2)
{
    topi = topi + i;
}
Console.WriteLine(topi);

