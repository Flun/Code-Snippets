<Query Kind="Statements" />

List<string> inputs = new List<string>
{
	"Play_Log_20150601",
	"play_Log_20150601",
	"aPlay_Log_20150601",
	"play_Log_20150601",
	"Play_Log_201"
};

string pattern = "^Play_Log_([0-9]{8})$";

Regex r = new Regex(pattern);
foreach (var input in inputs)
{
	Match m = r.Match(input);
	
	if(m.Success)
		Console.WriteLine("{0} - found '{1}', substring {2}", input.PadRight(20), m.Value, m.Groups[1]);
	else
		Console.WriteLine("{0} - no match", input.PadRight(20));
}


