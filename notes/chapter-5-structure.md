# Chapter:5

## <ins>Structure</ins>

### Introduction:
**Structure** is a value type and a collection of variables of different data types under a single unit. It is almost similar to a class because both are user-defined data types and both hold a bunch of different data types.
C# provide the ability to use pre-defined data types. However, sometimes the user might be in need to define its own data types which are also known as **User-Defined** Data Types. 
Although it comes under the value type, the user can modify it according to requirements and that’s why it is also termed as the user-defined data type.

### Defining Structure:
In C#, structure is defined using `struct` keyword. Using struct keyword one can define the structure consisting of different data types in it. 
A structure can also contain constructors, constants, fields, methods, properties, indexers and events etc. 

### Syntax:
```
    Access_Modifier struct structure_name
    {
        // Fields
        // Parameterized constructor
        // Constants
        // Properties
        // Indexers
        // Events
        // Methods etc.
    } 
```
#### Example:
```
public struct User
{
    public string name;
    public string location;
    public int age;
} 
```
> If you observe the above example, we defined a structure called “User” with required fields, and we can add required methods and properties based on our requirements.

### C# Structure Initialization:
In c#, structures can be instantiated with or without ```new```keyword. Following is the example of assigning values to the variables of structure.

### C# Structure with Constructor:
In c#, the structures won’t allow us to declare a default constructor or a construct o rwithout parameters. It won’t allow us to initialize fields with values unless they are declared as ```const``` or ```static```.
Following is the example of defining a structure with parameterized constructor and initializing the constructor fields in the c# programming language.
```
User u = new User();
u.name = "Suresh Dasari";
u.location = "Hyderabad";
u.age = 32;  
```
### Source Code:
Here is a example:
```
// C# program to illustrate copy the structure
using System;
namespace ConsoleApplication {

// Defining structure
public struct Person
{
	// Declaring different data types
	public string Name;
	public int Age;
	public int Weight;

}

class Student {
	
	// Main Method
	static void Main(string[] args)
	{

		// Declare P1 of type Person
		Person P1;

		// P1's data
		P1.Name = "Ramesh Thapa";
		P1.Age = 21;
		P1.Weight = 80;
		
		// Declare P2 of type Person
		Person P2;
		
		// Copying the values of P1 into P2
		P2 = P1;

		// Displaying the values of P1
		Console.WriteLine("Values Stored in P1");
		Console.WriteLine("Name: " +P1.Name);
		Console.WriteLine("Age: " +P1.Age);
		Console.WriteLine("Weight: " +P1.Weight);
		Console.WriteLine("");
		
		// Displaying the values of P2
		Console.WriteLine("Values Stored in P2");
		Console.WriteLine("Name: " +P2.Name);
		Console.WriteLine("Age: " +P2.Age);
		Console.WriteLine("Weight: " +P2.Weight);
							
	    }
    }
}

```
> In above example the structure is declared with out ``` new ``` keyword.

### Feature of C# Structure:
#### The C# structures have the following features:
- Structures can have methods, fields, indexers, properties, operator methods, and events.
- Structures can have defined constructors, but not destructors. However, you cannot define a default constructor for a structure. The default constructor is automatically defined and cannot be changed.
- Unlike classes, structures cannot inherit other structures or classes.
- Structures cannot be used as a base for other structures or classes.
- A structure can implement one or more interfaces.
- Structure members cannot be specified as abstract, virtual, or protected.
- When you create a struct object using the New operator, it gets created and the appropriate constructor is called. Unlike classes, structs can be instantiated without using the New operator.
- f the New operator is not used, the fields remain unassigned and the object cannot be used until all the fields are initialized.
- In c#, the structures won’t allow us to declare a ```default constructor``` or a ```constructor``` without parameters.It won’t allow us to initialize fields with values unless they are declared as ```const``` or ```static```.