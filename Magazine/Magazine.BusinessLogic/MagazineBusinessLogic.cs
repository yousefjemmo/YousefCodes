using System;
using System.Collections.Generic;
using Magazine.BusinessLogic.BALContracts;
using Magazine.DataAccessLayer;
using Magazine.DataAccessLayer.DAL_Contracts;
using Magazine.Entities;
using Magazine.Exceptions;

namespace Magazine.BusinessLogic
{
    public class IMagazineBusinessLogic : BALContracts.IMagazineBusinessLogic
    {

        private IMagazineDataAccessLayer _magazinesDataAccessLayer;

        public IMagazineBusinessLogic()
        {

            _magazinesDataAccessLayer = new MagazineDataAccessLayer();

        }

        private IMagazineDataAccessLayer MagazineDataAccessLayer
        {

            set => _magazinesDataAccessLayer = value;
            get => _magazinesDataAccessLayer;

        }

        public List<AmagnoMagazine> GetMagazine()
        {

            try
            {

                return MagazineDataAccessLayer.GetMagazines();

            }
            catch (MagazineExceptions)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<AmagnoMagazine> GetMagazineByCondition(Predicate<AmagnoMagazine> predicate)
        {

            
            try
            {
                return MagazineDataAccessLayer.GetMagazinesByCondition(predicate);
            }
            catch (MagazineExceptions)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Guid AddMagazine(AmagnoMagazine magazine)
        {

            try
            {

                List<AmagnoMagazine> allMagazines = MagazineDataAccessLayer.GetMagazines();

                MagazineDataAccessLayer.GetMagazines();

                int maxMagzNo = 0;

                foreach (var item in allMagazines)
                {

                    if (item.MagazineVersion > maxMagzNo)
                    {

                        maxMagzNo = item.MagazineVersion;

                    }

                }

                if (allMagazines.Count >= 1)
                {

                    magazine.MagazineVersion = maxMagzNo + 1;

                }
                else
                {

                    magazine.MagazineVersion = magazine.MagazineVersion + 1;

                }

                return MagazineDataAccessLayer.AddMagazine(magazine);

            }
            catch (MagazineExceptions)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool UpdateMagazine (AmagnoMagazine magazine)
        {

            try
            {

                return MagazineDataAccessLayer.UpdateMagazine(magazine);

            }
            catch (MagazineExceptions)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool DeleteMagazine(Guid magazineID)
        {

            try
            {

                return MagazineDataAccessLayer.DeleteMagazine(magazineID);

            }
            catch (MagazineExceptions)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
