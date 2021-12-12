using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizzCorection;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Les resultat de alexis ? 

            // le resulat à la question 
            //quel est le nonmbre de buts encaissés par les sio1
            // lors de la derniere recontre 
            // alexis au bord de l'agonie a repondu 3
            Question questionFoot = new Question();
            questionFoot.Description = "Resultats match SIO";
            Reponse reponse0 = new Reponse();
            reponse0.Description = "0";
            questionFoot.Reponses.Add(reponse0);
            Reponse reponse1 = new Reponse();
            reponse1.Description = "1";
            questionFoot.Reponses.Add(reponse1);
            Reponse reponse2 = new Reponse();
            reponse2.Description = "2";
            questionFoot.Reponses.Add(reponse2);
            Reponse reponse3 = new Reponse();
            reponse3.Description = "3";
            questionFoot.Reponses.Add(reponse3);
            questionFoot.GoodReponse = reponse3;
            Candidat alexis = new Candidat();
            alexis.FirstName = "Alexis";
            // alexis obtient 100% 
            Assert.AreEqual(1, alexis.GetResults(questionFoot, "3"));


            
            // Creation de la question
            Question questionChampionsLeague = new Question();
            questionChampionsLeague.Description = "Quels sont les equipes qualifier pour la CampionsLeague";

            // Creation des reponses
            Reponse reponse4 = new Reponse();
            reponse4.Description = "PSG";

            Reponse reponse5 = new Reponse();
            reponse5.Description = "Real";

            Reponse reponse6 = new Reponse();
            reponse6.Description = "Barca";

            Reponse reponse7 = new Reponse();
            reponse7.Description = "Bayern";

            // autres résultat 
            Assert.AreEqual(1, alexis.GetResultsAll(questionChampionsLeague,
                new List<string> { "PSG", "Real Madrid", "Bayern Munich" })
                );
        }
    }
}