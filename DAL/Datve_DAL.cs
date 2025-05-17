using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class Datve_DAL
    {
        private static Datve_DAL instance;
        public static Datve_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Datve_DAL();
                return instance;
            }
        }
        private Datve_DAL() { }
      
    }
}
