using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _GZFramework.Demo.Common
{
    public class ConvertEx
    {
        public static string ToString(object o)
        {
            if (o == null) return string.Empty;
            try
            {
                return o.ToString();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 转换为整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToInt(object o)
        {
            return ToInt(o, 0);
        }

        /// <summary>
        /// 转换为整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToInt(object o, int DefultValue)
        {
            if (IsNULL(o)) return DefultValue;
            try
            {
                return (int)Convert.ToDouble(o);
            }
            catch { return DefultValue; }
        }

        public static string DateTimeToString(DateTime time, string format)
        {
            return time.ToString(format);
        }

        public static DateTime ToDateTime(object o)
        {
            try
            {
                return Convert.ToDateTime(o);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }


        private static bool IsNULL(object o)
        {
            if (null == o)
                return true;
            if (DBNull.Value == o)
                return true;
            if (String.Empty.Equals(o))
                return true;
            return false;
        }
    }
}
