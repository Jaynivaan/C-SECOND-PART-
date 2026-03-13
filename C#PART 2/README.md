###################################################################################################################
c# part 2 course 
the files inside the directory C#PART 2
#############################################

#10
ConsoleAppArrayAssignment

a consonle app crafted  to learn about the application of array and list on c# .. 

learning concept: 
*   array
*   list

#11
ConsoleApp6partassignment.cs
________________________________

a console app crafted to complete 6 part assignment 

+++part1: 
    1.one dimentional string array.
    2.ask user to enter text.
    3.A loop that iteerates through each string in the array and adds the users textinput to the end  of each string. This step will not outputanything but will update each array item by appendeing the userinput text. 
    4. then second loop that prints each string one at a time.
    5. save and compile..

+++Part2:
    1.add and infinite loop 
    2.fix the infininte loop
    3. add comments to reveal how infinite loop was fixed.
    
+++Part3: 
    1.A loop where teh comparison operator used to determine whether to continue iteration is a "<" operator.
    2. save and run 
    3. Add another loop  where the comparison that is used is "<="Operator.
    4 save and run 

+++Part4: 
    1. a list of strings where each item inthe  list is unique.
    2. ask the user to input text to search for the list.
    3. a loop that iterates through the list  and then displays the index of the list item  that contains matching text on the screen.
    4. add code to check if the user put in text that isn't on the list and , if they did, tell the user their input  is not on the list.
    5. add code  that stops the loop from executing once a match has been found.
    6. save and run.

+++Part5:
    1. a list of strings with atleast two identical strings in the list. Ask the user to select to search for in the list.
    2. create a loop that iterates through the list and then display the indices of list that contain matching text on the screen. Ensure to remove any breaking statements that may prevent your code from returning multiple  matches.
    3. add code to the loop to check if the user put in text that  isn't on the list and if they they did tell the user their input is not on the list.
    (no need to provide any additional chances for the user to enter text)
    4. save and exit

+++Part6: 
    1. create a list of string with atleast two identical strings
    2.create a for each loop that evaluates each item in the list, and displays a message showing the stringa nd whether or not it has  already appeared in the list.
    3. save and execute the code make sure if it is displaying result as unique or duplicate tag with each string on list.



#12
ConsoleAppstrings&integersAssignment.cs
_______________________________________

a console app crafted for the assignment in module 3.
requirements : 
1.a  create a list of integers.
1.b Ask the user for a number to divide each number in the list by. 
1.c Write a loop that takes each integer in the list and divides it with the given number and displays hte result onthe screen.

2.a run code
2.b enter non zero as the nunbr from user and note any error that get displayed.

3.a run code
3.b enter zero as entry and note the error if any displayed.

4.a run code once again 
4.b enter a string as entry note the error if you receive any.

5.a now put the loop in try catch block
5.b below and outside the trycatch block make the programme print a message" to display to let you know the program has emerged form the try catch block. 
5.c in the catch block display the errror message to the screeen
5.d try various combi nations of user input. (validnumbers, zero and string)
5.e ensure appropriate error message is displayed in message. and code after the try catch block is executed..

#13
CallingMethodsAssignment(directory)
________________________
this directory consist of two files Mathmethods.cs and Program.cs 
this assignment part of module 4 for c# part2 course fullfulls the following requirements;

1.a  create a class
1.b  In that class create three methods.
1.c  Each method s will take one integer parameter in  and return an integer.
1.d The methods should do some math operations on the  received parameter.
1.e Put the class in a separate .cs file in the application.

2.a In the Main() program  ask the user what number they want to do the math operations on 
2.b Call each method in turn passing the user input to the method and  display the returned integer to the screen.

3.comment the code generously.

#14 
MainMethodAssignment(directory)
_______________________
This directory consist of two files MathMethods2.cs and Program.cs 
Mathmethod2.cs contains the class with overloaded methods.
Program.cs contains teh Main() method tht run the program
this directory project is crafted as an assignment from module 4 to learn the concept of method overloading.

requirements
1.a create a class,
1.b In that new class , create a method that take an integer,
1.c create a math operation for  this integer.
1.d return the answer as an integer.

2.a in the Main() method of the program.cs file, instantiate the class  and call the one method, 
2.b passing an integer and display result to screen

3.a Add a second method to t he class with the same name that will take the decimal.
3.b create a different math operation for it 
3.c return the answer as an integer.

4.a in the Main() method of the program.cs file, instantiate the class  and call the second method,
4.b passing an decimal. display result to screen.

5.a Add a third method to t he class with the same name that will take the string.
5.b convert it to an integer.
5.c create a different math operation for it 
5.d return the answer as an integer.

6.a in the Main() method of the program.cs file, instantiate the class  and call the third method,
6.b passing an string. display result to screen.

7.a comment generously and save run it.
7.b push it to github.

#15
MethodAssignment (directory)
_____________________________\
this directory consist of two cs files Program.cs and MathOperation1.cs
this is from module 4 
requirements:
1.a create a class
1.b craete a method that takes two integers as parameters
1.c make one of them optional
1.d have method ot do math and derive a integer resllut

2.ain program.cs Main(), instantiate class

3.a ask input of two numbers one at a time.
3.b let them know second number id optional elso they may hit enter to skip

4.a call method 
4.b using try catch set up the logic

5 comment generously..


#16
MethodClassAssignment(directory)
_______________________________
this directory consist of two files MathDisplay.cs and Program.cs
teh requirements are 

1.a create a class.
1.b in that class create a void method that takes two integers as parameters.
1.c have the method do a math operation on the first integer and display the second integer to the screen.

2.a in program.cs file main(), instantiate the class

3.a call the method in class passing the two numbers.

4.a call the method in the class specifying the parameters by name.

5.a add generous comments..

6.a push to git hub and submit .

#18
MethodsAndObjectsAssignment (directory)
________________________________________
This directory consist of three cs files person.cs, Employee.cs and Program.cs
This is the assignment from module 4

requirements:

1.a create a class called Person.
1.b give Person two properties of type string.
1.c property one is FirstName and property two is LastName

2.a Create a void  method called SayName()
2.b this method takes no parameters.
2.c print the full name in the format: Name:[full name]

3.a Create another class called Employee
3.b let Employee inherit from Person
3.c Give Employee an integer property called Id

4.a In program.cs Main(),instantiate and initialize the Employee object
4.b set FirstName = "sample"
4.c set LastName = "Student"

5.a call the superclass method SayName() on the Employee object

6.a comment generously , save nd run it .

7.a push to github.

#19

