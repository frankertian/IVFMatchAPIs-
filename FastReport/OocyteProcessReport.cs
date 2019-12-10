using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using FastReport;
using FastReport.Data;
using FastReport.Dialog;
using FastReport.Barcode;
using FastReport.Table;
using FastReport.Utils;

namespace FastReport
{
  public class OocyteProcessReport : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.Table.TableCell Cell1;
    public FastReport.Table.TableCell Cell14;
    public FastReport.Table.TableCell Cell15;
    public FastReport.Table.TableCell Cell17;
    public FastReport.Table.TableCell Cell18;
    public FastReport.Table.TableCell Cell2;
    public FastReport.Table.TableCell Cell20;
    public FastReport.Table.TableCell Cell21;
    public FastReport.Table.TableCell Cell23;
    public FastReport.Table.TableCell Cell24;
    public FastReport.Table.TableCell Cell26;
    public FastReport.Table.TableCell Cell27;
    public FastReport.Table.TableCell Cell29;
    public FastReport.Table.TableCell Cell3;
    public FastReport.Table.TableCell Cell30;
    public FastReport.Table.TableCell Cell32;
    public FastReport.Table.TableCell Cell6;
    public FastReport.Table.TableCell Cell8;
    public FastReport.CheckBoxObject CheckBox1;
    public FastReport.CheckBoxObject CheckBox2;
    public FastReport.Table.TableColumn Column1;
    public FastReport.Table.TableColumn Column2;
    public FastReport.Table.TableColumn Column3;
    public FastReport.Table.TableColumn Column4;
    public FastReport.Table.TableColumn Column5;
    public FastReport.Table.TableColumn Column6;
    public FastReport.Table.TableColumn Column7;
    public FastReport.Table.TableColumn Column8;
    public FastReport.Table.TableColumn Column9;
    public FastReport.DataBand Data1;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.PictureObject Picture1;
    public FastReport.PictureObject Picture2;
    public FastReport.PictureObject Picture3;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.RichObject Rich1;
    public FastReport.Table.TableRow Row1;
    public FastReport.Table.TableRow Row2;
    public FastReport.ShapeObject Shape1;
    public FastReport.Table.TableObject Table1;
    public FastReport.TextObject Text10;
    public FastReport.TextObject Text11;
    public FastReport.TextObject Text12;
    public FastReport.TextObject Text13;
    public FastReport.TextObject Text14;
    public FastReport.TextObject Text15;
    public FastReport.TextObject Text16;
    public FastReport.TextObject Text23;
    public FastReport.TextObject Text24;
    public FastReport.TextObject Text25;
    public FastReport.TextObject Text26;
    public FastReport.TextObject Text27;
    public FastReport.TextObject Text28;
    public FastReport.TextObject Text9;
    private object Sum(TableCell cell)
    {
      return cell.Table.Sum(cell);
    }

    private object Min(TableCell cell)
    {
      return cell.Table.Min(cell);
    }

    private object Max(TableCell cell)
    {
      return cell.Table.Max(cell);
    }

    private object Avg(TableCell cell)
    {
      return cell.Table.Avg(cell);
    }

