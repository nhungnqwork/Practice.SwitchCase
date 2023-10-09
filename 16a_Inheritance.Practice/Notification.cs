using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16a_Inheritance.Practice
{
    public class Notification : Information
    {
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public double Total()
        {
            return ((int)(Price) * Discount)/100;
        }
        public override string ToString()
            => new StringBuilder()
            .AppendLine($"||   Provider name: {ProviderName}      ||")
            .AppendLine($"||   Denomination: {De}           ||")
            //.AppendLine($"Seri code: {serialNumber}")
            .AppendLine($"||   Seri code: {SeriNumber}      ||")
            //.AppendLine($"Code number: {codeNumber}")
            .AppendLine($"||   Code number: {CodeNumber}  ||")
            .AppendLine($"||   IsValid: {(isValid() ? "Valid" : "Expire")}              ||")
            .AppendLine($"||   Price: {Price}                ||")
            .AppendLine($"||   Discount: {Discount}                 ||")
            .AppendLine($"||   Total: {Total()}                ||")
            .ToString();

        #region Make_Sound
        public void MakeSoundRelease()
        {
            Console.WriteLine("A customer has just completed an order");
        }
        public void MakeSoundDone() { Console.WriteLine("ORDER COMPLETED!!"); }
        public void MakeSoundReturn() { Console.WriteLine("The customer requests to return the order"); }
        #endregion

    }
}
