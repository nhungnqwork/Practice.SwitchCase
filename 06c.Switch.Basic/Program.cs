#region Switch Statement vs Switch Expression - Practice 1
/*
 * 1) For an ordinal number of a month, print the name of the corresponding month. For example, number 1 means January, number 2 means February, and so on. If the number is not valid, an error message is displayed. 
 * (Use switch statement and switch expression to solve this problem)
 */
using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Claims;
using System.Xml.Linq;

void PrintMonthNameV1(int month)
{
    string monthName = string.Empty;

    switch (month)
    {
        case 1: monthName = "January"; break;
        case 2: monthName = "February"; break;
        case 3: monthName = "March"; break;
        case 4: monthName = "April"; break;
        case 5: monthName = "May"; break;
        case 6: monthName = "June"; break;
        case 7: monthName = "July"; break;
        case 8: monthName = "August"; break;
        case 9: monthName = "September"; break;
        case 10: monthName = "October"; break;
        case 11: monthName = "November"; break;
        case 12: monthName = "December"; break;
        default:
            break;
    }
    Console.WriteLine($"The {month} number is {(month >= 1 && month <= 12 ? monthName : "invalid")}");
}
PrintMonthNameV1(13);
PrintMonthNameV1(12);
Console.WriteLine();
for (int i = 0; i <= 13; i++)
{
    PrintMonthNameV1(i);
}

Console.WriteLine("-----Exercise 2----");

#region Use switch expression version 2
void PrintMonthNameV2(int month)
{
    string monthName = month switch
    {
        1 => "January",
        2 => "February",
        3 => "March",
        4 => "April",
        5 => "May",
        6 => "June",
        7 => "July",
        8 => "August",
        9 => "September",
        10 => "October",
        11 => "November",
        12 => "December",
        _ => string.Empty
    };
    Console.WriteLine($"The {month} number is {(month >= 1 && month <= 12 ? monthName : "invalid")}");
}

for (int i = 0; i <= 13; i++)
{
    PrintMonthNameV2(i);
}
#endregion

#region Use Switch expression version 3
void PrintMonthNameV3(int month)
    => Console.WriteLine($@"{month,2} is {month switch
    {
        1 => "January",
        2 => "February",
        3 => "March",
        4 => "April",
        5 => "May",
        6 => "June",
        7 => "July",
        8 => "August",
        9 => "September",
        10 => "October",
        11 => "November",
        12 => "December",
        _ => "invalid"
    }}");
Console.WriteLine("\n----Switch Expression version 3 (Practice 1)----");
for (int i = 0; i <= 13; i++)
    PrintMonthNameV3(i);
#endregion
#endregion


#region Switch Statement vs Switch Expression - Practice 2

/*
 * 2) Based on the menu board, write the code to help the cashier quickly find the price of the drink to respond to the customer.
 * Refer to file "Simple Drinks Cocktail Menu Template" for more details.
 * (Use switch statement and switch expression to solve this problem)
 */

#region Use switch statement version 1
void FindDrinkPriceV1(string name)
{
    if (name is null) throw new Exception(nameof(name));

    decimal price = 0_0m;

    switch (name.ToLower())
    {
        case "tequila & lemon":
        case "whicky cola":
        case "peppermint": price = 2.0m; break;
        case "melon":
        case "peach schnapps":
        case "jagermeister": price = 3.00m; break;
        case "vodka lime":
        case "jim beam":
        case "pink lady":
        case "black russian": price = 4.00m; break;
        case "tequila sunrise":
        case "pina colada": price = 5.00m; break;
        case "sex on the beach":
        case "mojito":
        case "daiquiri": price = 6.00m; break;
        default:
            break;
    }
    Console.WriteLine($"Your drink: {name,-16} - {(price > 0 ? $"{price:c}" : "not found")}");
}
Console.WriteLine("\n----Switch Statement version 1 (Practice 2)----");
FindDrinkPriceV1("melon");
FindDrinkPriceV1("Melon");
FindDrinkPriceV1("pink layy");
FindDrinkPriceV1("pink lady");
FindDrinkPriceV1("sex on the beach");
FindDrinkPriceV1("Sex On The Beach");
FindDrinkPriceV1("daiquiri");
#endregion

