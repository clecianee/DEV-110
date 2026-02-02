# Week 2: Calculator Lite - Study Notes

**Name:**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: string - for user name; bool - if the user wants to use decimals or not; double - if decimals; int - if whole numbers, and to count
the number of operations.

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: Because it is possible to obtain more exact results than when using int, for example, in cases of division. Using int the result
would be close, not exact.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: Yes or no are the answers to wether the user wants to use decimal precision. Based on that, we convert these answers in false or true to trigger the behavior of the results. 

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: The hardest part was to figure out where to use int.Parse, since my first logic was "if it's not a double, it will be a int" because I thought it would be clear.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I kept rereading the coding and trying to find ways to include the int.Parse to it. It finally made sense that if it was not a decimal, I would need to specify it using a "if" statement.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: The parse is still confusing to me, as well other ways of convertions.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: Modulus shows what's remain in the division, while division does the exact division.

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: you add both numbers, then divide by 2.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: It calculates how much percent a number is different from another. In this formula, we first calculate the difference between num1 and num2, then divide it for the first number and multiply the result by 100.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Console.ReadLine() reads the line above where the user inputs a value, and storages its value. This command returns a string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: When the user enters a value, it is read first as string. The double.Parse() will convert that string to a double value. Same thing happens with int.Parse(), but it will convert the value to a int number.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: It is when you add text fields that are substituted for values pre determinated. 

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: Whole numbers can be formated using the type of data int, or converting it to int. :F followed by a number that determines how many decimal places that number will show.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: The division cannot be completed. I used "if" statements to handle these cases, showing a message, instead of crashing the program. This way, the program flows smoothly.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: Yes! I used bool at the beggining of the code, to handle situations where the user choses to see double or int. If a bool is true, I use one method and display a double format with two decimal places, or if it is false, I display whole numbers (int)

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. How to apply if else statements to handle situatins with different types of data
2. How to parse string into int or double
3. How to calculate percentage difference
4. How to specify how many decimal places I wish to display for doubles
5. How to use interpolation

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: The bool, because it allows me to set a starting point to how I will handle the values entered by the user.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: It displays results in a way that best matches the user needs or expectations.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I used positive numbers below 10, negative numbers and zeros.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: The spacing was off, the results weren't showing the decimal places I specified. I made some adjustments on the spacing and linig, then corrected my bool logic, parse and if statements.

## Time Spent

**Total time:** [7 hours]

**Breakdown:**

-   Understanding data types: [1 hours]
-   Reading and parsing user input: [2 hours]
-   Implementing arithmetic operations: [0.5 hours]
-   Adding conditional formatting: [1 hours]
-   Handling division by zero: [0.5 hours]
-   Testing and debugging: [0.5 hours]
-   Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Figuring out how to add int.Parse(). Because I thought that if the value isn't a double, and I'm using the right formating (:F0), that would be enough to read it as int.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I wouold give more attention to parsing and conversions.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: The math logic is extremely important to more complex calculations, and understanding the differente data types is essential to give the user the best experience and reach their expectations and needs.

