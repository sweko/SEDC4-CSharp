<Query Kind="Program" />

void Main()
{
	var first =72;
	var second = 6;
	var addition = Add(first, second);
	var subtraction = Subtract(first, second);
	var multiply = Multiply(addition, subtraction);
	
	multiply.Dump();
}

int Add(int first, int second)
{
	return first + second;
}

int Subtract(int first, int second)
{
	return Add(first, -second);
}

int Multiply(int first, int second)
{
	int result = 0;
	for (int i = 0; i < first; i = Add(i,1))
    {
       result =Add(result, second);
    }
	return result;
}


