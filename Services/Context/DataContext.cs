using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flashCardBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace flashCardBackend.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<CsharpCardModel>? CsharpFlashCards { get; set; }
        public DbSet<HtmlCardModel>? HtmlFlashCards { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var CsharpCards = new List<CsharpCardModel>()
            {
                new CsharpCardModel(){
                    Id = 1,
                    CsharpQuestion = "What Is A Writeline",
                    CsharpAnswer = "WriteLine prints the output on a new line each time",
                    CodeAnswer = ""
                },

                new CsharpCardModel(){
                    Id = 2,
                    CsharpQuestion = "What Is A Write",
                    CsharpAnswer = "Write prints on the same line",
                    CodeAnswer = ""
                },

                new CsharpCardModel(){
                    Id = 3,
                    CsharpQuestion = "What Does // Do",
                    CsharpAnswer = "Any text between // and the end of the line is ignored by C#",
                    CodeAnswer = ""
                },

                new CsharpCardModel(){
                    Id = 4,
                    CsharpQuestion = "What Does Throw Do",
                    CsharpAnswer = "The throw statement allows you to create a custom error",
                    CodeAnswer = ""
                },

                new CsharpCardModel()
                {
                    Id = 5,
                    CsharpQuestion = "What Does Finally D0",
                    CsharpAnswer = "The finally statement lets you execute code, after try...catch, regardless of the result",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 6,
                    CsharpQuestion = "Should You Use A Try And Catch",
                    CsharpAnswer = "you should always use them together,",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 7,
                    CsharpQuestion = "What Does A Catch Statement Do",
                    CsharpAnswer = "A catch statement allows you to define a block of code to be executed, if an error occurs in the try block",
                    CodeAnswer =""
                },
                new CsharpCardModel()
                {
                    Id = 8,
                    CsharpQuestion = "What Does A Try Statement Do",
                    CsharpAnswer = "A try statement allows you to define a block of code to be tested for errors while it is being executed",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 9,
                    CsharpQuestion = "Can Enums Be Used In Classes",
                    CsharpAnswer = "yes , you can also have an enum inside a class",
                    CodeAnswer =""
                },
                new CsharpCardModel()
                {
                    Id = 10,
                    CsharpQuestion = "How Do You Create A Enum",
                    CsharpAnswer = "To create an enum, use the enum keyword (instead of class or interface)",
                    CodeAnswer =""
                },
                new CsharpCardModel()
                {
                    Id = 11,
                    CsharpQuestion = "Why Would You Use Enum",
                    CsharpAnswer = "you use enums when you have values that you know aren't going to change",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 12,
                    CsharpQuestion = "What Is A Enum",
                    CsharpAnswer = "An enum is a special \"class\" that represents a group of constants (unchangeable/read-only variables)",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 13,
                    CsharpQuestion = "Can You Have Multiple Interfaces",
                    CsharpAnswer = "yes, to implement multiple interfaces, separate them with a comma",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 14,
                    CsharpQuestion = "Why Use A Interface Over Abstract",
                    CsharpAnswer = "C# does not support \"multiple inheritance\" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 15,
                    CsharpQuestion = "What Keyword Makes A Interface",
                    CsharpAnswer = "interface",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 16,
                    CsharpQuestion = "What Is A Interface",
                    CsharpAnswer = "An interface is a completely \"abstract class\", which can only contain abstract methods and properties",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 17,
                    CsharpQuestion = "Why Would We Use Abstract",
                    CsharpAnswer = "To achieve security - hide certain details and only show the important details of an object",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 18,
                    CsharpQuestion = "What Keyword Makes Data Abstraction",
                    CsharpAnswer = "abstract",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 19,
                    CsharpQuestion = "What Is Data Abstraction In C#",
                    CsharpAnswer = "Data abstraction is the process of hiding certain details and showing only essential information to the user",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 20,
                    CsharpQuestion = "What Is A Sealed Used For",
                    CsharpAnswer = "it is used If you don't want other classes to inherit from a class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 21,
                    CsharpQuestion = "To Inherit From A Class What Symbol Is Used",
                    CsharpAnswer = "A \":\" is used",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 22,
                    CsharpQuestion = "What Is Another Name For A Base Class",
                    CsharpAnswer = "Parent Class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 23,
                    CsharpQuestion = "What Is Another Name For A Derived Class",
                    CsharpAnswer = "Child Class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 24,
                    CsharpQuestion = "What Is A Base Class",
                    CsharpAnswer = "the class being inherited from",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 25,
                    CsharpQuestion = "What Is A Derived Class",
                    CsharpAnswer = "it is the class that inherits from another class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 26,
                    CsharpQuestion = "Why Do We Inheritance Code In C#",
                    CsharpAnswer = " It is useful for code reusability: reuse fields and methods of an existing class when you create a new class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 27,
                    CsharpQuestion = "How Do You Short Hand A Property",
                    CsharpAnswer = "you have to write get; and set; inside the property",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 28,
                    CsharpQuestion = "What Does A Set Method Do",
                    CsharpAnswer = "The set method assigns a value to the variable",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 29,
                    CsharpQuestion = "What Does A Get Method Do",
                    CsharpAnswer = "The get method returns the value of the variable",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 30,
                    CsharpQuestion = "What Is A Property",
                    CsharpAnswer = "A property is like a combination of a variable and a method, and it has two methods: a get and a set method",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 31,
                    CsharpQuestion = "What Does Internal Do",
                    CsharpAnswer = "makes the code only accessible within its own assembly, but not from another assembly",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 32,
                    CsharpQuestion = "What Does Protected Do",
                    CsharpAnswer = "makes the code accessible within the same class, or in a class that is inherited from that class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 33,
                    CsharpQuestion = "What Does Private Do",
                    CsharpAnswer = "makes the code only accessible within the same class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 34,
                    CsharpQuestion = "What Does Public Do",
                    CsharpAnswer = "makes the code accessible for all classes",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 35,
                    CsharpQuestion = "What Are The Two Access Modifiers That Have Combinations",
                    CsharpAnswer = "protected internal , private protected",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 36,
                    CsharpQuestion = "What Access Modifiers Are There",
                    CsharpAnswer = "public , private , protected , internal",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 37,
                    CsharpQuestion = "What Are Access Modifiers Used For",
                    CsharpAnswer = "it is used to set the access level/visibility for classes, fields, methods and properties",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 38,
                    CsharpQuestion = "Why Would You Use A Constructor",
                    CsharpAnswer = "constructors save time! , they help reducing the amount of code",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 39,
                    CsharpQuestion = "Can  Constructor Take Parameters",
                    CsharpAnswer = "Constructors can also take parameters, which is used to initialize fields",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 40,
                    CsharpQuestion = "Should The Constructor Have The Same Name As The Class",
                    CsharpAnswer = "constructor name must match the class name",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 41,
                    CsharpQuestion = "What Is A Constructor",
                    CsharpAnswer = "A constructor is a special method that is used to initialize objects",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 42,
                    CsharpQuestion = "What Are Class Members",
                    CsharpAnswer = "Fields and methods inside classes are often referred to as \"Class Members\"",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 43,
                    CsharpQuestion = "Can You Use Multiple Objects In One Class",
                    CsharpAnswer = "Yes, You can create multiple objects of one class",
                    CodeAnswer=""
                },


                new CsharpCardModel()
                {
                    Id = 44,
                    CsharpQuestion = "How Do You Make A Object",
                    CsharpAnswer = "To create an object of Car, specify the class name, followed by the object name, and use the keyword new",
                    CodeAnswer =""
                },

                new CsharpCardModel()
                {
                    Id = 45,
                    CsharpQuestion = "How Do You Make A Class",
                    CsharpAnswer = "you make a class using the keyword class",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 46,
                    CsharpQuestion = "What Does Oop Stand For",
                    CsharpAnswer = "OOP stands for Object-Oriented Programming",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 47,
                    CsharpQuestion = "How Many Parameters Can You Have In A Method",
                    CsharpAnswer = "You can add as many parameters as you want, just separate them with a comma",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 48,
                    CsharpQuestion = "What Are The Vaules You Pass Into A Parameter Called",
                    CsharpAnswer = "Arguments",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 49,
                    CsharpQuestion = "What Are Method Parameters",
                    CsharpAnswer = "Information that can be passed to methods as parameter. Parameters act as variables inside the method.",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 50,
                    CsharpQuestion = "How Do You Call A Method",
                    CsharpAnswer = " write the method's name followed by two parentheses () and a semicolon",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 51,
                    CsharpQuestion = "How Do You Make A Method",
                    CsharpAnswer = "A method is made with the name of the method, followed by parentheses ()",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 52,
                    CsharpQuestion = "What Is A Method",
                    CsharpAnswer = "A method is a block of code which only runs when it is called",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 53,
                    CsharpQuestion = "What Does Sort() Do To A Array",
                    CsharpAnswer = "Sort will sort an array alphabetically or in an ascending order",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 54,
                    CsharpQuestion = "How Do You Loop Through An Array",
                    CsharpAnswer = "You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 55,
                    CsharpQuestion = "What Does .Length Do To A Array",
                    CsharpAnswer = "finds out how many elements an array has",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 56,
                    CsharpQuestion = "How Do You Change An Array Element",
                    CsharpAnswer = "To change the value of a specific element, refer to the index number and then set the vaule to other variable",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 57,
                    CsharpQuestion = "How Do You Access The Elements Of An Array",
                    CsharpAnswer = "You access an array element by referring to the index number",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 58,
                    CsharpQuestion = "What Are Arrays Used For",
                    CsharpAnswer = "Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 59,
                    CsharpQuestion = "What Does Continue Do In A Loop",
                    CsharpAnswer = "continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 60,
                    CsharpQuestion = "What Does A Break Do In A Loop",
                    CsharpAnswer = "break statement can be used to jump out of a loop",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 61,
                    CsharpQuestion = "What Is A Foreach Loop For",
                    CsharpAnswer = "foreach loop is used exclusively to loop through elements in an array",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 62,
                    CsharpQuestion = "What Does A For Loop Do",
                    CsharpAnswer = "For Loop will loop through a specific number of times",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 63,
                    CsharpQuestion = "What Does A Do/While Loop Do",
                    CsharpAnswer = "Do/While loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 64,
                    CsharpQuestion = "What Does Default Do In A Switch Statement ",
                    CsharpAnswer = "default specifies some code to run if there is no case match",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 65,
                    CsharpQuestion = "What Does Break Do In A Switch Statement",
                    CsharpAnswer = "break when a match is found will stop the execution of more code and case testing inside the block",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 66,
                    CsharpQuestion = "What Does A  Switch Statement Do",
                    CsharpAnswer = "A switch statement is used to select one of many code blocks to be executed",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 67,
                    CsharpQuestion = "Why Would You Use Ternary Operators",
                    CsharpAnswer = " you can use it to replace multiple lines of code with a single line. It is often used to replace simple if else statements",
                    CodeAnswer=""
                },
                
                new CsharpCardModel()
                {
                    Id = 68,
                    CsharpQuestion = "What Do If Else Ternary Operators Look Like",
                    CsharpAnswer = "\"?\" is the if statement ternary operator and : is the else statement ternary operator",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 69,
                    CsharpQuestion = "What Does A Else If Statement Do",
                    CsharpAnswer = "you use a else if statement to specify a new condition if the first condition is False",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 70,
                    CsharpQuestion = "What Does A Else Statement Do",
                    CsharpAnswer = "you use a else statement to specify a block of code to be executed if the condition is False",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 71,
                    CsharpQuestion = "What Does A If Statement Do",
                    CsharpAnswer = "you use a if statement to specify a block of C# code to be executed if a condition is True",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 72,
                    CsharpQuestion = "What Are The If Statements And Conditions Called",
                    CsharpAnswer = "if , if else , else , switch",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 73,
                    CsharpQuestion = "What Does A Boolean Expression Do",
                    CsharpAnswer = "Boolean Expression uses a comparison operator, such as the greater than (>) operator to find out if an expression (or a variable) is true",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 74,
                    CsharpQuestion = "How Do You Make A Vaule Type Boolean",
                    CsharpAnswer = "you declare it has bool then vaule name",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {   
                    Id = 75,
                    CsharpQuestion = "What Are The Two Vaules A Boolean Has",
                    CsharpAnswer = "the vaules are true , false",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 76,
                    CsharpQuestion = "How Many Vaules Does A Boolean Have",
                    CsharpAnswer = "A boolean has two vaules",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 77,
                    CsharpQuestion = "What Are The Three Ways To Do String Concatenation",
                    CsharpAnswer = " using \"+\" and .Concat() or String Interpolation",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 78,
                    CsharpQuestion = "What Is String Concatenation",
                    CsharpAnswer = "String Concatenation is when you combine to strings together",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 79,
                    CsharpQuestion = "What Does .Length Do",
                    CsharpAnswer = "it find the length of a string or array",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 80,
                    CsharpQuestion = "What Does .Tolower Do",
                    CsharpAnswer = "it makes all letters in a string lower case",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 81,
                    CsharpQuestion = "What Does .Toupper Do",
                    CsharpAnswer = "it makes all letters in a string upper case",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 82,
                    CsharpQuestion = "What Methods Can You Use On Type String",
                    CsharpAnswer = ".Length ,  .ToUpper() , ToLower()",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 83,
                    CsharpQuestion = "What Does Math.Round Do",
                    CsharpAnswer = "Math.Round rounds a number to the nearest whole number",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 84,
                    CsharpQuestion = "What Does Math.Abs Do",
                    CsharpAnswer = "Math.Abs returns the absolute (positive) value of x",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 85,
                    CsharpQuestion = "What Does Math.Sqrt Do",
                    CsharpAnswer = "Math.Sqrt returns the square root of x",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 86,
                    CsharpQuestion = "What Does Math.Min Do",
                    CsharpAnswer = "Math.min can be used to find the lowest value of of x and y",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 87,
                    CsharpQuestion = "What Does Math.Max Do",
                    CsharpAnswer = "Math.Max can be used to find the highest value of x and y",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 88,
                    CsharpQuestion = "What Methods Does Math Have In C#",
                    CsharpAnswer = "Max , Min , Sqrt , Abs , Round",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 89,
                    CsharpQuestion = "What Does The \"!\" Operator Do",
                    CsharpAnswer = "Reverse the result, returns false if the result is true",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 90,
                    CsharpQuestion = "What Does The \"||\" Operator Do",
                    CsharpAnswer = "Returns true if one of the statements is true",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 91,
                    CsharpQuestion = "What Does The \"&&\" Operator Do",
                    CsharpAnswer = "Returns true if both statements are true",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 92,
                    CsharpQuestion = "What Do Logical Operators Do",
                    CsharpAnswer = "Logical operators are used to determine the logic between variables or values",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 93,
                    CsharpQuestion = "What Do Logical Operators Look Like",
                    CsharpAnswer = "\"|| , && , ! \"",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 94,
                    CsharpQuestion = "What Does The \"<=\" Operator Do",
                    CsharpAnswer = "checks if the vaule is less than or equal to the other value ",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 95,
                    CsharpQuestion = "What Does The \">=\" Operator Do",
                    CsharpAnswer = "checks if the vaule is greater than or equal to the other value ",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 96,
                    CsharpQuestion = "What Does The \"<\" Operator Do",
                    CsharpAnswer = "checks if the vaule is less than the other vaule",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 97,
                    CsharpQuestion = "What Does The \">\" Operator Do",
                    CsharpAnswer = "checks if the vaule is greater than the other vaule",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 98,
                    CsharpQuestion = "What Does The \"!=\" Operator Do",
                    CsharpAnswer = "checks if vaules are not equal to each other",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 99,
                    CsharpQuestion = "What Does The \"==\" Operator Do",
                    CsharpAnswer = "checks if both vaules are equal to each other",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 100,
                    CsharpQuestion = "What Do Comparison Operators Do",
                    CsharpAnswer = "Comparison operators are used to compare two values",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 101,
                    CsharpQuestion = "What Do Comparison Operators Look Like",
                    CsharpAnswer = "\"== , != , > , < , >= , <=\"",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 102,
                    CsharpQuestion = "What Does The Default  Assignment Operator Look Like",
                    CsharpAnswer = "\"=\"",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 103,
                    CsharpQuestion = "What Do Assignment Operators Do",
                    CsharpAnswer = "Assignment operators are used to assign values to variables.",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 104,
                    CsharpQuestion = "What Does \"--\" Operator Do?",
                    CsharpAnswer = "Decreases the value of a variable by 1",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 105,
                    CsharpQuestion = "What Does \"++\" Operator Do?",
                    CsharpAnswer = "Increases the value of a variable by 1",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 106,
                    CsharpQuestion = "What Does * Operator Do?",
                    CsharpAnswer = "Multiplies two values",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 107,
                    CsharpQuestion = "What Does \"%\" Operator Do?",
                    CsharpAnswer = "Returns the division remainder",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 108,
                    CsharpQuestion = "What Does \"/\" Operator Do?",
                    CsharpAnswer = "Divides one value by another",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 109,
                    CsharpQuestion = "What Does \"-\" Operator Do?",
                    CsharpAnswer = "Subtracts one value from another",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 110,
                    CsharpQuestion = "What Does \"+\" Operator Do?",
                    CsharpAnswer = "Adds together two values",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 111,
                    CsharpQuestion = "What Do Arithmetic Operators Look Like",
                    CsharpAnswer = "- + = * / % ++ --",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 112,
                    CsharpQuestion = "What Does A Console.Writeline() Do",
                    CsharpAnswer = "it outputs values aka prints values",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 113,
                    CsharpQuestion = "What Does A Console.Readline() Do",
                    CsharpAnswer = "it gets a user's input",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 114,
                    CsharpQuestion = "What Are The Type Conversion Methods",
                    CsharpAnswer = "Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 115,
                    CsharpQuestion = "What Does Explicit Casting",
                    CsharpAnswer = "manually converting a larger number type to a smaller size number type",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 116,
                    CsharpQuestion = "What Does Implicit Casting Do",
                    CsharpAnswer = "automatically converting a smaller number type to a larger number type size",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 117,
                    CsharpQuestion = "What Data Types Can Store Scientific Numbers",
                    CsharpAnswer = "float and double",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 118,
                    CsharpQuestion = "What Is A Float",
                    CsharpAnswer = "float data type can store fractional numbers from 3.4e−038 to 3.4e+038. Note that you should end the value with an \"F\"",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 119,
                    CsharpQuestion = "What Is The Unique Names Of Variables Called?",
                    CsharpAnswer = "These unique names are called identifiers",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 120,
                    CsharpQuestion = "What Does Lond Do",
                    CsharpAnswer = "This is used when int is not large enough to store the value. Note that you should end the value with an \"L\"",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 121,
                    CsharpQuestion = "What Does Const Do",
                    CsharpAnswer = "this will declare the variable as \"constant\", which means unchangeable and read-only",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 122,
                    CsharpQuestion = "What Is A Bool",
                    CsharpAnswer = "stores values with two states: true or false",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 123,
                    CsharpQuestion = "What Is A String",
                    CsharpAnswer = "stores text, such as \"Hello World\". String values are surrounded by double quotes",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 124,
                    CsharpQuestion = "What Is A Char",
                    CsharpAnswer = "stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {
                    Id = 125,
                    CsharpQuestion = "What Is A Double",
                    CsharpAnswer = "A double stores floating point numbers that also have decimals",
                    CodeAnswer=""
                },

                new CsharpCardModel()
                {   
                    Id = 126,
                    CsharpQuestion = "What Is A Int",
                    CsharpAnswer = "A int stores a whole number",
                    CodeAnswer=""
                }
            };
            
            var HtmlCards = new List<HtmlCardModel>()
            {
                
                new HtmlCardModel(){
                    Id = 1,
                    HtmlQuestion = "What Does Html Stand For",
                    HtmlAnswer = "HTML stands for Hyper Text Markup Language",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 2,
                    HtmlQuestion = "What Is An Html Element",
                    HtmlAnswer = "HTML element is defined by a start tag, some content, and an end tag",
                    CodeAnswer = ""
                },

                 new HtmlCardModel(){
                    Id = 3,
                    HtmlQuestion = "What Does The <!Doctype Html> Tag Do",
                    HtmlAnswer = "The <!DOCTYPE html> declaration defines that this document is an HTML5 document",
                    CodeAnswer = ""
                },

                 new HtmlCardModel(){
                    Id = 4,
                    HtmlQuestion = "What Does The Autoplay Attribute Do To A <Audio> Tag",
                    HtmlAnswer = "The autoplay attribute starts the a audio file automatically",
                    CodeAnswer = ""
                },

                 new HtmlCardModel(){
                    Id = 5,
                    HtmlQuestion = "What Does The Html <Audio> Element Do",
                    HtmlAnswer = "The HTML <audio> element is used to play an audio file on a web page",
                    CodeAnswer = ""
                },

                 new HtmlCardModel(){
                    Id = 6,
                    HtmlQuestion = "What Does The Autoplay Attribute Do To A <Video> Tag",
                    HtmlAnswer = "The autoplay attribute starts a video automatically",
                    CodeAnswer = ""
                },

                 new HtmlCardModel(){
                    Id = 7,
                    HtmlQuestion = "What Does A <Video> Tag Do",
                    HtmlAnswer = "The <video> tag is used to embed video content in a document, such as a movie clip or other video streams",
                    CodeAnswer = ""
                },

                 new HtmlCardModel(){
                    Id = 8,
                    HtmlQuestion = "What Character Do You Get When You Use &Reg;",
                    HtmlAnswer = "You get this (®)",
                    CodeAnswer = ""
                },

                 new HtmlCardModel(){
                    Id = 9,
                    HtmlQuestion = "What Character Do You Get When You Use &Copy;",
                    HtmlAnswer = "You get this (©)",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 10,
                    HtmlQuestion = "What Are Html Entities",
                    HtmlAnswer = "Some characters are reserved in HTML",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 11,
                    HtmlQuestion = "What Does A <Section> Element Do",
                    HtmlAnswer = "The <section> tag defines a section in a document",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 12,
                    HtmlQuestion = "What Does A <Nav> Element Do",
                    HtmlAnswer = "The <nav> tag defines a set of navigation links",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 13,
                    HtmlQuestion = "What Does A <Mark> Element Do",
                    HtmlAnswer = "The <mark> tag defines text that should be marked or highlighted",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 14,
                    HtmlQuestion = "What Does A <Main> Element Do",
                    HtmlAnswer = "The <main> tag specifies the main content of a document",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 15,
                    HtmlQuestion = "What Does A <Hearder> Element Do",
                    HtmlAnswer = "The <header> element represents a container for introductory content or a set of navigational links",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 16,
                    HtmlQuestion = "What Are Some Semantic Elements",
                    HtmlAnswer = "<header> <main> <mark> <nav> <section>",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 17,
                    HtmlQuestion = "What Is A Semantic Element",
                    HtmlAnswer = "A semantic element clearly describes its meaning to both the browser and the developer",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 18,
                    HtmlQuestion = "What Does The Html <Footer> Element Do",
                    HtmlAnswer = "The <footer> element defines a footer for a document or section",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 19,
                    HtmlQuestion = "What Is Html <Var> Tag Used For",
                    HtmlAnswer = "The HTML <var> element  is used to define a variable in programming or in a mathematical expression",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 20,
                    HtmlQuestion = "What Is Html <Code> Tag Used For",
                    HtmlAnswer = "The HTML <code> element  is used to define a piece of computer code",
                    CodeAnswer = ""
                },

                 new HtmlCardModel()
                {
                    Id = 21,
                    HtmlQuestion = "What Is Html <Samp> Tag Used For",
                    HtmlAnswer = "The HTML <samp> element is used to define sample output from a computer program",
                    CodeAnswer = ""
                },
                    new HtmlCardModel(){
                    Id = 22,
                    HtmlQuestion = "What Is Html <Kbd> Tag Used For",
                    HtmlAnswer = "The HTML <kbd> element is used to define keyboard input. The content inside is displayed in the browser's default monospace font",
                    CodeAnswer = ""
                },
                    new HtmlCardModel(){
                    Id = 23,
                    HtmlQuestion = "What Does The Html <Meta> Element Do",
                    HtmlAnswer = "The <meta> element is typically used to specify the character set, page description, keywords, author of the document, and viewport settings",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 24,
                    HtmlQuestion = "What Does The Html <Link> Element Do",
                    HtmlAnswer = "The <link> element defines the relationship between the current document and an external resource",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 25,
                    HtmlQuestion = "What Does A <Script> Tag Do",
                    HtmlAnswer = "The HTML <script> tag is used to define a client-side script (JavaScript)",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 26,
                    HtmlQuestion = "What Does The Html <Title> Element Do",
                    HtmlAnswer = "The <title> element defines the title of the document. The title must be text-only, and it is shown in the browser's title bar or in the page's tab",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 27,
                    HtmlQuestion = "What Does The Html <Head> Element Do",
                    HtmlAnswer = "The <head> element is a container for metadata (data about data) and is placed between the <html> tag and the <body> tag",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 28,
                    HtmlQuestion = "What Is A Relative File Path",
                    HtmlAnswer = "A relative file path points to a file relative to the current page",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 29,
                    HtmlQuestion = "What Is A Absolute File Path",
                    HtmlAnswer = "An absolute file path is the full URL to a file",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 30,
                    HtmlQuestion = "What Is A Html File Path",
                    HtmlAnswer = "A file path describes the location of a file in a web site's folder structure",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 31,
                    HtmlQuestion = "What Does The Html Iframe Used For",
                    HtmlAnswer = "An HTML iframe is used to display a web page within a web page",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 32,
                    HtmlQuestion = "Can You Use The Same Id On Multiple Html Elements",
                    HtmlAnswer = "no, You cannot have more than one element with the same id in an HTML document",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 33,
                    HtmlQuestion = "What Does A Id Attribute Do",
                    HtmlAnswer = "The HTML id attribute is used to specify a unique id for an HTML element",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 34,
                    HtmlQuestion = "Can You Use Multiple Classes On One Html Element",
                    HtmlAnswer = "yes you can use multiple classes on one HTML element",
                    CodeAnswer = ""
                },

                new HtmlCardModel(){
                    Id = 35,
                    HtmlQuestion = "Can You Use The Same Class On Multiple Html Elements",
                    HtmlAnswer = "yes, Multiple HTML elements can share the same class",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 36,
                    HtmlQuestion = "What Does A Class Attribute Do",
                    HtmlAnswer = "The HTML class attribute is used to specify a class for an HTML element",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 37,
                    HtmlQuestion = "What Does A <Span> Tag Do",
                    HtmlAnswer = "The <span> tag is an inline container used to mark up a part of a text, or a part of a document.",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 38,
                    HtmlQuestion = "What Is A <Div> Tag Mostly Used For",
                    HtmlAnswer = "The <div> tag is used as a container for HTML elements",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 39,
                    HtmlQuestion = "What Does A <Div> Tag Do",
                    HtmlAnswer = "The <div> tag defines a division or a section in an HTML document",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 40,
                    HtmlQuestion = "What Does A Inline Element Do",
                    HtmlAnswer = "An inline element does not start on a new line. Also an inline element only takes up as much width as necessary.",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 41,
                    HtmlQuestion = "What Does A Block-Level Element Do",
                    HtmlAnswer = "A block-level element always starts on a new line. Also a block-level element always takes up the full width available (stretches out to the left and right as far as it can). Also a block level element has a top and a bottom margin",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 42,
                    HtmlQuestion = "Can Lists Be Nested",
                    HtmlAnswer = "Lists can be nested (list inside list)",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 43,
                    HtmlQuestion = "What Does A <Dd> Tag Do",
                    HtmlAnswer = "The <dd> tag is used to describe a term/name in a description list",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 44,
                    HtmlQuestion = "What Does A <Dt> Tag Do",
                    HtmlAnswer = "The <dt> tag defines a term/name in a description list",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 45,
                    HtmlQuestion = "What Does A <Dl> Tag Do",
                    HtmlAnswer = "The <dl> tag defines a description list",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 46,
                    HtmlQuestion = "What Does A <Ol> Tag Do",
                    HtmlAnswer = "The <ol> tag defines an ordered list. An ordered list can be numerical or alphabetical",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 47,
                    HtmlQuestion = "What Does A <Li> Tag Do",
                    HtmlAnswer = "The <li> tag defines a list item",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 48,
                    HtmlQuestion = "What Does A <Ul> Tag Do",
                    HtmlAnswer = "The <ul> tag defines an unordered (bulleted) list",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 49,
                    HtmlQuestion = "What Does A <Th> Tag Do",
                    HtmlAnswer = "The <th> tag defines a header cell in an HTML table",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 50,
                    HtmlQuestion = "What Does A <Tr> Tag Do",
                    HtmlAnswer = "The <tr> tag defines a row in an HTML table",
                    CodeAnswer = ""
                },new HtmlCardModel(){
                    Id = 51,
                    HtmlQuestion = "What Does A <Td> Tag Do",
                    HtmlAnswer = "The <td> tag defines a standard data cell in an HTML table",
                    CodeAnswer = ""
                },
                 new HtmlCardModel(){
                    Id = 52,
                    HtmlQuestion = "What Does A <Table> Tag Do",
                    HtmlAnswer = "The <table> tag defines an HTML table",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 53,
                    HtmlQuestion = "What Tags Are Used In A Html Tables",
                    HtmlAnswer = "<table> <tr> <td> <th>",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 54,
                    HtmlQuestion = "What Does _Top Do",
                    HtmlAnswer = "_top - Opens the document in the full body of the window",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 55,
                    HtmlQuestion = "What Does _ Parent Do",
                    HtmlAnswer = "_parent - Opens the document in the parent fram",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 56,
                    HtmlQuestion = "What Does _Blank Do",
                    HtmlAnswer = "_blank - Opens the document in a new window or tab",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 57,
                    HtmlQuestion = "What Does  _Self Do",
                    HtmlAnswer = "_self - Default. Opens the document in the same window/tab as it was clicked",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 58,
                    HtmlQuestion = "What Are The Vaules A Target Attribute Can Have",
                    HtmlAnswer = "_self , _blank , _parent , _top",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 59,
                    HtmlQuestion = "What Does The Target Attribute Do To <A> Element",
                    HtmlAnswer = "The target attribute specifies where to open the linked document",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 60,
                    HtmlQuestion = "What Does A <!-- -->  Element Do",
                    HtmlAnswer = "the <!-- --> comments anything inside the <!-- kinda like this --> that will not display that text in the ui",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 61,
                    HtmlQuestion = "What Does A <Abbr> Element Do",
                    HtmlAnswer = "the <abbr> tag defines an abbreviation or an acronym, like HTML, CSS, Mr., Dr., ASAP, ATM",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 62,
                    HtmlQuestion = "What Does A <Q> Element Do",
                    HtmlAnswer = "the <q> tag defines a short quotation",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 63,
                    HtmlQuestion = "What Does A <Blockquote> Element Do",
                    HtmlAnswer = "the <blockquote> element defines a section that is quoted from another source",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 64,
                    HtmlQuestion = "What Does A <I> Element Do",
                    HtmlAnswer = "The <i> element makes text Italic",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 65,
                    HtmlQuestion = "What Does A <B> Element Do",
                    HtmlAnswer = "the <b> element makes text Bold",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 66,
                    HtmlQuestion = "What Does A <Pre> Element Do",
                    HtmlAnswer = "the <pre> element defines preformatted text",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 67,
                    HtmlQuestion = "What Does A Title Attribute Do",
                    HtmlAnswer = "The title attribute defines some extra information about an element",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 68,
                    HtmlQuestion = "What Does A Lang Attribute Do",
                    HtmlAnswer = "You should always include the lang attribute inside the <html> tag, to declare the language of the Web page. This is meant to assist search engines and browsers",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 69,
                    HtmlQuestion = "What Does A Style Attribute Do",
                    HtmlAnswer = "The style attribute is used to add styles to an element, such as color, font, size, and more",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 70,
                    HtmlQuestion = "Why Would You Use A Alt Attribute",
                    HtmlAnswer = "you want to use it if the image for some reason cannot be displayed. This can be due to slow connection, or an error in the src attribute, or if the user uses a screen reader",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 71,
                    HtmlQuestion = "What Does A Alt Attribute Do To A <Img>",
                    HtmlAnswer = "specifies an alternate text for an image",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 72,
                    HtmlQuestion = "What Does A Height Attribute Do To A <Img>",
                    HtmlAnswer = "specifies the height of a image in pixels",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 73,
                    HtmlQuestion = "What Does A Width Attribute Do To A <Img>",
                    HtmlAnswer = "specifies the width of a image in pixels",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 74,
                    HtmlQuestion = "What Does A Src Attribute Do To A <Img>",
                    HtmlAnswer = "The src attribute specifies the path to the image to be displayed",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 75,
                    HtmlQuestion = "What Does A <Img> Element Do",
                    HtmlAnswer = "The <img> tag is used to embed an image in an HTML page",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 76,
                    HtmlQuestion = "What Does A Href Attribute Do",
                    HtmlAnswer = "The href attribute specifies the URL of the page the link goes to on <a> tag",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 77,
                    HtmlQuestion = "What Is A Html Attribute",
                    HtmlAnswer = "HTML attributes provide additional information about HTML elements",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 78,
                    HtmlQuestion = "What Does A <A> Element Do",
                    HtmlAnswer = "The <a> element defines a HTML link",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 79,
                    HtmlQuestion = "What Does A <Hr/> Element Do",
                    HtmlAnswer = "The <hr/> element produces a line and spacing under the previous element",
                    CodeAnswer = ""
                },

                new HtmlCardModel(){
                    Id = 80,
                    HtmlQuestion = "What Is A Empty Element",
                    HtmlAnswer = "some HTML elements have no content (like the <br/> element), Empty elements do not have an end tag!",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 81,
                    HtmlQuestion = "What Does The <Br/> Element Do",
                    HtmlAnswer = "The <br/> element produces a line break in text",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 82,
                    HtmlQuestion = "What Does The <P> Element Do",
                    HtmlAnswer = "The <p> element defines a paragraph",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 83,
                    HtmlQuestion = "How Many Heading Elements Are There",
                    HtmlAnswer = "There are 6 heading, the 6 headings are <h1> - <h6>",
                    CodeAnswer = ""
                },

                new HtmlCardModel(){
                    Id = 84,
                    HtmlQuestion = "What Does The <H1> <H2> <H3> <H4> <H5> <H6> Elements Do",
                    HtmlAnswer = "The <h1> <h2> <h3> <h4> <h5> <h6> elements defines a heading, the lower the numbr the bigger the heading",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 85,
                    HtmlQuestion = "What Does The <Body> Element Do",
                    HtmlAnswer = "The <body> element defines the document's body, and is a container for all the visible contents, such as headings, paragraphs, images, hyperlinks, tables, lists, etc",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 86,
                    HtmlQuestion = "What Does The <Title> Element Do",
                    HtmlAnswer = "The <title> element specifies a title for the HTML page (which is shown in the browser's title bar or in the page's tab)",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 87,
                    HtmlQuestion = "What Does The <Head> Element Do",
                    HtmlAnswer = "The <head> element contains meta information about the HTML page",
                    CodeAnswer = ""
                },
                new HtmlCardModel(){
                    Id = 88,
                    HtmlQuestion = "What Does The <Html> Element Do",
                    HtmlAnswer = "The <html> element is the root element of an HTML page",
                    CodeAnswer = ""
                },
            };
            
            builder.Entity<CsharpCardModel>().HasData(CsharpCards);
            builder.Entity<HtmlCardModel>().HasData(HtmlCards);
        }
    }
}