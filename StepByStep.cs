using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Homework_03
{
    public class StepByStep
    {
        public List<int> trueNum = new List<int> { 1, 2, 3, 4};  // Задаем список допустимых значений

        public StepByStep()
        { }
        public string LogUser { get; set; } // Логин пользователя
        public int NumGame { get; set; }   // Номер в игре

        /// <summary>
        /// Функция поиска допустимых значений в списке
        /// </summary>
        /// <param name=""></param>
        public FList(int FNum)
        {
            int k = 0;
            foreach (var tn in this.trueNum)
            {
                if (FNum == tn.ElementAt(k++))
                { }

            }
        }
    }
}
