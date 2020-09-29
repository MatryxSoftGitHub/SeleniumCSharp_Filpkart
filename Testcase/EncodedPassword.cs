using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Flipkart_CS.Testcase
{
    class EncodedPassword
    {
        [Test]

        public void Encoded_Password()
        {
            string passWord = "";//pass the password in a string 
            var passwordInBytes = Encoding.UTF8.GetBytes(passWord);
            string encodedPassword = Convert.ToBase64String(passwordInBytes);
            Console.WriteLine("Encoded password is: " + encodedPassword);

           // VmlkeWEyNzEy Encoded password
        }
    }
}
