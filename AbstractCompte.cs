using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_De_Comptes_Bancaires
{
    abstract class AbstractCompte
    {
        private string nomProprietaire;
        private double solde;
        private int numero;
        public List<AbstractCompte> Accounts = new List<AbstractCompte>();
        public string NomProprietaire
        {
            get { return nomProprietaire; }
            set { nomProprietaire = value; }
        }

        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public AbstractCompte()
        {

        }
        public AbstractCompte(int Numero, string NomProprietaire, double Solde)
        {
            this.Numero = Numero;
            this.NomProprietaire = NomProprietaire;
            this.Solde = Solde;
        }

        public void Manage(int Index)
        {
            Console.WriteLine(@"Select next etape :
1 - AFicher les info
2 - Withdraw 
3 - Diposit
4 - Suprime");

            int Etape = Convert.ToInt32(Console.ReadLine());
            switch (Etape)
            {
                case 1:
                    Accounts[Index].AfficheInfo();
                    break;
                case 2:
                    Console.WriteLine("Taper le somme que tu peux diposit");
                    Accounts[Index].Debiter(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine("taper la somme que tu peux ajouter");
                     Accounts[Index].crediter(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 4:
                    Accounts.RemoveAt(Index);
                    Console.WriteLine("Good by");
                    break;
                default:
                    break;
            }
        }

         
        public abstract void AfficheInfo();
       

        public abstract void crediter(double somme);

        public abstract void Debiter(double somme);
    }
}
