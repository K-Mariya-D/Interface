using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTutor
{
    public class Formula
    {
        public string Name { get; set; }
        public string Data { get; set; }
        public Formula(string Name,string Data)
        {
            if (Name == null) throw new ArgumentNullException("Name is null");
            this.Name = Name;
            if (Data == null) throw new ArgumentNullException("Data is null");
            this.Data = Data;
        }
        public override string ToString()
        {
            return $"{Name} -> {Data}";
        }
    }
}
