Question 1  
The as operator performs a downcast that evaluates to null (rather than throwing an exception) if the downcast fails.  
a) True  
b) False  
Answer: a) True

Question 2  
What is the output of the following program?  
```
namespace ConsoleApp2
{
  class A
  {
    
  }
}
namespace ConsoleApp2
{
  class B : A
  {
    
  }
}
class Program
{
  static void Main(string[] args)
  {
    A a = new B();
    B b = new B();
    test(b);
    test(a);
  }
  static void test (A a)
  { Console.WriteLine("A"); }
  static void test (B b)
  { Consolt.WriteLine("B"); }
}
```  
Answer: B A

Question 3
Which of the following modifier is used when a virtual method is redefined by a derived class?  
a) virtual
b) 
c)
d) 
e) 
