﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data.Entity.Migrations.Model;

namespace excel_export_e9mdtf
{
    public partial class Form1 : Form
    {
        List<Flat> lakasok;
        RealEstateEntities context = new RealEstateEntities();
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }
        public void LoadData()
        {
            lakasok = context.Flats.ToList();

        }
        public void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(Missing.Value);
                xlWorkSheet = xlWorkBook.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlWorkBook.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWorkBook = null;
                xlApp = null;
            }
        }
        public void CreateTable()
        {
            string[] headers = new string[] {
                "Kód",
                "Eladó",
                "Oldal",
                "Kerület",
                "Lift",
                "Szobák száma",
                "Alapterület (m2)",
                "Ár (mFt)",
                "Négyzetméter ár (Ft/m2)"};
            for (int i = 0; i < headers.Length; i++)
            {
                xlWorkSheet.Cells[1, i + 1] = headers[i];
            }
            object[,] values = new object[lakasok.Count, headers.Length];
            int counter = 0;
            foreach (Flat f in lakasok)
            {
                values[counter, 0] = f.Code;
                values[counter, 1] = f.Vendor;
                values[counter, 2] = f.Side;
                values[counter, 3] = f.District;
                values[counter, 4] = f.Elevator;
                values[counter, 5] = f.NumberOfRooms;
                values[counter, 6] = f.FloorArea;
                values[counter, 7] = f.Price;
                values[counter, 8] = "=" + GetCell(counter + 2, headers.Length - 1).ToString() + "*" + "1000000" + "/" + GetCell(counter + 2, headers.Length - 2).ToString();
                counter++;
            }
            xlWorkSheet.get_Range(
                GetCell(2, 1),
                GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
            int lastRowID = xlWorkSheet.UsedRange.Rows.Count;
            int lastColID = xlWorkSheet.UsedRange.Columns.Count;
            Excel.Range headerRange = xlWorkSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            Excel.Range tableRange = xlWorkSheet.get_Range(GetCell(1, 1), GetCell(1 + values.GetLength(0), values.GetLength(1)));
            Excel.Range firstRow = xlWorkSheet.get_Range(GetCell(lastRowID, 1), GetCell(2,1));
            Excel.Range lastRow = xlWorkSheet.get_Range(GetCell(2, lastColID), GetCell(lastRowID, lastColID));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            tableRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            firstRow.Font.Bold = true;
            firstRow.Interior.Color = Color.LightYellow;
            lastRow.Interior.Color = Color.LightGreen;
            lastRow.NumberFormat = "0.00";
        }
       
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;
            while (dividend> 0 )
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}
