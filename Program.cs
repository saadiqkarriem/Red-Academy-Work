namespace Ifstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choose;
            int myPin;
            double balance, newbalance, newbalance2,  deposit, withdrawl, viewbalance, newpin;

            balance = 6000;

            Console.WriteLine(" Please enter pin ");
            myPin = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

            if (myPin == 1975)
            {
                Console.WriteLine("Welcome, \n" + "Which Of the following Action Would You like to do?: ");
                Console.WriteLine("*******************\n Deposit: \n*******************\n Withdraw: \n*******************\n View Balance: \n*******************\n New Pin: \n*******************");
                choose = Console.ReadLine();


                if (choose == "Deposit")
                {
                    Console.WriteLine(" Please enter the amount you would like to deposit");
                    deposit = Convert.ToInt32(Console.ReadLine());

                    newbalance = (balance + deposit);


                    Console.WriteLine("New Balance is: R" + newbalance);

                }

                else if (choose == "Withdraw")
                {
                    Console.WriteLine(" Please enter the amount you would like to withdrawl ");
                    withdrawl = Convert.ToInt32(Console.ReadLine());

                    newbalance2 = (balance - withdrawl);


                    Console.WriteLine("New Balance is: R" + newbalance2);

                }

                else if (choose == "View Balance")
                {
                    Console.WriteLine(" Please enter your balance amount ");
                    viewbalance = Convert.ToInt32(Console.ReadLine());

                    newbalance = (balance + viewbalance);


                    Console.WriteLine(" Please enter your balance amount " + viewbalance);

                }

                else if (choose == "New pin")
                {
                    Console.WriteLine(" Please change your pin");
                    newpin = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Please change your pin " + newpin);

                }






            }
           
            else
            {
                
                Console.WriteLine(" Incorrect Pin ");

            }
            








            }
        }
    }