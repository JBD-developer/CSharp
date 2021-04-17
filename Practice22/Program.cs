using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice22
{
    //Array
    //배열은 데이터를 담는 상자와 같아서 필요한 용량을 가진 배열을 만들어서 담는다 
    //배열은 각 요소에 데이터를 저장, 요소 안에 있는 데이터를 읽어올 때 배열 이름 뒤에 괄호 [] 를 붙이고 
    //[] 사이에는 indexx를 적어주면 된다 주의할 점은 index는 1부터가 아니라 0부터 시작한다는 것이다 

    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int[] score = new int[5];
            for(int i=0; i<score.Length; i++)
            {
                score[i] = rdm.Next(0, 10);
                Console.WriteLine(score[i]);
            }

            int totalScore = 0; 
            double avgScore = 0;
            
            int[] score2 = new int[10];
            foreach(int scoreValue in score)
            {
                totalScore += scoreValue;
                Console.WriteLine($"score={scoreValue}");
            }
            Console.WriteLine($"Total Score={totalScore}");

            avgScore =(double) totalScore / score.Length;

            Console.WriteLine($"Average Score={avgScore}");
        }
    }
}
