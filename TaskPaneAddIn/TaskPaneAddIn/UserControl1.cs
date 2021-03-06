﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;
using SolidWorks.Interop.swconst;
using SolidWorksTools;
using SolidWorksTools.File;
using TaskPaneAddIn;
using System.Data.SqlClient;

namespace TaskPaneAddIn
{
    [ComVisible(true)]
    [ProgId("Compac_CustomProperty_TaskPane")]
    public partial class UserControl1 : UserControl
    {
        private int _CurrentDocType;
        ISldWorks iSwApp;
        public int CurrentDocType
        {
            get
            {
                return _CurrentDocType;
            }
            set
            {
                _CurrentDocType = value;
                setImages(value);
            }
        }
        public ISldWorks swApp
        {
            get
            {
                return iSwApp;
            }
            set
            {
                this.iSwApp = value;
            }
        }
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelDoc2 swModel = this.swApp.ActiveDoc;
            if (swModel != null)
            {
                ConfigurationManager swConfigMgr = swModel.ConfigurationManager;
                Configuration swConfig = swConfigMgr.ActiveConfiguration;
                CustomPropertyManager cusPropMgr = swConfig.CustomPropertyManager;
                int nNbProps = cusPropMgr.Count;
                String[] vPropNames = cusPropMgr.GetNames();
                for (int i = 0; i < nNbProps - 1; i++)
                {
                    string tt = vPropNames[i];
                }
                MessageBox.Show(nNbProps.ToString());
                MessageBox.Show("Title" + swModel.GetTitle());
            }
        }

        public void setImages(int currentDocType)
        {
            if (currentDocType==(int)swDocumentTypes_e.swDocPART)
            {
                picComputer.Visible = true;
                picPrinter.Visible = false;
                picSetting.Visible = false;
            }
            else if (currentDocType==(int)swDocumentTypes_e.swDocASSEMBLY)
            {
                picComputer.Visible = false;
                picPrinter.Visible = true;
                picSetting.Visible = false;
                
            }
            else if (currentDocType == (int)swDocumentTypes_e.swDocDRAWING)
            {
                picComputer.Visible = false;
                picPrinter.Visible = false;
                picSetting.Visible = true;
            }
            else if (currentDocType == 100) //For parts and assemblies
            {
                picComputer.Visible = true;
                picPrinter.Visible = true;
                picSetting.Visible = false;
            }
            else //None selected
            {
                picComputer.Visible = false;
                picPrinter.Visible = false;
                picSetting.Visible = false;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //this.tableTableAdapter.Fill(this.addInDataSet1.Table);
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\michael.lu\Documents\GitHub\CustomProperty\TaskPaneAddIn\TaskPaneAddIn\AddIn.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string commandString = "SELECT * FROM Product";
            SqlCommand cmd = new SqlCommand(commandString, con);
            List<string> someList = new List<string>();
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                while (read.Read())
                {
                    someList.Add(read["ProductCode"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            con.Close();

            comboBox2.DataSource = someList;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //this.tableTableAdapter.Fill(this.addInDataSet1.Table);
        }
    }
}