#region Use switch statement version 2
void FindDrinkPriceV2(string name)
{
    decimal price = 0.0m;

    switch (name.ToLower())
    {
        case "tequila & lemon" or "whicky cola" or "peppermint": price = 2.0m; break;
        case "melon" or "peach schnapps" or "jagermeister": price = 3.00m; break;
        case "vodka lime" or "jim beam" or "pink lady" or "black russian": price = 4.00m; break;
        case "tequila sunrise" or "pina colada": price = 5.00m; break;
        case "sex on the beach" or "mojito" or "daiquiri": price = 6.00m; break;
        case null: throw new Exception(nameof(name));
        default: break;
    }
    Console.WriteLine($"Your drink: {name,-16} - {(price > 0 ? $"{price:c}" : "not found")}");
}
Console.WriteLine("\n----Switch Statement version 2 (Practice 2)----");
FindDrinkPriceV2("melon");
FindDrinkPriceV2("Melon");
FindDrinkPriceV2("pink layy");
FindDrinkPriceV2("pink lady");
FindDrinkPriceV2("sex on the beach");
FindDrinkPriceV2("Sex On The Beach");
FindDrinkPriceV2("daiquiri");
#endregion

#region Use switch expresion version 3
void FindDrinkPriceV3(string name)
{
    decimal price = name.ToLower() switch
    {
        "tequila & lemon" or "whicky cola" or "peppermint" => 2.0m,
        "melon" or "peach schnapps" or "jagermeister" => 3.00m,
        "vodka lime" or "jim beam" or "pink lady" or "black russian" => 4.00m,
        "tequila sunrise" or "pina colada" => 5.00m,
        "sex on the beach" or "mojito" or "daiquiri" => 6.00m,
        null => throw new Exception(nameof(name)),
        _ => 0.0m
    };
    Console.WriteLine($"Your drink: {name,-16} - {(price > 0 ? $"{price:c}" : "not found")}");
}
Console.WriteLine("\n----Switch Statement version 3 (Practice 2)----");
FindDrinkPriceV3("melon");
FindDrinkPriceV3("Melon");
FindDrinkPriceV3("pink layy");
FindDrinkPriceV3("pink lady");
FindDrinkPriceV3("sex on the beach");
FindDrinkPriceV3("Sex On The Beach");
FindDrinkPriceV3("daiquiri");
#endregion
#endregion


#region Pattern Matching - Type Pattern - Delacration Pattern - Practice 3
/*
 * 3) For the information samples below whose data type is object, print the data in these objects if one of the following conditions is met:
 * - object is string data type and value starts with letter 'M'
 * - object is int data type and value is greater than or equal 18
 * - object is bool data type and value is true
 * If the object is null, print an error message
 *
 * Samples:
 * ========
 * object
 *     nullObject = null,
 *     nameObject = "Manh",
 *     ageObject = 18,
 *     genderObject = true;
 */

object
    nullObject = null,
    nameObject = "Manh",
    ageObject = 18,
    genderObject = true,
    salaryObject = 10_000m;

#region Version 1
void PrintProfileV1(object value)
{
    string message = string.Empty;
    switch (value)
    {
        case null: message = "Value is null"; break;
        case string name when name.StartsWith("N"): message = $"Name: {name}"; break;
        case int age when age == 18: message = $"The age: {age}"; break;
        case bool gender when gender is true: message = $"Gender: Male"; break;
        default:
            message = $"Not match any case";
            break;
    }
    Console.WriteLine(message);
}
Console.WriteLine("\n---Pattern Matching - Type Pattern - Delacration Pattern - Practice 3---");
PrintProfileV1(nullObject);
PrintProfileV1(nameObject);
PrintProfileV1(ageObject);
PrintProfileV1(genderObject);
PrintProfileV1(salaryObject);
#endregion


#region Version 2

void PrintProfileV2(object value)
{
    string message = string.Empty;
    switch (value)
    {
        case null: message = "Value is null"; break;
        case string name when name.StartsWith("M"): message = $"Name = {name}"; break;
        case >= 17: message = $"Age = {value}"; break;
        case true: message = $"Gender: Man"; break;
    }
    Console.WriteLine(message);
}
Console.WriteLine("\n---Pattern Matching - Type Pattern - Delacration Pattern - Practice 3---");
PrintProfileV2(nullObject);
PrintProfileV2(nameObject);
PrintProfileV2(ageObject);
PrintProfileV2(genderObject);
PrintProfileV2(salaryObject);
#endregion

#region Version 3
void PrintProfileV3(object value)
{
    string message = string.Empty;
    message = value switch
    {
        null => "Value is null",
        string { Length: > 0 } s => s[0] switch { 'M' => $"Name: {value}", _ => "Not match any case" },
        >= 18 => $"Age = {value}",
        true => "Gender: Male",
        _ => "Not match any case",
    };
    Console.WriteLine($"{message}");
}
Console.WriteLine("\n---Pattern Matching - Type Pattern - Delacration Pattern - Practice 3---");
PrintProfileV3(nullObject);
PrintProfileV3(nameObject);
PrintProfileV3(ageObject);
PrintProfileV3(genderObject);
PrintProfileV3(salaryObject);
#endregion

