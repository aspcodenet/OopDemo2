using OopDemo;

public class App
{
    public void Run()
    {

        var houseList = new List<House>();

        var yellowHouse = new House(1999,"Testgatan 123");
        yellowHouse.Repaint("Yellow");
        houseList.Add(yellowHouse);

        var stefansHouse = new House(1111,"Testgatan 99");
        stefansHouse.Repaint("Green");
        houseList.Add(stefansHouse);

        var annasHouse = new House(2222,"Testgatan 1234");
        houseList.Add(annasHouse);


        stefansHouse.Repaint("Blue");

        Console.WriteLine($"renovering:  {stefansHouse.TotalRenovations()} kr");

        foreach (var house in houseList)
        {
            Console.WriteLine($"Address: {house.GetAddress()}");
        }


       



    }
}