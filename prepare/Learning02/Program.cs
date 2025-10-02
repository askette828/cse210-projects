using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Front-End Developer", "Dartcore Inc.", 2022, 2025);
        Job job2 = new Job("QA Analyst", "CRM systems", 2018, 2020);

        Resume resume1 = new Resume("Dias Doktyrbek");
        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);


        resume1.Display();


    }
}