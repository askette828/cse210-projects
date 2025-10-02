using System;
using Classes;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Front-End Developer", "Dartcore Inc.", 2022, 2025);
        Job job2 = new Job("QA Analyst", "CRM systems", 2018, 2020);

        job1.Display();
        job2.Display();


    }
}