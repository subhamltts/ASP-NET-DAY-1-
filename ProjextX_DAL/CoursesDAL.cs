using ProjectX_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjextX_DAL
{
    public class CoursesDAL
    {
        Cours CouObj;
        
        public List<Cours> DisplayCourse()
        {
            try
            {
                var display = new ProjectX_DB();

                List<Cours> deptList = display.Courses.ToList();

                return deptList;
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
                List<CoursesDTO> lstResult = new List<CoursesDTO>();
                ProjectX_DB XobjDB = new ProjectX_DB();
                var rndPartList = XobjDB.Courses.
                    Where(x => x.CourseID ==couId).ToList();
                foreach (var item in rndPartList)
                {
                    lstResult.Add(new CoursesDTO()
                    {
                        CourseID = item.CourseID,
                        CourseTitle = item.CourseTitle,
                        Duration = item.Duration,
                        Owner = item.Owner,
                        AssessmentMode = item.AssessmentMode
                    });
                }
                return lstResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
