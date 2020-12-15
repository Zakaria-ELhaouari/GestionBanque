using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_De_Comptes_Bancaires
{
    class Banquecontenant
    {
        //List<CompteSurCheque> ChequeAcc = new List<CompteSurCheque>() { new CompteSurCheque(1, "zakaria", 2870, 1234) };
        //List<CompteSurCarnet> CarnetAcc = new List<CompteSurCarnet>() { new CompteSurCarnet(1, "Asmae", 3000, 1234) };
        static bool Quit = false;
        CompteSurCheque Chequew = new CompteSurCheque();
        CompteSurCarnet Carnet = new CompteSurCarnet();

        public Banquecontenant()
        {
            Chequew.Accounts.Add(new CompteSurCheque(1, "Zakaria", 10200, 1323));
            Carnet.Accounts.Add(new CompteSurCarnet(2, "Asmae", 3000, 1234));
        }

        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private int typeAcc;  
        public int TypeAcc
        {
            get { return typeAcc; }
            set { typeAcc = value; }
        }

        internal void search()
        {
            Console.WriteLine("Taper le num de votre Compte");
            int numAcc = Convert.ToInt32(Console.ReadLine());

            var ListCarnet = Carnet.Accounts.FindAll(x => x.Numero == numAcc);
            var ListCheque = Chequew.Accounts.FindAll(x => x.Numero == numAcc);
            if(ListCarnet.Count != 0)
            {
                ListCarnet[0].AfficheInfo();
                int Sindex = Carnet.Accounts.IndexOf(ListCarnet[0]);
                Carnet.Manage(Sindex);
            }
            else if(ListCheque.Count != 0)
            {
                ListCheque[0].AfficheInfo();
                int Sindex = Chequew.Accounts.IndexOf(ListCheque[0]);
                Chequew.Manage(Sindex);
            }
            else
            {
                Console.WriteLine("This acc is not exist");
            }
        }

        internal void AjouterCompte()
        {
            Console.WriteLine("Num acc:");
            int RefNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            string yourName = Console.ReadLine();
            Console.WriteLine("Solde");
            double solde = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Taper 1 c ton acc est carnet
Taper 2 c ton acc est cheque");
            int AccountType = Convert.ToInt32(Console.ReadLine());
            TypeAcc = AccountType;
            if (AccountType == 1)
            {
                Console.WriteLine("num Carnet");
                int NumCarnet = Convert.ToInt32(Console.ReadLine());
                Carnet.Accounts.Add(new CompteSurCarnet(RefNum, yourName, solde, NumCarnet));
                Index = Carnet.Accounts.Count - 1;
            }
            else if(AccountType == 2)
            {
                Console.WriteLine("Num Cheque");
                int NumCheque = Convert.ToInt32(Console.ReadLine());
                Chequew.Accounts.Add(new CompteSurCheque(RefNum, yourName, solde, NumCheque));
                Index = Chequew.Accounts.Count - 1;
                
            }

        }

        internal void ManageAccount()
        {
            while (Quit == false)
            {
                if (TypeAcc == 1)
                {
                    Carnet.Manage(Index);
                } else if(TypeAcc == 2)
                {
                    Chequew.Manage(Index);
                }
                Console.WriteLine("Press Q to (quite) or (Enter) to continue");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    Quit = true;
                }
            }
        }

    }


}
