Question 1  
The **as** operator performs a downcast that evaluates to null (rather than throwing an exception) if the downcast fails.  
a) True  
b) False  
Answer: a) True

Question 2  
What is the output of the following program?  
![image](https://github.com/user-attachments/assets/e41ec3dd-5bdf-4f2c-ad29-e2b79c4d440d)  
Answer: B A

Question 3  
Which of the following modifier is used when a virtual method is redefined by a derived class?  
a) virtual  
b) overridable  
c) overloads  
d) override  
e) base  
Answer: d) override

Question 4  
protected internal: Accessible only in the assembly.  
a) True  
b) False  
Answer: b) False

Question 5  
The class Car below is designed so the method Accelerate can fire the event.  
![image](https://github.com/user-attachments/assets/1755694b-c3fb-4156-969c-783c68a08c3b)  
Write a main method that adds the required C# statement(s) and/or methods so the main method can listen and handle the incoming event from the class Car.

Question 6  
Keyword ____ is used for constants whose values cannot be determined at compile time.  
a) readonly  
b) static  
c) const  
d) None of the above.  
Answer: a) readonly

Question 7  
A **static constructor** executes once per _type_, rather than once per _instance_.  
a) True  
b) False  
Answer: a) True

Question 8  
An indexer  
a) is a special type of property.  
b) lets the user of a class access an item by using an index.  
c) uses the this keyword in its declaration.  
d) all of the above  
Answer: d) all of the above

Question 9  
An out argument needs assigned before going into function.  
a) True  
b) False  
Answer: b) False

Question 10
The program below can sort an integer array in ascending order or descending order using the bubble sort algorithm and delegate. Complete the code by filling in blanks with C# statement(s).  
![image](https://github.com/user-attachments/assets/ece84af8-6d6a-4d83-9390-bb266b9a7318)  
Answer: sort(list, IComparable a) , sort(list, IComparable b), public static void sort(int[] num, IComparable<int> c)

Question 11  
The base keyword serves for accessing an overridden function member from the subclass.  
a) True  
b) False  
Answer: a) True

Question 12
An _Employee_ class has a property called _age_ and _emp_ is reference to a _Employee_ object and we want the statement _Console.WriteLine(emp.age)_ to fail. Which of the following options will ensure this functionality?  
a) Declare _age_ property with both get and set accessors.  
b) Declare _age_ property with get, set and normal accessors.  
c) Declare _age_ property with only set accessor.  
d) Declare _age_ property with only get accessor.  
e) None of the above  
Answer: c) Declare _age_ property with only set accessor.

Question 13
Which of the following is the correct way to implement a write only propert _Length_ in a _Sample_ class?  
a) 
```
class Sample
{
  public int Length
  {
    set
    {
      Length = value;
    }
  }
}
```
b) 
```
class Sample
{
  int len;
  public int Length
  {
    set
    {
      len = value;
    }
  }
}
```
c) 
```
class Sample
{
  int len;
  public int Length
  {
    WriteOnly set
    {
      len = value;
    }
  }
}
```
d) 
```
class Sample
{
  int len;
  public int Length
  {
    get
    {
      return len;
    }
    set
    {
      len = value;
    }
  }
}
```
Answer: b)

Question 14  
What is the output of the following program?  
![image](https://github.com/user-attachments/assets/23aff511-1037-4e63-a6bf-1e459ac9b703)  
Answer: B.test
        B.test
        C.test
        A.test

Question 15  
Given the interfaces IA and IB as well as class C below.  
![image](https://github.com/user-attachments/assets/db411bc4-51ce-4c84-a18a-9fff046c4cb3)  
a. Write code in class C to define the method test from the interface IB. The method displays "Implementation of IB.test" and retunrs a value of 5.  
b. Write the C# statements in a Main method to call the method test from the interface IA and the method test from interface IB.  

Question 16  
A field with **readonly** modifier can be assigned only in its declaration or within the enclosing type's constructor.  
a) True  
b) False  
Answer: a) True

Question 17  
Which of the following keyword is used to change the data and behavior of a base class by replacing a member of a base class with a new derived member?  
a) override  
b) overridable  
c) base  
d) new  
e) overloads  
Answer: d) new

Question 18  
Contravariance allows to use base type where derived is expected.  
a) True  
b) False  
Answer: b) False

Question 19  
Assemblies take the form of an executable (.exe) file or dynamic link library (.dll) file, and are the building blocks of the .NET Framework.
a) True
b) False  
Answer: a) True

Quesiton 20  
Covariance means we can substitute derived type in place of Base type.  
a) True  
b) False  
Answer: a) True

Question 21  
Which of the following modifier is used when a virtual method is redefined by a derived class?  
a) virtual  
b) base  
c) overloads  
d) overridable  
e) override  
Answer: e) override

Question 22  
The is operator is often used to test before downcasting.  
a) True  
b) False  
Answer: a) True

Question 23  
Given the code below. Write code for the method Test.  
![image](https://github.com/user-attachments/assets/762ba967-27e5-4bad-918f-ee4cab2785a1)  
Answer: 
```
static void Test(Animal a)
{
  Mammal m = a as Mammal;
  m.Dance();
}
```

Question 24  
Class A is defined as below:  
![image](https://github.com/user-attachments/assets/376fb702-29b9-400e-bca8-698f4f524a5c)  
Write a complete code for the method **display**. You are not allowed to write any code in the class A and the method Main.  
Answer:
```
namespace ext
{
  public static class DisplayValue:A
  {
    public static void display()
    {
      Console.WriteLine(A);
    }
  }
}
```
