using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Entities;

namespace Magazine.BusinessLogic.BALContracts
{
    internal interface IMagazineBusinessLogic
    {
        public interface ICustomersBusinessLogicLayer
        {
            


            List<AmagnoMagazine> GetMagazines();


            List<AmagnoMagazine> GetMagazinesByCondition(Predicate<AmagnoMagazine> predicate);


            Guid AddMagazine(AmagnoMagazine magazine);


            bool UpdateMagazine(AmagnoMagazine magazine);


            bool DeleteMagazine(Guid magazineID);


           
        }
    }
}
