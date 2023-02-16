using OopDemo;

public class App
{
    public void Run()
    {
        

        var yellowHouse = new House(1999,"Testgatan 123");
        yellowHouse.Repaint("Yellow");




        var stefansHouse = new House(1111,"Testgatan 99");
        stefansHouse.Repaint("Green");


        var annasHouse = new House(2222,"Testgatan 1234");


        stefansHouse.Repaint("Blue");
        
        
        Console.WriteLine($"renovering:  {stefansHouse.TotalRenovations()} kr");



       



    }
}