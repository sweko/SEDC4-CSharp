<Query Kind="Program" />

void Main()
{
	var balls = 20;
	var drawn = 5;
	var combinations = GetCombinations(balls, drawn)
	combinations.Dump();
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

