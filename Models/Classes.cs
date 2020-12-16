using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewAssignment.Models
{
    public class Classes
    {
        public string ClassID { get; set; }
        public int ClassCapacity { get; set; }
        public string CourseID { get; set; }
        public string CourseTitle { get; set; }
        public int Credits { get; set; }
        public int DayID { get; set; } 
        public int StudentsEnrolled { get; set; }
        public string Modality { get; set; }
        public string SectionStatusID { get; set; }
        public string DisplayModality  { get {
                if (Modality == "80")
                    return "Hybrid";
                else if (Modality == "50")
                    return "Virtual";
                else if (Modality == "51")
                    return "Virtual Hybrid";
                else if (Modality == "3C")
                    return "Online";
                else
                    return "Face to Face";
            }
        }

        public string Status { get {
                if (SectionStatusID == "X")
                    return "Cancelled";
                else if(ClassCapacity<=StudentsEnrolled)
                {
                    return "Closed";
                }
                else
                {
                    return (ClassCapacity - StudentsEnrolled).ToString();
                }
                   
            } 
        }
        public string Quarter => ClassID.Substring(ClassID.Length - 4);
    }
    //public class GroupedClasses
    //{
    //    public IReadOnlyList<Classes> Classes { get; set; }
    //    public string Quarter { get => ; set; }
    //}
}
