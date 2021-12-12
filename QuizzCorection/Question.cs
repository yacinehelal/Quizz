using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCorection
{
    public class Question
    {
        public List<Reponse> Reponses { get; set; }
        public List<Reponse> GoodReponses { get; set; }
        public Question()
        {
            Reponses = new List<Reponse>();
            GoodReponses = new List<Reponse>();
        }
        public string Description { get; set; }
        public Reponse GoodReponse { get; set; }
    }


}
