# Lab03SystemIO

LAB 03: System I.O

*Author: Biniam Tesfamariam*

----

## Description
This is a C# console application that creates a “Word Guess Game”. The main idea of the game is to allow the user to guess who the basketball player is. 
Each round will randomly select a basketball player from the list. It is the users job to guess that player by entering in their first name one letter 
at a time. As the user guesses the name the application will display all their guesses. If the user guesses a letter correctly it will replace the placeholder
with that letter. However, if the user doesn't guess correctly the placeholder will remain unchanged and the user will be notified that their guess was incorrect.

## Program Specifications  
Some methods that you should consider creating with your application, at minimum:

Main Method  
This will be the first method that runs in the program. Consider calling the UserInterface() method from this method.  
UserInterface  
Asks the user what action they should take  
ViewWords  
Reads the words in from the external file and outputs them to the console  
RemoveWords  
Gives the user the ability to remove one of the words in the list  
AddWord  
Add a new word to the list  
ExitGame  
End the game  
StartGame*  
Actual game logic of guessing a letter of the mystery word  

---

### Getting Started
Clone this repository to your local machine.

```
$ git clone https://github.com/biniamsea2/Lab03-Systems-IO.git
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```Lab03SystemIO``` directory.

Then select and open ```Lab03SystemIO.sln```

---

### Visuals

#### Application Start
![Image 1](https://github.com/biniamsea2/Lab03-Systems-IO/blob/master/Screenshots/mainMenu.png)
#### Game in Action
![Image 1](https://github.com/biniamsea2/Lab03-Systems-IO/blob/master/Screenshots/playing%20game.png)
#### Won Game
![Image 1](https://github.com/biniamsea2/Lab03-Systems-IO/blob/master/Screenshots/game%20won.png)
#### View Names in the List
![Image 1](https://github.com/biniamsea2/Lab03-Systems-IO/blob/master/Screenshots/view%20list%20of%20names.png)
#### Add Name to the List
![Image 1](https://github.com/biniamsea2/Lab03-Systems-IO/blob/master/Screenshots/add%20to%20list.png)
---

### Change Log
1.0: LAB 03: Systems I.O complete 10/20/19

------------------------------
