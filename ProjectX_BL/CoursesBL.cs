using ProjectX_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_BL
{
    public class CoursesBL
    {
        ProjextX_DAL.CoursesDAL DalObj = new ProjextX_DAL.CoursesDAL();
        public List<CoursesDTO> DisplayCourse()
        {
            try 
            {
                List<CoursesDTO> lstCourses = new List<CoursesDTO>();
                foreach (var item in DalObj.DisplayCourse())
                {
                    CoursesDTO coursesDTOObj = new CoursesDTO
                    {
                        CourseID = item.CourseID,
                        CourseTitle = item.CourseTitle,
                        Duration = item.Duration,
                        Owner = item.Owner,
                        AssessmentMode = item.AssessmentMode
                    };
                    lstCourses.Add(coursesDTOObj);
                }
                return lstCourses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CoursesDTO> GetCourseNameByID(string couId)
        {
            try
            {
                var courseList = DalObj.GetCourseNameByID(couId);
                return courseList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
