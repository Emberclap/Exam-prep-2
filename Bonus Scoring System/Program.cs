namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfLectures = double.Parse(Console.ReadLine());
            double bonusPoints = double.Parse(Console.ReadLine());

            double maxBonusPoints = 0;
            int Attendances = 0;
            
            for (int i = 0; i < numberOfStudents; i++)
            {
                int currentStudentAttendance = int.Parse(Console.ReadLine());
                
                double currentMaxBonus = currentStudentAttendance / numberOfLectures * (5 + bonusPoints);
                if (currentMaxBonus > maxBonusPoints)
                {
                    maxBonusPoints = currentMaxBonus;
                    Attendances = currentStudentAttendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonusPoints)}.");
            Console.WriteLine($"The student has attended {Attendances} lectures.");
        }
    }
}