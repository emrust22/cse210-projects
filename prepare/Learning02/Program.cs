using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Digital AdOps Specialist";
        job1._company = "Premion";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Paid Media Specialist";
        job2._company = "Digital Natives";
        job2._startYear = 2024;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Emily Rust";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}