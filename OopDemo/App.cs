using OopDemo;

public class App
{
    public void Run()
    {
        var lunchMenyn = new List<Matratt>();

        var mat = new Matratt();
        mat.Calories = 20;
        mat.Name = "Pannkakor";
        mat.Price = 100;
        mat.Type = "Vegetarisk";
        lunchMenyn.Add(mat);

        mat = new Matratt();
        mat.Calories = 100;
        mat.Name = "Kebabtallrik";
        mat.Price = 150;
        mat.Type = "Kött";
        lunchMenyn.Add(mat);

        Console.WriteLine("*** LUNCHMENYN ***");
        foreach (var dish in lunchMenyn)
        {
            Console.WriteLine($"{dish.Name} {dish.Price} kr {dish.Type}");
        }








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