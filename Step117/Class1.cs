using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step117
{
    public class Class1
    {
        //Step 6: static class
        public static string secretMessage;
        public Class1()
        {
            secretMessage = "Hi there!";
        }
  
        public void VoidMethod(int x, out int y)
        {
            y = x / 2;
        }

        public void VoidMethod(int x, int z, out int y)
        {
            int a;
            a = x + z;
            y = a / 2;
        }







    }
}
