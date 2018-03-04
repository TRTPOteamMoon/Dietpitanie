namespace Dietpitanie
{
    internal class Human
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Index { get; set; }


        public Human (double height, double weight)
        {
            Height = (height/100);
            Weight = weight;
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
    }
}
