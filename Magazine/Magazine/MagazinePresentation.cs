using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Entities;
using Magazine.BusinessLogic;
using Magazine.BusinessLogic.BALContracts;

namespace MagazinePresentation
{
    static class MagazinePresentation
    {
        internal static void AddMagazine()
        {
            try
            {
                AmagnoMagazine magazine = new AmagnoMagazine();

                Console.WriteLine("\n********ADD Magazine*************");
                Console.WriteLine("Magazine Name:");
                magazine.MagazineName = Console.ReadLine();
                Console.WriteLine("Magazine Title: ");
                magazine.MagazineTitle = Console.ReadLine();
               
                IMagazineBusinessLogic magazineBusinessLogic = new MagazineBusinessLogic();
                Guid newGuid = magazineBusinessLogic.AddMagazine(magazine);

                List<AmagnoMagazine> matchingMagazines = magazineBusinessLogic.GetMagazineByCondition(item => item.MagazineID == newGuid);

                if (matchingMagazines.Count >= 1)
                {
                    Console.WriteLine("New Magazine Code: " + matchingMagazines[0].MagazineID);
                    Console.WriteLine("Magazine Added.\n");
                }
                else
                {
                    Console.WriteLine("Magazine Not added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                
            }
        }
        internal static void ViewMagazine()
        {
            try
            {

                IMagazineBusinessLogic magazineBusinessLogic = new IMagazineBusinessLogic();


                List<AmagnoMagazine> allCustomers = magazineBusinessLogic.GetMagazine();

                Console.WriteLine("\n**********ALL Magazines*************");

                foreach (var item in allCustomers)
                {

                    Console.WriteLine("Magazine Code: " + item.MagazineID);
                    Console.WriteLine("Magazine Name: " + item.MagazineName);                    
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                throw;
            }



        }
        internal static void EditMagazine()
        {
            try
            {

                Console.WriteLine("\n**********UPDATE Magazine*************");



                IMagazineBusinessLogic magazineBusinessLogic = new IMagazineBusinessLogic();

                Console.WriteLine("\n**********Enter a Magazine Version*************");

                int magazineVersion = Convert.ToInt32(Console.ReadLine());

                List<AmagnoMagazine> matchingMagazine = magazineBusinessLogic.GetMagazineByCondition(item => item.MagazineVersion == magazineVersion);



                if (matchingMagazine.Count >= 1)
                {
                    Console.WriteLine("Magazine Found : " + matchingMagazine[0].MagazineName);

                    Console.WriteLine("\n**********UPDATE CUSTOMER*************");
                    Console.Write("Magazine Name: ");
                    matchingMagazine[0].MagazineName = Console.ReadLine();
                   

                    if (magazineBusinessLogic.UpdateMagazine(matchingMagazine[0]))
                    {

                        Console.WriteLine("Magazine Updated Successfully");

                    }


                }
                else
                {

                    Console.WriteLine("No Magazine found");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                throw;
            }

        }
        internal static void DeleteMagazine()
        {
            try
            {

                Console.WriteLine("\n**********DELETE Magazine*************");



                IMagazineBusinessLogic magazineBusinessLogic = new IMagazineBusinessLogic();

                Console.WriteLine("\n**********Enter a Magazine code*************");

                long MagazineVersion = Convert.ToInt32(Console.ReadLine());

                List<AmagnoMagazine> matchingMagazine = magazineBusinessLogic.GetMagazineByCondition(item => item.MagazineVersion == MagazineVersion);



                if (matchingMagazine.Count >= 1 && magazineBusinessLogic.DeleteMagazine(matchingMagazine[0].MagazineID))
                {

                    Console.WriteLine("Magazine Deleted Successfully");

                }
                else
                {

                    Console.WriteLine("No Magazine found");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                throw;
            }

        }
    }
}
