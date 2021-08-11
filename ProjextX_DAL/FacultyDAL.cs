using ProjectX_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjextX_DAL
{
    public class FacultyDAL
    {
        Faculty FacObj;
        
        public List<Faculty> DisplayFaculty()
        {
            try
            {
                var display = new ProjectX_DB();

                List<Faculty> deptList = display.Faculties.ToList();

                return deptList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<FacultyDTO> GetFacultyNameByID(int partId)
        {
            try
            {
                List<FacultyDTO> lstResult = new List<FacultyDTO>();
                ProjectX_DB XobjDB = new ProjectX_DB();
                var rndPartList = XobjDB.Faculties.
                    Where(x => x.PSNo == partId).ToList();
                foreach (var item in rndPartList)
                {
                    lstResult.Add(new FacultyDTO()
                    {
                        PSNo = item.PSNo,
                        FacultyName = item.FacultyName,
                        EmailID = item.EmailID
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
