<Query Kind="Program" />

void Main()
{
	Multiply(5, 5, 5).Dump();
	Multiply(5.2, 4.4, 3.3).Dump();
	Multiply(240234202352, 3, 6).Dump();
	Multiply(14043542355554202352, 5, 2).Dump();
}

int Multiply(int x, int y, int k)
{
	Console.WriteLine("Called int-int-int multiply");
	return x * y * k;
}

double Multiply(double x, double y, double k)
{
	Console.WriteLine("Called double-double-double multiply");
	return x * y * k;
}

long Multiply(long x, long y, long k)
{
	Console.WriteLine("Called long-long-long multiply");
	return x * y * k;
}

ulong Multiply(ulong x, ulong y, ulong k)
{
	Console.WriteLine("Called ulong-ulong-ulong multiply");
	return x * y * k;
}