// read input from stdin pipe
var input = "";
if (Console.IsInputRedirected)
{
    input = new StreamReader(Console.OpenStandardInput()).ReadToEnd();
}
else
{
    // read input from input.txt file
    input = File.ReadAllText("input.txt");
}
var result = 0;

// check length of input
Console.WriteLine(input?.Length ?? 0);

// create lists to store the values
var values = new List<int>();
var values2 = new List<int>();

// read the input and store the values in the lists
// loop through each line of the input
if (input != null)
{
    foreach (var line in input.Split('\n'))
    {
        // trim line
        var cleanline = line.Trim();
        if (!string.IsNullOrWhiteSpace(cleanline))
        {
            // each line is 2 value separated by any whitespace characters
            var parts = cleanline.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var value1 = int.Parse(parts[0]);
            var value2 = int.Parse(parts[1]);
            values.Add(value1);
            values2.Add(value2);
        }
    }
}


// sort each list
values.Sort();
values2.Sort();

// loop through all values in first list and get the distance between the value in the 2nd list
for (var i = 0; i < values.Count; i++)
{
    var value1 = values[i];
    var value2 = values2[i];
    result += Math.Abs(value1 - value2);
}

Console.WriteLine(result);