#region Version 4
void PrintProfileV4(object value)
    => Console.WriteLine(value switch
    {
        null => "Value is null",
        string { Length: > 0 } x => x[0] switch { 'M' => $"Name: {value}", _ => "Not match any case" },
        >= 18 => $"Age = {value}",
        true => $"Gender: Male",
        _ => "Not match any case",
    });

Console.WriteLine("\n----Type Pattern - Delacration Pattern version 4 (Practice 3)----");
PrintProfileV4(nullObject);
PrintProfileV4(nameObject);
PrintProfileV4(ageObject);
PrintProfileV4(genderObject);
PrintProfileV4(salaryObject);
#endregion
#endregion


#region Pattern Matching - Type Pattern - Delacration Pattern - Practice 4
/*
 * 4) Write code to calculate the area of a shape based on its shape type like circle, square, triangle or rectangle
 * by using User-Defined DataTypes "Shape" below
 * 
 * User-Defined DataTypes:
 * =========================
 * class Shape { }
 * 
 * class Circle : Shape
 * {
 *     public double Radius { get; set; }
 * }
 * 
 * class Square : Shape
 * {
 *     public double Edge { get; set; }
 * }
 * 
 * class Triangle : Shape
 * {
 *     public double Width { get; set; }
 *     public double Height { get; set; }
 * }
 * 
 * class Rectangle : Shape
 * {
 *     public double Width { get; set; }
 *     public double Height { get; set; }
 * }
 */


#region Version 1
void CalculateAreaV1(Shape shape)
{
    double area = 0.0d;

    switch (shape)
    {
        case Circle c: area = c.Radius * c.Radius * Math.PI; break;
        case Square s: area = s.Edge * s.Edge; break;
        case Triangle t: area = t.Height * t.Width * 0.5; break;
        case Rectangle r: area = r.Height * r.Width; break;
        case Shape s: area = 0; break;
        case null: throw new Exception(nameof(shape));
    }
    Console.WriteLine($"Area of {shape.GetType().Name} is {area}");
}
#endregion
Console.WriteLine("\n----Type Pattern - Delacration Pattern version 1 (Practice 4)----");
CalculateAreaV1(new Shape());
CalculateAreaV1(new Circle { Radius = 5 });
CalculateAreaV1(new Square { Edge = 5 });
CalculateAreaV1(new Triangle { Height = 5, Width = 10 });
CalculateAreaV1(new Rectangle { Height = 5, Width = 10 });

#region Version 2
void CalculateAreaV2(Shape shape)
{
    double area = shape switch
    {
        Circle c => c.Radius * c.Radius * Math.PI,
        Square s => s.Edge * s.Edge,
        Triangle t => t.Height * t.Width * 0.5,
        Rectangle r => r.Height * r.Width,
        Shape => 0,
        null => throw new ArgumentException(nameof(shape)),
    };
    Console.WriteLine($"Area of {shape} is {area}");
}
Console.WriteLine("\n----Type Pattern - Delacration Pattern version 1 (Practice 4)----");
CalculateAreaV2(new Shape());
CalculateAreaV2(new Circle { Radius = 5 });
CalculateAreaV2(new Square { Edge = 5 });
CalculateAreaV2(new Triangle { Height = 5, Width = 10 });
CalculateAreaV2(new Rectangle { Height = 5, Width = 10 });

#endregion

#region Version 3
void CalculateAreaV3(Shape shape)
    => Console.WriteLine($@"Area of {shape} is {shape switch
    {
        Circle c => c.Radius * c.Radius * Math.PI,
        Square s => s.Edge * s.Edge,
        Triangle t => t.Height * t.Width * 0.5,
        Rectangle r => r.Height * r.Width,
        Shape => 0,
        null => throw new ArgumentException(nameof(shape)),
    }}");
Console.WriteLine("\n----Type Pattern - Delacration Pattern version 3 (Practice 4)----");
CalculateAreaV3(new Shape());
CalculateAreaV3(new Circle { Radius = 5 });
CalculateAreaV3(new Square { Edge = 5 });
CalculateAreaV3(new Triangle { Height = 5, Width = 10 });
CalculateAreaV3(new Rectangle { Height = 5, Width = 10 });
#endregion


#endregion


