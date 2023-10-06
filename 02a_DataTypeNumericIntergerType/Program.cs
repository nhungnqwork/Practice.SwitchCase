#region Topic
/*
 * 7) A customer wants to buy some cakes at a bakery. 
 *    Use integer data type to represent the type of cake, its quantity, and its unit price. 
 *    Calculate the amount that the customer needs to pay for each cake and for the whole order.
 *    See cake menu "Valentine Bakery Cake Menu 2022 Template - Made with Poster My Wall"
 */

#region Cake Data
using System.Xml.Linq;

ushort muffins = 1 | (1 << 5);          //id = 1, price = $1 
                    //$50               //0_00001 | 1_00000
                                        // 0b0001_00001
ushort chocco_muffins = 2 | (2 << 5);   //id = 2, price = $2
                   //$100               //0_00010 | 0_00010
                                        //  0b0100_0010
ushort de_muffins_theme = 3 | (3 << 5); //id = 3, price: $3 //$150
ushort eggless_cake = 4 | (50 << 5);     //id = 4, price: $4 //$2500
ushort diabetie_cake = 5 | (50 << 5);     //id = 5, price: $4 //$2500
ushort black_forest_cake = 6 | (34 << 5); // id = 6, //$1700
ushort red_velvet_cheese_cake = 7  | (60 << 5); // id = 7, //$3000
ushort caramel_cake = 8  | (40 << 5); // id = 8, //$2000
#endregion


#region Algorithms for cake data
void DisplayCake(string name, ushort cake)
{
    Console.WriteLine($"STT: {name}");
    Console.WriteLine($"     {name.Replace('_', ' ')}");
    Console.WriteLine($"---------------------------");
    Console.WriteLine($"Binary Layout: {Convert.ToString(cake,2).PadLeft(11,'0')}");
    Console.WriteLine($"Temporary price: ${cake >> 5}");
    Console.WriteLine($"Real price: ${(cake >> 5) * 50}\n\n");
}
DisplayCake(nameof(muffins), muffins);
DisplayCake(nameof(chocco_muffins), chocco_muffins);
DisplayCake(nameof(de_muffins_theme), de_muffins_theme);
DisplayCake(nameof(eggless_cake), eggless_cake);
DisplayCake(nameof(diabetie_cake), diabetie_cake);
DisplayCake(nameof(black_forest_cake), black_forest_cake);
DisplayCake(nameof(red_velvet_cheese_cake), red_velvet_cheese_cake);
DisplayCake(nameof(caramel_cake), caramel_cake);
#endregion


#region Order Data
uint orderLine1 = (uint)(muffins | (3 << 11));
uint orderLine2 = (uint)(chocco_muffins | (1 << 11));
uint orderLine3 = (uint)(de_muffins_theme | (2 << 11));
uint orderLine4 = (uint)(eggless_cake | (10 << 11));
uint orderLine5 = (uint)(diabetie_cake | (7 << 11));
uint orderLine6 = (uint)(black_forest_cake | (1 << 11));
uint orderLine7 = (uint)(red_velvet_cheese_cake | (2 << 11));
uint orderLine8 = (uint)(caramel_cake | (5 << 11));

void DisplayOrder(string name, uint orderLine)
{
    uint price    = orderLine >> 5 & 0b111111;
    uint quantity = orderLine >> 11;
    Console.WriteLine($"Order: {name.Replace('_', ' ')}");
    Console.WriteLine($"---------------------------");
    Console.WriteLine($"Binary Layout: {Convert.ToString(orderLine,2).PadLeft(18,'0')}");
    Console.WriteLine($"Quantity: {quantity}");
    Console.WriteLine($"Temporary price: {price}"); 
    Console.WriteLine($"Temporary amount: ${quantity * price}");
    Console.WriteLine($"Real price      : ${price * 50}");
    Console.WriteLine($"Real amount     : ${quantity * price * 50}\n");
}
DisplayOrder(nameof(muffins), orderLine1);
DisplayOrder(nameof(chocco_muffins), orderLine2);
DisplayOrder(nameof(de_muffins_theme), orderLine3);
DisplayOrder(nameof(eggless_cake), orderLine4);
DisplayOrder(nameof(diabetie_cake), orderLine5);
DisplayOrder(nameof(black_forest_cake), orderLine6);
DisplayOrder(nameof(red_velvet_cheese_cake), orderLine7);
DisplayOrder(nameof(caramel_cake), orderLine8);
#endregion


#endregion