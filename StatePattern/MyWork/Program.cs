using System;

namespace MyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Work myProjects = new Work();
            myProjects.Hour = 9;
            myProjects.WriteProgram();

            myProjects.Hour = 10;
            myProjects.WriteProgram();

            myProjects.Hour = 12;
            myProjects.WriteProgram();

            myProjects.Hour = 13;
            myProjects.WriteProgram();

            myProjects.Hour = 14;
            myProjects.WriteProgram();

            myProjects.Hour = 17;
            myProjects.WriteProgram();

            //myProjects.TaskFinished = true;
            myProjects.TaskFinished = false;
            myProjects.WriteProgram();

            myProjects.Hour = 19;
            myProjects.WriteProgram();

            myProjects.Hour = 22;
            myProjects.WriteProgram();

            Console.Read();
        }
    }
}