#region Pattern Matching - Logical Pattern - Parenthesized pattern  - Practice 5
/*
 * 5) 
 * A customer's mobile phone number has 10 digits. Check which provider the phone number belongs to.
 *  
 *  Provider Information:
 *  =====================
 *  Mobile      : 089, 090, 093, 070, 079, 077, 076, 078
 *  Viettel     : 086, 096, 097, 098, 032, 033, 034, 035, 036, 037, 038, 039
 *  VinaPhone   : 088, 091, 094, 083, 084, 085, 081, 082
 *  Vietnamobile: 092, 056, 058
 *  Gmobile     : 099, 059
 *  Itelecom    : 087
 *  
 *  //phoneNumber != null
 *  //phoneNumber has 10 digits
 *  //check first three digits of phoneNumber to find provider
 */

void FindPhoneNumberProviderV1(string phoneNumber)
{
    if (phoneNumber is null) throw new Exception(nameof(phoneNumber));

    if (phoneNumber.Length is not 10)
    {
        Console.WriteLine("Invalid phone number");
    }
    string provider = string.Empty;
    switch (phoneNumber[0..3])
    {
        case "089" or "090" or "093" or "070" or "079" or "077" or "076" or "078": provider = "Mobile"; break;
        case "034" or "035" or "036" or "037" or "038" or "039" or "086" or "096" or "097" or "098" or "032" or "033": provider = "Viettel"; break;
        case "088" or "091" or "094" or "083" or "084" or "085" or "081" or "082": provider = "Vinaphone"; break;
        case "092" or "056" or "058": provider = "Vietnamobile"; break;
        case "087": provider = "Itelecom"; break;
        default:
            provider = "Not found";
            break;
    }
    Console.WriteLine($"Provider of number {phoneNumber} is {provider}");
}
Console.WriteLine("\n----Logical Pattern - Parenthesized pattern version 1 (Practice 5)----");
FindPhoneNumberProviderV1("12345");
FindPhoneNumberProviderV1("0890000001");
FindPhoneNumberProviderV1("0860000001");
FindPhoneNumberProviderV1("0880000001");
FindPhoneNumberProviderV1("0920000001");
FindPhoneNumberProviderV1("0870000001");
FindPhoneNumberProviderV1("0120000001");


void FindPhoneNumberProviderV2(string phoneNumber)
{
    switch (phoneNumber)
    {
        case null: throw new Exception(nameof(phoneNumber));
        case { Length: not 10 }:
            Console.WriteLine("Invalid phone number"); break;
        default:
            {
                string provider = string.Empty;

                switch (phoneNumber[0..3])
                {
                    case "089" or "090" or "093" or "070" or "079" or "077" or "076" or "078": provider = "Mobile"; break;
                    case "034" or "035" or "036" or "037" or "038" or "039" or "086" or "096" or "097" or "098" or "032" or "033": provider = "Viettel"; break;
                    case "088" or "091" or "094" or "083" or "084" or "085" or "081" or "082": provider = "Vinaphone"; break;
                    case "092" or "056" or "058": provider = "Vietnamobile"; break;
                    case "087": provider = "Itelecom"; break;
                    default:
                        provider = "Not found";
                        break;
                }
                Console.WriteLine($"Provider of number {phoneNumber} is {provider}");
                break;
            }
    }
}
Console.WriteLine("\n----Logical Pattern - Parenthesized pattern version 2 (Practice 5)----");
FindPhoneNumberProviderV2("12345");
FindPhoneNumberProviderV2("0890000001");
FindPhoneNumberProviderV2("0860000001");
FindPhoneNumberProviderV2("0880000001");
FindPhoneNumberProviderV2("0920000001");
FindPhoneNumberProviderV2("0870000001");
FindPhoneNumberProviderV2("0120000001");


void FindPhoneNumberVersion3(string phoneNumber)
    => Console.WriteLine(phoneNumber switch
    {
        null => throw new ArgumentException(nameof(phoneNumber)),
        { Length: not 10 } => "Invalid phone number",
        _ => $@"Provider of number {phoneNumber} is {phoneNumber[0..3] switch
        {
            "089" or "090" or "093" or "070" or "079" or "077" or "076" or "078" => "Mobile",
            "086" or "096" or "097" or "098" or "032" or "033" or "034" or "035" or "036" or "037" or "038" or "039" => "Viettel",
            "088" or "091" or "094" or "083" or "084" or "085" or "081" or "082" => "VinaPhone",
            "092" or "056" or "058" => "Vietnamobile",
            "099" or "059" => "Gmobile",
            "087" => "Itelecom",
            _ => "not found"
        }}"
    });
