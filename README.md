# Practice

#### Using VS Code

1. Clone this project and create a new branch with the following convention: **_chore/firstname-lastname_**

1. Create the **launch.json** file to debug this .Net. Once it is added two files will be created and tracked by git these files (launch.json and tasks.json) should not be tracked, please add them into .gitignore.

1. In **Program.cs** the method **Display Pattern** is not printing the correct values. Add a **breakpoint** where **PrintMessage** is called and check the value that is being printed. Add the fix. It should print:

   > 1
   > 12
   > 123
   > 1234

1. For method **PalydromeWords** it should print:

   > ana
   > Mom
   > pop
   > RedDer
   > Reparer
   > LeveL

   Add a breakpoint where method **VerifyWord** is called, once that breakpoint is hit use Step Into(F11) or Step Over(F10) to navigate and look for the issue. Add the fix so it could print the correct values.

1. For method **PrintNames** add a conditional breakpoint so it could be hit only when name is equal to **"Luis"**.

1. For method **DisplayEvenNumbers** add a breakpoint inside the foreach loop and see what the variables are in the left panel in **Variables** section. Try to find the error and add the fix. It is should print:

   > 2
   > 6
   > 4
   > 10

1. Create a Pull Request in the description section add a small description for the solution applied for each method and screenshot of the breakpoint that you set. Try to use markdown if possible.
