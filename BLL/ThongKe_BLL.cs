﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ThongKe_BLL
   {
        private static ThongKe_BLL instance;
        public static ThongKe_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKe_BLL();
                return instance;
            }
        }
        private ThongKe_BLL() { }

        public DataTable GetStaticByMovie(string movieName, string begin_day, string End_day)
        {
            return DAL.ThongKe_DAL.Instance.GetStaticByMovie(movieName, begin_day, End_day);
        }
        public DataTable GetStaticByDirector(string Director, string begin_day, string End_day)
        {
            return DAL.ThongKe_DAL.Instance.GetStaticByDirector(Director, begin_day, End_day);
        }
        public DataTable GetStaticByDay(string begin_day)
        {
            return DAL.ThongKe_DAL.Instance.GetStaticByDay(begin_day);
        }
    }
}
