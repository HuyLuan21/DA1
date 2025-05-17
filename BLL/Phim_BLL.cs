using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Phim_BLL
    {
        private static Phim_BLL instance;
        public static Phim_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Phim_BLL();
                return instance;
            }
        }
        private Phim_BLL() { }
    
        public DataTable GetPhimList()
        {
            return DAL.Phim_DAL.Instance.GetPhim();
        }
        public List<string> GetMovieListName()
        {
            return DAL.Phim_DAL.Instance.GetMoviesName();
        }
        public List<string> GetMovieTypes(int maphim)
        {
            return DAL.Phim_DAL.Instance.GetmovieType(maphim);
        }


    }
}
