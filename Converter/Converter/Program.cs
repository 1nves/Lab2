using Converter = converter.Converter;
using Currency = converter.Converter.Currency;
using System;

namespace lab_2
{
    class Programm
    {
        private static Converter Converter = new Converter
        (usdValue: 36.56, eurValue: 36.40, rubValue: 0.61, currensyValue: "UAH"
        );

        static void Main(string[] args)
        {
            int? number = null;
            Console.WriteLine("Choose the financial operation");
            Console.WriteLine("1:Convert UAH to usd/eur/rub");
            Console.WriteLine($"2:Convert usd/eur/rub to {Converter.CurrensyValue}");

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Can't convert to 'int'");
                }

                if (number == 1 || number == 2)
                {
                    break;
                }
            }

            switch (number)
            {
                case 1:
                    Currency currency;
                    double sum;
                    Console.WriteLine("Choose currency to convert in: (usd/eur/rub)");
                    while (true)
                    {
                        string cy = Console.ReadLine();
                        try
                        {
                            switch (cy)
                            {
                                case "usd":
                                    currency = Currency.USD;
                                    break;
                                case "eur":
                                    currency = Currency.EUR;
                                    break;
                                case "rub":
                                    currency = Currency.RUB;
                                    break;
                                default:
                                    throw new NullReferenceException("Non existing currency");
                            }

                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine($"Enter the amount of money in {Converter.CurrensyValue}");
                        try
                        {
                            sum = double.Parse(Console.ReadLine());
                            if (sum > 0)
                                break;
                            throw new Exception("Can't convert to 'double'");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    Console.WriteLine($"Amount of money after converting: {Converter.Convert(to: currency, sum)}");
                    Console.ReadLine();
                    break;

                case 2:
                    Currency currency2;
                    double sum2;
                    Console.WriteLine("Enter the currency: (usd/eur/rub)");
                    while (true)
                    {
                        string cy = Console.ReadLine();
                        try
                        {
                            switch (cy)
                            {
                                case "usd":
                                    currency2 = Currency.USD;
                                    break;
                                case "eur":
                                    currency2 = Currency.EUR;
                                    break;
                                case "rub":
                                    currency2 = Currency.RUB;
                                    break;
                                default:
                                    throw new NullReferenceException("Non existing currency");
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine($"Enter the amount of money is: {currency2}");
                        try
                        {
                            sum2 = double.Parse(Console.ReadLine());
                            if (sum2 > 0)
                                break;
                            throw new Exception("Can't convert to 'double'");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    Console.WriteLine($"Amount of money after converting: {Converter.Convert(sum2, of: currency2)}");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Choose 1 or 2"); break;
            }
        }
    }
}