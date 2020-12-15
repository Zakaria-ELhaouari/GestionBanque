using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_De_Comptes_Bancaires
{
    class CompteSurCheque : AbstractCompte
    {
        public int NumeroCheque;
        public CompteSurCheque()
        {

        }

        public CompteSurCheque(int numero, string nomProprietaire, double solde, int NumeroCheque) : base(numero, nomProprietaire, solde)
        {
            this.NumeroCheque = NumeroCheque;
        }

        public override void crediter(double somme)
        {
            this.Solde += somme;
            Console.WriteLine($"Numero : {Numero} || NomProprietaire  : {NomProprietaire} || NomProprietaire  : {Solde} || NomProprietaire  : {NumeroCheque}");
        }

        public override void Debiter(double somme)
        {
            if (somme > Solde)
            {
                throw new ArgumentException("Solde insuffisant ");
            }
            else
            {
                this.Solde -= somme;
                Console.WriteLine($"Numero : {this.Numero}  NomProprietaire  : {this.NomProprietaire} || NomProprietaire  : {this.Solde} || NomProprietaire  : {this.NumeroCheque}");
            }
        }

        public override void AfficheInfo()
        {
            Console.WriteLine($"Numero : {this.Numero} || NomProprietaire  : {this.NomProprietaire} || NomProprietaire  : {this.Solde} || NomProprietaire  : {this.NumeroCheque}");
        }
    }
}
