using System.Security.Cryptography;

int n = int.Parse(Console.ReadLine());

var l = new List<int>();
for (int i = 0; i < n; i++)
{
    l.Add(new Random().Next());
}

var l1 = l.Select(x => Convert.ToInt32(x.ToString()[^1]));

var l12 = from el in l select Convert.ToInt32(el.ToString()[^1]);

var l2 = l.GroupBy(x => x.ToString()[^1]);

var l22 = from el in l group el by el.ToString()[^1];

var l3 = l.Count(x => x > 0 && x % 2 == 0);

var l32 = (from el in l where el > 0 & el % 2 == 0 select el).Count();

var sumEven = l.Where(x => x % 2 == 0).Sum();

var sum2 = (from el in l where el % 2 == 0 select el).Sum();

var l4 = l.OrderBy(x => 1).ThenBy(x => x.ToString()[^1]);

var l42 = from x in l orderby 1 orderby x.ToString()[^1] select x;
