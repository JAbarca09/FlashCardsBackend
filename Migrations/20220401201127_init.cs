using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CsharpFlashCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CsharpQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CsharpAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CsharpFlashCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtmlFlashCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HtmlQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HtmlAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlFlashCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CsharpFlashCards",
                columns: new[] { "Id", "CodeAnswer", "CsharpAnswer", "CsharpQuestion" },
                values: new object[,]
                {
                    { 1, "", "WriteLine prints the output on a new line each time", "What Is A Writeline" },
                    { 2, "", "Write prints on the same line", "What Is A Write" },
                    { 3, "", "Any text between // and the end of the line is ignored by C#", "What Does // Do" },
                    { 4, "", "The throw statement allows you to create a custom error", "What Does Throw Do" },
                    { 5, "", "The finally statement lets you execute code, after try...catch, regardless of the result", "What Does Finally D0" },
                    { 6, "", "you should always use them together,", "Should You Use A Try And Catch" },
                    { 7, "", "A catch statement allows you to define a block of code to be executed, if an error occurs in the try block", "What Does A Catch Statement Do" },
                    { 8, "", "A try statement allows you to define a block of code to be tested for errors while it is being executed", "What Does A Try Statement Do" },
                    { 9, "", "yes , you can also have an enum inside a class", "Can Enums Be Used In Classes" },
                    { 10, "", "To create an enum, use the enum keyword (instead of class or interface)", "How Do You Create A Enum" },
                    { 11, "", "you use enums when you have values that you know aren't going to change", "Why Would You Use Enum" },
                    { 12, "", "An enum is a special \"class\" that represents a group of constants (unchangeable/read-only variables)", "What Is A Enum" },
                    { 13, "", "yes, to implement multiple interfaces, separate them with a comma", "Can You Have Multiple Interfaces" },
                    { 14, "", "C# does not support \"multiple inheritance\" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces", "Why Use A Interface Over Abstract" },
                    { 15, "", "interface", "What Keyword Makes A Interface" },
                    { 16, "", "An interface is a completely \"abstract class\", which can only contain abstract methods and properties", "What Is A Interface" },
                    { 17, "", "To achieve security - hide certain details and only show the important details of an object", "Why Would We Use Abstract" },
                    { 18, "", "abstract", "What Keyword Makes Data Abstraction" },
                    { 19, "", "Data abstraction is the process of hiding certain details and showing only essential information to the user", "What Is Data Abstraction In C#" },
                    { 20, "", "it is used If you don't want other classes to inherit from a class", "What Is A Sealed Used For" },
                    { 21, "", "A \":\" is used", "To Inherit From A Class What Symbol Is Used" },
                    { 22, "", "Parent Class", "What Is Another Name For A Base Class" },
                    { 23, "", "Child Class", "What Is Another Name For A Derived Class" },
                    { 24, "", "the class being inherited from", "What Is A Base Class" },
                    { 25, "", "it is the class that inherits from another class", "What Is A Derived Class" },
                    { 26, "", " It is useful for code reusability: reuse fields and methods of an existing class when you create a new class", "Why Do We Inheritance Code In C#" },
                    { 27, "", "you have to write get; and set; inside the property", "How Do You Short Hand A Property" },
                    { 28, "", "The set method assigns a value to the variable", "What Does A Set Method Do" },
                    { 29, "", "The get method returns the value of the variable", "What Does A Get Method Do" },
                    { 30, "", "A property is like a combination of a variable and a method, and it has two methods: a get and a set method", "What Is A Property" },
                    { 31, "", "makes the code only accessible within its own assembly, but not from another assembly", "What Does Internal Do" },
                    { 32, "", "makes the code accessible within the same class, or in a class that is inherited from that class", "What Does Protected Do" },
                    { 33, "", "makes the code only accessible within the same class", "What Does Private Do" },
                    { 34, "", "makes the code accessible for all classes", "What Does Public Do" },
                    { 35, "", "protected internal , private protected", "What Are The Two Access Modifiers That Have Combinations" },
                    { 36, "", "public , private , protected , internal", "What Access Modifiers Are There" },
                    { 37, "", "it is used to set the access level/visibility for classes, fields, methods and properties", "What Are Access Modifiers Used For" },
                    { 38, "", "constructors save time! , they help reducing the amount of code", "Why Would You Use A Constructor" },
                    { 39, "", "Constructors can also take parameters, which is used to initialize fields", "Can  Constructor Take Parameters" },
                    { 40, "", "constructor name must match the class name", "Should The Constructor Have The Same Name As The Class" },
                    { 41, "", "A constructor is a special method that is used to initialize objects", "What Is A Constructor" },
                    { 42, "", "Fields and methods inside classes are often referred to as \"Class Members\"", "What Are Class Members" }
                });

            migrationBuilder.InsertData(
                table: "CsharpFlashCards",
                columns: new[] { "Id", "CodeAnswer", "CsharpAnswer", "CsharpQuestion" },
                values: new object[,]
                {
                    { 43, "", "Yes, You can create multiple objects of one class", "Can You Use Multiple Objects In One Class" },
                    { 44, "", "To create an object of Car, specify the class name, followed by the object name, and use the keyword new", "How Do You Make A Object" },
                    { 45, "", "you make a class using the keyword class", "How Do You Make A Class" },
                    { 46, "", "OOP stands for Object-Oriented Programming", "What Does Oop Stand For" },
                    { 47, "", "You can add as many parameters as you want, just separate them with a comma", "How Many Parameters Can You Have In A Method" },
                    { 48, "", "Arguments", "What Are The Vaules You Pass Into A Parameter Called" },
                    { 49, "", "Information that can be passed to methods as parameter. Parameters act as variables inside the method.", "What Are Method Parameters" },
                    { 50, "", " write the method's name followed by two parentheses () and a semicolon", "How Do You Call A Method" },
                    { 51, "", "A method is made with the name of the method, followed by parentheses ()", "How Do You Make A Method" },
                    { 52, "", "A method is a block of code which only runs when it is called", "What Is A Method" },
                    { 53, "", "Sort will sort an array alphabetically or in an ascending order", "What Does Sort() Do To A Array" },
                    { 54, "", "You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run", "How Do You Loop Through An Array" },
                    { 55, "", "finds out how many elements an array has", "What Does .Length Do To A Array" },
                    { 56, "", "To change the value of a specific element, refer to the index number and then set the vaule to other variable", "How Do You Change An Array Element" },
                    { 57, "", "You access an array element by referring to the index number", "How Do You Access The Elements Of An Array" },
                    { 58, "", "Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value", "What Are Arrays Used For" },
                    { 59, "", "continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop", "What Does Continue Do In A Loop" },
                    { 60, "", "break statement can be used to jump out of a loop", "What Does A Break Do In A Loop" },
                    { 61, "", "foreach loop is used exclusively to loop through elements in an array", "What Is A Foreach Loop For" },
                    { 62, "", "For Loop will loop through a specific number of times", "What Does A For Loop Do" },
                    { 63, "", "Do/While loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true", "What Does A Do/While Loop Do" },
                    { 64, "", "default specifies some code to run if there is no case match", "What Does Default Do In A Switch Statement " },
                    { 65, "", "break when a match is found will stop the execution of more code and case testing inside the block", "What Does Break Do In A Switch Statement" },
                    { 66, "", "A switch statement is used to select one of many code blocks to be executed", "What Does A  Switch Statement Do" },
                    { 67, "", " you can use it to replace multiple lines of code with a single line. It is often used to replace simple if else statements", "Why Would You Use Ternary Operators" },
                    { 68, "", "\"?\" is the if statement ternary operator and : is the else statement ternary operator", "What Do If Else Ternary Operators Look Like" },
                    { 69, "", "you use a else if statement to specify a new condition if the first condition is False", "What Does A Else If Statement Do" },
                    { 70, "", "you use a else statement to specify a block of code to be executed if the condition is False", "What Does A Else Statement Do" },
                    { 71, "", "you use a if statement to specify a block of C# code to be executed if a condition is True", "What Does A If Statement Do" },
                    { 72, "", "if , if else , else , switch", "What Are The If Statements And Conditions Called" },
                    { 73, "", "Boolean Expression uses a comparison operator, such as the greater than (>) operator to find out if an expression (or a variable) is true", "What Does A Boolean Expression Do" },
                    { 74, "", "you declare it has bool then vaule name", "How Do You Make A Vaule Type Boolean" },
                    { 75, "", "the vaules are true , false", "What Are The Two Vaules A Boolean Has" },
                    { 76, "", "A boolean has two vaules", "How Many Vaules Does A Boolean Have" },
                    { 77, "", " using \"+\" and .Concat() or String Interpolation", "What Are The Three Ways To Do String Concatenation" },
                    { 78, "", "String Concatenation is when you combine to strings together", "What Is String Concatenation" },
                    { 79, "", "it find the length of a string or array", "What Does .Length Do" },
                    { 80, "", "it makes all letters in a string lower case", "What Does .Tolower Do" },
                    { 81, "", "it makes all letters in a string upper case", "What Does .Toupper Do" },
                    { 82, "", ".Length ,  .ToUpper() , ToLower()", "What Methods Can You Use On Type String" },
                    { 83, "", "Math.Round rounds a number to the nearest whole number", "What Does Math.Round Do" },
                    { 84, "", "Math.Abs returns the absolute (positive) value of x", "What Does Math.Abs Do" }
                });

            migrationBuilder.InsertData(
                table: "CsharpFlashCards",
                columns: new[] { "Id", "CodeAnswer", "CsharpAnswer", "CsharpQuestion" },
                values: new object[,]
                {
                    { 85, "", "Math.Sqrt returns the square root of x", "What Does Math.Sqrt Do" },
                    { 86, "", "Math.min can be used to find the lowest value of of x and y", "What Does Math.Min Do" },
                    { 87, "", "Math.Max can be used to find the highest value of x and y", "What Does Math.Max Do" },
                    { 88, "", "Max , Min , Sqrt , Abs , Round", "What Methods Does Math Have In C#" },
                    { 89, "", "Reverse the result, returns false if the result is true", "What Does The \"!\" Operator Do" },
                    { 90, "", "Returns true if one of the statements is true", "What Does The \"||\" Operator Do" },
                    { 91, "", "Returns true if both statements are true", "What Does The \"&&\" Operator Do" },
                    { 92, "", "Logical operators are used to determine the logic between variables or values", "What Do Logical Operators Do" },
                    { 93, "", "\"|| , && , ! \"", "What Do Logical Operators Look Like" },
                    { 94, "", "checks if the vaule is less than or equal to the other value ", "What Does The \"<=\" Operator Do" },
                    { 95, "", "checks if the vaule is greater than or equal to the other value ", "What Does The \">=\" Operator Do" },
                    { 96, "", "checks if the vaule is less than the other vaule", "What Does The \"<\" Operator Do" },
                    { 97, "", "checks if the vaule is greater than the other vaule", "What Does The \">\" Operator Do" },
                    { 98, "", "checks if vaules are not equal to each other", "What Does The \"!=\" Operator Do" },
                    { 99, "", "checks if both vaules are equal to each other", "What Does The \"==\" Operator Do" },
                    { 100, "", "Comparison operators are used to compare two values", "What Do Comparison Operators Do" },
                    { 101, "", "\"== , != , > , < , >= , <=\"", "What Do Comparison Operators Look Like" },
                    { 102, "", "\"=\"", "What Does The Default  Assignment Operator Look Like" },
                    { 103, "", "Assignment operators are used to assign values to variables.", "What Do Assignment Operators Do" },
                    { 104, "", "Decreases the value of a variable by 1", "What Does \"--\" Operator Do?" },
                    { 105, "", "Increases the value of a variable by 1", "What Does \"++\" Operator Do?" },
                    { 106, "", "Multiplies two values", "What Does * Operator Do?" },
                    { 107, "", "Returns the division remainder", "What Does \"%\" Operator Do?" },
                    { 108, "", "Divides one value by another", "What Does \"/\" Operator Do?" },
                    { 109, "", "Subtracts one value from another", "What Does \"-\" Operator Do?" },
                    { 110, "", "Adds together two values", "What Does \"+\" Operator Do?" },
                    { 111, "", "- + = * / % ++ --", "What Do Arithmetic Operators Look Like" },
                    { 112, "", "it outputs values aka prints values", "What Does A Console.Writeline() Do" },
                    { 113, "", "it gets a user's input", "What Does A Console.Readline() Do" },
                    { 114, "", "Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)", "What Are The Type Conversion Methods" },
                    { 115, "", "manually converting a larger number type to a smaller size number type", "What Does Explicit Casting" },
                    { 116, "", "automatically converting a smaller number type to a larger number type size", "What Does Implicit Casting Do" },
                    { 117, "", "float and double", "What Data Types Can Store Scientific Numbers" },
                    { 118, "", "float data type can store fractional numbers from 3.4e−038 to 3.4e+038. Note that you should end the value with an \"F\"", "What Is A Float" },
                    { 119, "", "These unique names are called identifiers", "What Is The Unique Names Of Variables Called?" },
                    { 120, "", "This is used when int is not large enough to store the value. Note that you should end the value with an \"L\"", "What Does Lond Do" },
                    { 121, "", "this will declare the variable as \"constant\", which means unchangeable and read-only", "What Does Const Do" },
                    { 122, "", "stores values with two states: true or false", "What Is A Bool" },
                    { 123, "", "stores text, such as \"Hello World\". String values are surrounded by double quotes", "What Is A String" },
                    { 124, "", "stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes", "What Is A Char" },
                    { 125, "", "A double stores floating point numbers that also have decimals", "What Is A Double" },
                    { 126, "", "A int stores a whole number", "What Is A Int" }
                });

            migrationBuilder.InsertData(
                table: "HtmlFlashCards",
                columns: new[] { "Id", "CodeAnswer", "HtmlAnswer", "HtmlQuestion" },
                values: new object[,]
                {
                    { 1, "", "HTML stands for Hyper Text Markup Language", "What Does Html Stand For" },
                    { 2, "", "HTML element is defined by a start tag, some content, and an end tag", "What Is An Html Element" },
                    { 3, "", "The <!DOCTYPE html> declaration defines that this document is an HTML5 document", "What Does The <!Doctype Html> Tag Do" },
                    { 4, "", "The autoplay attribute starts the a audio file automatically", "What Does The Autoplay Attribute Do To A <Audio> Tag" },
                    { 5, "", "The HTML <audio> element is used to play an audio file on a web page", "What Does The Html <Audio> Element Do" },
                    { 6, "", "The autoplay attribute starts a video automatically", "What Does The Autoplay Attribute Do To A <Video> Tag" },
                    { 7, "", "The <video> tag is used to embed video content in a document, such as a movie clip or other video streams", "What Does A <Video> Tag Do" },
                    { 8, "", "You get this (®)", "What Character Do You Get When You Use &Reg;" },
                    { 9, "", "You get this (©)", "What Character Do You Get When You Use &Copy;" },
                    { 10, "", "Some characters are reserved in HTML", "What Are Html Entities" },
                    { 11, "", "The <section> tag defines a section in a document", "What Does A <Section> Element Do" },
                    { 12, "", "The <nav> tag defines a set of navigation links", "What Does A <Nav> Element Do" },
                    { 13, "", "The <mark> tag defines text that should be marked or highlighted", "What Does A <Mark> Element Do" },
                    { 14, "", "The <main> tag specifies the main content of a document", "What Does A <Main> Element Do" },
                    { 15, "", "The <header> element represents a container for introductory content or a set of navigational links", "What Does A <Hearder> Element Do" },
                    { 16, "", "<header> <main> <mark> <nav> <section>", "What Are Some Semantic Elements" },
                    { 17, "", "A semantic element clearly describes its meaning to both the browser and the developer", "What Is A Semantic Element" },
                    { 18, "", "The <footer> element defines a footer for a document or section", "What Does The Html <Footer> Element Do" },
                    { 19, "", "The HTML <var> element  is used to define a variable in programming or in a mathematical expression", "What Is Html <Var> Tag Used For" },
                    { 20, "", "The HTML <code> element  is used to define a piece of computer code", "What Is Html <Code> Tag Used For" },
                    { 21, "", "The HTML <samp> element is used to define sample output from a computer program", "What Is Html <Samp> Tag Used For" },
                    { 22, "", "The HTML <kbd> element is used to define keyboard input. The content inside is displayed in the browser's default monospace font", "What Is Html <Kbd> Tag Used For" },
                    { 23, "", "The <meta> element is typically used to specify the character set, page description, keywords, author of the document, and viewport settings", "What Does The Html <Meta> Element Do" },
                    { 24, "", "The <link> element defines the relationship between the current document and an external resource", "What Does The Html <Link> Element Do" },
                    { 25, "", "The HTML <script> tag is used to define a client-side script (JavaScript)", "What Does A <Script> Tag Do" },
                    { 26, "", "The <title> element defines the title of the document. The title must be text-only, and it is shown in the browser's title bar or in the page's tab", "What Does The Html <Title> Element Do" },
                    { 27, "", "The <head> element is a container for metadata (data about data) and is placed between the <html> tag and the <body> tag", "What Does The Html <Head> Element Do" },
                    { 28, "", "A relative file path points to a file relative to the current page", "What Is A Relative File Path" },
                    { 29, "", "An absolute file path is the full URL to a file", "What Is A Absolute File Path" },
                    { 30, "", "A file path describes the location of a file in a web site's folder structure", "What Is A Html File Path" },
                    { 31, "", "An HTML iframe is used to display a web page within a web page", "What Does The Html Iframe Used For" },
                    { 32, "", "no, You cannot have more than one element with the same id in an HTML document", "Can You Use The Same Id On Multiple Html Elements" },
                    { 33, "", "The HTML id attribute is used to specify a unique id for an HTML element", "What Does A Id Attribute Do" },
                    { 34, "", "yes you can use multiple classes on one HTML element", "Can You Use Multiple Classes On One Html Element" },
                    { 35, "", "yes, Multiple HTML elements can share the same class", "Can You Use The Same Class On Multiple Html Elements" },
                    { 36, "", "The HTML class attribute is used to specify a class for an HTML element", "What Does A Class Attribute Do" },
                    { 37, "", "The <span> tag is an inline container used to mark up a part of a text, or a part of a document.", "What Does A <Span> Tag Do" },
                    { 38, "", "The <div> tag is used as a container for HTML elements", "What Is A <Div> Tag Mostly Used For" },
                    { 39, "", "The <div> tag defines a division or a section in an HTML document", "What Does A <Div> Tag Do" },
                    { 40, "", "An inline element does not start on a new line. Also an inline element only takes up as much width as necessary.", "What Does A Inline Element Do" },
                    { 41, "", "A block-level element always starts on a new line. Also a block-level element always takes up the full width available (stretches out to the left and right as far as it can). Also a block level element has a top and a bottom margin", "What Does A Block-Level Element Do" },
                    { 42, "", "Lists can be nested (list inside list)", "Can Lists Be Nested" }
                });

            migrationBuilder.InsertData(
                table: "HtmlFlashCards",
                columns: new[] { "Id", "CodeAnswer", "HtmlAnswer", "HtmlQuestion" },
                values: new object[,]
                {
                    { 43, "", "The <dd> tag is used to describe a term/name in a description list", "What Does A <Dd> Tag Do" },
                    { 44, "", "The <dt> tag defines a term/name in a description list", "What Does A <Dt> Tag Do" },
                    { 45, "", "The <dl> tag defines a description list", "What Does A <Dl> Tag Do" },
                    { 46, "", "The <ol> tag defines an ordered list. An ordered list can be numerical or alphabetical", "What Does A <Ol> Tag Do" },
                    { 47, "", "The <li> tag defines a list item", "What Does A <Li> Tag Do" },
                    { 48, "", "The <ul> tag defines an unordered (bulleted) list", "What Does A <Ul> Tag Do" },
                    { 49, "", "The <th> tag defines a header cell in an HTML table", "What Does A <Th> Tag Do" },
                    { 50, "", "The <tr> tag defines a row in an HTML table", "What Does A <Tr> Tag Do" },
                    { 51, "", "The <td> tag defines a standard data cell in an HTML table", "What Does A <Td> Tag Do" },
                    { 52, "", "The <table> tag defines an HTML table", "What Does A <Table> Tag Do" },
                    { 53, "", "<table> <tr> <td> <th>", "What Tags Are Used In A Html Tables" },
                    { 54, "", "_top - Opens the document in the full body of the window", "What Does _Top Do" },
                    { 55, "", "_parent - Opens the document in the parent fram", "What Does _ Parent Do" },
                    { 56, "", "_blank - Opens the document in a new window or tab", "What Does _Blank Do" },
                    { 57, "", "_self - Default. Opens the document in the same window/tab as it was clicked", "What Does  _Self Do" },
                    { 58, "", "_self , _blank , _parent , _top", "What Are The Vaules A Target Attribute Can Have" },
                    { 59, "", "The target attribute specifies where to open the linked document", "What Does The Target Attribute Do To <A> Element" },
                    { 60, "", "the <!-- --> comments anything inside the <!-- kinda like this --> that will not display that text in the ui", "What Does A <!-- -->  Element Do" },
                    { 61, "", "the <abbr> tag defines an abbreviation or an acronym, like HTML, CSS, Mr., Dr., ASAP, ATM", "What Does A <Abbr> Element Do" },
                    { 62, "", "the <q> tag defines a short quotation", "What Does A <Q> Element Do" },
                    { 63, "", "the <blockquote> element defines a section that is quoted from another source", "What Does A <Blockquote> Element Do" },
                    { 64, "", "The <i> element makes text Italic", "What Does A <I> Element Do" },
                    { 65, "", "the <b> element makes text Bold", "What Does A <B> Element Do" },
                    { 66, "", "the <pre> element defines preformatted text", "What Does A <Pre> Element Do" },
                    { 67, "", "The title attribute defines some extra information about an element", "What Does A Title Attribute Do" },
                    { 68, "", "You should always include the lang attribute inside the <html> tag, to declare the language of the Web page. This is meant to assist search engines and browsers", "What Does A Lang Attribute Do" },
                    { 69, "", "The style attribute is used to add styles to an element, such as color, font, size, and more", "What Does A Style Attribute Do" },
                    { 70, "", "you want to use it if the image for some reason cannot be displayed. This can be due to slow connection, or an error in the src attribute, or if the user uses a screen reader", "Why Would You Use A Alt Attribute" },
                    { 71, "", "specifies an alternate text for an image", "What Does A Alt Attribute Do To A <Img>" },
                    { 72, "", "specifies the height of a image in pixels", "What Does A Height Attribute Do To A <Img>" },
                    { 73, "", "specifies the width of a image in pixels", "What Does A Width Attribute Do To A <Img>" },
                    { 74, "", "The src attribute specifies the path to the image to be displayed", "What Does A Src Attribute Do To A <Img>" },
                    { 75, "", "The <img> tag is used to embed an image in an HTML page", "What Does A <Img> Element Do" },
                    { 76, "", "The href attribute specifies the URL of the page the link goes to on <a> tag", "What Does A Href Attribute Do" },
                    { 77, "", "HTML attributes provide additional information about HTML elements", "What Is A Html Attribute" },
                    { 78, "", "The <a> element defines a HTML link", "What Does A <A> Element Do" },
                    { 79, "", "The <hr/> element produces a line and spacing under the previous element", "What Does A <Hr/> Element Do" },
                    { 80, "", "some HTML elements have no content (like the <br/> element), Empty elements do not have an end tag!", "What Is A Empty Element" },
                    { 81, "", "The <br/> element produces a line break in text", "What Does The <Br/> Element Do" },
                    { 82, "", "The <p> element defines a paragraph", "What Does The <P> Element Do" },
                    { 83, "", "There are 6 heading, the 6 headings are <h1> - <h6>", "How Many Heading Elements Are There" },
                    { 84, "", "The <h1> <h2> <h3> <h4> <h5> <h6> elements defines a heading, the lower the numbr the bigger the heading", "What Does The <H1> <H2> <H3> <H4> <H5> <H6> Elements Do" }
                });

            migrationBuilder.InsertData(
                table: "HtmlFlashCards",
                columns: new[] { "Id", "CodeAnswer", "HtmlAnswer", "HtmlQuestion" },
                values: new object[,]
                {
                    { 85, "", "The <body> element defines the document's body, and is a container for all the visible contents, such as headings, paragraphs, images, hyperlinks, tables, lists, etc", "What Does The <Body> Element Do" },
                    { 86, "", "The <title> element specifies a title for the HTML page (which is shown in the browser's title bar or in the page's tab)", "What Does The <Title> Element Do" },
                    { 87, "", "The <head> element contains meta information about the HTML page", "What Does The <Head> Element Do" },
                    { 88, "", "The <html> element is the root element of an HTML page", "What Does The <Html> Element Do" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CsharpFlashCards");

            migrationBuilder.DropTable(
                name: "HtmlFlashCards");
        }
    }
}
