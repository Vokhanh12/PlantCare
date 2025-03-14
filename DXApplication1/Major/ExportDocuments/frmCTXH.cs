﻿using Dapper;
using DevExpress.XtraEditors;
using DXApplication1.FolderMajor;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Subject.ExportDocuments
{
    public partial class frmCTXH : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        fsEdit Edit = new fsEdit();

        public MaterialListView mLV;

        public string casechange;

        public static frmCTXH instance;
        public frmCTXH()
        {
            InitializeComponent();


            instance = this;

            //Design MarterialListview
            skinManager = MaterialSkinManager.Instance;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo900, Primary.Indigo700, Accent.Indigo700, TextShade.WHITE);


            materialListView1.Columns[0].Width = 153;
            materialListView1.Columns[1].Width = 353;
            materialListView1.Columns[2].Width = 103;
            materialListView1.Columns[3].Width = 153;
            materialListView1.Columns[4].Width = 153;
            materialListView1.Columns[5].Width = 103;
            materialListView1.Columns[6].Width = 103;
            materialListView1.Columns[7].Width = 153;
            materialListView1.Columns[8].Width = 153;
            materialListView1.Columns[9].Width = 103;
            materialListView1.Columns[10].Width = 153;
            materialListView1.Columns[11].Width = 203;

            OpenSql();

        }



        public virtual void OpenSql()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["LAPTOP-JN4FK6OT"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var data = db.Query<ExportDocumentsDTO>("SELECT * FROM NHANVIEN_KHOHANG_MATHANG", commandType: CommandType.Text);
                materialListView1.Items.Clear();
                foreach (ExportDocumentsDTO p in data)
                {

                    ListViewItem item = new ListViewItem(p.SOHD_NHANVIEN_BANHANG_MATHANG);
                    item.SubItems.Add(p.TENHD_NHANVIEN_BANHANG_MATHANG);
                    item.SubItems.Add(p.MANV);
                    item.SubItems.Add(p.TENNV);
                    item.SubItems.Add(p.SDT_EMPLOYEE);
                    item.SubItems.Add(p.MAKHO);
                    item.SubItems.Add(p.TENKHO);
                    item.SubItems.Add(p.MAMATHANG);
                    item.SubItems.Add(p.TENMATHANG);
                    item.SubItems.Add(p.SL.ToString());
                    item.SubItems.Add(p.GIA.ToString());
                    item.SubItems.Add(p.NGAYLAY.ToString());
                  

                    materialListView1.Items.Add(item);

                }
                db.Close();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}