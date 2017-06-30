using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PaperRound.Business.Models;

namespace PaperRound.Business.Parse
{
    /// <summary>
    /// Processes to build and populate a streett model for use
    /// </summary>
    public class StreetBuilder
    {
        private const string Street1 = "1 2 4 3 6 5 7 8 9 10 12 11 13 15";
     
        /// <summary>
        /// Gets the street.
        /// </summary>
        /// <param name="filePath">The submitted file path.</param>
        /// <returns></returns>
        public static Street GetStreet()
        {
            //TODO: GET THIS FROM THE FILE ON THE FILEPATH 
            var streetNumbers = Street1;

            var streetNumbersList = new List<int>();

            var houses = GetHouses(streetNumbers);

            var street = new Street
            {
                Crosses = GetCrosses(houses)
                , Valid = Utilities.Strings.IsValidStreet(streetNumbers)
                , Houses = houses
                , North = GetStreetSide(streetNumbersList, 1)
                , South = GetStreetSide(streetNumbersList, 2)
                , Sequence = streetNumbers.Replace(" ", ",")
            };

            return street;
        }

        /// <summary>
        /// Gets the houses.
        /// </summary>
        /// <param name="streetNumbers">The street numbers.</param>
        /// <returns></returns>
        public static List<House> GetHouses(string streetNumbers)
        {
            var houses = new List<House>();

            var houseItems = streetNumbers.Split(' ');

            var x = 1;

            foreach (var item in houseItems)
            {
                var houseNumber = int.Parse(item);

                var house = new House
                {
                    Number = houseNumber
                    , IsEven = !Utilities.Integers.IsOdd(houseNumber)
                    , Sequence = x
                };

                houses.Add(house);

                x++;
            }

            return houses;
        }

        /// <summary>
        /// Gets the street side.
        /// </summary>
        /// <param name="streetNumbers">The street numbers.</param>
        /// <param name="modulo">The modulo.</param>
        /// <returns></returns>
        private static StreetSide GetStreetSide(List<int> streetNumbers, int modulo)
        {
            var streetSide = new StreetSide();

            return streetSide;
        }

        private static int GetCrosses(List<House> houses)
        {
            var x = 0;

            var side = false;

            foreach (var house in houses)
            {
                if (!side.Equals(house.IsEven))
                {
                    x = x + 1;

                    side = house.IsEven;
                }
            }

            return x;
        }
    }
}
