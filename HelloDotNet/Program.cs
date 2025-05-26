using System;

class TypeConversionAndCasting
{
    public void TypeConversion(int a)
    {
        double b = a;
        Console.WriteLine(a + " Got converted to: " + b);
    }
    public void TypeCasting(double x)
    {
        int y = (int)x;
        Console.WriteLine(x + " Got converted to: " + y);
    }
    public void StringToInt(string input)
    {
        int number;
        bool success = int.TryParse(input, out number);
        Console.WriteLine("Was it successful? " + success);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from Main!");
        string name = "Benjamin";
        /* int age = 20;
        double height = 1.73;
        bool isStudent = true; */
        string favouriteFood = "Quesadillas";
        int calorie100g = 293;
        string thisNumber = "44";


        #region Introduction
        /* Introduction.TellAboutYou(name, age, height, isStudent, favouriteFood, calorie100g);
        TypeConversionAndCasting converter = new TypeConversionAndCasting();
        converter.StringToInt(name);
        converter.StringToInt(thisNumber);
        converter.TypeCasting(height);
        converter.TypeConversion(age); */
        #endregion

        #region String manipulation
        /* StringManipulator sm = new StringManipulator();
        string upper = StringManipulator.MakeUpper(name);
        Console.WriteLine(upper);
        string favUpper = StringManipulator.MakeUpper(favouriteFood);
        Console.WriteLine(favUpper);

        string rever = StringManipulator.Reverse(name);
        Console.WriteLine(rever);
        string revfoodUpper = StringManipulator.Reverse(favUpper);
        Console.WriteLine(revfoodUpper);

        bool letterT = StringManipulator.ContainsLetter(favouriteFood, 't');
        Console.WriteLine(letterT);
        bool letterQ = StringManipulator.ContainsLetter(favouriteFood, 'q');
        Console.WriteLine(letterQ);
        bool letterS = StringManipulator.ContainsLetter(favouriteFood, 's');
        Console.WriteLine(letterS); */
        #endregion

        #region Book
        Book book1 = new Book(favouriteFood, name, 650, false);
        Book book2 = new Book(thisNumber, name, calorie100g, true);

        book1.PrintDetails();
        Console.WriteLine();
        book2.PrintDetails();
        Console.WriteLine(book1.isLong());
        Console.WriteLine(book2.isLong());
        #endregion
    }
}
