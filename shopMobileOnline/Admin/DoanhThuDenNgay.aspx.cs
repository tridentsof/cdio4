﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopMobileOnline.Admin
{
    public partial class DoanhThuDenNgay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("ADLogin.aspx");
            }
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            string sqlDHChoDuyet = "SELECT TENSP,SUM(DOANHTHU) as DOANHTHU FROM  (SELECT  c.TENSP,(c.DONGIA*b.SOLUONG) as doanhthu FROM DONHANG a,CTDONHANG b,SANPHAM c WHERE a.ID_DONHANG=b.ID_DONHANG and b.ID_SP=c.ID_SP and a.TRANGTHAI=3 and a.NGAYDH  BETWEEN '"  + TextBox1.Text  + "' AND'" + TextBox2.Text + "' group by NGAYDH,TENSP,c.DONGIA,b.SOLUONG) a GROUP BY TENSP";
          
            DataTable dtDHChoDuyet = dataAccess.LayBangDuLieu(sqlDHChoDuyet);

            StringBuilder table = new StringBuilder();

            if (dtDHChoDuyet != null && dtDHChoDuyet.Rows.Count > 0)
            {
                foreach (DataRow dr in dtDHChoDuyet.Rows)
                {
                    table.Append("<tr class=\"table-tr\">");
                    table.Append("<td class=\"table-td table-item\">" + dr["TENSP"] + "</td>");
                    //table.Append("<td class=\"table-td table-item\">" + dr["THANG"] + "</td>");
                    //table.Append("<td class=\"table-td table-item\">" + dr["SOLUONG"] + "</td>");
                    //table.Append("<td class=\"table-td table-item\">" + dr["TONGSL"] + "</td>");
                    table.Append("<td class=\"table-td table-item\">" + String.Format("{0:N0}", int.Parse(dr["DOANHTHU"].ToString())) + "</td>");
                    //table.Append("<td class=\"table-td table-item\"><a href=\"/Admin/ADChiTietDonHang.aspx?t=3&idDH=" + dr["ID_DONHANG"] + "\" class=\"qldh-btnXem\">Xem</a> </td>");
                }

                Panel1.Controls.Add(new Label { Text = table.ToString() });

                //dataAccess.DongKetNoiCSDL();
            }
            //string sqlDHChoDuyet1 = "SELECT Thang, sum(TONGSOLUONG) AS SOLUONGBANRA,SUM(DOANHTHU) as TIEN FROM ( SELECT  MONTH(a.NGAYDH) as Thang,sum(b.SOLUONG) AS TONGSOLUONG,(c.DONGIA*b.SOLUONG) as doanhthu FROM DONHANG a,CTDONHANG b,SANPHAM c WHERE a.ID_DONHANG=b.ID_DONHANG and b.ID_SP=c.ID_SP and MONTH(a.NGAYDH) = '" + Int32.Parse(TextBox1.Text) + "' and a.TRANGTHAI=3  group by NGAYDH,b.SOLUONG,c.DONGIA,b.SOLUONG) a GROUP BY Thang";
            //DataTable dtDHChoDuyet1 = dataAccess.LayBangDuLieu(sqlDHChoDuyet1);
            //StringBuilder table1 = new StringBuilder();
            //if (dtDHChoDuyet1 != null && dtDHChoDuyet1.Rows.Count > 0)
            //{
            //    foreach (DataRow dr in dtDHChoDuyet1.Rows)
            //    {
            //        table1.Append("<tr class=\"table1-tr\">");
            //        //table.Append("<td class=\"table-td table-item\">" + dr["THANG"] + "</td>");
            //        //table.Append("<td class=\"table-td table-item\">" + dr["SOLUONG"] + "</td>");
            //        //table.Append("<td class=\"table-td table-item\">" + dr["TONGSL"] + "</td>");
            //        table1.Append("<td class=\"table1-td table1-item\">" + String.Format("{0:N0}", int.Parse(dr["TIEN"].ToString())) + "</td>");
            //        //table.Append("<td class=\"table-td table-item\"><a href=\"/Admin/ADChiTietDonHang.aspx?t=3&idDH=" + dr["ID_DONHANG"] + "\" class=\"qldh-btnXem\">Xem</a> </td>");
            //    }

            //    Panel2.Controls.Add(new Label { Text = table1.ToString() });

            //    dataAccess.DongKetNoiCSDL();
            //}
        }
    }
}