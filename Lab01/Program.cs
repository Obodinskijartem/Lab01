using Lab01;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try
        {
            Console.Write("Введіть ім'я абонента: ");
            string sName = Console.ReadLine();
            Console.Write("Введіть номер телефону: ");
            string sPhoneNumber = Console.ReadLine();
            Console.Write("Введіть адресу абонента: ");
            string sAddress = Console.ReadLine();
            Console.Write("Чи є у абонента Інтернет? (н-так, у-ні): ");
            ConsoleKeyInfo keyHasInternet = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Введіть кількість хвилин дзвінків на місяць: ");
            string sCallMinutesPerMonth = Console.ReadLine();
            Console.Write("Введіть кількість SMS на місяць: ");
            string sSMSPerMonth = Console.ReadLine();
            Console.Write("Введіть щомісячну плату: ");
            string sMonthlyFee = Console.ReadLine();

            Subscriber OurSubscriber = new Subscriber();
            OurSubscriber.Name = sName;
            OurSubscriber.PhoneNumber = sPhoneNumber;
            OurSubscriber.Address = sAddress;
            OurSubscriber.HasInternet = keyHasInternet.Key == ConsoleKey.Y ? true : false;
            OurSubscriber.CallMinutesPerMonth = int.Parse(sCallMinutesPerMonth);
            OurSubscriber.SMSPerMonth = int.Parse(sSMSPerMonth);
            OurSubscriber.MonthlyFee = double.Parse(sMonthlyFee);

            double CostPerMinute = OurSubscriber.GetCostPerMinute();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Дані про абонента:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ім'я: " + OurSubscriber.Name);
            Console.WriteLine("Номер телефону: " + OurSubscriber.PhoneNumber);
            Console.WriteLine("Адреса: " + OurSubscriber.Address);
            Console.WriteLine("Інтернет: " + (OurSubscriber.HasInternet ? "Підключено" : "Немає"));
            Console.WriteLine("Кількість хвилин дзвінків на місяць: " + OurSubscriber.CallMinutesPerMonth.ToString());
            Console.WriteLine("Кількість SMS на місяць: " + OurSubscriber.SMSPerMonth.ToString());
            Console.WriteLine("Щомісячна плата: " + OurSubscriber.MonthlyFee.ToString("0.00"));
            Console.WriteLine("Вартість хвилини дзвінка: " + CostPerMinute.ToString("0.00"));

            if (!OurSubscriber.HasInternet)
            {
                Console.WriteLine();
                Console.WriteLine("У абонента немає підключення до Інтернету.");
            }
            Console.WriteLine();
            Console.WriteLine("Щомісячна вартість дзвінків на одного абонента: " + CostPerMinute.ToString("0.00"));
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка: " + ex.Message);
            Console.ReadKey();
        }
    }
}