using _16a_Inheritance.Practice;
using System.Text;
using Info = _16a_Inheritance.Practice.Information;
using Sound = _16a_Inheritance.Practice.Notification;
using Order = _16a_Inheritance.Practice.Notification;
using detail = _16a_Inheritance.Practice.Detail;
Console.OutputEncoding = Encoding.UTF8;

var order1 = new Info
{
    ProviderName = "Viettel",
    De = Denomination._20,
    SeriNumber = "1000000002323",
    CodeNumber = "42342234244243",
    Expiration = new DateTime(2022,10,7),
};
Console.WriteLine(order1);
Console.Write($"Is the card still valid? {order1.isValid()}\n");

var sound = new Notification { };
sound.MakeSoundReturn();

Console.WriteLine("\n---------------------\n");
var order2 = new Sound
{
    ProviderName = "Mobifone",
    De = Denomination._50,
    SeriNumber = "0938003216546546",
    CodeNumber = "129309209033233",
    Expiration = new DateTime(2025, 12, 12),
    Price = 50_000m,
};
Console.Write($"Is the card still valid? {order2.isValid()}\n");
Console.WriteLine(order2);
order2.MakeSoundDone();


Console.WriteLine("\n---------------------\n");
var order3 = new Order
{
    ProviderName = "Vinaphone",
    De = Denomination._300,
    SeriNumber = "590546846465",
    CodeNumber = "546764654645",
    Expiration = new DateTime(2029,9,9),
    Discount = 90,
    Price = 300_000
};
Console.WriteLine(order3);
Console.WriteLine($"Is this card still valid? {order3.isValid()}\n");
order3.MakeSoundDone();
order3.MakeSoundRelease();

Console.WriteLine("\n------------------------------------");
var order4 = new detail
{
    ProviderName = "Mobifone",
    De = Denomination._500,
    SeriNumber = "098215544554",
    CodeNumber = "65464646465466",
    Expiration = new DateTime(2020, 5, 20),
    Discount = 95,
    Price = 500_000,
};
Console.WriteLine(order4);
Console.WriteLine("------------------------------------"); 
order4.Mobfifone();


Console.WriteLine("\n*//////////////////////////////////*\n");
Console.WriteLine("\n------------------------------------");
var order5 = new detail
{
    ProviderName = "Vinaphone",
    De = Denomination._100,
    SeriNumber = "32323",
    CodeNumber = "6565445",
    Expiration = new DateTime(2023,10,10),
    Price = 100_000m,
    Discount = 97,
};
Console.WriteLine(order5);
order5.Vinaphone();

Console.WriteLine("\n*//////////////////////////////////*\n");
Console.WriteLine("\n------------------------------------");
var order6 = new detail
{
    ProviderName = " Viettel",
    De = Denomination._200,
    SeriNumber = "100042343323",
    CodeNumber = "65654423424245",
    Expiration = new DateTime(2021, 10, 10),
    Price = 200_000m,
    Discount = 97,
};
Console.WriteLine(order6);
order5.Mobfifone();