using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_De_Comptes_Bancaires
{
    class CompteSurCarnet : AbstractCompte
    {
        public int NumeroCanret;
        //this.Accounts.Add(new CompteSurCarnet(12, "Ziko", 1200, 1222 ));
        public CompteSurCarnet()
        {

        }
 
        public CompteSurCarnet(int numero, string nomProprietaire, double solde, int NumeroCanret) : base(numero, nomProprietaire, solde)
        {
            this.NumeroCanret = NumeroCanret;
        }
        public override void crediter(double somme)
        {
            this.Solde += somme;
            Console.WriteLine($"Numero : {this.Numero} || NomProprietaire  : {this.NomProprietaire} || Solde  : {this.Solde} || NumCarnet  : {this.NumeroCanret}");
        }

        public override void Debiter(double somme)
        {
            if (somme > this.Solde)
            {
                throw new ArgumentException("Solde insuffisant ");
            }
            else if (somme > 10000)
            {
                throw new ArgumentException("Plafond dépassé ");
            }
            else
            {
                this.Solde -= somme;
                Console.WriteLine($"Numero : {this.Numero} || NomProprietaire  : {this.NomProprietaire} || Solde  : {this.Solde} || NumCarnet  : {this.NumeroCanret}");
            }
        }

        public override void AfficheInfo()
        {
            Console.WriteLine($"Numero : {this.Numero} || NomProprietaire  : {this.NomProprietaire} || Solde  : {this.Solde} || NumCarnet  : {this.NumeroCanret}");
        }
    }
}
