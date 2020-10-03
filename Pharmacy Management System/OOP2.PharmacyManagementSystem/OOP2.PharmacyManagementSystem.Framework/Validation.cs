using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.PharmacyManagementSystem.Framework
{
    public static class Validation
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        public static bool IsIntValid(string value)
        {
            int i;
            return Int32.TryParse(value, out i);
        }

        //another way to implement
        public static bool IsFloatValid(string value)
        {
            try
            {
                float.Parse(value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool IsDoubleValid(string value)
        {
            try
            {
                double.Parse(value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool IsDateTimeValid(string value)
        {
            try
            {
                DateTime.Parse(value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
