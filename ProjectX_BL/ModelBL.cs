using ProjectX_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_BL
{
    public class ModelBL
    {
        ProjextX_DAL.ModelDAL DALObj = new ProjextX_DAL.ModelDAL();
        public List<ModelDTO> DisplayModel()
        {
            try
            {
                List<ModelDTO> lstModel = new List<ModelDTO>();
                foreach(var item in DALObj.DisplayModel())
                {
                    ModelDTO modelDTOObj = new ModelDTO
                    {
                        ModelID = item.ModelID,
                        ModelName = item.ModelName,
                        ModelOwner = item.ModelOwner,
                        ModelDate = item.ModelDate
                    };
                    lstModel.Add(modelDTOObj);
                }
                return lstModel;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
