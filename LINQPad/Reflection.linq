<Query Kind="Program">
  <Reference Relative="..\Reflect\bin\Debug\Reflect.exe">C:\Source\Sedc\SEDC4-CSharp\Reflect\bin\Debug\Reflect.exe</Reference>
  <Namespace>Reflect.Entities</Namespace>
</Query>

void Main()
{
	Type personType = typeof(Person);

    var props = personType.GetProperties();
	//props.Select(pi => pi.Name).Dump();
	
	var mems = personType.GetMembers(BindingFlags.NonPublic|BindingFlags.Instance);
	//mems.Dump();
	
	var methods = personType.GetMethods();
	//methods.Dump();
	
	var weko = GetSomething();
	//weko.Dump();
	var propFirst = personType.GetProperty("FirstName");
	//propFirst.Dump();
	
	var firstSetter = propFirst.SetMethod;
	firstSetter.Invoke(weko, new object[]{"Weko"});
	//weko.Dump();
	
	var field = personType.GetField("address", BindingFlags.NonPublic|BindingFlags.Instance);
	
	field.GetValue(weko).Dump();
	var p = new Person();
	field.GetValue(p).Dump();
	
	field.SetValue(weko, null);
	field.GetValue(weko).Dump();
}

object GetSomething(){
	return new Person
    {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Age = 0x26,
                Address = "Kisela Voda, Skopje"
    };
}

// Define other methods and classes here
