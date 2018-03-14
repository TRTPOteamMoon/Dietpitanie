using System.Security.Cryptography.X509Certificates;

namespace Dietpitanie
{
    internal class Human
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }
        public int Sex { get; set; }
        public double Index { get; set; }
        public double Bmr { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }


        public Human (double height, double weight, double age, int sex)
        {
            Height = (height/100);
            Weight = weight;
            Age = age;
            Sex = sex;
        }

        public void CalcuteIndex()
        {
            Index = Weight / (Height * Height);
        }

        public string CompareIndex()
        {
            if (Index < 16)
                return "Выраженный дефицит массы тела";
            if (Index < 18.5 && Index > 16)
                return "Дефицит массы тела";
            if (Index >= 18.5 && Index < 25)
                return "Нормальный вес";
            if (Index >= 25 && Index < 30)
                return "Предожирение";
            if (Index >= 30 && Index < 35)
                return "Ожирение 1 степени";
            if (Index >= 35 && Index < 40)
                return "Ожирение 2 степени";
            return "Ожирение 3 степени";
        }

        public void CalculateBmr(string activity1Type,string activity2Type, double time)
        {
            Bmr = 9.99 * Weight + 6.25 * Height - 4.95 * Age;
            if (Sex==1)
            {
                Bmr += 5;
            }
            else
            {
                Bmr -= 161;
            }

            switch (activity1Type)
            {
                case "сидячая работа, отсутствие спорта":
                    Bmr = Bmr * 1.2;
                    break;
                case "легкие физические упражнения около 3 раз за неделю, ежедневная утренняя зарядка, пешие прогулки":
                    Bmr = Bmr * 1.35;
                    break;
                case "спорт до 5 раз за неделю":
                    Bmr = Bmr * 1.55;
                    break;
                case "активный образ жизни вкупе с ежедневными интенсивными тренировками":
                    Bmr = Bmr * 1.75;
                    break;
                case "спортивный образ жизни, тяжелый физический труд, длительные тяжелые тренировки каждый день":
                    Bmr = Bmr * 1.95;
                    break;
            }

            if (time > 0)
            {
                switch (activity2Type)
                {
                    case "ничего":
                        break;
                    case "велоспорт":
                        Bmr += 660 * time / 60;
                        break;
                    case "бег трусцой":
                        Bmr += 600 * time / 60;
                        break;
                    case "волейбол":
                        Bmr += 350 * time / 60;
                        break;
                    case "гимнастика":
                        Bmr += 440 * time / 60;
                        break;
                    case "катание на коньках":
                        Bmr += 400 * time / 60;
                        break;
                    case " плавние":
                        Bmr += 350 * time / 60;
                        break;
                }
            }
        }

        public void CalculateMacroelemnts()
        {
            Proteins = Weight * 1.2;
            Fats = Weight * 0.5;
            Carbohydrates = (Bmr - Proteins * 4 - Fats * 9) / 4;
        }
    }
}
