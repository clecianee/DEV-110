# Week 5: Guess the Number - Study Notes

**Name:** Cleciane Oliveira Silva

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: do-while ensures that the user can see the prompt for the loop at least once, and while keeps the loop going until the guess is right.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: I used a do-while inside the helper method, so I could check if the input are valid numbers, inside the correct range

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used to keep the round going until the user guess the right number. With while, I added an if-else statement to give the user tips about the right number.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: Before while, to calculate and display the round number.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: whithout the helper method, i'd have to right do-while and int.TryParse twice, for max number and for the number of rounds. This helper method maked the code easier to read and understand.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: specifying min and max value on the variable statement.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: specifying min and max value on the variable statement.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: using an if-else statement, so the user can reentry their values.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: Because the secret number generated is the number we're looking for, if they are the same, means that the user guessed it!

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: using a for loop to create the game loop

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: It creates a random number, respecting the min and max values. In this case, for each these numbers are the min and max values.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: because the guess has to be in the range informed. if it doesnt inform the max value, the user might input an out of range value.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: 25, 56, 73, 22

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: a few loop erros, on my nested if else statements.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. how to use the three loops
2. how to nest loops
3. how to generate random numbers
4. how to specify range for inputs
5. how to manage "for" values

**Which loop felt most natural to use and why?**

Answer: do-while because for some reason it seems more obvious to me than any other loops.

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

- Planning the loops: [2 hours]
- Input validation: [1 hours]
- Guessing logic: [1 hours]
- Testing and debugging: [0.5 hours]
- Writing documentation: [1.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: the logic, especially how to nest the loops.

## Reflection

**What would you do differently next time?**

Answer: start with inner loops.

**How did using three different loop types improve your understanding of repetition?**

Answer: it makes easier to figure out the logic behind a problem.
