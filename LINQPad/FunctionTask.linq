<Query Kind="Program" />

void Main()
{
	var first = 72;
	var second = 6;
	var addition = Add(first, second);
	var subtraction = Subtract(first, second);
	var multiply = Multiply(addition, subtraction);
	
	multiply.Dump();
}
