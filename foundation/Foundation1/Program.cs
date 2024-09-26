using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobtitle = "Backend Platform Developer";
        job1._company = "Veritas";
        job1._startYear = 2016;
        job1.endYear = 2020;

        job job2 = new job();
        job2._jobtitle = "Senior Platform Engineer";
        job2._company = "BBC"
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Bella Newcastle";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    
    }
    
}        
