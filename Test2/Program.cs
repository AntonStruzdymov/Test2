using T2Library;
int[,] arrx2 = new int[4, 5];
Random rand = new Random();
for (int i = 0; i < arrx2.GetLength(0); i++)
{
    for (int j = 0; j < arrx2.GetLength(1); j++)
    {
        arrx2[i, j] = rand.Next(100);
    }
}

for (int i = 0; i < arrx2.GetLength(1); i++)
{
    for (int j = 0; j < arrx2.GetLength(1); j++)
    {
        if (i < j)
        {
            arrx2[i, j] = 1;
        }
    }
}

int row = 1234567890;
var print = row.IntToString();
Console.WriteLine(print);

int[] randArr = new int[20];
for (int i = 0; i < randArr.Length; i++) { randArr[i] = rand.Next(100); }
var linquedArr = randArr.OrderBy(x => x).TakeLast(randArr.Length/2).OrderByDescending(x => x).Select(x => x*x);

UserClass class1 = new UserClass();
UserClass class2 = new UserClass();
class1.SayHello("Привет");
class2.SayHello("НеПривет");
class1.SayHello("Привет");
class2.SayHello("НеПривет");
class1.SayHello("Привет");
class2.SayHello("НеПривет");
class1.SayHello("Привет");
class2.SayHello("НеПривет");
class1.SayHello("Привет");
class2.SayHello("НеПривет");

Mathematics math = new Mathematics();
var x1 = int.Parse(Console.ReadLine());
var x2 = int.Parse(Console.ReadLine());
var res1 = math.Exponent(x1, x2);
var x3 = int.Parse(Console.ReadLine());
var res2 = math.Factorial(x3);

Console.ReadLine();