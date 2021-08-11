using ProjectX_DTO;
using ProjextX_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_BL
{
    public class BatchBL
    {
        ProjextX_DAL.BatchDAL DalObj = new ProjextX_DAL.BatchDAL();
        public BatchDTO ParticipantInputValues(string Bid, string Bname, int Bstrength)
        {
            try
            {
                BatchDTO dto_obj = new BatchDTO();
                dto_obj.BatchID = Bid;
                dto_obj.BatchName = Bname;
                dto_obj.BatchStrength = Bstrength;


                return dto_obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateBatchInfo(BatchDTO dtonewObj)
        {
            int result = DalObj.UpdateBatchName(dtonewObj);
            return result;
        }

        public int deleteBatchInfo(string BName)
        {
            int result = DalObj.DeleteBatchName(BName);
            return result;
        }
        public List<BatchDTO> DisplayParticipant()
        {
            try
            {
                List<BatchDTO> depts = new List<BatchDTO>();

                foreach (var item in DalObj.DisplayBatch())
                {
                    BatchDTO dtoObj = new BatchDTO
                    {
                        BatchID = item.BatchID,
                        BatchName = item.BatchName,
                        BatchStrength = item.BatchStrength,

                    };
                    depts.Add(dtoObj);
                }
                return depts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BatchDTO> GetParticipantName(string BId)
        {
            var partList = DalObj.GetBatchNameByID(BId);
            return partList;
        }
        public int UpdateBatchInfo(string name)
        {
            throw new NotImplementedException();
        }
    }
}
