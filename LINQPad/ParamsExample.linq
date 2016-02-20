<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Jas se vikam Wekoslav Stefanovski, imam 38 godini, roden vo Bitola");
	Console.WriteLine("Jas se vikam {0}, imam 38 godini, roden vo Bitola", "Wekoslav Stefanovski");
	Console.WriteLine("Jas se vikam {0} {1}, imam 38 godini, roden vo Bitola", "Wekoslav", "Stefanovski");
	Console.WriteLine("Jas se vikam {0} {1}, imam {2} godini, roden vo {3}", "Wekoslav", "Stefanovski",38,"Bitola");
	
	Multiply(2,3).Dump();
	Multiply(2,3,4).Dump();
	
	Multiply(new int[]{2, 3, 4, 5, 6, 7}).Dump();
	
	Multiply(2, 3, 4, 5, 6, 7).Dump();
}

int Multiply(int first, int second)
{
	return first * second;
}

int Multiply(int first, int second, int third)
{
	return Multiply(first, Multiply(second, third));
}

int Multiply(params int[] numbers){
	int product = 1;
	foreach(var number in numbers)
	{
		product *= number;
	}
	return product;
}

// Define other methods and classes here
