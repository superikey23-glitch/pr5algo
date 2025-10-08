
int terraria = 6;
Console.WriteLine("while (не выполнится):");
while (terraria < 5)
{
    Console.WriteLine(terraria);
}

Console.WriteLine("do-while (выполнится):");
do
{
    Console.WriteLine(terraria);
} while (terraria < 5);

Console.WriteLine("Введите любое число");
int minecraft = int.Parse(Console.ReadLine());
int cs = 1;
do
{
    Console.WriteLine(cs);
    cs *= 2;
} while (cs <= minecraft);

Console.WriteLine("Введите количество чисел в ряду Фибоначи");
int portal = int.Parse(Console.ReadLine());
int[] dota = new int[portal];
dota[0] = 0;
dota[1] = 1;
int i = 0;
while (i < portal - 2)
{   
    dota[i+2] = dota[i] + dota[1 + i];
    i++;
}
Console.WriteLine("Ряд Фибоначчи: " + string.Join(", ", dota));


