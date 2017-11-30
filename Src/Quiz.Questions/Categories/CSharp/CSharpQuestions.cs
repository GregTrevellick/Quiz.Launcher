using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.CSharp
{
    internal class CSharpQuestions : IGetQuizQuestions
    {
        private const Category Category = Entities.Category.CSharp;

        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                #region https://www.codeproject.com/Articles/827091/Csharp-Attributes-in-minutes
                //What does[Obsolete("Please use NewMethod1", true)] do ?
                //If you want to be bit strict and do not want developers to use that method, you can pass ‘true” to the “Obsolete” attribute as shown in the below code.
                
                //Is it possible to restrict a custom attribute to a method only?
                //By using the “AttributeUsage” and “AttributeTargets” you can restrict the attribute to a particular section like class , method , property etc.Below is a simple custom attribute is now confined only to methods.
                
                //Do attributes get inherited ?
                //Yes, they get inherited in the child classes.
                
                //If I want an attribute to be used only once in a program?
                //If you specify “AllowMultiple” as true it can be used multiple times in the same program.
                //[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)] Multiple = false)]
                #endregion

                #region mine
                //Min date sql=?
                //Min date=?
                //Int.max=?
                //Decimal.max=?
                //Is [Flags] w/o =1/2/4/8 useless ? yes it is
                Common.Get(Category, DifficultyLevel.Hard,
                    "The following valid C# code:   var weekDays &= ~WeekDays.Sunday   ?",
                    "true",
                    "false"),
                #endregion
     
                #region web camp training kit
                Common.Get(Category, DifficultyLevel.Hard,
                    "What was the original name of the C# programming language?",
                    "Cool",
                    "Boo",
                    "C+++",
                    "Anders"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Which of the following is an example of Boxing in C#?",
                    "object bar = 42;",
                    "int foo = 12;",
                    "System.Box(56);",
                    "int foo = (int)bar;"),
                #endregion

                #region http://www.naukrieducation.com/100-top-real-time-c-net-multiple-choice-questions-and-answers-pdf/
                Common.Get(Category, DifficultyLevel.Medium,"CLR is the .NET equivalent of what ?",
                "Java Virtual Machine",
                "Common Language Runtime",
                "Common Type System",
                "Common Language Specification"),

                Common.Get(Category, DifficultyLevel.Medium,"The CLR is physically represented by which assembly ?",
                "mscoree.dll",
                "mcoree.dll",
                "msoree.dll",
                "mscor.dll"),

                Common.Get(Category, DifficultyLevel.Medium,"SOAP is short for ?",
                "Simple Object Access Protocol",
                "Simple Object Access Program",
                "Simple Object Application Protocol",
                "Simple Object Account Protocol"),

                Common.Get(Category, DifficultyLevel.Medium,"Which language allows more than one method in a single class?",
                "C#",
                "J#",
                "C++",
                "C"),

                Common.Get(Category, DifficultyLevel.Medium,"In C#, a subroutine is called a what ?",
                "Method",
                "Function",
                "Metadata",
                "Managed code"),

                Common.Get(Category, DifficultyLevel.Medium,"All C# applications begin execution by calling which method?",
                "Main()",
                "Class()",
                "Submain()",
                "Namespace"),

                Common.Get(Category, DifficultyLevel.Medium,"A _______ is an identifier that denotes a storage location?",
                "Variable",
                "Constant",
                "Reference type",
                "Object"),

                Common.Get(Category, DifficultyLevel.Medium,"_________ are reserved, and cannot be used as identifiers?",
                "Keywords",
                "literal",
                "variables",
                "Identifiers"),

                Common.Get(Category, DifficultyLevel.Medium,"Boxing converts a value type on the stack to an ______ on the heap?",
                "Object type",
                "Bool type",
                "Instance type",
                "Class type"),

                Common.Get(Category, DifficultyLevel.Medium,"The character pair ?: is a________________available in C#?",
                "Ternary operator",
                "Unary operator",
                "Decision operator",
                "Functional operator"),

                Common.Get(Category, DifficultyLevel.Medium,"In C#, all binary operators are ______?",
                "Left-associative",
                "Center-associative",
                "Right-associative",
                "Top-associative"),

                Common.Get(Category, DifficultyLevel.Medium,"An _______ is a symbol that tells the computer to perform certain mathematical or logical manipulations?",
                "Operator",
                "Expression",
                "Condition",
                "Logic"),

                Common.Get(Category, DifficultyLevel.Medium,"A _____ is any valid C# variable ending with a colon?",
                "Label",
                "goto",
                "Logical",
                "Bitwise"),

                Common.Get(Category, DifficultyLevel.Medium,"C# has _______ operator, useful for making two way decisions?",
                "Conditional",
                "Looping",
                "Functional",
                "Exponential"),

                Common.Get(Category, DifficultyLevel.Medium,"________causes the loop to continue with the next iteration after skipping any statements in between?",
                "Continue",
                "Loop",
                "Exit",
                "Break"),

                Common.Get(Category, DifficultyLevel.Medium,"An ____ is a group of contiguous or related data items that share a common name?",
                "Array",
                "Operator",
                "Integer",
                "Exponential"),

                Common.Get(Category, DifficultyLevel.Medium,"Arrays in C# are ______ objects?",
                "Reference",
                "Logical",
                "Value",
                "Arithmetic"),

                Common.Get(Category, DifficultyLevel.Medium,"Multidimensional arrays are sometimes called _______ Arrays?",
                "Rectangular",
                "Square",
                "Triangular",
                "Cube"),

                Common.Get(Category, DifficultyLevel.Medium,"______ parameters are used to pass results back to the calling method?",
                "Output",
                "Input",
                "Reference",
                "Value"),

                Common.Get(Category, DifficultyLevel.Medium,"The formal-parameter-list is always enclosed in _______?",
                "Parenthesis",
                "Square",
                "Semicolon",
                "Colon"),


                Common.Get(Category, DifficultyLevel.Medium,"_______ variables are visible only in the block they are declared?",
                "Local",
                "System",
                "Global",
                "Console"),


                Common.Get(Category, DifficultyLevel.Medium,"C# does not support _____ constructors?",
                "parameter-less",
                "parameterized",
                "Class",
                "Method"),
                

                //23.A structure in C# provides a unique way of packing together data of ______ types?",
                //"Different
                //"Same
                //"Invoking
                //"Calling
                

                //24.Struct’s data members are ____________ by default.
                //"Private
                //"Protected
                //"Public
                //"Default
                 

                //25.A _______ creates an object by copying variables from another object.
                //"Copy constructor
                //"Default constructor
                //"Invoking constructor
                //"Calling constructor
                

                //26.The methods that have the same name, but different parameter lists and different definitions is called______.
                //"Method Overloading
                //"Method Overriding
                //"Method Overwriting
                //"Method Overreading
                

                //27.The C# provides special methods known as _____ methods to provide access to data members.
                //"Accessor
                //"Loop
                //"Functions
                //"Methods
                 

                //28.When an instance method declaration includes the abstract modifier, the method is said to be an ______.
                //"Abstract method
                //"Instance method
                //"Sealed method
                //"Expression method
                

                //29.The theory of _____ implies that user can control the access to a class, method, or variable.
                //"Encapsulation
                //"Data hiding
                //"Information Hiding
                //"Polymorphism
                

                //30.Inheritance is ______ in nature.
                //"Transitive
                //"Commutative
                //"Associative
                //"Iterative
                 

                //31.The point at which an exception is thrown is called the _______.
                //"Throw point
                //"Default point
                //"Invoking point
                //"Calling point
                 

                //32.In C#, having unreachable code is always an _____.
                //"Error
                //"Method
                //"Function
                //"Iterative
                 

                //33.C# treats the multiple catch statements like cases in a _____________ statement.
                //"Switch
                //"If
                //"For
                //"While
                

                //34.C# supports a technique known as________, which allows a method to specify explicitly the name of the interface it is implementing.
                //"Explicit Interface Implementation
                //"Method Implementaion
                //"Implicit Interface Implementation
                //"Iterative Interface Implementation
                 

                //35.The reason that C# does not support multiple inheritances is because of ______.
                //"Name collision
                //"Method collision
                //"Function collision
                //"Interface collision
                

                //36._______ is a set of devices through which a user communicates with a system using interactive set of commands.
                //"Console
                //"System
                //"Keyboard
                //"Monitor
                

                //37.Exponential formatting character (‘E’ or ‘e’) converts a given value to string in the form of _______.
                //"m.dddd E+xxx
                //"m.dddd
                //"E+xxx
                //"None of the above
                

                //38.The ______ are the Graphical User Interface (GUI) components created for web based interactions..
                //"Window Forms
                //"Web forms
                //"Application Forms
                //"None of the above
                

                //39.In Microsoft Visual Studio, ______ technology and a programming language such as C# is used to create a Web based application.
                //"ASP.NET
                //"JAVA
                //"J#
                //"VB.NET
                 

                //40.The controls available in the tool box of the ______ are used to create the user interface of a web based application.
                //"Microsoft visual studio IDE
                //"Application window
                //"Web forms
                //"None of the above
                

                //41.The infrastructure that supports these dynamic operations at run time is called the__________.
                //"DLR
                //"CLR
                //"CTS
                //"CLS
                 

                //42.The___________keyword is new to C# 4.0, and is used to tell the compiler that a variable’s type can change or that it is not known until runtime.
                //"dynamic
                //"Covariance
                //"Contravariance
                //"Object
                

                //43._______ methods are not supported for dynamic types.
                //"Extension
                //"Anonymous
                //"Static
                //"Abstract
                 

                //44.myMobile.Accept(55, inReject: false); Above statement is an example of which new concept of C# 4.0?
                //"Named Parameters
                //"Optional Parameters
                //"dynamic
                //"Variance
                

                //45.COM Interop is simplified in C#4.0 e.g.var doc = Application.GetDocument(“MyFile.txt”); In above statement_______ keyword was essential in parameters of GetDocument() in previous versions of C#.
                //"ref
                //"out
                //"named
                //"base
                 

                //46.Covariance and Contravariance are new features introduced in C# 4.0.True/False?
                //"True
                //"False
                

                //47._________parameters allows you to give a method parameter a default value so that you do not have to specify it every time you call the method.
                //"optional
                //"named
                //"out
                //"ref
                

                //48.Duck typing is implemented by using_________ keyword.
                //"dynamic
                //"object
                //"ref
                //"base
                

                //49.Web Forms consists of a _______ and a _________.
                //"Template, Component
                //"CLR, CTS
                //"HTML Forms, Web services
                //"Windows, desktop
                

                //50.The ______ parentheses that follow _____ indicate that no information is passed to Main ().
                //"Empty, Main
                //"Empty, class
                //"Empty, submain
                //"Empty, Namespace
                 

                //51.Is it possible to store multiple data types in System.Array?
                //"No
                //"Yes
                

                //52.What is the wild card character in the SQL “like” statement?
                //" % (Percent)
                //"* (Asterisk)
                //"# (Pound)
                //"$ (Dollar)
                //Ans:	C

                //53.Which of the following is the root of the .NET type hierarchy?
                //"System.Object
                //"System.Base
                //"System.Root
                //"System.Parent
                //Ans:	A

                //54.C# doesnot support:
                //"multiple inheritance
                //"abstraction
                //"polymorphism
                //"inheritance
                //Ans:	C

                //55.Your company uses Visual Studio.NET 2005 as its application development platform. You are developing an application using the .NET Framework 2.0. You are required to use a datatype that will store only numbers ranging from -32,768 to 32,767. Which of the following datatypes will you use to accomplish the task?
                //"a and b
                //"short
                //"System.Int16
                //"string
                //Ans:	D

                //56.Which of the following jobs are NOT performed by Garbage Collector?
                //1.Freeing memory on the stack.
                //2.Avoiding memory leaks.
                //3.Freeing memory occupied by unreferenced objects.
                //4.Closing unclosed database collections.
                //5.Closing unclosed files.
                //(B) 1, 4, 5
                //(A) 1, 2, 3
                //(C) 3, 5
                //(D) 3, 4
                

                //57.Which of the following statements is correct about Managed Code?
                //"Managed code is the code that is written to target the services of the CLR.
                //"Managed code is the code that runs on top of Windows.
                //"Managed code is the code where resources are Garbage Collected.
                //"Managed code is the code that is compiled by the JIT compilers.
                //Ans:	B

                //58.How does assembly versioning in .NET prevent DLL Hell?
                //".NET allows assemblies to specify the name AND the version of any assemblies they need to run.
                //"The runtime checks to see that only one version of an assembly is on the machine at any one time.
                //"The compiler offers compile time checking for backward compatibility.
                //"It doesn.t.
                //Ans:	C

                //59.Which of the following is/are not types of arrays in C#?
                //"Jazzed arrays
                //"Single-Dimensional
                //"Multidimensional
                //"Jagged arrays
                //Ans:	C

                //60.A variable which is declared inside a method is called a________variable
                //"Local
                //"Private
                //"Static
                //"Serial
                //Ans:	A

                //61.Two methods with the same name but with different parameters.
                //"Overloading
                //"Multiplexing
                //"Duplexing
                //"Loading
                //Ans:	A

                //62.Which file contains configuration data for each unique URl resource used in project?
                //"web.config
                //"global.asax
                //"webapplication.vsdisco
                //"assemblyinfo.cs
                //Ans:	A

                //63.Features of Read only variables
                //"all of the above
                //"Declaration and initialization is separated
                //"It is allocated at compile time
                //"It is allocated at runtime
                //Ans:	D

                //64.Different ways a method can be overloaded in C#.NET
                //"All of above
                //"Different parameter data types
                //"Different order of parameters
                //"Different number of parameters
                //Ans:	D

                //65.Is it possible to change the value of a variable while debugging a C# application?
                //"Yes
                //"No
                //Ans:	A

                //66.Which of the following constitutes the .NET Framework?
                //1.ASP.NET Applications
                //2.CLR
                //3.Framework Class Library
                //4.WinForm Applications
                //5.Windows Services
                //(C) 2, 3
                //(A) 2, 5
                //(B) 2, 1
                //(D) 3, 4
                 

                //67.Which of the following statements is correct about the C#.NET program given below?
                //namespace PskillsConsoleApplication
                //{
                //class Baseclass
                //{
                //int i;
                //public Baseclass(int ii)
                //{
                //i = ii;
                //Console.Write(“Base “);
                //}
                //}
                //class Derived : Baseclass
                //{
                //public Derived(int ii) : base(ii)
                //{
                //Console.Write(“Derived “);
                //}
                //}
                //class MyProgram
                //{
                //static void Main(string[] args)
                //{
                //Derived d = new Derived(10);
                //}
                //}
                //}
                //"The program will output: Base Derived
                //"The program will report an error in the statement base(ii).
                //"The program will work correctly if we replace base(ii) with base.Baseclass(ii).
                //"The program will work correctly only if we implement zero-argument constructors in Baseclass as well as Derived class.
                //Ans:	C

                //68.Managed methods will be marked as ———— in MSIL code
                //"cil
                //"mscorjit
                //"dgclr
                //"None
                //Ans:	B

                //69.Identify which is true
                //"DataView ia subset of row and not columns
                //"find can be done only on sorted columns
                //"Sorting can be done on multiple columns
                //"None of these
                //Ans:	A

                //70.Which of the following .NET components can be used to remove unused references from the managed heap?
                //"Garbage Collector
                //"Class Loader
                //"CTS
                //"CLR
                
              
                //71.A local variable
                //"Is declared within a method
                //"Can be used anywhere in the program
                //"Must accept a class
                //"Represent a class object
                

                //72.An instance variable
                //"represents an attribute of an object
                //"is an object of a class
                //"is a method of a class
                //"a and c
                

                //73.Private Button print = new button();
                //"a and c
                //"creates a button control
                //"initializes a button control
                //"instantiates button control
                //"a and b
                 

                //74.An instance method
                //"Represents the behavior of an object"
                //"Represents the attribute of an object"
                //"Represents another class"
                //"a and b"
                

                //75.A Constructor
                //"b and c
                //"is used to create objects
                //"must have the same name as the class it is declared within
                //"is a method of a class
                //"maybe overloaded
                //"all of the above
                 

                //76.class Test : Form { }
                //"Creates the class Test that inherits the class Form
                //"Creates the class Test : Form
                //"Creates the class form that inherits the class Test
                //"a and b
                

                //77.A variable declared inside a method is called a________variable
                //"Local
                //"Static
                //"Private
                //"Serial
                //"b and d
                 

                //78.Defining two methods with the same name but with different parameters is called.
                //"Overloading
                //"Loading
                //"Multiplexing
                //"Duplexing
                

                //79.Find any errors in the following BankAccount constructor: Public int BankAccount() { balance = 0; }
                //"Return type
                //"Name
                //"Formal parameters
                //"No errors
                 
    
                //80.In the body of a method, C# uses the variable named_____to refer to the current object whose method is being invoked
                //"this
                //"call
                //"do
                //"that
                
    
                //81.String mystring; Creates a(n)
                //"Object
                //"class
                //"Constructor
                //"a and b
                 

                //82.An Event is
                //"The result of a users action
                //"result of a party
                //"code to force users action
                

                //83.A delegate defines
                //"a class that encapsulates methods
                //"a Wahsington representative
                //"a means of passing arrays into methods
                //"a substitue for an inherited method
                

                //84.Is it possible to pass methods as arguments for other methods without modification.
                //"True
                //"False
                

                //85.All interfaces must contain IDrivable
                //"False
                //"True
                

                //86.What is the proper header for a class that intends to use an interface.
                //"class MyClass : IFace
                //"class MyClass IFace
                //"class MyClass ; IFace
                //"class MyCalss { IFace }
                //"class MyCalss(IFace)
                 

                //87.In order for a class to use an interface, it must
                //"all of the above
                //"inherit the properties of the interface
                //"contain the same methods as the interface
                //"create an interface objects
                //"a and b
                 

                //88.Every class directly or indirectly extends the______class.
                //"Object
                //"System
                //"Drawing
                //"Console
                

                //89.The concept of composition specifies that you can.
                //"Compose C# projects with different objects
                //"Compose good code with C#
                //"Reduce errors by remaining composed during programming
                //"all of the above
                

                //90.Polymorphism occurs when the methods of the child class.
                //"Maintain the same return type and arguments as the parent class, but implement it differently
                //"Override the parent class methods but maintain the implementation
                //"Have different return types and arguments than the parent class
                //"Are Virtual
                

                //91.To output the value of multidimensional array, Console.WriteLines(___)
                //"myArray[1][3];
                //"myArray[1.3];
                //"myArray{1}{3};
                //"myArray(1),(3);
                

                //92.All methods in an abstract base class must be declared abstract.
                //"False
                //"True
                

                //93.Methods that are declared abstract in the base class must show implementation at the time of declaration.
                //"False
                //"True
                

                //94.The code public class B : A { }
                //"Defines a class that inherits the public and protected methods of A only
                //"Defines a class that inherits all the methods of A
                //"Errors
                //"a and b
                

                //95.Assuming that public class B : A { public B(int i) : base(i) { } }
                //compiles and runs correctly, what can we conclude about the constructors in the class A?
                //"There is only a default constructor
                //"One constructor takes an argument of type i
                //"One constructor takes an arguments of the type int
                //"False
                

                //96.Classes declared with the sealed keyword cannot be base class.
                //"True
                //"False
                

                //97.A method_____an exception when that method detects that a problem has occured.
                //"Throws
                //"Trys
                //"Catches
                //"a and b
                 

                //98.Exception objects are derived from the class.
                //"Exception
                //"Try
                //"Catch
                //"Event
                //"System
                 

                //99.An abstract class
                //"all of the above
                //"may contain instance variables
                //"may contain constructors
                //"may extend another class
                //"a and b
                 

                //100. A____block enclose the code that could throw an exception.
                //"Try
                //"Catch
                //"Exception
                //"Error
                //"a and b
                
                #endregion
            };

            return quizQuestions;
        }
    }
}
