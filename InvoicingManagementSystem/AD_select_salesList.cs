﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_select_salesList : Form
    {
        public AD_select_salesList()
        {
            InitializeComponent();
        }

        private void AD_select_salesList_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id<3 or id=5 or id=7";
            DataTable dataTableSelectList = SqlHelper.GetDataTable(sql);
            DataRow dataRowSelectList = dataTableSelectList.NewRow();
            dataRowSelectList["id"] = 0;
            dataRowSelectList["name"] = "请选择";
            dataTableSelectList.Rows.InsertAt(dataRowSelectList, 0);

            comboBoxKeyword.DataSource = dataTableSelectList;
            comboBoxKeyword.DisplayMember = "name";
            comboBoxKeyword.ValueMember = "id";
        }

        public void SqlDataRefresh()
        {
            //刷新商品列表
            string sql1 = "select * from SalesList";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql1);
            dataGridView_select_salesList.DataSource = dataTableGoodsList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select * from SalesList where 1=1 ";
            //sql += " where 1=1";
            if (SearchSID > 0)
            {
                if (SearchSID == 1)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and goods_id like @goods_id";
                    }

                }
                if (SearchSID == 2)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and goods_name like @goods_name";
                    }
                }
                if (SearchSID == 5)
                {
                    //按照日期顺序排序
                    sql += "order by goods_soldDate";
                }
                if (SearchSID == 7)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and goods_type like @goods_type";
                    }
                }
                
            }

            SqlParameter[] parameters =
            {
                new SqlParameter("@goods_id","%"+keyWord+"%"),
                new SqlParameter("@goods_name","%"+keyWord+"%"),
                new SqlParameter("@goods_type","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_select_salesList.DataSource = dataTableGoodsList;
        }
    }
}
