using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Entities;

namespace Magazine.DataAccessLayer.DAL_Contracts
{
    public interface IMagazineDataAccessLayer
    {
        List<AmagnoMagazine> GetMagazines();


        List<AmagnoMagazine> GetMagazinesByCondition(Predicate<AmagnoMagazine> predicate);
        Guid AddMagazine(AmagnoMagazine magazine);

        bool UpdateMagazine(AmagnoMagazine magazine);

        bool DeleteMagazine(Guid magazineID);
        
    }
}