    private object Count(TableCell cell)
    {
      return cell.Table.Count(cell);
    }

    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "ToBoolean([OPU.卵巢左])")
        return ToBoolean(((String)Report.GetColumnValue("OPU.卵巢左")));
      if (expression == "ToBoolean([OPU.卵巢右])")
        return ToBoolean(((String)Report.GetColumnValue("OPU.卵巢右")));
      return null;
    }

    private SByte Abs(SByte value)
    {
      return System.Math.Abs(value);
    }

    private Int16 Abs(Int16 value)
    {
      return System.Math.Abs(value);
    }

    private Int32 Abs(Int32 value)
    {
      return System.Math.Abs(value);
    }

    private Int64 Abs(Int64 value)
    {
      return System.Math.Abs(value);
    }

    private Single Abs(Single value)
    {
      return System.Math.Abs(value);
    }

    private Double Abs(Double value)
    {
      return System.Math.Abs(value);
    }

    private Decimal Abs(Decimal value)
    {
      return System.Math.Abs(value);
    }

    private Double Acos(Double d)
    {
      return System.Math.Acos(d);
    }

    private Double Asin(Double d)
    {
      return System.Math.Asin(d);
    }

    private Double Atan(Double d)
    {
      return System.Math.Atan(d);
    }

    private Double Ceiling(Double a)
    {
      return System.Math.Ceiling(a);
    }

    private Decimal Ceiling(Decimal d)
    {
      return System.Math.Ceiling(d);
    }

    private Double Cos(Double d)
    {
      return System.Math.Cos(d);
    }

    private Double Exp(Double d)
    {
      return System.Math.Exp(d);
    }

    private Double Floor(Double d)
    {
      return System.Math.Floor(d);
    }

    private Decimal Floor(Decimal d)
    {
      return System.Math.Floor(d);
    }

    private Double Log(Double d)
    {
      return System.Math.Log(d);
    }

    private Int32 Maximum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int64 Maximum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Single Maximum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Double Maximum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Decimal Maximum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int32 Minimum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Int64 Minimum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Single Minimum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Minimum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Decimal Minimum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Round(Double a)
    {
      return System.Math.Round(a);
    }

    private Decimal Round(Decimal d)
    {
      return System.Math.Round(d);
    }

    private Double Round(Double value, Int32 digits)
    {
      return System.Math.Round(value, digits);
    }

    private Decimal Round(Decimal d, Int32 decimals)
    {
      return System.Math.Round(d, decimals);
    }

    private Double Sin(Double a)
    {
      return System.Math.Sin(a);
    }

    private Double Sqrt(Double d)
    {
      return System.Math.Sqrt(d);
    }

    private Double Tan(Double a)
    {
      return System.Math.Tan(a);
    }

    private Double Truncate(Double d)
    {
      return System.Math.Truncate(d);
    }

    private Decimal Truncate(Decimal d)
    {
      return System.Math.Truncate(d);
    }

    private Int32 Asc(Char c)
    {
      return FastReport.Functions.StdFunctions.Asc(c);
    }

    private Char Chr(Int32 i)
    {
      return FastReport.Functions.StdFunctions.Chr(i);
    }

    private String Insert(String s, Int32 startIndex, String value)
    {
      return FastReport.Functions.StdFunctions.Insert(s, startIndex, value);
    }

    private Int32 Length(String s)
    {
      return FastReport.Functions.StdFunctions.Length(s);
    }

    private String LowerCase(String s)
    {
      return FastReport.Functions.StdFunctions.LowerCase(s);
    }

    private String PadLeft(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth);
    }

    private String PadLeft(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth, paddingChar);
    }

    private String PadRight(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth);
    }

    private String PadRight(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth, paddingChar);
    }

    private String Remove(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex);
    }

    private String Remove(String s, Int32 startIndex, Int32 count)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex, count);
    }

    private String Replace(String s, String oldValue, String newValue)
    {
      return FastReport.Functions.StdFunctions.Replace(s, oldValue, newValue);
    }

    private String Substring(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex);
    }

    private String Substring(String s, Int32 startIndex, Int32 length)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex, length);
    }

    private String TitleCase(String s)
    {
      return FastReport.Functions.StdFunctions.TitleCase(s);
    }

    private String Trim(String s)
    {
      return FastReport.Functions.StdFunctions.Trim(s);
    }

    private String UpperCase(String s)
    {
      return FastReport.Functions.StdFunctions.UpperCase(s);
    }

    private DateTime AddDays(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddDays(date, value);
    }

    private DateTime AddHours(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddHours(date, value);
    }

    private DateTime AddMinutes(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddMinutes(date, value);
    }

    private DateTime AddMonths(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddMonths(date, value);
    }

    private DateTime AddSeconds(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddSeconds(date, value);
    }

    private DateTime AddYears(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddYears(date, value);
    }

    private TimeSpan DateDiff(DateTime date1, DateTime date2)
    {
      return FastReport.Functions.StdFunctions.DateDiff(date1, date2);
    }

    private DateTime DateSerial(Int32 year, Int32 month, Int32 day)
    {
      return FastReport.Functions.StdFunctions.DateSerial(year, month, day);
    }

    private Int32 Day(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Day(date);
    }

    private String DayOfWeek(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfWeek(date);
    }

    private Int32 DayOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfYear(date);
    }

    private Int32 DaysInMonth(Int32 year, Int32 month)
    {
      return FastReport.Functions.StdFunctions.DaysInMonth(year, month);
    }

    private Int32 Hour(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Hour(date);
    }

    private Int32 Minute(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Minute(date);
    }

    private Int32 Month(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Month(date);
    }

    private String MonthName(Int32 month)
    {
      return FastReport.Functions.StdFunctions.MonthName(month);
    }

    private Int32 Second(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Second(date);
    }

    private Int32 WeekOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.WeekOfYear(date);
    }

    private Int32 Year(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Year(date);
    }

    private String Format(String format, params Object[] args)
    {
      return FastReport.Functions.StdFunctions.Format(format, args);
    }

    private String FormatCurrency(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value);
    }

    private String FormatCurrency(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value, decimalDigits);
    }

    private String FormatDateTime(DateTime value)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value);
    }

    private String FormatDateTime(DateTime value, String format)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value, format);
    }

    private String FormatNumber(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value);
    }

    private String FormatNumber(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value, decimalDigits);
    }

    private String FormatPercent(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value);
    }

    private String FormatPercent(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value, decimalDigits);
    }

    private Boolean ToBoolean(Object value)
    {
      return System.Convert.ToBoolean(value);
    }

    private Byte ToByte(Object value)
    {
      return System.Convert.ToByte(value);
    }

    private Char ToChar(Object value)
    {
      return System.Convert.ToChar(value);
    }

    private DateTime ToDateTime(Object value)
    {
      return System.Convert.ToDateTime(value);
    }

    private Decimal ToDecimal(Object value)
    {
      return System.Convert.ToDecimal(value);
    }

    private Double ToDouble(Object value)
    {
      return System.Convert.ToDouble(value);
    }

    private Int32 ToInt32(Object value)
    {
      return System.Convert.ToInt32(value);
    }

    private String ToRoman(Object value)
    {
      return FastReport.Functions.StdFunctions.ToRoman(value);
    }

    private Single ToSingle(Object value)
    {
      return System.Convert.ToSingle(value);
    }

    private String ToString(Object value)
    {
      return System.Convert.ToString(value);
    }

    private String ToWords(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWords(value);
    }

    private String ToWords(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, currencyName);
    }

    private String ToWords(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, one, many);
    }

    private String ToWordsEnGb(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value);
    }

    private String ToWordsEnGb(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, currencyName);
    }

    private String ToWordsEnGb(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, one, many);
    }

    private String ToWordsEs(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value);
    }

    private String ToWordsEs(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, currencyName);
    }

    private String ToWordsEs(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, one, many);
    }

    private String ToWordsRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value);
    }

    private String ToWordsRu(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, currencyName);
    }

    private String ToWordsRu(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, male, one, two, many);
    }

    private Object Choose(Double index, params Object[] choice)
    {
      return FastReport.Functions.StdFunctions.Choose(index, choice);
    }

    private Object IIf(Boolean expression, Object truePart, Object falsePart)
    {
      return FastReport.Functions.StdFunctions.IIf(expression, truePart, falsePart);
    }

    private Object Switch(params Object[] expressions)
    {
      return FastReport.Functions.StdFunctions.Switch(expressions);
    }

    private Boolean IsNull(String name)
    {
      return FastReport.Functions.StdFunctions.IsNull(Report, name);
    }

    private void InitializeComponent()
    {
      string reportString = 
        "﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Report ScriptLanguage=\"CSharp\" ReportI" +
        "nfo.Created=\"11/29/2018 10:51:52\" ReportInfo.Modified=\"12/18/2018 14:41:07\" Repo" +
        "rtInfo.CreatorVersion=\"2013.2.5.0\">\r\n  <Dictionary>\r\n    <TableDataSource Name=\"" +
        "OPU\" ReferenceName=\"Data.OPU\" DataType=\"System.Int32\" Enabled=\"true\">\r\n      <Co" +
        "lumn Name=\"管号\" DataType=\"System.String\"/>\r\n      <Column Name=\"卵巢左\" DataType=\"Sy" +
        "stem.String\"/>\r\n      <Column Name=\"卵巢右\" DataType=\"System.String\"/>\r\n      <Colu" +
        "mn Name=\"卵泡数量\" DataType=\"System.String\"/>\r\n      <Column Name=\"液体体积\" DataType=\"S" +
        "ystem.String\"/>\r\n      <Column Name=\"性状\" DataType=\"System.String\"/>\r\n      <Colu" +
        "mn Name=\"卵子情况\" DataType=\"System.String\"/>\r\n      <Column Name=\"培养皿号\" DataType=\"S" +
        "ystem.String\"/>\r\n      <Column Name=\"存放点\" DataType=\"System.String\"/>\r\n    </Tabl" +
        "eDataSource>\r\n    <TableDataSource Name=\"INFO\" ReferenceName=\"Data.INFO\" DataTyp" +
        "e=\"System.Int32\" Enabled=\"true\">\r\n      <Column Name=\"男方姓名\" DataType=\"System.Str" +
        "ing\"/>\r\n      <Column Name=\"女方姓名\" DataType=\"System.String\"/>\r\n      <Column Name";
      reportString += "=\"病历编号\" DataType=\"System.String\"/>\r\n      <Column Name=\"卵子总数\" DataType=\"System.S" +
        "tring\"/>\r\n      <Column Name=\"取卵时间\" DataType=\"System.String\"/>\r\n      <Column Na" +
        "me=\"自用数\" DataType=\"System.String\"/>\r\n      <Column Name=\"其他用途数\" DataType=\"System" +
        ".String\"/>\r\n      <Column Name=\"遗弃数\" DataType=\"System.String\"/>\r\n      <Column N" +
        "ame=\"遗失数\" DataType=\"System.String\"/>\r\n    </TableDataSource>\r\n    <TableDataSour" +
        "ce Name=\"SignaturePatient\" ReferenceName=\"Data.SignaturePatient\" DataType=\"Syste" +
        "m.Int32\" Enabled=\"true\">\r\n      <Column Name=\"SignaturePatient\" DataType=\"System" +
        ".Byte[]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataSour" +
        "ce Name=\"SignatureOperator\" ReferenceName=\"Data.SignatureOperator\" DataType=\"Sys" +
        "tem.Int32\" Enabled=\"true\">\r\n      <Column Name=\"SignatureOperator\" DataType=\"Sys" +
        "tem.Byte[]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataS" +
        "ource Name=\"SignatureChecker\" ReferenceName=\"Data.SignatureChecker\" DataType=\"Sy";
      reportString += "stem.Int32\" Enabled=\"true\">\r\n      <Column Name=\"SignatureChecker\" DataType=\"Sys" +
        "tem.Byte[]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n  </Dictionary>" +
        "\r\n  <ReportPage Name=\"Page1\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=\"7" +
        "18.2\" Height=\"94.5\">\r\n      <TextObject Name=\"Text10\" Left=\"9.45\" Top=\"9.45\" Wid" +
        "th=\"699.3\" Height=\"47.25\" Text=\"华中科技大学同济医学院附属荆州医院&#13;&#10;荆州市中心医院\" Format=\"Curr" +
        "ency\" Format.UseLocale=\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 1" +
        "2pt\"/>\r\n      <TextObject Name=\"Text11\" Left=\"340.2\" Top=\"56.7\" Width=\"94.5\" Hei" +
        "ght=\"18.9\" Text=\"[INFO.男方姓名]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text12\" " +
        "Left=\"94.5\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"[INFO.女方姓名]\" Font=\"宋体, 9" +
        "pt\"/>\r\n      <TextObject Name=\"Text13\" Left=\"9.45\" Top=\"56.7\" Width=\"75.6\" Heigh" +
        "t=\"18.9\" Text=\"妻子姓名：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text14\" Left=\"25" +
        "5.15\" Top=\"56.7\" Width=\"75.6\" Height=\"18.9\" Text=\"丈夫姓名：\" Font=\"宋体, 9pt\"/>\r\n     ";
      reportString += " <TextObject Name=\"Text15\" Left=\"567\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text" +
        "=\"[INFO.病历编号]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text16\" Left=\"481.95\" T" +
        "op=\"56.7\" Width=\"75.6\" Height=\"18.9\" Text=\"病历编号：&#13;&#10;\" Font=\"宋体, 9pt\"/>\r\n  " +
        "    <RichObject Name=\"Rich1\" Left=\"9.45\" Top=\"75.6\" Width=\"689.85\" Height=\"18.9\"" +
        " Border.Lines=\"Top\"/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHea" +
        "der1\" Top=\"98.5\" Width=\"718.2\"/>\r\n    <DataBand Name=\"Data1\" Top=\"102.5\" Width=\"" +
        "718.2\" Height=\"916.65\">\r\n      <TableObject Name=\"Table1\" Left=\"9.45\" Top=\"94.5\"" +
        " Width=\"585.9\" Height=\"37.8\">\r\n        <TableColumn Name=\"Column1\" Width=\"75.6\"/" +
        ">\r\n        <TableColumn Name=\"Column2\" Width=\"47.25\"/>\r\n        <TableColumn Nam" +
        "e=\"Column3\" Width=\"47.25\"/>\r\n        <TableColumn Name=\"Column4\"/>\r\n        <Tab" +
        "leColumn Name=\"Column5\" Width=\"85.05\"/>\r\n        <TableColumn Name=\"Column6\"/>\r\n" +
        "        <TableColumn Name=\"Column7\"/>\r\n        <TableColumn Name=\"Column8\"/>\r\n  ";
      reportString += "      <TableColumn Name=\"Column9\"/>\r\n        <TableRow Name=\"Row1\">\r\n          <" +
        "TableCell Name=\"Cell1\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" " +
        "Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"管号\" Padding=" +
        "\"5, 0, 0, 0\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          " +
        "<TableCell Name=\"Cell2\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\"" +
        " Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"卵巢左\" Paddin" +
        "g=\"0, 0, 5, 0\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n        " +
        "  <TableCell Name=\"Cell3\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glas" +
        "s\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"卵巢右\" Horz" +
        "Align=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"" +
        "Cell17\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tra" +
        "nsparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"卵泡数量\" HorzAlign=\"Center\" Ve";
      reportString += "rtAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell14\" Border.Li" +
        "nes=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Bl" +
        "end=\"0.47\" Fill.Hatch=\"false\" Text=\"液体体积(ml)\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell20\" Border.Lines=\"All\" Bor" +
        "der.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fi" +
        "ll.Hatch=\"false\" Text=\"性状\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"" +
        "/>\r\n          <TableCell Name=\"Cell23\" Border.Lines=\"All\" Border.Color=\"LightGra" +
        "y\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Te" +
        "xt=\"卵子情况\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <Ta" +
        "bleCell Name=\"Cell26\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" F" +
        "ill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"培养皿号\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cel";
      reportString += "l29\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transp" +
        "arent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"存放点\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row" +
        "2\">\r\n          <TableCell Name=\"Cell6\" Border.Lines=\"All\" Border.Color=\"LightGra" +
        "y\" Text=\"[OPU.管号]\" Padding=\"5, 0, 0, 0\" HorzAlign=\"Center\" VertAlign=\"Center\" Fo" +
        "nt=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell32\" Border.Lines=\"All\" Border" +
        ".Color=\"LightGray\" Format=\"Currency\" Format.UseLocale=\"true\" HorzAlign=\"Center\" " +
        "VertAlign=\"Center\" Font=\"新宋体, 8.25pt\">\r\n            <CheckBoxObject Name=\"CheckB" +
        "ox1\" Left=\"18.9\" Top=\"3.78\" Width=\"9.45\" Height=\"9.45\" DataColumn=\"OPU.卵巢左\" Expr" +
        "ession=\"ToBoolean([OPU.卵巢左])\"/>\r\n          </TableCell>\r\n          <TableCell Na" +
        "me=\"Cell8\" Border.Lines=\"All\" Border.Color=\"LightGray\" Format=\"Currency\" Format." +
        "UseLocale=\"true\" HorzAlign=\"Right\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\">\r\n     ";
      reportString += "       <CheckBoxObject Name=\"CheckBox2\" Left=\"18.9\" Top=\"3.78\" Width=\"9.45\" Heig" +
        "ht=\"9.45\" DataColumn=\"OPU.卵巢右\" Expression=\"ToBoolean([OPU.卵巢右])\"/>\r\n          </" +
        "TableCell>\r\n          <TableCell Name=\"Cell18\" Border.Lines=\"All\" Border.Color=\"" +
        "LightGray\" Text=\"[OPU.卵泡数量]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8." +
        "25pt\"/>\r\n          <TableCell Name=\"Cell15\" Border.Lines=\"All\" Border.Color=\"Lig" +
        "htGray\" Text=\"[OPU.液体体积]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25p" +
        "t\"/>\r\n          <TableCell Name=\"Cell21\" Border.Lines=\"All\" Border.Color=\"LightG" +
        "ray\" Text=\"[OPU.性状]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r" +
        "\n          <TableCell Name=\"Cell24\" Border.Lines=\"All\" Border.Color=\"LightGray\" " +
        "Text=\"[OPU.卵子情况]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n  " +
        "        <TableCell Name=\"Cell27\" Border.Lines=\"All\" Border.Color=\"LightGray\" Tex" +
        "t=\"[OPU.培养皿号]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n     ";
      reportString += "     <TableCell Name=\"Cell30\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"" +
        "[OPU.存放点]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n        <" +
        "/TableRow>\r\n      </TableObject>\r\n      <TextObject Name=\"Text25\" Left=\"207.9\" T" +
        "op=\"18.9\" Width=\"255.15\" Height=\"47.25\" Text=\"捡 卵 记 录\" HorzAlign=\"Center\" Font=\"" +
        "宋体, 16pt, style=Bold, Italic\"/>\r\n      <TextObject Name=\"Text9\" Left=\"9.45\" Top=" +
        "\"75.6\" Width=\"170.1\" Height=\"18.9\" Text=\"取卵时间：[INFO.取卵时间]\" Font=\"宋体, 9pt\"/>\r\n   " +
        "   <TextObject Name=\"Text26\" Left=\"415.8\" Top=\"75.6\" Width=\"94.5\" Height=\"18.9\" " +
        "Text=\"取卵患者签字：\" Font=\"宋体, 9pt\"/>\r\n      <PictureObject Name=\"Picture2\" Left=\"519." +
        "75\" Top=\"66.15\" Width=\"75.6\" Height=\"28.35\" DataColumn=\"SignaturePatient.Signatu" +
        "rePatient\"/>\r\n      <ShapeObject Name=\"Shape1\" Left=\"9.45\" Top=\"803.25\" Width=\"3" +
        "96.9\" Height=\"75.6\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparen" +
        "t\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\"/>\r\n      <TextObject Name=\"Text27\" Left=";
      reportString += "\"18.9\" Top=\"812.7\" Width=\"264.6\" Height=\"47.25\" Fill=\"Glass\" Fill.Color=\"Transpa" +
        "rent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"卵子总数 [INFO.卵子总数] 个，自用 [INFO.自用数" +
        "] 个&#13;&#10;其他用途 [INFO.其他用途数] 个，遗弃 [INFO.遗弃数] 个， 遗失 [INFO.遗失数] 个。\" Font=\"新宋体, 9" +
        "pt\"/>\r\n      <TextObject Name=\"Text23\" Left=\"434.7\" Top=\"812.7\" Width=\"94.5\" Hei" +
        "ght=\"18.9\" Text=\"操作者签字：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text24\" Left=" +
        "\"434.7\" Top=\"841.05\" Width=\"94.5\" Height=\"18.9\" Text=\"核对者签字：\" Font=\"宋体, 9pt\"/>\r\n" +
        "      <PictureObject Name=\"Picture1\" Left=\"529.2\" Top=\"812.7\" Width=\"75.6\" Heigh" +
        "t=\"18.9\" DataColumn=\"SignatureOperator.SignatureOperator\"/>\r\n      <PictureObjec" +
        "t Name=\"Picture3\" Left=\"529.2\" Top=\"841.05\" Width=\"75.6\" Height=\"28.35\" DataColu" +
        "mn=\"SignatureChecker.SignatureChecker\"/>\r\n      <TextObject Name=\"Text28\" Left=\"" +
        "9.45\" Top=\"897.75\" Width=\"614.25\" Height=\"18.9\" Text=\"备注：C：清亮 F：血水样 B：血性 T：凝固\" F" +
        "ont=\"宋体, 9pt\"/>\r\n    </DataBand>\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"10";
      reportString += "23.15\" Width=\"718.2\" Height=\"18.9\"/>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      Table1.ManualBuild += Table1_ManualBuild;
      
    }

    public OocyteProcessReport()
    {
      InitializeComponent();
    }

    private void Table1_ManualBuild(object sender, EventArgs e)
    {
      // get the data source by its name
      DataSourceBase rowData = Report.GetDataSource("OPU");
      // init the data source
      rowData.Init();
      
      // print the first table row - it is a header
      Table1.PrintRow(0);
      // each PrintRow call must be followed by either PrintColumn or PrintColumns call
      // to print cells on the row
      Table1.PrintColumns();
      
      // now enumerate the data source and print the table body
      while (rowData.HasMoreRows)
      {
        // print the table body  
        Table1.PrintRow(1);
        Table1.PrintColumns();
        
        // go next data source row
        rowData.Next();
      }

    }
  }
}
