/*
Implement a Hotel Room class with private attributes roomNumber, roomType, isBooked, and price. 
Provide methods like bookRoom(), cancelBooking(), and getRoomDetails(). 
Ensure the room cannot be booked more than once at the same time and that room details are only accessible via controlled methods.
*/


using System;

class HotelRoom
{
    private int roomNumber;
    private string roomType;
    private bool isBooked;
    private double price;

    public HotelRoom(int roomNumber, string roomType, double price)
    {
        this.roomNumber = roomNumber;
        this.roomType = roomType;
        this.price = price;
        this.isBooked = false;
    }

    public void SetRoomNumber(int roomNumber)
    {
        this.roomNumber = roomNumber;
    }

    public int GetRoomNumber()
    {
        return this.roomNumber;
    }

    public void SetRoomType(string roomType)
    {
        this.roomType = roomType;
    }

    public string GetRoomType()
    {
        return this.roomType;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public double GetPrice()
    {
        return this.price;
    }

    public void SetBooked(bool isBooked)
    {
        this.isBooked = isBooked;
    }

    public bool IsBooked()
    {
        return this.isBooked;
    }

    public bool BookRoom()
    {
        if (isBooked)
        {
            return false;
        }
        else
        {
            isBooked = true;
            return true;
        }
    }

    public bool CancelBooking()
    {
        if (isBooked) // 
        {
            isBooked = false;
            return true;
        }
        else
        {
            return false;
        }
        
    }
}

class Program
{
    static void Main()
    {
        int yn;


        HotelRoom room = new HotelRoom(101, "Deluxe", 150.0);
        Console.WriteLine("Room Number: " + room.GetRoomNumber());
        Console.WriteLine("Room Type: " + room.GetRoomType());
        Console.WriteLine("Price: " + room.GetPrice());


        Console.WriteLine("Would you like to book a room? \n 1 --> Yes \n 2 --> No ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            do
            {
                if (room.BookRoom())
                {
                    Console.WriteLine("Enter money: ");
                    int money = Convert.ToInt32(Console.ReadLine());
                    if (money < room.GetPrice())
                    {
                        Console.WriteLine("Not enough money to book the room.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Room booked successfully.");
                        Console.WriteLine("Room Number: " + room.GetRoomNumber());
                        Console.WriteLine("Room Type: " + room.GetRoomType());
                        Console.WriteLine("Price: $" + room.GetPrice());

                        if (room.IsBooked())
                        {
                            Console.WriteLine("Booked: Yes");
                        }
                        else
                        {
                            Console.WriteLine("Booked: No");
                        }

                        Console.WriteLine("Would you like to cancel your booking? \n 1 --> Yes \n 2 --> No ");
                        int cancelBooking = Convert.ToInt32(Console.ReadLine());
                        if (cancelBooking == 1)
                        {
                            if (room.CancelBooking())
                            {
                                Console.WriteLine("Booking canceled successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Room is not currently booked.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Room already booked.\n");
                }
                Console.WriteLine("Room Number: " + room.GetRoomNumber());
                Console.WriteLine("Room Type: " + room.GetRoomType());
                Console.WriteLine("Price: $" + room.GetPrice());

                if (room.IsBooked())
                {
                    Console.WriteLine("Booked: Yes");
                }
                else
                {
                    Console.WriteLine("Booked: No");
                }
                Console.WriteLine("Would you like to book room 101? \n 1 --> Yes \n 2 --> No ");
                yn = Convert.ToInt32(Console.ReadLine());
            }
            while (yn == 1);
        }
    }
}