Console.WriteLine("\n----Logical Pattern - Parenthesized pattern version 3 (Practice 5)----");
FindPhoneNumberVersion3("12345");
FindPhoneNumberVersion3("0890000001");
FindPhoneNumberVersion3("0860000001");
FindPhoneNumberVersion3("0880000001");
FindPhoneNumberVersion3("0920000001");
FindPhoneNumberVersion3("0870000001");
FindPhoneNumberVersion3("0120000001");


void FindPhoneNumberProviderV4(string phoneNumber)
    => Console.WriteLine(
        phoneNumber is null ? throw new ArgumentException(nameof(phoneNumber)) :
        phoneNumber is { Length: not 10 } ? "Invalid phone number" :
        $@"Provider of number {phoneNumber} is {phoneNumber[0..3] switch
        {
            "089" or "090" or "093" or "070" or "079" or "077" or "076" or "078" => "Mobile",
            "086" or "096" or "097" or "098" or "032" or "033" or "034" or "035" or "036" or "037" or "038" or "039" => "Viettel",
            "088" or "091" or "094" or "083" or "084" or "085" or "081" or "082" => "VinaPhone",
            "092" or "056" or "058" => "Vietnamobile",
            "099" or "059" => "Gmobile",
            "087" => "Itelecom",
            _ => "not found"
        }}"
        );
Console.WriteLine("\n----Logical Pattern - Parenthesized pattern version 4 (Practice 5)----");
FindPhoneNumberProviderV4("12345");
FindPhoneNumberProviderV4("0890000001");
FindPhoneNumberProviderV4("0860000001");
FindPhoneNumberProviderV4("0880000001");
FindPhoneNumberProviderV4("0920000001");
FindPhoneNumberProviderV4("0870000001");
FindPhoneNumberProviderV4("0120000001");
#endregion


#region Pattern Matching - Relational Pattern (<, > , <=, >=) - Practice 6
/*
 * 6) Write the code to calculate the total electricity bill according to the given conditions:
 * - For level 1: (>=   0 and <=  50 kWh): 1.678 VND/kWh
 * - For level 2: (>=  51 and <= 100 kWh): 1.734 VND/kWh
 * - For level 3: (>= 101 and <= 200 kWh): 2.014 VND/kWh
 * - For level 4: (>= 201 and <= 300 kWh): 2.536 VND/kWh
 * - For level 5: (>= 301 and <= 400 kWh): 2.834 VND/kWh
 * - For level 6: (>= 401               ): 2.927 VND/kWh
 * 
 * Example 1:  30 kWH                           => 30 * 1.678    
 * 
 * Example 2:  60 kWh = 50 kWH + 1 0kWH         => (50 * 1.678) + (10 * 1.734)                
 *                                              =  (50 * 1.678) + (60 - 50) * 1.734
 *                                              
 * Example 3: 120 kWH = 50 kWH + 50 kWH + 20kWH => (50 * 1.678) + (50 * 1.734) + (20 * 2.014)
 *                                              =  (50 * 1.678) + (50 * 1.734) + (120 - 100) * 2.014
 *                                              
 * Example 4: 360 kWH = 50 kwh + 50 kWH + 100 kWH + 100 kWH + 60 kWH
 *            => (50 * 1.678) + (50 * 1.734) + (100 * 2.014) + (100 * 2.536) + (60 * 2.834)
 *            =  (50 * 1.678) + (50 * 1.734) + (100 * 2.014) + (100 * 2.536) + (360 - 300) * 2.834
 */

void CalculateElectricBillV1(int kWh)
{
    decimal total = 0.0m;
    switch (kWh)
    {
        case >= 0 and <= 50: total = kWh * 1.678m; break;
        //case >= 51 and <= 100:total = kWh * 1.734m;break;
        case >= 51 and <= 100: total = 83.9m + (kWh - 50) * 1.734m; break;
        //case >= 101 and <= 200:total = kWh * 2.014m;break;
        case >= 101 and <= 200: total = 170.6m + (kWh - 100) * 2.014m; break;
        //case >= 201 and <= 300:total = kWh * 2.536m;break;
        case >= 201 and <= 300: total = 372m + (kWh - 200) * 2.536m; break;
        //case >= 301 and <= 400: total = kWh * 2.834m;break;
        case >= 301 and <= 400: total = 625.6m + (kWh - 300) * 2.834m; break;
        //case >= 401:total = kWh * 2927;break;
        case >= 401: total = 909m + (kWh - 400) * 2.927m; break;

        default: total = 0.0m; break;
    }
    Console.WriteLine(kWh < 0 ? "Invalid data" : $"With {kWh} kWh, electric bill total is {total} VND");
}
Console.WriteLine("\n----Relational Pattern version 1 (Practice 6)----");
CalculateElectricBillV1(-1); //invalid
CalculateElectricBillV1(10); //16780
CalculateElectricBillV1(60); //104040
CalculateElectricBillV1(110);//221540
CalculateElectricBillV1(210);//532560
CalculateElectricBillV1(310);//878540
CalculateElectricBillV1(410);//12000470

