using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Uygulaması
{
    class Question
    {
        public Question(string text, string[] choices, string answers)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answers = answers;
        }
        public string Text { get; set; }
        public string[] Choices { get; set; }//dizi yaptık çünkü cevaplar dizi şeklinde olucaktır.
        public string Answers { get; set; }
        public bool checkAnswer(string answer)
        {
            return this.Answers == answer;
        }
    }
    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }
        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }
        private Question getQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }
        public void DisplayQuestion()
        {
            var question = this.getQuestion();
            this.DisplayProgress();
            Console.WriteLine($"Soru {this.QuestionIndex + 1}: {question.Text}");
            foreach (var c in question.Choices)
            {
                Console.WriteLine($"{c}");
            }
                Console.Write("Cevap:");
                var cevap=Console.ReadLine();
            this.Guess(cevap);
        }
        private void Guess(string answer)
        {
            var question = this.getQuestion();
            if(question.checkAnswer(answer))//skor
            {
                this.Score++;
            }
            this.QuestionIndex++;
            if(this.Questions.Length==this.QuestionIndex)
            {
                this.DisplayScore();
                return;
            }
            else
            {
                
                this.DisplayQuestion();
            }

           // this.DisplayQuestion();
        }
        private void DisplayScore()
        {
            Console.WriteLine($"Score:{this.Score}");
        }
        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber=this.QuestionIndex+1;
           
                
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP:Harry Potter Filmi Quiz Uygulaması
            var q1 = new Question("Lord Voldemort'un gücünü kendinde sandığı mürver asa gerçekte en son kime itaat ediyordu?", new string[] { "a)Draco Malfoy", "b)Albus Dumbledore", "c)Severus Snape", "d)Harry Potter" }, "d");
            var q2 = new Question("Hermione Granger'ın en sevdiği ders hangisiydi?", new string[] { "a)Şekil Değiştirme", "b)Muggle Araştırmaları", "c)Aritmetik", "d)Zehirler" }, "a");
            var q3 = new Question("Harry Potter, çataldili konuşma özelliğini kimden almıştır?", new string[] { "a)Rubeus Hagrid", "b)Lily Potter", "c)Voldemort", "d)Albus Dumbledore" }, "c");
            var q4 = new Question("Hangisi Hagrid'in hayvanlarından biri değildir?", new string[] { "a)Fluffy", "b)Norberta", "c)Grawp", "d)Aragog" }, "c");
            var q5 = new Question("Hangisi Voldemort'un hortkuluklarından biri değildir?", new string[] { "a)Gryffindor'un kılıcı", "b)Tom Riddle'ın Günlüğü", "c)Helga Hufflepuff'ın Kupası", "d)Harry Potter" }, "a");
            var q6 = new Question("Hangi karakter safkan büyücüdür?", new string[] { "a)Severus Snape", "b)Ron Weasly", "c)Lord Voldemort", "d)Hermione Granger" }, "b");
            var q7 = new Question("Quidditch Dünya Kupası finali nasıl sonuçlanmıştır?", new string[] { "a)160-150", "b)180-170", "c)150-170", "d)170-160" }, "d");
            var q8 = new Question("Harry Potter ve Sırlar Odası filminde, Dobby’nin filmin sonunda sahip olduğu çorap hangi renktir?", new string[] { "a)Mavi", "b)Kırmızı", "c)Siyah", "d)Gri" }, "d");
            var q9 = new Question("Felsefe taşı hangi renkti?", new string[] { "a)kırmızı", "b)siyah", "c)yeşil", "d)mor" }, "a");
            var q10 = new Question("Ravenclaw'un sembolü nedir?", new string[] { "a)kaplan", "b)porsuk", "c)şahin", "d)karga" }, "c");
            var questions = new Question[] { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10 };
            var quiz = new Quiz(questions);
            quiz.DisplayQuestion();
            
           
            
        }
    }
}
