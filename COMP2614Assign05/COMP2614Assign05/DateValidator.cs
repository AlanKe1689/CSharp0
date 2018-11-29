using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class DateValidator
    {
        private const int MIN_YEAR = 1900;

        public static bool Validate(string year, string month, string day)
        {
            bool isValid = false;

            try
            {
                DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

                if (date.Year >= MIN_YEAR)
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {

            }
            return isValid;
        }
    }
}