#region Version 2
void CalculateElectricBillV2(int Kwh)
{
    decimal total = Kwh switch
    {
        >= 0 and <= 50 => Kwh * 1.678m,
        >= 51 and <= 100 => (50 * 1.678m) + (Kwh - 50) * 1.734m,
        >= 101 and <= 200 => (50 * 1.678m + 50 * 1.734m) + (Kwh - 100) * 2.014m,
        >= 201 and <= 300 => (50 * 1.678m + 50 * 1.734m + 100 * 2.014m) + (Kwh - 200) * 2.536m,
        >= 301 and <= 400 => (50 * 1.678m + 50 * 1.734m + 100 * 2.014m + 100 * 2.536m) + (Kwh - 300) * 2.834m,
        >= 401 => (50 * 1.678m + 50 * 1.734m + 100 * 2.014m + 100 * 2.536m + 100 * 2.834m) + (Kwh - 400) * 2.927m,
        _ => 0.0m,
    };
    Console.WriteLine(Kwh < 0 ? "Invalid data" : $"With {Kwh} kWh, electric bill total is {total:c} VND");
}
Console.WriteLine("\n----Relational Pattern version 1 (Practice 6)----");
CalculateElectricBillV2(-1); //invalid
CalculateElectricBillV2(10); //16780
CalculateElectricBillV2(60); //104040
CalculateElectricBillV2(110);//221540
CalculateElectricBillV2(210);//532560
CalculateElectricBillV2(310);//878540
CalculateElectricBillV2(410);//12000470

#endregion

#region Version 3
void CalculateElectricBillV3(int kWh)
    => Console.WriteLine(kWh < 0 ? "Invalid data" : $@"With {kWh} kWh, electric bill total is {kWh switch
    {
        >= 0 and <= 50 => kWh * 1.678m,
        >= 51 and <= 100 => (50 * 1.678m) + (kWh - 50) * 1.734m,
        >= 101 and <= 200 => (50 * 1.678m + 50 * 1.734m) + (kWh - 100) * 2.014m,
        >= 201 and <= 300 => (50 * 1.678m + 50 * 1.734m + 100 * 2.014m) + (kWh - 200) * 2.536m,
        >= 301 and <= 400 => (50 * 1.678m + 50 * 1.734m + 100 * 2.014m + 100 * 2.536m) + (kWh - 300) * 2.834m,
        >= 401 => (50 * 1.678m + 50 * 1.734m + 100 * 2.014m + 100 * 2.536m + 100 * 2.834m) + (kWh - 400) * 2.927m,
        _ => 0.0m,
    }}");
Console.WriteLine("\n----Relational Pattern version 3 (Practice 6)----");
CalculateElectricBillV3(-1);
CalculateElectricBillV3(10);
CalculateElectricBillV3(60);
CalculateElectricBillV3(110);
CalculateElectricBillV3(210);
CalculateElectricBillV3(310);
CalculateElectricBillV3(410);
#endregion

#endregion


#region Pattern Matching - Property Pattern - Practice 7
/*
 * 7) A brewery with a discount policy as follows:
 * - Buy 1 case of beer, the price remains the same
 * - Buy 2 cases of beer, the price of the first case remains the same and the price of the second case decreases by 5%
 * - Buy 3 cases of beer, the calculation of the discount for the first two cases is still the same, the third one is 10% off.
 * - Buy 4 or more cases of beer, discount calculation for the first three cases remains unchanged. From the 4th case of beer onwards, each barrel is 20% off
 * Calculate the total amount obtained if a person buys 6 cases of beer  by using User-Defined DataTypes "Order" below.
 * 
 * Defaut Cost of one case of beer: 300000
 * 
 * User-Defined DataTypes:
 * =========================
 * class Order
 * {
 *     public int Quantity { get; set; }
 *     public decimal Price { get; set; }
 * }
 * 
 * Buy 1 case of beer  => total = 1 * 300000
 * Buy 2 case of beers => total = 1 * 300000 + 1 * 300000 * (1 - 0.05) 
 *                              = 1 * 300000 + 1 * 300000 * 0.95
 *                              = 1 * 300000 * (1 + 0.95)
 *                              = 1 * 300000 * 1.95
 *                              
 * Buy 3 case of beers = Buy 2 case of beers + 1 * 300000 * (1 - 0.1)
 *                     = 1 * 300000 * 1.95   + 1 * 300000 * 0.9
 *                     = 1 * 300000 * (1.95 + 0.9)
 *                     = 1 * 300000 * 2.85
 * 
 * Buy 4 case of beers = Buy 3 case of beers + 1 * 300000 * (1 - 0.2)
 *                     = Buy 3 case of beers + (4 - 3) * 300000 * 0.8

 *
 * Buy 5 case of beers = Buy 3 case of beers + 2 * 300000 * (1 - 0.2)
 *                     = Buy 3 case of beers + (5 - 3) * 300000 * 0.8
 *                     
 * Buy 6 case of beers = Buy 3 case of beers + 3 * 300000 * (1 - 0.2)
 *                     = Buy 3 case of beers + (6 - 3) * 300000 * 0.8
 *                                       
 */

