/*  Given an array of bird sightings where every element represents a bird type id, 
    determine the id of the most frequently sighted type. If more than 1 type has been spotted that maximum amount, 
    return the smallest of their ids. */

Console.WriteLine("Enter a integer list seprated by a single space");
string[] input = Console.ReadLine().ToString().Split(' ');
var groupingResult = input.GroupBy(x=> x).Select(x=> new { key = x.Key, count = x.Count() }).ToList();
var maxNumberOfCount = groupingResult.Max(y => y.count);
var response = groupingResult.Where(x=> x.count == maxNumberOfCount).OrderBy(x => x.key).FirstOrDefault();
Console.WriteLine($" maximum time called smallest one is {response?.key}");
