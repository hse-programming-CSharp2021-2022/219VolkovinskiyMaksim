var n = int.Parse(Console.ReadLine());

var arr = new int[n];
for (var i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-1000,1001);
}
Array.ForEach(arr, Console.WriteLine);

Console.WriteLine();
var sqs = arr.Select(x => x*x).ToArray();
Array.ForEach(sqs, Console.WriteLine);

Console.WriteLine();
var arr2 = arr.Where(x => x > 0 && x.ToString().Length == 2).ToArray();
Array.ForEach(arr2, Console.WriteLine);

Console.WriteLine();
var arr3 = arr.Where(x => x % 2== 0).OrderByDescending(x => x).ToArray();
Array.ForEach(arr3, Console.WriteLine);

Console.WriteLine();
var arr4 = arr.GroupBy(x => x.ToString().Length).ToArray();
Array.ForEach(arr4, x =>
{
    Array.ForEach(x.ToArray(), Console.WriteLine);
});