void CalculateOrderV1(Order order)
{
    decimal total = 0.0m;
    switch (order)
    {
        case { Quantity: 1 }: total = 1 * order.Price; break;
        case { Quantity: 2 }: total = 1 * order.Price + (order.Price * 95) / 100; break;
        case { Quantity: 3 }: total = 1 * order.Price + ((order.Price * 95) / 100) + (order.Price * 90) / 100; break;
        case { Quantity: 4 }: total = 1 * order.Price + ((order.Price * 95) / 100) + ((order.Price * 90) / 100) + ((order.Price * 80) / 100); break;
        case { Quantity: 5 }: total = 1095000 + ((order.Price * 80) / 100); break;
        case { Quantity: 6 }: total = 1095000 + (((order.Price * 80) / 100) * 2); break;
        default:
            total = 0.0m;
            break;
    }
    Console.WriteLine($"Total of {order.Quantity} beer - PRICE is: {total}");
}
Console.WriteLine("\n----Property Pattern version 2 (Practice 6)----");
CalculateOrderV1(new Order { Quantity = 1, Price = 300000m });
CalculateOrderV1(new Order { Quantity = 2, Price = 300000m });
CalculateOrderV1(new Order { Quantity = 3, Price = 300000m });
CalculateOrderV1(new Order { Quantity = 4, Price = 300000m });
CalculateOrderV1(new Order { Quantity = 5, Price = 300000m });
CalculateOrderV1(new Order { Quantity = 6, Price = 300000m });
CalculateOrderV1(new Order { Quantity = 7, Price = 300000m });


#region Version 2
void CalculateOrderV2(Order order)
{
    decimal total = order switch
    {
        { Quantity: 1 } => order.Price,
        { Quantity: 2 } => 1 * order.Price + (order.Price * 95) / 100,
        { Quantity: 3 } => 1 * order.Price + ((order.Price * 95) / 100) + (order.Price * 90) / 100,
        { Quantity: 4 } => 1 * order.Price + ((order.Price * 95) / 100) + ((order.Price * 90) / 100) + ((order.Price * 80) / 100),
        { Quantity: 5 } => 1095000 + ((order.Price * 80) / 100),
        { Quantity: 6 } => 1095000 + (((order.Price * 80) / 100) * 2),
        null => throw new Exception(nameof(order)),
        _ => 0.0m,
    };
    Console.WriteLine($"Total of {order.Quantity} beer - PRICE is: {total:N}");
    //Console.WriteLine($"Total of {order.Quantity} beer - PRICE is: {total:C}");
}
Console.WriteLine("\n----Property Pattern version 2 (Practice 6)----");
CalculateOrderV2(new Order { Quantity = 1, Price = 300000m });
CalculateOrderV2(new Order { Quantity = 2, Price = 300000m });
CalculateOrderV2(new Order { Quantity = 3, Price = 300000m });
CalculateOrderV2(new Order { Quantity = 4, Price = 300000m });
CalculateOrderV2(new Order { Quantity = 5, Price = 300000m });
CalculateOrderV2(new Order { Quantity = 6, Price = 300000m });
CalculateOrderV2(new Order { Quantity = 7, Price = 300000m });
#endregion

