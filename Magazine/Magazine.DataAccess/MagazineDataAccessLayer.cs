using System;
using Magazine.Entities;
using Magazine.Exceptions;
using Magazine.DataAccessLayer.DAL_Contracts;
using System.Collections.Generic;

namespace Magazine.DataAccessLayer
{
    public class MagazineDataAccessLayer : IMagazineDataAccessLayer
    {
        private static List<AmagnoMagazine> _magazines;

        static MagazineDataAccessLayer()
        {
            _magazines = new List<AmagnoMagazine>();
        }

        private List<AmagnoMagazine> Magazines
        {
            set => _magazines = value;
            get => _magazines;
        }

        public List<AmagnoMagazine> GetMagazines()
        {

            try
            {

                List<AmagnoMagazine> customersList = new List<AmagnoMagazine>();
                Magazines.ForEach(item => customersList.Add(item.Clone() as AmagnoMagazine));
                return customersList;

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

        public List<AmagnoMagazine> GetMagazinesByCondition(Predicate<AmagnoMagazine> predicate)
        {
            try
            {

                List<AmagnoMagazine> magazineList = new List<AmagnoMagazine>();


                List<AmagnoMagazine> filteredMagazine = Magazines.FindAll(predicate);


                filteredMagazine.ForEach(item => magazineList.Add(item.Clone() as AmagnoMagazine));
                return magazineList;
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
                magazine.MagazineID = Guid.NewGuid();
                Magazines.Add(magazine);
                return magazine.MagazineID;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public bool UpdateMagazine(AmagnoMagazine magazine)
        {

            try
            {


                AmagnoMagazine existingMagazine = Magazines.Find(item => item.MagazineID == magazine.MagazineID);



                if (existingMagazine != null)
                {

                    existingMagazine.MagazineID = magazine.MagazineID;
                    existingMagazine.MagazineName = magazine.MagazineName;
                    existingMagazine.MagazineVersion = magazine.MagazineVersion;
                    existingMagazine.MagazineTitle = magazine.MagazineTitle;
                 
                    return true;

                }
                else
                {
                    return false;
                }
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

                if (Magazines.RemoveAll(item => item.MagazineID == magazineID) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
