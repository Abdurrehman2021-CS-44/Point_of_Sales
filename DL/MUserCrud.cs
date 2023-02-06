using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using System.IO;

namespace PointOfSale.DL
{
    class MUserCrud
    {
        public static List<MUser> usersList = new List<MUser>();
        public static void addUserIntoList(MUser user)
        {
            usersList.Add(user);
        }
        public static string isUser(MUser user)
        {
            foreach (MUser i in usersList)
            {
                if (i.userName == user.userName)
                {
                    if (i.userPassword == user.userPassword)
                    {
                        return i.userRole;
                    }
                }
            }
            return null;
        }
        public static bool loadIntoList(string path)
        {
            /*StreamReader file = new StreamReader(path);
            string record = "";
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedString = record.Split(',');
                    string userName = splittedString[0];
                    string Password = splittedString[1];
                    string Role = splittedString[2];
                    MUser u = new MUser(userName, Password, Role);
                    addUserIntoList(u);
                }
                file.Close();
                return true;
            }*/
            return true;
        }
        public static void storeDataIntoFile(string path, MUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.userName + "," + user.userPassword + "," + user.userRole);
            file.Flush();
            file.Close();
        }
    }
}
