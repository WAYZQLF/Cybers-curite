// See https://aka.ms/new-console-template for more information
using Cybersécurite;

utilisateur u1 = new utilisateur(new DateTime(23/03/2026), "toto@libre.fr", 1, "harsh123", "alice", 1);
ProfilSecurite P1 = new ProfilSecurite(false,DateTime.Now,1,true,1,5);
Console.WriteLine(P1.ToString());
Console.WriteLine(u1.ToString());