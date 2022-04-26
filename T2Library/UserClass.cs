using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2Library
{
    public class UserClass
    {
        private delegate void UserEvent (string value);
        private event UserEvent Printmessage;
        static private int count;

        public UserClass()
        {
            this.Printmessage += temp => Console.WriteLine(temp);
        }

        public void SayHello (string message)
        {
            Console.WriteLine(message);
            count++;
            if(count == 10)
            {
                Printmessage.Invoke("Метод вызван 10 раз");
            }
        }

    }
}
