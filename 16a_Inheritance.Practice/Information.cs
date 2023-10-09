using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16a_Inheritance.Practice
{
    public class Information
    {
        private string serialNumber;
        private string codeNumber;

        public string ProviderName { get; set; }
        public Denomination De { get; set; }
        public string SeriNumber 
        {
            get => serialNumber;
            set
            {
                if (value is null)
                {
                    Console.WriteLine("Serial number is empty");
                }
                if (value is { Length: not 12})
                {
                    Console.WriteLine("Length must be 12 digits.");
                }
                else
                {
                    serialNumber = value;
                }
            }

        }
        public string CodeNumber
        {
            get => codeNumber;
            set
            {
                if (value is null)
                {
                    Console.WriteLine("Code number is empty.");
                }
                if (value is { Length: not 14})
                {
                    Console.WriteLine("Length must be 14 digits.");
                }
                else
                {
                    codeNumber = value;
                }
            }
        }
        public DateTime Expiration { get; set; }
        public bool isValid() => DateTime.Now <= Expiration;
        public override string ToString()
            => new StringBuilder()
            .AppendLine($"Provider name: {ProviderName}")
            .AppendLine($"Denomination: {De}")
            .AppendLine($"Seri code: {serialNumber}")
            .AppendLine($"Code number: {codeNumber}")
            .AppendLine($"IsValid: {(isValid()? "con han" : "het han su dung")}")
            .ToString();
    }
    public enum Denomination
    {
        _20 = 0,
        _50  = 1,
        _100 = 2,
        _200 = 3,
        _300 = 4,
        _500 = 5
    }
}
