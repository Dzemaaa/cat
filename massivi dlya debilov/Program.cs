Random r = new Random();
int[] cat = new int[r.Next(2, 100)];

for (int i = 0; i < cat.Length; i++)
{
    cat[i] = r.Next(0, 10);
}
int count = yachmo(cat, 5);
Console.WriteLine("в случайном массиве " + count + " четных чисел!!!");

int yachmo(int[] ints, int x)
{
    List<int> list = new List<int>();

    foreach (var item in ints)
    {
        if (item % 2 == 0)
            list.Add(item);

    }

    return list.Count; 
}
