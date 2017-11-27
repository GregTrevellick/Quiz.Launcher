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
                //B.Simple Object Access Protocol
                //A.Simple Object Access Program
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
                //C.Method
                //A.Function
                //B.Metadata
                //D.Managed code
                //Ans: C

                //6.All C# applications begin execution by calling the _____ method.
                //B.Main()
                //A.Class()
                //C.Submain()
                //D.Namespace
                //Ans: B

                //7.A _______ is an identifier that denotes a storage location
                //C.Variable
                //A.Constant
                //B.Reference type
                //D.Object
                //Ans: C

                //8._________ are reserved, and cannot be used as identifiers.
                //A.Keywords
                //B.literal
                //C.variables
                //D.Identifiers
                //Ans: A

                //9.Boxing converts a value type on the stack to an ______ on the heap.
                //D.Object type
                //A.Bool type
                //B.Instance type
                //C.Class type
                //Ans: D

                //10.The character pair?: is a________________available in C#.
                //B.Ternary operator
                //A.Unary operator
                //C.Decision operator
                //D.Functional operator
                //Ans: B

                //11.In C#, all binary operators are ______.
                //C.Left-associative
                //A.Center-associative
                //B.Right-associative
                //D.Top-associative
                //Ans: C

                //12.An _______ is a symbol that tells the computer to perform certain mathematical or logical manipulations.
                //A.Operator
                //B.Expression
                //C.Condition
                //D.Logic
                //Ans: A

                //13.A _____ is any valid C# variable ending with a colon.
                //B.Label
                //A.goto
                //C.Logical
                //D.Bitwise
                //Ans: B

                //14.C# has _______ operator, useful for making two way decisions.
                //D.Conditional
                //A.Looping
                //B.Functional
                //C.Exponential
                //Ans: D

                //15.________causes the loop to continue with the next iteration after skipping any statements in between.
                //D.Continue
                //A.Loop
                //B.Exit
                //C.Break
                //Ans: D

                //16.An ____ is a group of contiguous or related data items that share a common name.
                //D.Array
                //A.Operator
                //B.Integer
                //C.Exponential
                //Ans: D

                //17.Arrays in C# are ______ objects
                //A.Reference
                //B.Logical
                //C.Value
                //D.Arithmetic
                //Ans: A

                //18.Multidimensional arrays are sometimes called _______ Arrays.
                //C.Rectangular
                //A.Square
                //B.Triangular
                //D.Cube
                //Ans: C

                //19.______ parameters are used to pass results back to the calling method.
                //D.Output
                //A.Input
                //B.Reference
                //C.Value
                //Ans: D

                //20.The formal-parameter-list is always enclosed in _______.
                //C.Parenthesis
                //A.Square
                //B.Semicolon
                //D.Colon
                //Ans: C

                //21._______ variables are visible only in the block they are declared.
                //C.Local
                //A.System
                //B.Global
                //D.Console
                //Ans: C

                //22.C# does not support _____ constructors.
                //B.parameter-less
                //A.parameterized
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
                //C.Private
                //A.Protected
                //B.Public
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
                //D.Accessor
                //A.Loop
                //B.Functions
                //C.Methods
                //Ans: D

                //28.When an instance method declaration includes the abstract modifier, the method is said to be an ______.
                //A.Abstract method
                //B.Instance method
                //C.Sealed method
                //D.Expression method
                //Ans: A

                //29.The theory of _____ implies that user can control the access to a class, method, or variable.
                //B.Encapsulation
                //A.Data hiding
                //C.Information Hiding
                //D.Polymorphism
                //Ans: B

                //30.Inheritance is ______ in nature.
                //C.Transitive
                //A.Commutative
                //B.Associative
                //D.Iterative
                //Ans: C

                //31.The point at which an exception is thrown is called the _______.
                //D.Throw point
                //A.Default point
                //B.Invoking point
                //C.Calling point
                //Ans: D

                //32.In C#, having unreachable code is always an _____.
                //C.Error
                //A.Method
                //B.Function
                //D.Iterative
                //Ans: C

                //33.C# treats the multiple catch statements like cases in a _____________ statement.
                //B.Switch
                //A.If
                //C.For
                //D.While
                //Ans: B

                //34.C# supports a technique known as________, which allows a method to specify explicitly the name of the interface it is implementing.
                //C.Explicit Interface Implementation
                //A.Method Implementaion
                //B.Implicit Interface Implementation
                //D.Iterative Interface Implementation
                //Ans: C

                //35.The reason that C# does not support multiple inheritances is because of ______.
                //B.Name collision
                //A.Method collision
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
                //B.Window Forms
                //A.Web forms
                //C.Application Forms
                //D.None of the above
                //Ans: B

                //39.In Microsoft Visual Studio, ______ technology and a programming language such as C# is used to create a Web based application.
                //D.ASP.NET
                //A.JAVA
                //B.J#
                //C.VB.NET
                //Ans: D

                //40.The controls available in the tool box of the ______ are used to create the user interface of a web based application.
                //A.Microsoft visual studio IDE
                //B.Application window
                //C.Web forms
                //D.None of the above
                //Ans: A

                //41.The infrastructure that supports these dynamic operations at run time is called the__________.
                //D.DLR
                //A.CLR
                //B.CTS
                //C.CLS
                //Ans: D

                //42.The___________keyword is new to C# 4.0, and is used to tell the compiler that a variable’s type can change or that it is not known until runtime.
                //B.dynamic
                //A.Covariance
                //C.Contravariance
                //D.Object
                //Ans: B

                //43._______ methods are not supported for dynamic types.
                //D.Extension
                //A.Anonymous
                //B.Static
                //C.Abstract
                //Ans: D

                //44.myMobile.Accept(55, inReject: false); Above statement is an example of which new concept of C# 4.0?
                //A.Named Parameters
                //B.Optional Parameters
                //C.dynamic
                //D.Variance
                //Ans: A

                //45.COM Interop is simplified in C#4.0 e.g.var doc = Application.GetDocument(“MyFile.txt”); In above statement_______ keyword was essential in parameters of GetDocument() in previous versions of C#.
                //D.ref
                //A.out
                //B.named
                //C.base
                //Ans: D

                //46.Covariance and Contravariance are new features introduced in C# 4.0.True/False?
                //B.True
                //A.False
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
                //C.Empty, Main
                //A.Empty, class
                //B.Empty, submain
                //D.Empty, Namespace
                //Ans: C

                //51.Is it possible to store multiple data types in System.Array?
                //B.No
                //A.Yes
                //Ans: B

                //52.What is the wild card character in the SQL “like” statement?
                //C. % (Percent)
                //A.* (Asterisk)
                //B.# (Pound)
                //D.$ (Dollar)
                //Ans:	C

                //53.Which of the following is the root of the .NET type hierarchy?
                //A.System.Object
                //B.System.Base
                //C.System.Root
                //D.System.Parent
                //Ans:	A

                //54.C# doesnot support:
                //C.multiple inheritance
                //A.abstraction
                //B.polymorphism
                //D.inheritance
                //Ans:	C

                //55.Your company uses Visual Studio.NET 2005 as its application development platform. You are developing an application using the .NET Framework 2.0. You are required to use a datatype that will store only numbers ranging from -32,768 to 32,767. Which of the following datatypes will you use to accomplish the task?
                //D.a and b
                //A.short
                //B.System.Int16
                //C.string
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
                //Ans: B

                //57.Which of the following statements is correct about Managed Code?
                //B.Managed code is the code that is written to target the services of the CLR.
                //A.Managed code is the code that runs on top of Windows.
                //C.Managed code is the code where resources are Garbage Collected.
                //D.Managed code is the code that is compiled by the JIT compilers.
                //Ans:	B

                //58.How does assembly versioning in .NET prevent DLL Hell?
                //C..NET allows assemblies to specify the name AND the version of any assemblies they need to run.
                //A.The runtime checks to see that only one version of an assembly is on the machine at any one time.
                //B.The compiler offers compile time checking for backward compatibility.
                //D.It doesn.t.
                //Ans:	C

                //59.Which of the following is/are not types of arrays in C#?
                //C.Jazzed arrays
                //A.Single-Dimensional
                //B.Multidimensional
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
                //D.all of the above
                //A.Declaration and initialization is separated
                //B.It is allocated at compile time
                //C.It is allocated at runtime
                //Ans:	D

                //64.Different ways a method can be overloaded in C#.NET
                //D.All of above
                //A.Different parameter data types
                //B.Different order of parameters
                //C.Different number of parameters
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
                //(C) 2, 3
                //(A) 2, 5
                //(B) 2, 1
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
                //C.The program will output: Base Derived
                //A.The program will report an error in the statement base(ii).
                //B.The program will work correctly if we replace base(ii) with base.Baseclass(ii).
                //D.The program will work correctly only if we implement zero-argument constructors in Baseclass as well as Derived class.
                //Ans:	C

                //68.Managed methods will be marked as ———— in MSIL code
                //B.cil
                //A.mscorjit
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
                //B.Garbage Collector
                //A.Class Loader
                //C.CTS
                //D.CLR
                //Ans: B
              
                //71.A local variable
                //B.Is declared within a method
                //A.Can be used anywhere in the program
                //C.Must accept a class
                //D.Represent a class object
                //Ans: b

                //72.An instance variable
                //B.represents an attribute of an object
                //A.is an object of a class
                //C.is a method of a class
                //D.a and c
                //Ans: b

                //73.Private Button print = new button();
                //E.a and c
                //A.creates a button control
                //B.initializes a button control
                //C.instantiates button control
                //D.a and b
                //Ans: e

                //74.An instance method
                //A.Represents the behavior of an object
                //B.Represents the attribute of an object
                //C.Represents another class
                //D.a and b
                //Ans: a

                //75.A Constructor
                //E.b and c
                //A.is used to create objects
                //B.must have the same name as the class it is declared within
                //C.is a method of a class
                //D.maybe overloaded
                //F.all of the above
                //Ans: e

                //76.class Test : Form { }
                //B.Creates the class Test that inherits the class Form
                //A.Creates the class Test : Form
                //C.Creates the class form that inherits the class Test
                //D.a and b
                //Ans: b

                //77.A variable declared inside a method is called a________variable
                //C.Local
                //A.Static
                //B.Private
                //D.Serial
                //E.b and d
                //Ans: c

                //78.Defining two methods with the same name but with different parameters is called.
                //B.Overloading
                //A.Loading
                //C.Multiplexing
                //D.Duplexing
                //Ans: b

                //79.Find any errors in the following BankAccount constructor: Public int BankAccount() { balance = 0; }
                //C.Return type
                //A.Name
                //B.Formal parameters
                //D.No errors
                //Ans: c
    
                //80.In the body of a method, C# uses the variable named_____to refer to the current object whose method is being invoked
                //B.this
                //A.call
                //C.do
                //D.that
                //Ans: b
    
                //81.String mystring; Creates a(n)
                //C.Object
                //A.class
                //B.Constructor
                //D.a and b
                //Ans: c

                //82.An Event is
                //A.The result of a users action
                //B.result of a party
                //C.code to force users action
                //Ans: a

                //83.A delegate defines
                //B.a class that encapsulates methods
                //A.a Wahsington representative
                //C.a means of passing arrays into methods
                //D.a substitue for an inherited method
                //Ans: b

                //84.Is it possible to pass methods as arguments for other methods without modification.
                //A.True
                //B.False
                //Ans: a

                //85.All interfaces must contain IDrivable
                //B.False
                //A.True
                //Ans: b

                //86.What is the proper header for a class that intends to use an interface.
                //C.class MyClass : IFace
                //A.class MyClass IFace
                //B.class MyClass ; IFace
                //D.class MyCalss { IFace }
                //E.class MyCalss(IFace)
                //Ans: c

                //87.In order for a class to use an interface, it must
                //E.all of the above
                //A.inherit the properties of the interface
                //B.contain the same methods as the interface
                //C.create an interface objects
                //D.a and b
                //Ans: e

                //88.Every class directly or indirectly extends the______class.
                //B.Object
                //A.System
                //C.Drawing
                //D.Console
                //Ans: b

                //89.The concept of composition specifies that you can.
                //B.Compose C# projects with different objects
                //A.Compose good code with C#
                //C.Reduce errors by remaining composed during programming
                //D.all of the above
                //Ans: b

                //90.Polymorphism occurs when the methods of the child class.
                //B.Maintain the same return type and arguments as the parent class, but implement it differently
                //A.Override the parent class methods but maintain the implementation
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
                //B.False
                //A.True
                //Ans: b

                //93.Methods that are declared abstract in the base class must show implementation at the time of declaration.
                //B.False
                //A.True
                //Ans: b

                //94.The code public class B : A { }
                //B.Defines a class that inherits the public and protected methods of A only
                //A.Defines a class that inherits all the methods of A
                //C.Errors
                //D.a and b
                //Ans: b

                //95.Assuming that public class B : A { public B(int i) : base(i) { } }
                //compiles and runs correctly, what can we conclude about the constructors in the class A?
                //B.There is only a default constructor
                //A.One constructor takes an argument of type i
                //C.One constructor takes an arguments of the type int
                //D.False
                //Ans: b

                //96.Classes declared with the sealed keyword cannot be base class.
                //A.True
                //B.False
                //Ans: a

                //97.A method_____an exception when that method detects that a problem has occured.
                //C.Throws
                //A.Trys
                //B.Catches
                //D.a and b
                //Ans: c

                //98.Exception objects are derived from the class.
                //C.Exception
                //A.Try
                //B.Catch
                //D.Event
                //E.System
                //Ans: c

                //99.An abstract class
                //E.all of the above
                //A.may contain instance variables
                //B.may contain constructors
                //C.may extend another class
                //D.a and b
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
