# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Cleciane Oliveira Silva

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: It returns a string array where each of the elements represents one liine from the file, and i used to read all lines from csv file. For each of the non blank lines I split it with commas to get the habit name, status, and frequency to create a habit object

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: Because if i try to split an empty string with the Split(',') that would cause an array with missing values, causing errors when trying to access parts. by skipping the blank lines we ensure that the program will only process valid data

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: It writes all lines to a file and replace its content if there's already something in there. It takes two arguments: the file path and a string array

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select is a LINQ method that turns each habit into a string with a csv format. that's when ToArray converts that sequence into a string arrray that is required by File.WriteAllLines

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: It happens if the program tries to read a file that does not exist in that specific path

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: we catch filenotfoundexception to handle expected erros from missing files. Using the catch exception would catch all the possible errors, it helps to handle known issues while still allowing unexpected problems to be noticed

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. how to read data from files using file.readalllines
2. how to write data back to a file 
3. how to use linq to simplfy data processing

**What was the trickiest part of this assignment and how did you work through it?**

Answer: handling CSV parsing correcly and making sure the program didn't crash with bad or empty lines. I worked it through carefully using trim() and checking for blank lines with string.isnullorwhitespace

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 0.5 hours
- Implementing LoadHabits: 1 hours
- Implementing PrintHabits / PrintSummary: 1.5 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1 hours
- Testing and debugging: 1.5 hours
- Writing study notes: 0.5 hours

**Most time-consuming part:**

Answer: implementing LoadHabits.
