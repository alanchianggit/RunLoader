﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BusinessLayer;


namespace RunLoader
{
    public partial class Production : Form
    {
        public Productions currProd;
        //private DateTime defaultTime = DateTime.Now;

        public Production()
        {
            InitializeComponent();
            currProd = new Productions();
        }

        private static Production inst;
        public static Production GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Production();
                return inst;
            }
        }

        private void ControlTextChanged(object sender, EventArgs e)
        {
            currProd.UpdateProperty(sender);
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            currProd.CreateNew(currProd);
        }

        private void ShowProduction()
        {
            txt_Ender.Text = currProd.Ender;
            txt_Starter.Text = currProd.Starter;
            if (currProd.StartTime == DateTime.MinValue)
            {
                dateTime_StartTime.Text = dateTime_StartTime.MinDate.ToString();
            }
            else
            {
                dateTime_StartTime.Text = currProd.StartTime.ToString();
            }

            if (currProd.EndTime == DateTime.MinValue)
            {
                dateTime_EndTime.Text = dateTime_EndTime.MinDate.ToString();
            }
            else
            {
                dateTime_EndTime.Text = currProd.EndTime.ToString();
            }
            cmb_Method.Text = currProd.Method;
            cmb_ProductionName.Text = currProd.ProductionName;
            cmb_Type.Text = currProd.Type;
            txt_Quantity.Text = currProd.Quantity.ToString();
            cmb_EqpName.Text = currProd.EqpName;

        }

        private  void StoreProduction()
        {
            currProd.Ender = txt_Ender.Text;
            currProd.Starter = txt_Starter.Text;
            currProd.StartTime = DateTime.Parse( dateTime_StartTime.Text);
            currProd.EndTime = DateTime.Parse(dateTime_EndTime.Text);
            currProd.Method = cmb_Method.Text;
            currProd.ProductionName = cmb_ProductionName.Text;
            currProd.Type = cmb_Type.Text ;
            currProd.Quantity = int.Parse(txt_Quantity.ToString());
            currProd.EqpName = cmb_EqpName.Text;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            currProd.GetProduction();
            if (currProd.ID == int.MinValue)
            {
                ClearFields();
            }
            else
            {
                ShowProduction();
            }
        }

        private void ClearFields()
        {
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                switch (ctrl.Name.Substring(0, 4))
                {
                    case "cmb_":
                    case "txt_":
                        ctrl.ResetText();
                        break;
                    case "date":
                        ctrl.Text = DateTime.MinValue.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            StoreProduction();

        }
    }
}