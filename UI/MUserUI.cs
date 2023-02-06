using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;

namespace PointOfSale.UI
{
    class MUserUI
    {
        public static MUser takeInput()
        {
            string userName, userPassword, userRole;
            Console.Write("Enter Username : ");
            userName = Console.ReadLine();
            Console.Write("Enter Password : ");
            userPassword = Console.ReadLine();
            Console.Write("Enter Role : ");
            userRole = Console.ReadLine();
            MUser user = new MUser(userName, userPassword, userRole);
            return user;
        }
    }
}
