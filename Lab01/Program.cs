class Subscriber
{
    public string Name;            // Ім'я абонента
    public string PhoneNumber;      // Номер телефону
    public string Address;          // Адреса абонента
    public bool HasInternet;        // Чи є у абонента підключення до Інтернету
    public int CallMinutesPerMonth; // Кількість хвилин дзвінків на місяць
    public int SMSPerMonth;         // Кількість SMS на місяць
    public double MonthlyFee;       // Щомісячна плата за послуги

    public double GetCostPerMinute() // Метод для отримання вартості хвилини дзвінка
    {
        return MonthlyFee / CallMinutesPerMonth;
    }
}