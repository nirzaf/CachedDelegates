var ages = Enumerable.Range(0,100).ToList();

var sum = ages.Where(x => x>50).Sum();

Console.WriteLine(sum);

Console.ReadLine();