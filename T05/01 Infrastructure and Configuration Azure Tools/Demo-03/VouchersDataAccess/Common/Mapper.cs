using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vouchers
{
    public class Mapper
    {
        public static void CopyData(object Source, object Destination, bool CopyID = false)
        {
            if (Source == null) throw new ArgumentNullException("Source");
            PropertyInfo[] props = Source.GetType().GetProperties();
            foreach (PropertyInfo p in props)
            {
                if (CopyID || p.Name != "ID")
                {
                    object val = p.GetValue(Source, null);
                    if (p.CanWrite && val != null)
                    {
                        p.SetValue(Destination, val, null);
                    }
                }
            }
        }
    }
}
