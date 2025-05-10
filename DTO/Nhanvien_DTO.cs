using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Represents a staff member in the system
    /// </summary>
    public class Nhanvien_DTO
    {
		private int _MaNV;
        private string _TenNV;
        private DateTime _NgaySinh;
        private string _DiaChi;
        private string _SDT;
        private string _CCCD;

        /// <summary>
        /// Staff ID
        /// </summary>
        public int MaNV
        {
            get => _MaNV;
            set => _MaNV = value;
        }

        /// <summary>
        /// Staff name
        /// </summary>
        public string TenNV
        {
            get => _TenNV;
            set => _TenNV = value;
        }

        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime NgaySinh
        {
            get => _NgaySinh;
            set => _NgaySinh = value;
        }

        /// <summary>
        /// Address
        /// </summary>
        public string DiaChi
        {
            get => _DiaChi;
            set => _DiaChi = value;
        }

        /// <summary>
        /// Phone number
        /// </summary>
        public string SDT
        {
            get => _SDT;
            set => _SDT = value;
        }

        /// <summary>
        /// Citizen ID
        /// </summary>
        public string CCCD
        {
            get => _CCCD;
            set => _CCCD = value;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Nhanvien_DTO() { }

    
        public Nhanvien_DTO(int maNV, string tenNV, DateTime ngaySinh, string diaChi, string sDT, string cCCD)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = sDT;
            CCCD = cCCD;
        }
    }
}
