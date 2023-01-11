# tasks description for the practice
### solutions:
3. two lines were exchanged:
```c#
    message += i.ToString();
    PrintMessage(message);
```
![solution 3](./debuggingImages/image3.png)

---
4. 'toLower' method was added on the return line code
```c#
    return newWord.ToLower() == word.ToLower();
```
![solution 4](./debuggingImages/image4.png)

---
5. a conditional breakpouint was added, with the expresion 'i == 3'
![solution 51](./debuggingImages/image51.png)
![solution 52](./debuggingImages/image52.png)

---
6. a return line into foreach was commented. this was returning in ther first iteration from loop.

![solution 6](./debuggingImages/image6.png)