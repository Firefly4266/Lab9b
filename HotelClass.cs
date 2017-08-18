// HotelClass.cs

using System;

public class Hotel
{
	public Hotel(string city, string name, int rooms, decimal cost)
	{
		Console.WriteLine("Hotel class instance");
		this.city = city;
		this.name = name;
		this.rooms = rooms;
		this.cost = cost;
	}
	public void Show()
	{
		Console.WriteLine("{0} {1} {2} {3:C}", city, name, rooms, cost);
	}

    public string City
    {
        get
        {
            return city;
        }
        set
        {
            city = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Rooms
    {
        get
        {
            return rooms
        }
        set
        {
            rooms = value;
            if(rooms > 400)
            { }
        }
    }



    private string city;
	public string name;
	public int rooms;
	public decimal cost;
}
