//driver code for Abstract
Car c = new Car(){Make = "Mahindra", Model = "XUV"};
Motorcycle m = new Motorcycle(){Make = "Bajaj", Model = "Pulsar"};

Console.WriteLine(c);
c.SoundHorn();
Console.WriteLine(m);
m.SoundHorn();


//driver code for Sealed
B example1  = new B();
example1.Func1();
