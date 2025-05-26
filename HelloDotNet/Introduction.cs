using System;

class Introduction
{
    public static void TellAboutYou(string name, int age, double height, bool isStudent, string favouriteFood, int calorie100g)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Student: " + isStudent);
        Console.WriteLine("Favourite food: " + favouriteFood);
        Console.WriteLine("Calorie (pr. 100g): " + calorie100g);
    }
}