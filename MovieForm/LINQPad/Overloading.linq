<Query Kind="Program" />

void Main()
{
//	var first = "Wekoslav";
//	var second = "Stefanovski";
//	var times = 3;
//	
//	Repeat(first, times).Dump();
//	Repeat(first, times, second).Dump();

	Add(1,2).Dump();
	Add(1.1,2.3).Dump();
	Add(10100100100, 3).Dump();
	
	Add(true, false).Dump();

}

int Add(int x, int y)
{
	Console.WriteLine("Called int-int add");
	return x + y;
}

double Add(double x, double y)
{
	Console.WriteLine("Called double-double add");
	return x + y;
}

long Add(long x, long y)
{
	Console.WriteLine("Called long-long add");
	return x + y;
}

bool Add(bool x, bool y)
{
	Console.WriteLine("Called bool-bool add");
	return x || y;
}

string Repeat(string text, int count){
	Console.WriteLine("Called repeat with two parameters");
	var result = "";
	for(int i=0; i < count-1; i++){
		result += text + " ";
	}
	result +=text;
	return result;
}

string Repeat(string text, int count, string suffix){
	Console.WriteLine("Called repeat with three parameters");
	return Repeat(text, count) + " " + suffix;
}


