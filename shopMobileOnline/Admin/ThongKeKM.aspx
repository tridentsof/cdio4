﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAD.Master" AutoEventWireup="true" CodeBehind="ThongKeKM.aspx.cs" Inherits="shopMobileOnline.Admin.QuanLyKM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
         .qltk-container{
            margin: 0 0px;
            max-width: 100%;
            min-width: 100%;
            display: flex;
            flex-direction: column;
            justify-content: center;
           
        }
        .qltk-container h4 {
            margin: 0 auto;
            font-size: 30px;
            font-weight: bold; 
            color: #262626;
        }
        .qltk-header {
             display: flex;
             justify-content: center;
             align-items: center;
             margin: 40px 0;
        }
        .qltk-btnThemMoi-container {
            position: absolute;
            right: 40px;
            background: #031a43;
            padding: 11px 13px;
            border-radius: 5px;
        }

        .qltk-btnThemMoi-container:hover {
            background: #155e98;
            transition : all 0.2s ease-in;
        }

        .qltk-btnThemMoi-container a {
            display: flex;
            align-items: center;
        }
        .qltk-btnThemMoi-container i,
        .qltk-btnThemMoi-container span {
            display: block;
            color: white;
            
        }
        .qltk-btnThemMoi-container i {
            font-size: 12px;
        }
        .qltk-btnThemMoi-container span{
            font-size: 16px;
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            margin-left: 10px;
        }
        .table {
            width: 80%;
            margin: 0 auto;
        }
        .table,
        .table-th,
        .table-tr,
        .table-item {
            border: 1px solid #adc9fa;  
            text-align: left;
            line-height: 1.3;
            color: #333333;
        }
        .table-th{
           padding: 10px;
           text-align: center;
           vertical-align: middle;
           font-weight: bold;
           background: #ffe4da
        }
        .table-item {
            padding: 10px;
        }
        .table-tr:nth-child(even){
            background: #fff9f9;
        }
        #table-item-tensp a {
            font-weight: bold;
            color: #031a43
        }
        #table-item-tensp a:hover{
            color: #0654a9;
            transition : all 0.1s ease-in;
        }
        .qlkm-btnCapNhat {
            color: #0654a9;
            font-weight: bold;
            font-size: 14px;
            text-align: center;
            display: block;
        }
        .qlkm-btnCapNhat:hover{
            color: #0094ff;
        }
        .qlkm-btnXoa {
            color: tomato;
            font-weight: bold;
            text-align: center;
            display: block;
            font-size: 14px;
        }
        .qlkm-btnXoa:hover{
            color: #f62d2d;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="qltk-container">
       <div class="qltk-header">
               <h4>Thống kê khuyến mãi</h4>
            <div class="qltk-btnThemMoi-container">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/QuanLyKMThemKM.aspx" Target="_blank">
                    <i class="fas fa-user-plus"></i>
                    <span>Thêm </span>
                </asp:HyperLink>
            </div>
        </div>
        <table class="table" border="1">
            <tr  class="table-tr">
                 <th class="table-th">ID</th>
                <th class="table-th">Tên khuyến mãi</th>
                <th class="table-th">NSX</th>
                <th class="table-th" style="max-width:80px;">Phần trăm khuyến mãi</th>
                <th class="table-th">Trạng thái</th>
                <th class="table-th">Cập nhật</th>
            </tr>
              <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        </table>

    </div>
</asp:Content>
