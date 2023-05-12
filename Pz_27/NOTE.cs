using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz_27
{
    struct NOTE
    {
        private string NAME;
        public string name
        {
            get
            {
                return NAME;
            }
            set
            {
                NAME = value;
            }
        }
        private string TELE;
        public string tele
        {
            get
            {
                return TELE;
            }
            set
            {
                TELE = value;
            }
        }
        private int[] BDAY = new int[3];
        public int[] bday
        {
            get
            {
                return BDAY;
            }
            set
            {
                BDAY = value;
            }
        }
        public NOTE(string NAME, string TELE, int[] BDAY)
        {
            this.NAME = NAME;
            this.TELE = TELE;
            this.BDAY = BDAY;
        }
        public void PrintNote()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Телефон: " + tele);
            Console.Write("Дата рождения: ");
            foreach (int i in bday)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
