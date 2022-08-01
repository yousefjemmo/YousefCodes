using System;
using Magazine.Exceptions;
using Magazine.Entities.Contracts;

namespace Magazine.Entities
{
    public class AmagnoMagazine : IMagazine, ICloneable
    {
        private Guid _magazineID;
        private string _magazineName;
        private int _magazineVersion;
        private string _magazineTitle;

        public Guid MagazineID { get => _magazineID; set => _magazineID = value; }

        public int MagazineVersion
        {
            get => _magazineVersion;
            set
            {
                if (value > 0)
                {
                    _magazineVersion = value;
                }
                else
                {

                    throw new MagazineExceptions("Customer code should only be positive");
                }
            }
        }

        public string MagazineName
        {

            get => _magazineName;

            set
            {
                if (value.Length < 40 && string.IsNullOrEmpty(value) == false)
                {
                    _magazineName = value;

                }
                else
                {
                    throw new MagazineExceptions("Magazine code should longer than 40 and not null");
                }
            }

        }
        public string MagazineTitle
        {

            get => _magazineTitle;

            set
            {
                if (value.Length < 40 && string.IsNullOrEmpty(value) == false)
                {
                    _magazineTitle = value;

                }
                else
                {
                    throw new MagazineExceptions("Magazine Title");
                }
            }

        }

        public object Clone()
        {
            return new AmagnoMagazine() { MagazineID = this.MagazineID, MagazineName = this.MagazineName, MagazineVersion = this.MagazineVersion, _magazineTitle = this.MagazineTitle}; //coppy all values of current instance
        }
    }
}
