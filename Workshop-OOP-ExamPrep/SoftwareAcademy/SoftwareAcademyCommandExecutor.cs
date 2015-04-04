namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using SoftwareAcademy.Models;
    using SoftwareAcademy.Interfaces;

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            //using (var sw = new StreamWriter("../../test.out.txt"))
            //{
            //    Console.SetOut(sw);

                CourseFactory factory = new CourseFactory();
                ICourse css = factory.CreateLocalCourse("CSS", null, "Ultimate");
                Console.WriteLine(css);
            //}
        }
    }
}
