using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;
using PointOfSale.UI;

namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersPath = "Users.txt";
            string productPath = "Product.txt";
            string option;
            
            if (ProductDL.loadIntoList(productPath))
            {
                Console.WriteLine("Product Data load successfully.");
            }
            if (MUserCrud.loadIntoList(usersPath))
            {
                Console.WriteLine("Users Data load successfully.");
            }

            while (true)
            {
                Console.Clear();
                option = MenuUI.mainMenu();
                if (option == "1")
                {
                    string userName, userPassword;
                    Console.Write("Enter Username : ");
                    userName = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    userPassword = Console.ReadLine();
                    MUser user = new MUser(userName, userPassword);
                    string users = MUserCrud.isUser(user);
                    if (users == "Admin")
                    {
                        string option1;
                        while (true)
                        {
                            Console.Clear();
                            option1 = MenuUI.adminMenu();
                            if (option1 == "1")
                            {
                                Product p = ProductUI.takeInputForProduct();
                                ProductDL.addIntoTheList(p);
                                ProductDL.storeDataIntoFile( productPath, p);
                            }
                            else if (option1 == "2")
                            {
                                ProductUI.viewProducts();
                            }
                            else if (option1 == "3")
                            {
                                ProductUI.highestPriceProduct();
                            }
                            else if (option1 == "4")
                            {
                                ProductUI.viewSalesTax();
                            }
                            else if (option1 == "5")
                            {
                                ProductUI.lessThanThresholdProducts();
                            }
                            else if (option1 == "6")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Username & Password");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                        }
                        continue;
                    }
                    else if (users == "User")
                    {
                        string option2;
                        while (true)
                        {
                            option2 = MenuUI.userMenu();
                            if (option2 == "1")
                            {
                                ProductUI.viewProducts();
                            }
                            else if (option2 == "2")
                            {
                                CustomerUI.buyProduct();
                            }
                            else if (option2 == "3")
                            {
                                CustomerUI.genInvoice();
                            }
                            else if (option2 == "4")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Username & Password");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (option == "2")
                {
                    MUser u = MUserUI.takeInput();
                    MUserCrud.usersList.Add(u);
                    MUserCrud.storeDataIntoFile(usersPath, u);
                }
                else if (option == "3")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }

        }
    }
}
