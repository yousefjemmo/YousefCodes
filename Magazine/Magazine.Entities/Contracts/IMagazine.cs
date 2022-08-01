using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities.Contracts
{
    public interface IMagazine
    {
        Guid MagazineID { get; set; }
        string MagazineName { get; set; }
        int MagazineVersion { get; set; }
        string MagazineTitle { get; set; }

    }
}
