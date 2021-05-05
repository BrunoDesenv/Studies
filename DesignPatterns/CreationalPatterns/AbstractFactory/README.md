# Abstract Factory
In this example, I studied following the example from 
https://refactoring.guru/design-patterns/abstract-factory

I mixed the project in two ways, one for learn and another to be the exercise.<br>
In the method main you'll notice have a code comment:  
```sh
new Client().Main();
```
This code is for executing the test to learn about the abstract factory, this code I copied, so before you execute the code before this will be good if you try to understand this code before.<br>
Or you can access the site from guru to see all articles.<br>
So after understand that you can see my code where I resolve the exercise about the furniture.<br>
So you have the option to chose the furniture and after that choose the type.<br>
```sh
Console.WriteLine("Choose the furniture.");
Console.WriteLine("Press S To Sofa.");
Console.WriteLine("Press C To Chair.");
Console.WriteLine("Press F To CoffeTable.");
string option = Console.ReadLine().Trim();
Console.WriteLine();

Console.WriteLine("Choose the type of furniture.");
Console.WriteLine("Press A To Art Deco.");
Console.WriteLine("Press V To Victorian.");
Console.WriteLine("Press M To Modern.");
string type = Console.ReadLine().Trim();
Console.WriteLine();
```
All the class of products is inside the folder class in your respective type, the factories are inside class too.<br>
![ScreenShot](https://github.com/BrunoDesenv/Studies/blob/main/DesignPatterns/CreationalPatterns/AbstractFactory/AbstractFactory/images/class.PNG)<br>
The interfaces are inside the folder interfaces.<br>
![ScreenShot](https://github.com/BrunoDesenv/Studies/blob/main/DesignPatterns/CreationalPatterns/AbstractFactory/AbstractFactory/images/interfaces.PNG)<br>


The class 
```sh
 public class Exercice
```
where the calls happens.
