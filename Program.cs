using System;

namespace Gestion_De_Comptes_Bancaires
{
    class Program
    {
        static void Main(string[] args)
        {

            Banquecontenant Bank = new Banquecontenant();

            Console.WriteLine("yu peux cree un acc taper y c no taper n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                //Create Account
                Bank.AjouterCompte();

                //Manage Account
                Bank.ManageAccount();
            }
            else
            {
                Bank.search();
            }

        }

    }
}
