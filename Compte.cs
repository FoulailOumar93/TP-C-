using System;
public class Compte
{
	public Compte()
	{
		private string solde;
		private int numero;
		private string nom;
		private string DecouvertAutorise;

	//constructeur par défaut
	public Compte() 

	// constructeur avec les attributs des classes

		public Compte(string solde, int numero, string nom, string DecouvertAutorise)
		{
			this.solde = solde;
			this.numero = numero;
			this.nom = nom;
			this.DecouvertAutorise = DecouvertAutorise;
		}

		public string solde
		{
			get { return solde; }
			set { solde = value; }
		}

		public int numero
		{
			get { return numero; }
			set { numero = value; }
		}
		public string nom
		{
			get { return nom; }
			set { nom = value; }
		}
		public string DecouvertAutorise
		{
			get { return DecouvertAutorise; }
			set { DecouvertAutorise = value; }
		}
		// méthode de classe
		public void Afficher()
		{
			Console.WriteLine(this.solde+ "" + this.numero + "" + this.nom + "" + "DecouverteAutorise"+this.DecouvertAutorise);
		}
		
}
				static void Main()
	{
					// *********A àjouter*****************
					Banque b = new Banque();
					b.ajouterType("ch, "chèque débité");


					b.ajouterType("pre", "prélèvement");
					b.ajouterType("dab", "retrait en distributeur");
					b.ajouterType("ret", "retrait guichet ");
					b.ajouterType("vir", "virement sur compte");
					b.ajouterType("dch", "chèque déposé");
					b.ajouterType("des", "dépôt d’espèce");
	}			}		// **********Fin ajout*********


