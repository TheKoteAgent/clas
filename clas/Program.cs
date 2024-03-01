using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        // Завдання 1
        DrawSquare(5, '*');

        // Завдання 2
        Console.WriteLine(IsPalindrome(1221)); // True
        Console.WriteLine(IsPalindrome(3443)); // True
        Console.WriteLine(IsPalindrome(7854)); // False

        // Завдання 3
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };
        int[] result = FilterArray(originalArray, filterArray);
        foreach (int item in result)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Завдання 4
        Website website = new Website();
        website.SetName("Example Website");
        website.SetPath("/example");
        website.SetDescription("This is an example website.");
        website.SetIpAddress("192.168.1.1");
        website.DisplayData();

        // Завдання 5
        Magazine magazine = new Magazine();
        magazine.SetName("Example Magazine");
        magazine.SetYearFounded(2020);
        magazine.SetDescription("This is an example magazine.");
        magazine.SetContactPhone("123-456-7890");
        magazine.SetEmail("example@example.com");
        magazine.DisplayData();

        // Завдання 6
        Shop shop = new Shop();
        shop.SetName("Example Shop");
        shop.SetAddress("123 Example St");
        shop.SetProfileDescription("This is an example shop.");
        shop.SetContactPhone("123-456-7890");
        shop.SetEmail("example@example.com");
        shop.DisplayData();
    }

    // Завдання 1
    static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

    // Завдання 2
    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    // Завдання 3
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        List<int> resultList = new List<int>();

        foreach (int item in originalArray)
        {
            if (!filterArray.Contains(item))
            {
                resultList.Add(item);
            }
        }

        return resultList.ToArray();
    }

    // Завдання 4
    class Website
    {
        private string name;
        private string path;
        private string description;
        private string ipAddress;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }

        public string GetPath()
        {
            return path;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetIpAddress(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Path: {path}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"IP Address: {ipAddress}");
        }
    }

    // Завдання 5
    class Magazine
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetYearFounded(int yearFounded)
        {
            this.yearFounded = yearFounded;
        }

        public int GetYearFounded()
        {
            return yearFounded;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetContactPhone(string contactPhone)
        {
            this.contactPhone = contactPhone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Year Founded: {yearFounded}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Contact Phone: {contactPhone}");
            Console.WriteLine($"Email: {email}");
        }
    }

    // Завдання 6
    class Shop
    {
        private string name;
        private string address;
        private string profileDescription;
        private string contactPhone;
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetProfileDescription(string profileDescription)
        {
            this.profileDescription = profileDescription;
        }

        public string GetProfileDescription()
        {
            return profileDescription;
        }

        public void SetContactPhone(string contactPhone)
        {
            this.contactPhone = contactPhone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Profile Description: {profileDescription}");
            Console.WriteLine($"Contact Phone: {contactPhone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
