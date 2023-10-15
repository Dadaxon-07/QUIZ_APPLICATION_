using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralQuiz
{
    class Quiz
    {
        private string[,] questions = new string[20, 5];
        public Quiz()
        {
            questions[0, 0] = "The 2006 World Cup Football Tournament held in";
            questions[0, 1] = "France";
            questions[0, 2] = "China";
            questions[0, 3] = "*Germany";
            questions[0, 4] = "Brazil";
            //
            questions[1, 0] = "The 'Black flag' signifies";
            questions[1, 1] = "revolution/danger";
            questions[1, 2] = "*protest";
            questions[1, 3] = "truce";
            questions[1, 4] = "peace";
            //
            questions[2, 0] = "Robert Koch worked on";
            questions[2, 1] = "*tuberculosis";
            questions[2, 2] = "cholera";
            questions[2, 3] = "malaria";
            questions[2, 4] = "diabetes";
            //
            questions[3, 0] = "The 2002 Commonwealth Games were held in";
            questions[3, 1] = "*UK";
            questions[3, 2] = "Canada";
            questions[3, 3] = "Australia";
            questions[3, 4] = "Malaysia";
            //
            questions[4, 0] = "The 2012 Olympics Games were held in";
            questions[4, 1] = "New York";
            questions[4, 2] = "Seul";
            questions[4, 3] = "*London";
            questions[4, 4] = "Tokyo";
            //
            questions[5, 0] = "Who is the owner of Marvel Studios";
            questions[5, 1] = "Warner Bros";
            questions[5, 2] = "*Walt Disney";
            questions[5, 3] = "21st Century Fox";
            questions[5, 4] = "Universal Studios";
            //
            questions[6, 0] = "Pythagoras was first to ____ the universal validity of geometrical theorem.";
            questions[6, 1] = "give";
            questions[6, 2] = "*prove";
            questions[6, 3] = "both";
            questions[6, 4] = "None of the above";
            //
            questions[7, 0] = "Sulphur is not present in";
            questions[7, 1] = "iron pyrites";
            questions[7, 2] = "gypsum";
            questions[7, 3] = "coal";
            questions[7, 4] = "*chlorapatite";
            //
            questions[8, 0] = "Oscar Awards were instituted in";
            questions[8, 1] = "1968";
            questions[8, 2] = "1901";
            questions[8, 3] = "1965";
            questions[8, 4] = "*1929";
            //
            questions[9, 0] = "Sculpture flourished during";
            questions[9, 1] = "*Indus valley civilization";
            questions[9, 2] = "Egyptian civilization";
            questions[9, 3] = "Chinese civilization";
            questions[9, 4] = "None of the above";
            //
            questions[10, 0] = "Penicillin is widely used as";
            questions[10, 1] = "an insecticide";
            questions[10, 2] = "an antiseptic";
            questions[10, 3] = "a disinfectant";
            questions[10, 4] = "*an antibiotic";
        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i,int j)
        {
            return questions[i, j];
        }

    }
}
