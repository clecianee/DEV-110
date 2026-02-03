# Week 3: Personal Profile Card - Study Notes

**Name:** Cleciane Oliveira Silva

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: int for year, favorite number; string for student name, city, state; double for gpa, height; bool for full-time student, honor student.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: double gives more precise answers. int would show only integers numbers.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: trimming and setting as low case the input from user, obtaining a 'keyword' and using it as a trigger for true or false bool.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: Spacing and adding extra blank lines always helps me to visualize and keep my code readable for me, this way i can better see each group and find it quickly if i need to make any adjustments.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: birth year, years to graduate, height conversion, student honor status, age in months.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: Because it optmizes the program, and the user doesnt have to type so many different types of data. Althogh it can work, basing age only on birth year does not give a precise answers if the user hasn't had his birthday for this year yet.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: Formating. I took forever to make the box lines to look good.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: With patience and excuting the program each time, to make sure i wasn't missing any spacing or formating.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: modulus for height.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: using either int.Parse() or double.Parse(), according to the information needed and the best data type for it. for example, int for year, double for gpa.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: divided the number of inches by 12 to see feet, then using % to get the reminders inches to add to it.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: i used an if statement with bool in it.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: it adds the number of decimal places that will be displayed for that data. if set as :F2, it will show 2 decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: using boolean for true and false

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I added the width number at the end of each line to be displayed using interpolation.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: i would add date of birth instead of age. This way, the data would be more accurate.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: each type of data holds a specific number of characters, as well as different precision, and the choice must be according to users needs.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: It can be used for job applications, resumes, social media, dating app, donor compatibiliy. 

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. different types of variables according to users needs
2. if statements can be used to settle a bool logic
3. it's possible to have an if inside another if.
4. strings can be directly converted to numbers, if applicable
5. exact data results and exact data

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: bool, because I still had to set up its logic in an if else statement, and it looked confusing at first.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: because it allows you to write less code and make your program easily readable.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: different ages, gpas, heights, year of graduation.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: boolean erros, I wasnt putting it inside if else statements, so there were no parameters to be compared.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: Yes, i did! I checked it with different inputs.

## Time Spent

**Total time:** [4 hours]

**Breakdown:**

-   Understanding data types and planning variables: [0.5 hours]
-   Collecting user input with correct types: [1 hours]
-   Implementing calculations: [0.5 hours]
-   Formatting output: [1 hours]
-   Testing and debugging: [0.5 hours]
-   Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: formating. I wanted the display to look perfect, and it was a little frustrating.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: i would start on bool logic and calculations before trying to format the output to look good.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: readability, the program is easy to read and fix, especially if another person is trying to work with it.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: game character.