#region Version 3
void CalculateOrderV3(Order order)
    => Console.WriteLine($@"Total of {order.Quantity} beer - Price is: {order switch
    {
        { Quantity: 1 } => order.Price,
        { Quantity: 2 } => 1 * order.Price + (order.Price * 95) / 100,
        { Quantity: 3 } => 1 * order.Price + ((order.Price * 95) / 100) + (order.Price * 90) / 100,
        { Quantity: 4 } => 1 * order.Price + ((order.Price * 95) / 100) + ((order.Price * 90) / 100) + ((order.Price * 80) / 100),
        { Quantity: 5 } => 1095000 + ((order.Price * 80) / 100),
        { Quantity: 6 } => 1095000 + (((order.Price * 80) / 100) * 2),
        _ => 0.0m,
    }:N}");
Console.WriteLine("\n----Property Pattern version 2 (Practice 6)----");
CalculateOrderV3(new Order { Quantity = 1, Price = 300000m });
CalculateOrderV3(new Order { Quantity = 2, Price = 300000m });
CalculateOrderV3(new Order { Quantity = 3, Price = 300000m });
CalculateOrderV3(new Order { Quantity = 4, Price = 300000m });
CalculateOrderV3(new Order { Quantity = 5, Price = 300000m });
CalculateOrderV3(new Order { Quantity = 6, Price = 300000m });
CalculateOrderV3(new Order { Quantity = 7, Price = 300000m });
#endregion


#endregion


#region Pattern Matching - Positional Pattern - Discard Pattern - Practice 8
/*
 * 8) Based on the ip address information table, write a code to help the administrator quickly find the network class of any ip address.
 * (Use positional pattern to solve this problems)
 * 
 * ip adress: octet1.octet2.octet3.octet4 
 * => (octet1, octet2, octet3, octet4)
 * 
 * 192.168.1.1 => class C
 */
#region Version 1
void FindClassOfAdressV1(byte octet1, byte octet2, byte octet3, byte octet4)
{
    (byte, byte, byte, byte) ipAddress = (octet1, octet2, octet3, octet4);

    string result = string.Empty;
    switch (ipAddress)
    {
        case ( >= 0 and 126, _, _, _): result = "Class A"; break;
        case ( >= 128 and <= 191, _, _, _): result = "Class B"; break;
        case ( >= 192 and <= 233, _, _, _): result = "Class C"; break;
        case ( >= 224 and <= 239, _, _, _): result = "Class D"; break;
        case ( >= 240 and <= 254, _, _, _): result = "Class E"; break;
        default:
            result = "no found or invalid";
            break;
    }
    Console.WriteLine($"Ip Address {octet1}.{octet2}.{octet3}.{octet4} is {result}");
}
Console.WriteLine("\n----Positional Pattern - Discard Pattern version 1 (Practice 7)----");
FindClassOfAdressV1(192, 168, 1, 1);
#endregion

#region Version 2
void FindClassOfAdressV2(byte octet1, byte octet2, byte octet3, byte octet4)
{
    string result = (octet1, octet2, octet3, octet4) switch
    {
        ( >= 0 and 126, _, _, _) => "Class A",
        ( >= 128 and <= 191, _, _, _) => "Class B",
        ( >= 192 and <= 233, _, _, _) => "Class C",
        ( >= 224 and <= 239, _, _, _) => "Class D",
        ( >= 240 and <= 254, _, _, _) => "Class E",
        _ => "no found or invalid",
    };
    Console.WriteLine($"Ip Address {octet1}.{octet2}.{octet3}.{octet4} is {result}");
}
Console.WriteLine("\n----Positional Pattern - Discard Pattern version 2 (Practice 7)----");
FindClassOfAdressV2(192, 168, 1, 1);
#endregion

#region Version 3
void FindClassOfAdressV3(byte octet1, byte octet2, byte octet3, byte octet4)
    => Console.WriteLine($@"Ip Address: {octet1}.{octet2}.{octet3}.{octet4} is {(octet1,octet2,octet3,octet4) switch
    {
        ( >= 0 and 126, _, _, _) => "Class A",
        ( >= 128 and <= 191, _, _, _) => "Class B",
        ( >= 192 and <= 233, _, _, _) => "Class C",
        ( >= 224 and <= 239, _, _, _) => "Class D",
        ( >= 240 and <= 254, _, _, _) => "Class E",
        _ => "no found or invalid",
    }
        }");
Console.WriteLine("\n----Positional Pattern - Discard Pattern version 3 (Practice 7)----");
FindClassOfAdressV3(192, 168, 1, 1);
#endregion
#endregion

#region Order for Excersice 07
class Order
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
#endregion

#region Shape for Excersice 04
class Shape { }

class Circle : Shape
{
    public double Radius { get; set; }
}

class Square : Shape
{
    public double Edge { get; set; }
}

class Triangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
}

#endregion
