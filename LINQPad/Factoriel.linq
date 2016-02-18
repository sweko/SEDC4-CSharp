<Query Kind="Program" />

void Main()
{
	var f = Factoriel(35);
	f.Dump();
}

long Factoriel(long number){
	//Console.WriteLine($"Called Factoriel with parameter {number}");
	if (number == 0)
	{
		return 1;
	}
	var result =number * Factoriel(number - 1);
	//Console.WriteLine($"Finishing Factoriel with parameter {number}");
	return result;
}

