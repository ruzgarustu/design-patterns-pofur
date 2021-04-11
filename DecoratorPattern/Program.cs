using DecoratorPattern.BaseTreatment;
using System;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume we have 2 options of treatments for Pofur: We can visit the local vet or can urgently take him to clinic if it is an emergency. (Both classes derive from ITreatment interface)
            // Based on the problem, he might have different operations separately or togehter: Like getting a routine control and/or vaccinated, X-rayed or ultrasound.
            // These are decorator classes that decorate LocalVetTreatment or UrgentClinicTreatment. 

            Console.WriteLine("Pofur goes to a plain control to the vet:");
            var routineControl = new RoutineControl(new LocalVetTreatment());
            Console.WriteLine($"Treatment: {routineControl.GetDescription()} Cost: {routineControl.GetCost()}");

            Console.WriteLine("Pofur goes urgently to animal clinic due to gastro-intestinal infection and we need to live on bread and cheese for the rest of the month now:");
            var gastroIntestinalInfectionTreatment = new Ultrasound(new XRay(new UrgentClinicTreatment()));
            Console.WriteLine($"Treatment: {gastroIntestinalInfectionTreatment.GetDescription()} Cost: {gastroIntestinalInfectionTreatment.GetCost()}");

            Console.ReadLine();

        }
    }
}
