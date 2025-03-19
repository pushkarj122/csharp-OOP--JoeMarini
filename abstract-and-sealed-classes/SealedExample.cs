//it is used to ensure that method or functionality of a class is not changed by the subclass
//it can be due to security reason or class design

// example of sealing a class
using System.Runtime.CompilerServices;

public class A{
    public A(){
        Console.WriteLine("A");
    }
    public virtual void Func1(){
        Console.WriteLine($"Func1 in class A");
    }
}
public class B : A{
    public B(){
        Console.WriteLine("B");
    }
    public override void Func1()
    {
        Console.WriteLine("Func1 is in class B");
    }
}

//sealing an individual member
public class C{
    public C(){}
    public virtual void Func2(){}

}
public class D : C{
    public D(){}
    public sealed override void Func2()
    {
        
    }
}
public class E : D{
    public E(){}

    //cannot override Func2 because it is sealed in D
    // public override void Func2(){}
}