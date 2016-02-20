<Query Kind="Program" />

void Main()
{
	Multiply(2,3).Dump();
	Multiply(2,3,4).Dump();
	Multiply(2,3,4,5).Dump();
	Multiply(2.1,3.2).Dump();
	Multiply(2.2,3.3,4.4).Dump();
	Multiply(2.4,3.7,4.8,5.2).Dump();
}

int Multiply(int first, int second)
{
	return first * second;
}

int Multiply(int first, int second, int third)
{
	return Multiply(first, Multiply(second, third));
}

int Multiply(int first, int second, int third, int fourth)
{
	return Multiply(first, Multiply(second, third, fourth));
}

double Multiply(double first, double second)
{
	return first * second;
}

double Multiply(double first, double second, double third)
{
	return Multiply(first, Multiply(second, third));
}

double Multiply(double first, double second, double third, double fourth)
{
	return Multiply(first, Multiply(second, third, fourth));
}

