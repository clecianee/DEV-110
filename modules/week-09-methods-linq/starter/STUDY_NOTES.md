# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Test Student

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: With small methods, programs are easier to read, debugging and testing. This way, instead of taking longer to find the bugs, the solution might come quicker since we'll be analyzing only the method that is causing the program to crash instead of going throught the whole thing.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: Min(), Max(), Average(), and Count().

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: I used OrderBy(score => score) for all the scores in ascending order, OrderByDescending(scroe => score) and Take(topCount) to obtain highest scores and get the top ones. I also chained where() for score filtering and orderbyDescending() to order thenm from high to low.

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: It helps to keep the program organized and easy to read, because the program class only handles the main workflow and the user's inputs, and scoreReport checks and analyzes and shows the score data.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to use linq methods
2. how to use those methods together
3. how to make my program more organized and easier to read breaking into small methods
4. how create a separated class can make the program cleaner, setting apart the program flow and the analyzing part
5. how to use string.Join to format output

**Which concept felt easiest (methods or LINQ) and why?**

Answer: Methods felt easier, because since I have been practicing it for a while, I just feel that I knwo where to put what.

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Understanding the starter code: 1.5 hours
- Implementing the print methods: 1 hours
- LINQ method chaining: 1.5 hours
- Testing and debugging: 1 hours
- Writing documentation: 1 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Understading the starter code and using LINQ method chaining, because I had to sketch how I'd chain them first.

## Reflection

**What would you improve next time?**

Answer: Maybe time managenment. I feel that I had a better workflow for this assignment, and it makes me happy seeing how much I've been improving.

**How did methods make this program easier to work on?**

Answer: Separating things by parts makes the process easier because I can work on one thing at the time and it doesn't get overwhelming.
