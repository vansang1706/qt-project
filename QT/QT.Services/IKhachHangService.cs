﻿using System.Collections.Generic;
using QT.Models;
using QT.Service.Pattern;

namespace QT.Services
{
    public interface IKhachHangService:IService<KhachHang>
    {
        void InsertKhachHang(KhachHang khachHang);
        List<KhachHang> GetAllKhachHang();
        KhachHang GetKhachHangByTenKhachHang(string tenKhachHang);
        void UpdateKhachHang(KhachHang khachHang);
        string GetTenKhachHangById(int id);
    }
}
