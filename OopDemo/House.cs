using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    // Detta är en RITNING 
    public class House
    {
        public House(int year, string address)
        {
            if (year < 1900 || year > DateTime.Now.Year)
                throw new ArgumentException("Ange ett bra år DUMMER ");
            this.year = year;
            this.address = address;
        }

        public void Repaint(string color)
        {
            this.color = color;
            spentOnRenovations += 10000;
        }

        private int spentOnRenovations = 0;

        private int year;  
        private string address = "";

        private string color = "";


        public int TotalRenovations()
        {
            return spentOnRenovations;
        }
    }
}
