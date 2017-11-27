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
                #region mine
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
                //1.CLR is the .NET equivalent of _________.
                //A.Java Virtual Machine
                //B.Common Language Runtime
                //C.Common Type System
                //D.Common Language Specification
                //Ans: A

                //2.The CLR is physically represented by an assembly named _______
                //A.mscoree.dll
                //B.mcoree.dll
                //C.msoree.dll
                //D.mscor.dll
                //Ans: A

                //3.SOAP stands for __________.
                //A.Simple Object Access Program
                //B.Simple Object Access Protocol
                //C.Simple Object Application Protocol
                //D.Simple Object Account Protocol
                //Ans: B

                //4.The ____ language allows more than one method in a single class
                //A.C#
                //B.J#
                //C.C++
                //D.C
                //Ans: A

                //5.In C#, a subroutine is called a ________.
                //A.Function
                //B.Metadata
                //C.Method
                //D.Managed code
                //Ans: C

                //6.All C# applications begin execution by calling the _____ method.
                //A.Class()
                //B.Main()
                //C.Submain()
                //D.Namespace
                //Ans: B

                //7.A _______ is an identifier that denotes a storage location
                //A.Constant
                //B.Reference type
                //C.Variable
                //D.Object
                //Ans: C

                //8._________ are reserved, and cannot be used as identifiers.
                //A.Keywords
                //B.literal
                //C.variables
                //D.Identifiers
                //Ans: A

                //9.Boxing converts a value type on the stack to an ______ on the heap.
                //A.Bool type
                //B.Instance type
                //C.Class type
                //D.Object type
                //Ans: D

                //10.The character pair?: is a________________available in C#.
                //A.Unary operator
                //B.Ternary operator
                //C.Decision operator
                //D.Functional operator
                //Ans: B

                //11.In C#, all binary operators are ______.
                //A.Center-associative
                //B.Right-associative
                //C.Left-associative
                //D.Top-associative
                //Ans: C

                //12.An _______ is a symbol that tells the computer to perform certain mathematical or logical manipulations.
                //A.Operator
                //B.Expression
                //C.Condition
                //D.Logic
                //Ans: A

                //13.A _____ is any valid C# variable ending with a colon.
                //A.goto
                //B.Label
                //C.Logical
                //D.Bitwise
                //Ans: B

                //14.C# has _______ operator, useful for making two way decisions.
                //A.Looping
                //B.Functional
                //C.Exponential
                //D.Conditional
                //Ans: D

                //15.________causes the loop to continue with the next iteration after skipping any statements in between.
                //A.Loop
                //B.Exit
                //C.Break
                //D.Continue
                //Ans: D

                //16.An ____ is a group of contiguous or related data items that share a common name.
                //A.Operator
                //B.Integer
                //C.Exponential
                //D.Array
                //Ans: D

                //17.Arrays in C# are ______ objects
                //A.Reference
                //B.Logical
                //C.Value
                //D.Arithmetic
                //Ans: A

                //18.Multidimensional arrays are sometimes called _______ Arrays.
                //A.Square
                //B.Triangular
                //C.Rectangular
                //D.Cube
                //Ans: C

                //19.______ parameters are used to pass results back to the calling method.
                //A.Input
                //B.Reference
                //C.Value
                //D.Output
                //Ans: D

                //20.The formal-parameter-list is always enclosed in _______.
                //A.Square
                //B.Semicolon
                //C.Parenthesis
                //D.Colon
                //Ans: C

                //21._______ variables are visible only in the block they are declared.
                //A.System
                //B.Global
                //C.Local
                //D.Console
                //Ans: C

                //22.C# does not support _____ constructors.
                //A.parameterized
                //B.parameter-less
                //C.Class
                //D.Method
                //Ans: B

                //23.A structure in C# provides a unique way of packing together data of ______ types.
                //A.Different
                //B.Same
                //C.Invoking
                //D.Calling
                //Ans: A

                //24.Struct’s data members are ____________ by default.
                //A.Protected
                //B.Public
                //C.Private
                //D.Default
                //Ans: C

                //25.A _______ creates an object by copying variables from another object.
                //A.Copy constructor
                //B.Default constructor
                //C.Invoking constructor
                //D.Calling constructor
                //Ans: A

                //26.The methods that have the same name, but different parameter lists and different definitions is called______.
                //A.Method Overloading
                //B.Method Overriding
                //C.Method Overwriting
                //D.Method Overreading
                //Ans: A

                //27.The C# provides special methods known as _____ methods to provide access to data members.
                //A.Loop
                //B.Functions
                //C.Methods
                //D.Accessor
                //Ans: D

                //28.When an instance method declaration includes the abstract modifier, the method is said to be an ______.
                //A.Abstract method
                //B.Instance method
                //C.Sealed method
                //D.Expression method
                //Ans: A

                //29.The theory of _____ implies that user can control the access to a class, method, or variable.
                //A.Data hiding
                //B.Encapsulation
                //C.Information Hiding
                //D.Polymorphism
                //Ans: B

                //30.Inheritance is ______ in nature.
                //A.Commutative
                //B.Associative
                //C.Transitive
                //D.Iterative
                //Ans: C

                //31.The point at which an exception is thrown is called the _______.
                //A.Default point
                //B.Invoking point
                //C.Calling point
                //D.Throw point
                //Ans: D

                //32.In C#, having unreachable code is always an _____.
                //A.Method
                //B.Function
                //C.Error
                //D.Iterative
                //Ans: C

                //33.C# treats the multiple catch statements like cases in a _____________ statement.
                //A.If
                //B.Switch
                //C.For
                //D.While
                //Ans: B

                //34.C# supports a technique known as________, which allows a method to specify explicitly the name of the interface it is implementing.
                //A.Method Implementaion
                //B.Implicit Interface Implementation
                //C.Explicit Interface Implementation
                //D.Iterative Interface Implementation
                //Ans: C

                //35.The reason that C# does not support multiple inheritances is because of ______.
                //A.Method collision
                //B.Name collision
                //C.Function collision
                //D.Interface collision
                //Ans: B

                //36._______ is a set of devices through which a user communicates with a system using interactive set of commands.
                //A.Console
                //B.System
                //C.Keyboard
                //D.Monitor
                //Ans: A

                //37.Exponential formatting character (‘E’ or ‘e’) converts a given value to string in the form of _______.
                //A.m.dddd E+xxx
                //B.m.dddd
                //C.E+xxx
                //D.None of the above
                //Ans: A

                //38.The ______ are the Graphical User Interface (GUI) components created for web based interactions..
                //A.Web forms
                //B.Window Forms
                //C.Application Forms
                //D.None of the above
                //Ans: B

                //39.In Microsoft Visual Studio, ______ technology and a programming language such as C# is used to create a Web based application.
                //A.JAVA
                //B.J#
                //C.VB.NET
                //D.ASP.NET
                //Ans: D

                //40.The controls available in the tool box of the ______ are used to create the user interface of a web based application.
                //A.Microsoft visual studio IDE
                //B.Application window
                //C.Web forms
                //D.None of the above
                //Ans: A

                //41.The infrastructure that supports these dynamic operations at run time is called the__________.
                //A.CLR
                //B.CTS
                //C.CLS
                //D.DLR
                //Ans: D

                //42.The___________keyword is new to C# 4.0, and is used to tell the compiler that a variable’s type can change or that it is not known until runtime.
                //A.Covariance
                //B.dynamic
                //C.Contravariance
                //D.Object
                //Ans: B

                //43._______ methods are not supported for dynamic types.
                //A.Anonymous
                //B.Static
                //C.Abstract
                //D.Extension
                //Ans: D

                //44.myMobile.Accept(55, inReject: false); Above statement is an example of which new concept of C# 4.0?
                //A.Named Parameters
                //B.Optional Parameters
                //C.dynamic
                //D.Variance
                //Ans: A

                //45.COM Interop is simplified in C#4.0 e.g.var doc = Application.GetDocument(“MyFile.txt”); In above statement_______ keyword was essential in parameters of GetDocument() in previous versions of C#.
                //A.out
                //B.named
                //C.base
                //D.ref
                //Ans: D

                //46.Covariance and Contravariance are new features introduced in C# 4.0.True/False?
                //A.False
                //B.True
                //Ans: B

                //47._________parameters allows you to give a method parameter a default value so that you do not have to specify it every time you call the method.
                //A.optional
                //B.named
                //C.out
                //D.ref
                //Ans: A

                //48.Duck typing is implemented by using_________ keyword.
                //A.dynamic
                //B.object
                //C.ref
                //D.base
                //Ans: A

                //49.Web Forms consists of a _______ and a _________.
                //A.Template, Component
                //B.CLR, CTS
                //C.HTML Forms, Web services
                //D.Windows, desktop
                //Ans: A

                //50.The ______ parentheses that follow _____ indicate that no information is passed to Main ().
                //A.Empty, class
                //B.Empty, submain
                //C.Empty, Main
                //D.Empty, Namespace
                //Ans: C

                //51.Is it possible to store multiple data types in System.Array?
                //A.Yes
                //B.No
                //Ans: B

                //52.What is the wild card character in the SQL “like” statement?
                //A.* (Asterisk)
                //B.# (Pound)
                //C. % (Percent)
                //D.$ (Dollar)
                //Ans:	C

                //53.Which of the following is the root of the .NET type hierarchy?
                //A.System.Object
                //B.System.Base
                //C.System.Root
                //D.System.Parent
                //Ans:	A

                //54.C# doesnot support:
                //A.abstraction
                //B.polymorphism
                //C.multiple inheritance
                //D.inheritance
                //Ans:	C

                //55.Your company uses Visual Studio.NET 2005 as its application development platform. You are developing an application using the .NET Framework 2.0. You are required to use a datatype that will store only numbers ranging from -32,768 to 32,767. Which of the following datatypes will you use to accomplish the task?
                //A.short
                //B.System.Int16
                //C.string
                //D.a and b
                //Ans:	D

                //56.Which of the following jobs are NOT performed by Garbage Collector?
                //1.Freeing memory on the stack.
                //2.Avoiding memory leaks.
                //3.Freeing memory occupied by unreferenced objects.
                //4.Closing unclosed database collections.
                //5.Closing unclosed files.
                //(A) 1, 2, 3
                //(B) 1, 4, 5
                //(C) 3, 5
                //(D) 3, 4
                //Ans: B

                //57.Which of the following statements is correct about Managed Code?
                //A.Managed code is the code that runs on top of Windows.
                //B.Managed code is the code that is written to target the services of the CLR.
                //C.Managed code is the code where resources are Garbage Collected.
                //D.Managed code is the code that is compiled by the JIT compilers.
                //Ans:	B

                //58.How does assembly versioning in .NET prevent DLL Hell?
                //A.The runtime checks to see that only one version of an assembly is on the machine at any one time.
                //B.The compiler offers compile time checking for backward compatibility.
                //C..NET allows assemblies to specify the name AND the version of any assemblies they need to run.
                //D.It doesn.t.
                //Ans:	C

                //59.Which of the following is/are not types of arrays in C#?
                //A.Single-Dimensional
                //B.Multidimensional
                //C.Jazzed arrays
                //D.Jagged arrays
                //Ans:	C

                //60.A variable which is declared inside a method is called a________variable
                //A.Local
                //B.Private
                //C.Static
                //D.Serial
                //Ans:	A

                //61.Two methods with the same name but with different parameters.
                //A.Overloading
                //B.Multiplexing
                //C.Duplexing
                //D.Loading
                //Ans:	A

                //62.Which file contains configuration data for each unique URl resource used in project?
                //A.web.config
                //B.global.asax
                //C.webapplication.vsdisco
                //D.assemblyinfo.cs
                //Ans:	A

                //63.Features of Read only variables
                //A.Declaration and initialization is separated
                //B.It is allocated at compile time
                //C.It is allocated at runtime
                //D.all of the above
                //Ans:	D

                //64.Different ways a method can be overloaded in C#.NET
                //A.Different parameter data types
                //B.Different order of parameters
                //C.Different number of parameters
                //D.All of above
                //Ans:	D

                //65.Is it possible to change the value of a variable while debugging a C# application?
                //A.Yes
                //B.No
                //Ans:	A

                //66.Which of the following constitutes the .NET Framework?
                //1.ASP.NET Applications
                //2.CLR
                //3.Framework Class Library
                //4.WinForm Applications
                //5.Windows Services
                //(A) 2, 5
                //(B) 2, 1
                //(C) 2, 3
                //(D) 3, 4
                //Ans: C

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
                //A.The program will report an error in the statement base(ii).
                //B.The program will work correctly if we replace base(ii) with base.Baseclass(ii).
                //C.The program will output: Base Derived
                //D.The program will work correctly only if we implement zero-argument constructors in Baseclass as well as Derived class.
                //Ans:	C

                //68.Managed methods will be marked as ———— in MSIL code
                //A.mscorjit
                //B.cil
                //C.dgclr
                //D.None
                //Ans:	B

                //69.Identify which is true
                //A.DataView ia subset of row and not columns
                //B.find can be done only on sorted columns
                //C.Sorting can be done on multiple columns
                //D.None of these
                //Ans:	A

                //70.Which of the following .NET components can be used to remove unused references from the managed heap?
                //A.Class Loader
                //B.Garbage Collector
                //C.CTS
                //D.CLR
                //Ans: B
              
                //71.A local variable
                //A.Can be used anywhere in the program
                //B.Is declared within a method
                //C.Must accept a class
                //D.Represent a class object
                //Ans: b

                //72.An instance variable
                //A.is an object of a class
                //B.represents an attribute of an object
                //C.is a method of a class
                //D.a and c
                //Ans: b

                //73.Private Button print = new button();
                //A.creates a button control
                //B.initializes a button control
                //C.instantiates button control
                //D.a and b
                //E.a and c
                //Ans: e

                //74.An instance method
                //A.Represents the behavior of an object
                //B.Represents the attribute of an object
                //C.Represents another class
                //D.a and b
                //Ans: a

                //75.A Constructor
                //A.is used to create objects
                //B.must have the same name as the class it is declared within
                //C.is a method of a class
                //D.maybe overloaded
                //E.b and c
                //F.all of the above
                //Ans: e

                //76.class Test : Form { }
                //A.Creates the class Test : Form
                //B.Creates the class Test that inherits the class Form
                //C.Creates the class form that inherits the class Test
                //D.a and b
                //Ans: b

                //77.A variable declared inside a method is called a________variable
                //A.Static
                //B.Private
                //C.Local
                //D.Serial
                //E.b and d
                //Ans: c

                //78.Defining two methods with the same name but with different parameters is called.
                //A.Loading
                //B.Overloading
                //C.Multiplexing
                //D.Duplexing
                //Ans: b

                //79.Find any errors in the following BankAccount constructor: Public int BankAccount() { balance = 0; }
                //A.Name
                //B.Formal parameters
                //C.Return type
                //D.No errors
                //Ans: c
    
                //80.In the body of a method, C# uses the variable named_____to refer to the current object whose method is being invoked
                //A.call
                //B.this
                //C.do
                //D.that
                //Ans: b
    
                //81.String mystring; Creates a(n)
                //A.class
                //B.Constructor
                //C.Object
                //D.a and b
                //Ans: c

                //82.An Event is
                //A.The result of a users action
                //B.result of a party
                //C.code to force users action
                //Ans: a

                //83.A delegate defines
                //A.a Wahsington representative
                //B.a class that encapsulates methods
                //C.a means of passing arrays into methods
                //D.a substitue for an inherited method
                //Ans: b

                //84.Is it possible to pass methods as arguments for other methods without modification.
                //A.True
                //B.False
                //Ans: a

                //85.All interfaces must contain IDrivable
                //A.True
                //B.False
                //Ans: b

                //86.What is the proper header for a class that intends to use an interface.
                //A.class MyClass IFace
                //B.class MyClass ; IFace
                //C.class MyClass : IFace
                //D.class MyCalss { IFace }
                //E.class MyCalss(IFace)
                //Ans: c

                //87.In order for a class to use an interface, it must
                //A.inherit the properties of the interface
                //B.contain the same methods as the interface
                //C.create an interface objects
                //D.a and b
                //E.all of the above
                //Ans: e

                //88.Every class directly or indirectly extends the______class.
                //A.System
                //B.Object
                //C.Drawing
                //D.Console
                //Ans: b

                //89.The concept of composition specifies that you can.
                //A.Compose good code with C#
                //B.Compose C# projects with different objects
                //C.Reduce errors by remaining composed during programming
                //D.all of the above
                //Ans: b

                //90.Polymorphism occurs when the methods of the child class.
                //A.Override the parent class methods but maintain the implementation
                //B.Maintain the same return type and arguments as the parent class, but implement it differently
                //C.Have different return types and arguments than the parent class
                //D.Are Virtual
                //Ans: b

                //91.To output the value of multidimensional array, Console.WriteLines(___)
                //A.myArray[1][3];
                //B.myArray[1.3];
                //C.myArray{1}{3};
                //D.myArray(1),(3);
                //Ans: a

                //92.All methods in an abstract base class must be declared abstract.
                //A.True
                //B.False
                //Ans: b

                //93.Methods that are declared abstract in the base class must show implementation at the time of declaration.
                //A.True
                //B.False
                //Ans: b

                //94.The code public class B : A { }
                //A.Defines a class that inherits all the methods of A
                //B.Defines a class that inherits the public and protected methods of A only
                //C.Errors
                //D.a and b
                //Ans: b

                //95.Assuming that public class B : A { public B(int i) : base(i) { } }
                //compiles and runs correctly, what can we conclude about the constructors in the class A?
                //A.One constructor takes an argument of type i
                //B.There is only a default constructor
                //C.One constructor takes an arguments of the type int
                //D.False
                //Ans: b

                //96.Classes declared with the sealed keyword cannot be base class.
                //A.True
                //B.False
                //Ans: a

                //97.A method_____an exception when that method detects that a problem has occured.
                //A.Trys
                //B.Catches
                //C.Throws
                //D.a and b
                //Ans: c

                //98.Exception objects are derived from the class.
                //A.Try
                //B.Catch
                //C.Exception
                //D.Event
                //E.System
                //Ans: c

                //99.An abstract class
                //A.may contain instance variables
                //B.may contain constructors
                //C.may extend another class
                //D.a and b
                //E.all of the above
                //Ans: e

                //100. A____block enclose the code that could throw an exception.
                //A.Try
                //B.Catch
                //C.Exception
                //D.Error
                //E.a and b
                //Ans: a
                #endregion
            };

            return quizQuestions;
        }
    }
}
