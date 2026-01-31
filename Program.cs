using System;
using System.Runtime.CompilerServices;
using System.Text;
using PersonNamespace;
namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            #region Question 1
            //Question : 1 
            /*
             Problem: Write a program to: 
                o Accept a string input from the user. 
                o Convert it to an integer using both int.Parse and Convert.ToInt32. 
                o Handle potential exceptions using a try-catch block. 
             Question: What is the difference between int.Parse and Convert.ToInt32 when 
            handling null inputs?
            */

            // Console.WriteLine("Enter a string to convert to an integer:");

            // string input = Console.ReadLine();

            // try
            // {
            //     int parsedValue = int.Parse(input);
            //     Console.WriteLine($"Using int.Parse: {parsedValue}");
            //     int ConvertedValue = Convert.ToInt32(input);
            //     Console.WriteLine($"Using Convert.ToInt32: {ConvertedValue}");
            // }catch (Exception ex)
            // {
            //     Console.WriteLine($"An error occurred: {ex.Message}");
            // }

            /*
            both int.Parse and Convert.ToInt32
             are used to convert data into a 32-bit signed integer (int)

            The Critical Difference: Handling null Inputs
                int.Parse(string): strictly expects a string. If you pass null, it throws an exception.
                Convert.ToInt32(object): is designed to handle generic objects. If you pass null, it returns the default value for an integer, which is 0.

            Type Flexibility
                int.Parse(string): only accepts string inputs.
                Convert.ToInt32(object): Accepts almost anything (object, string, bool, float, double, etc.).\
                 It attempts to convert whatever generic data type you feed it into an integer.

            -Under the Hood
            internally, Convert.ToInt32(string)
             actually calls int.Parse. It is essentially a "safe wrapper" around parsing.

            */
            #endregion
            

            #region Question 2
            //Question : 2
            /*
            Problem: Write a program that: 
                o Prompts the user to input a number. 
                o Uses int.TryParse to check if the input is a valid integer. 
                o If valid, print the number; otherwise, print an error message. 
             Question: Why is TryParse recommended over Parse in user-facing applications?
            */


            // Console.WriteLine("Enter a number:");
            // string userInput = Console.ReadLine();

            // if (int.TryParse(userInput , out int res))
            // {
            //     Console.WriteLine($"You entered a valid number: {res}");
            // }
            // else
            // {
            //     Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            // }

            /*
            Anatomy of int.TryParse
                The method signature is distinct because it returns two things at once:

                Success Status (bool): Did it work? (true/false)

                The Actual Value (out int): The converted number.
                
                If Successful: The method returns true, and the out variable holds the converted number.
                If Failed: The method returns false, and the out variable is set to 0

            Why is TryParse Recommended in User-Facing Applications?
                User Input is Unpredictable: Users can enter anything—letters, symbols, empty strings, etc. TryParse gracefully handles these scenarios without throwing exceptions.
                Performance Efficiency: TryParse avoids the overhead of exception handling, making it more efficient for frequent input validation.
                Cleaner Code: Using TryParse leads to more readable and maintainable code by reducing the need for extensive try-catch blocks.
            */
            #endregion



            //------------------------------------------------------------------


            #region Question 3
            // Question : 3
            /*
             Problem: Implement a program to: 
                o Declare an object variable. 
                o Assign it different data types (e.g., int, string, double). 
                o Print the GetHashCode() of each assignment. 
             Question: Explain the real purpose of the GetHashCode() method. 
            */

            // object obj = "Ali";
            // Console.WriteLine(obj.GetHashCode());
            //  obj = 12456;
            // Console.WriteLine(obj.GetHashCode());
            //  obj = 457.65;
            // Console.WriteLine(obj.GetHashCode());
            //  obj = 'A';
            // Console.WriteLine(obj.GetHashCode());
            //  obj = true;
            // Console.WriteLine(obj.GetHashCode());

            // Purpose of GetHashCode()
            /*
            
             The purpose of GetHashCode() is to provide a unique integer value that represents the object's content.
             It is used primarily in hash-based collections like HashSet, Dictionary, and Hashtable to quickly locate an object in memory.
             The method is overridden in most classes to return a hash code that is consistent with the object's equality comparison (i.e., if two objects are equal, they must have the same hash code).
            */
            #endregion


            //------------------------------------------------------------------


            #region Question 4
            // Question : 4
            /*
                Problem: Demonstrate how changing one reference affects another when both point to 
                the same object. Use the following steps: 
                    o Create an object and assign it a value. 
                    o Create a second reference to the same object. 
                    o Modify the value of the object using one reference and print the value using the 
                    other. 
                 Question: What is the significance of reference equality in .NET?
            */

            // Person person1 = new Person();
            // person1.Name = "Ali";
            // Person person2 = person1; // Both references point to the same object
            // person2.Name = "Ahmed"; // Modifying the object using person2 reference
            // Console.WriteLine($"person1 Name: {person1.Name}"); // Output will be "Ahmed"


            // Significance of Reference Equality in .NET
            /*
            Reference equality asks the ultimate question: "Are these two variables pointing to the exact same chunk of memory?"


            Reference equality in .NET is significant because it determines whether two variables refer to the same object in memory. 
            When two references point to the same object, they are considered equal by reference,
             even if their values are the same but they are separate objects in memory.
             This is important for performance and correctness in collections like HashSet and Dictionary, 
             where objects are compared by reference equality unless overridden.


            Identity vs. Equality
                Reference equality is about identity (same memory location).
                Value equality is about content (same data).

            // Usage in Collections
                Many .NET collections rely on reference equality to manage object storage and retrieval efficiently.
            //Why is it Significant?
            Performance (O(1))
            Reference equality is the fastest comparison possible—just compare memory addresses.
            Correctness in Object Management
            It ensures that operations on objects (like updates or deletions) affect the intended instance.
            Avoiding Duplicates
            In collections, reference equality helps prevent duplicate entries of the same object instance.
            */
            #endregion 


            //------------------------------------------------------------------


            #region Question 5
            // Question : 5
            /*
            Problem: Write a program to: 
                o Declare a string and modify it by concatenating additional text “Hi Willy”. 
                o Print the GetHashCode() before and after modification. 
             Question: Why string is immutable in C# ?
            */
            // string str = "Hello World";
            // Console.WriteLine($"Before Modification: {str.GetHashCode()}");
            // str += " Hi Ali";
            // Console.WriteLine($"After Modification: {str.GetHashCode()}");

            // Why is String Immutable in C#?
            /*\
            Strings in C# are immutable because they are designed to be thread-safe and efficient in memory management. 
            When a string is modified, a new string object is created instead of changing the existing one.
            Thread Safety
                Immutability ensures that strings can be safely shared across multiple threads without the risk of one thread modifying the string while another is reading it.
            Memory Efficiency
                Since strings are immutable, they can be interned (stored in a shared pool) to save memory.
                This allows multiple references to point to the same string instance, reducing memory overhead. (String Interning)
            Performance Optimization
                Operations that modify strings (like concatenation) create new instances, which can be optimized by the runtime to improve performance in certain scenarios.
            Predictable Behavior
                Immutability leads to more predictable code, as developers can be sure that once a string is created, it will not change unexpectedly.

            Why New Instance when Modified ? 
                the internal structure of a string is fixed once created.
                array of characters allocated in memory cannot be resized.
                When you modify a string (e.g., concatenation), a new character array is created to hold the new content,
                and a new string object is instantiated to reference this new array.   
            */
            #endregion

            #region Question 6
            // Question 6
            /*
             Problem: Create a program to: 
                o Use StringBuilder to append text to a string “Hi Willy”. 
                o Print the GetHashCode() of the StringBuilder instance before and after the 
                modification. 
             Question: How does StringBuilder address the inefficiencies of string concatenation?
            */

            // StringBuilder sb = new("Hello ,World!");

            // Console.WriteLine($"Before Modification: {sb.GetHashCode()}");
            // sb.Append(" Hi ,Ali");
            // Console.WriteLine($"After Modification: {sb.GetHashCode()}");



            // How does StringBuilder address the inefficiencies of string concatenation?
            //It switches from an "Immutable" model to a "Mutable" model.

            //Why is StringBuilder faster for large-scale string modifications? 
            //It reduces Memory Allocation and Garbage Collection (GC) pressure


            #endregion


            //------------------------------------------------------------------


            #region Question 7
            // Question 7
            /*
            Problem: Create a program to: 
                o Accept two integer inputs from the user. 
                o Display the sum using all three methods “Sum is input1+input2”: 
             Concatenation (+ operator) 
             Composite formatting (string.Format) 
             String interpolation ($)
            */

            // Console.Write("Enter First Number : ");
            // int input1 , input2; 
            // bool isSucced1 = int.TryParse(Console.ReadLine(), out input1);
            // Console.WriteLine();
            // Console.Write("Enter Second Number : ");
            // bool isSucced2 = int.TryParse(Console.ReadLine(), out input2);
            // try
            // {
            //     if(!isSucced1 || !isSucced2) return;

            //     Console.WriteLine("Input 1 + Input 2 = " + (input1 + input2));
            //     string result = String.Format("input 1 + input 2 = {0}" , input1 + input2);
            //     Console.WriteLine(result);
            //     Console.WriteLine($"input 1 + input 2 = {input1 + input2}");
                
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine($"{ex.Message}");
            // }



            // Which string formatting method is most used and why?
            //String Interpolation ($) 
            //Readability , Compile-Time Safety , Power Of supports expressions inside the brackets.

            #endregion


            //------------------------------------------------------------------

            #region Question 8 
            //Question 8
            /*
            Problem: Create a program using StringBuilder to: 
                o Append text. 
                o Replace a substring. 
                o Insert a string at a specific position. 
                o Remove a portion of text.  
            */
            StringBuilder sb = new();
            sb.Append("Hello ,World");
            sb.Replace("World","Depi");
            sb.Insert(7 , "Dear ");
            sb.Remove(7,5);
            Console.WriteLine(sb.ToString());

            // Question: Explain how StringBuilder is designed to handle frequent modifications compared to strings.
            /*
            The core difference lies in how they treat memory after creation.

            String (Immutable Design): Designed for safety. Once created, it cannot change. This makes strings thread-safe and predictable, but it means any "modification" is actually a "replacement."

            StringBuilder (Mutable Design): Designed for manipulation. It is a wrapper around a raw memory buffer (an LinkedList) that is expected to change.
            */
            #endregion

            

            


        }
    }
}