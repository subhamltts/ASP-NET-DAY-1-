using ProjectX_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjextX_DAL
{
    public class ModelDAL
    {
        public List<Model> DisplayModel()
        {
            try
            {
                var display = new ProjectX_DB();
                List<Model> lstModel = display.Models.ToList();
                return lstModel;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
