using FeeTypeForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeeTypeForm.Repositories
{
    public interface IFeeTypeRepository
    {
        DataTable GetAll();
        void AddFeeType(FeeType feetype); 
        void UpdateFeeType(FeeType feetype);
        void DeleteFeetype(int FeeTypeID);
    }
}
