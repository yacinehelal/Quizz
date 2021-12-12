namespace QuizzCorection
{
    public class Candidat
    {
        public Candidat()
        {
        }
        public string FirstName { get; set; }
        public int GetResults(Question questionFoot, string reponse)
        {
            int result = 0;
            if (questionFoot.GoodReponse.Description == reponse)
            {
                result = 1;
            }
            return result;
        }

        public double GetResultsAll(Question question, List<string> reponses)
        {
            double result = 0;
            int bonnesReponses = 0;

            foreach (var bonne in question.GoodReponses)
            {
                foreach (var reponse in reponses)
                {
                    if (reponse == bonne.Description)
                    {
                        bonnesReponses += 1;
                    }
                }
            }


            result = bonnesReponses / question.GoodReponses.Count;
            return result;
        }
    }
}