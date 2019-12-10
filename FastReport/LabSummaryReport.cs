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
  public class LabSummaryReport : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.Table.TableCell Cell1;
    public FastReport.Table.TableCell Cell10;
    public FastReport.Table.TableCell Cell11;
    public FastReport.Table.TableCell Cell12;
    public FastReport.Table.TableCell Cell13;
    public FastReport.Table.TableCell Cell14;
    public FastReport.Table.TableCell Cell15;
    public FastReport.Table.TableCell Cell2;
    public FastReport.Table.TableCell Cell26;
    public FastReport.Table.TableCell Cell27;
    public FastReport.Table.TableCell Cell28;
    public FastReport.Table.TableCell Cell29;
    public FastReport.Table.TableCell Cell3;
    public FastReport.Table.TableCell Cell30;
    public FastReport.Table.TableCell Cell31;
    public FastReport.Table.TableCell Cell32;
    public FastReport.Table.TableCell Cell33;
    public FastReport.Table.TableCell Cell34;
    public FastReport.Table.TableCell Cell35;
    public FastReport.Table.TableCell Cell36;
    public FastReport.Table.TableCell Cell37;
    public FastReport.Table.TableCell Cell38;
    public FastReport.Table.TableCell Cell39;
    public FastReport.Table.TableCell Cell4;
    public FastReport.Table.TableCell Cell40;
    public FastReport.Table.TableCell Cell41;
    public FastReport.Table.TableCell Cell42;
    public FastReport.Table.TableCell Cell43;
    public FastReport.Table.TableCell Cell44;
    public FastReport.Table.TableCell Cell45;
    public FastReport.Table.TableCell Cell46;
    public FastReport.Table.TableCell Cell47;
    public FastReport.Table.TableCell Cell48;
    public FastReport.Table.TableCell Cell49;
    public FastReport.Table.TableCell Cell5;
    public FastReport.Table.TableCell Cell50;
    public FastReport.Table.TableCell Cell51;
    public FastReport.Table.TableCell Cell52;
    public FastReport.Table.TableCell Cell53;
    public FastReport.Table.TableCell Cell54;
    public FastReport.Table.TableCell Cell55;
    public FastReport.Table.TableCell Cell56;
    public FastReport.Table.TableCell Cell57;
    public FastReport.Table.TableCell Cell58;
    public FastReport.Table.TableCell Cell59;
    public FastReport.Table.TableCell Cell6;
    public FastReport.Table.TableCell Cell60;
    public FastReport.Table.TableCell Cell61;
    public FastReport.Table.TableCell Cell62;
    public FastReport.Table.TableCell Cell63;
    public FastReport.Table.TableCell Cell64;
    public FastReport.Table.TableCell Cell65;
    public FastReport.Table.TableCell Cell66;
    public FastReport.Table.TableCell Cell67;
    public FastReport.Table.TableCell Cell68;
    public FastReport.Table.TableCell Cell69;
    public FastReport.Table.TableCell Cell7;
    public FastReport.Table.TableCell Cell70;
    public FastReport.Table.TableCell Cell8;
    public FastReport.Table.TableCell Cell9;
    public FastReport.CheckBoxObject CheckBox1;
    public FastReport.CheckBoxObject CheckBox10;
    public FastReport.CheckBoxObject CheckBox11;
    public FastReport.CheckBoxObject CheckBox12;
    public FastReport.CheckBoxObject CheckBox13;
    public FastReport.CheckBoxObject CheckBox14;
    public FastReport.CheckBoxObject CheckBox15;
    public FastReport.CheckBoxObject CheckBox2;
    public FastReport.CheckBoxObject CheckBox3;
    public FastReport.CheckBoxObject CheckBox4;
    public FastReport.CheckBoxObject CheckBox5;
    public FastReport.CheckBoxObject CheckBox6;
    public FastReport.CheckBoxObject CheckBox7;
    public FastReport.CheckBoxObject CheckBox8;
    public FastReport.CheckBoxObject CheckBox9;
    public FastReport.Table.TableColumn Column1;
    public FastReport.Table.TableColumn Column2;
    public FastReport.Table.TableColumn Column3;
    public FastReport.Table.TableColumn Column4;
    public FastReport.Table.TableColumn Column5;
    public FastReport.DataBand Data1;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.PictureObject Picture1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.RichObject Rich1;
    public FastReport.Table.TableRow Row1;
    public FastReport.Table.TableRow Row10;
    public FastReport.Table.TableRow Row11;
    public FastReport.Table.TableRow Row12;
    public FastReport.Table.TableRow Row13;
    public FastReport.Table.TableRow Row14;
    public FastReport.Table.TableRow Row2;
    public FastReport.Table.TableRow Row3;
    public FastReport.Table.TableRow Row6;
    public FastReport.Table.TableRow Row7;
    public FastReport.Table.TableRow Row8;
    public FastReport.Table.TableRow Row9;
    public FastReport.Table.TableObject Table1;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text10;
    public FastReport.TextObject Text11;
    public FastReport.TextObject Text12;
    public FastReport.TextObject Text13;
    public FastReport.TextObject Text14;
    public FastReport.TextObject Text15;
    public FastReport.TextObject Text16;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text25;
    public FastReport.TextObject Text26;
    public FastReport.TextObject Text27;
    public FastReport.TextObject Text28;
    public FastReport.TextObject Text29;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text30;
    public FastReport.TextObject Text31;
    public FastReport.TextObject Text32;
    public FastReport.TextObject Text33;
    public FastReport.TextObject Text34;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text36;
    public FastReport.TextObject Text37;
    public FastReport.TextObject Text38;
    public FastReport.TextObject Text39;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text40;
    public FastReport.TextObject Text5;
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
      if (expression == "ToBoolean([INFO.常规Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.常规Flag")));
      if (expression == "ToBoolean([INFO.ICSIFlag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.ICSIFlag")));
      if (expression == "ToBoolean([INFO.其他Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.其他Flag")));
      if (expression == "ToBoolean([INFO.冷冻胚胎Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.冷冻胚胎Flag")));
      if (expression == "ToBoolean([INFO.冷冻精子Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.冷冻精子Flag")));
      if (expression == "ToBoolean([INFO.夫精Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.夫精Flag")));
      if (expression == "ToBoolean([INFO.妻卵Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.妻卵Flag")));
      if (expression == "ToBoolean([INFO.他精Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.他精Flag")));
      if (expression == "ToBoolean([INFO.精液精子Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.精液精子Flag")));
      if (expression == "ToBoolean([INFO.睾丸精子Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.睾丸精子Flag")));
      if (expression == "ToBoolean([INFO.附睾精子Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.附睾精子Flag")));
      if (expression == "ToBoolean([INFO.精子好Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.精子好Flag")));
      if (expression == "ToBoolean([INFO.精子一般Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.精子一般Flag")));
      if (expression == "ToBoolean([INFO.精子差Flag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.精子差Flag")));
      if (expression == "ToBoolean([INFO.精子ICSIFlag])")
        return ToBoolean(((String)Report.GetColumnValue("INFO.精子ICSIFlag")));
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
        "nfo.Created=\"11/29/2018 11:04:54\" ReportInfo.Modified=\"12/20/2018 13:52:03\" Repo" +
        "rtInfo.CreatorVersion=\"2013.2.5.0\">\r\n  <Dictionary>\r\n    <TableDataSource Name=\"" +
        "INFO\" ReferenceName=\"Data.INFO\" DataType=\"System.Int32\" Enabled=\"true\">\r\n      <" +
        "Column Name=\"男方姓名\" DataType=\"System.String\"/>\r\n      <Column Name=\"女方姓名\" DataTyp" +
        "e=\"System.String\"/>\r\n      <Column Name=\"病历编号\" DataType=\"System.String\"/>\r\n     " +
        " <Column Name=\"诊断\" DataType=\"System.String\"/>\r\n      <Column Name=\"妻子年龄\" DataTyp" +
        "e=\"System.String\"/>\r\n      <Column Name=\"丈夫年龄\" DataType=\"System.String\"/>\r\n     " +
        " <Column Name=\"LMP日\" DataType=\"System.String\"/>\r\n      <Column Name=\"OPU日\" DataT" +
        "ype=\"System.String\"/>\r\n      <Column Name=\"ET日\" DataType=\"System.String\"/>\r\n    " +
        "  <Column Name=\"常规Flag\" DataType=\"System.String\"/>\r\n      <Column Name=\"ICSIFlag" +
        "\" DataType=\"System.String\"/>\r\n      <Column Name=\"其他Flag\" DataType=\"System.Strin" +
        "g\"/>\r\n      <Column Name=\"其他描述\" DataType=\"System.String\"/>\r\n      <Column Name=\"";
      reportString += "冷冻胚胎Flag\" DataType=\"System.String\"/>\r\n      <Column Name=\"冷冻精子Flag\" DataType=\"Sy" +
        "stem.String\"/>\r\n      <Column Name=\"夫精Flag\" DataType=\"System.String\"/>\r\n      <C" +
        "olumn Name=\"他精Flag\" DataType=\"System.String\"/>\r\n      <Column Name=\"妻卵Flag\" Data" +
        "Type=\"System.String\"/>\r\n      <Column Name=\"精液精子Flag\" DataType=\"System.String\"/>" +
        "\r\n      <Column Name=\"睾丸精子Flag\" DataType=\"System.String\"/>\r\n      <Column Name=\"" +
        "附睾精子Flag\" DataType=\"System.String\"/>\r\n      <Column Name=\"获卵总数\" DataType=\"System" +
        ".String\"/>\r\n      <Column Name=\"三级卵数\" DataType=\"System.String\"/>\r\n      <Column " +
        "Name=\"二级卵数\" DataType=\"System.String\"/>\r\n      <Column Name=\"一级卵数\" DataType=\"Syst" +
        "em.String\"/>\r\n      <Column Name=\"其他卵数\" DataType=\"System.String\"/>\r\n      <Colum" +
        "n Name=\"受精总数\" DataType=\"System.String\"/>\r\n      <Column Name=\"2PN数\" DataType=\"Sy" +
        "stem.String\"/>\r\n      <Column Name=\"1PN数\" DataType=\"System.String\"/>\r\n      <Col" +
        "umn Name=\"3PN数\" DataType=\"System.String\"/>\r\n      <Column Name=\"胚胎总数\" DataType=\"";
      reportString += "System.String\"/>\r\n      <Column Name=\"一级胚胎数\" DataType=\"System.String\"/>\r\n      <" +
        "Column Name=\"二级胚胎数\" DataType=\"System.String\"/>\r\n      <Column Name=\"利用胚胎数\" DataT" +
        "ype=\"System.String\"/>\r\n      <Column Name=\"ET胚胎数\" DataType=\"System.String\"/>\r\n  " +
        "    <Column Name=\"冷冻总数\" DataType=\"System.String\"/>\r\n      <Column Name=\"冷冻管数\" Da" +
        "taType=\"System.String\"/>\r\n      <Column Name=\"精子好Flag\" DataType=\"System.String\"/" +
        ">\r\n      <Column Name=\"精子一般Flag\" DataType=\"System.String\"/>\r\n      <Column Name=" +
        "\"精子差Flag\" DataType=\"System.String\"/>\r\n      <Column Name=\"精子ICSIFlag\" DataType=\"" +
        "System.String\"/>\r\n      <Column Name=\"解冻管数\" DataType=\"System.String\"/>\r\n      <C" +
        "olumn Name=\"解冻胚胎数\" DataType=\"System.String\"/>\r\n      <Column Name=\"解冻存活胚胎数\" Data" +
        "Type=\"System.String\"/>\r\n      <Column Name=\"解冻ET胚胎数\" DataType=\"System.String\"/>\r" +
        "\n      <Column Name=\"其他记录\" DataType=\"System.String\"/>\r\n      <Column Name=\"签字时间\"" +
        " DataType=\"System.String\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Name=\"";
      reportString += "SignaturePatient\" ReferenceName=\"Data.SignaturePatient\" DataType=\"System.Int32\" " +
        "Enabled=\"true\">\r\n      <Column Name=\"SignaturePatient\" DataType=\"System.Byte[]\" " +
        "BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Name=\"" +
        "SignatureOperator\" ReferenceName=\"Data.SignatureOperator\" DataType=\"System.Int32" +
        "\" Enabled=\"true\">\r\n      <Column Name=\"SignatureOperator\" DataType=\"System.Byte[" +
        "]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Nam" +
        "e=\"SignatureChecker\" ReferenceName=\"Data.SignatureChecker\" DataType=\"System.Int3" +
        "2\" Enabled=\"true\">\r\n      <Column Name=\"SignatureChecker\" DataType=\"System.Byte[" +
        "]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n  </Dictionary>\r\n  <Repo" +
        "rtPage Name=\"Page1\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=\"718.2\" Hei" +
        "ght=\"94.5\">\r\n      <TextObject Name=\"Text10\" Left=\"9.45\" Top=\"9.45\" Width=\"699.3" +
        "\" Height=\"47.25\" Text=\"华中科技大学同济医学院附属荆州医院&#13;&#10;荆州市中心医院\" Format=\"Currency\" For";
      reportString += "mat.UseLocale=\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 12pt\"/>\r\n " +
        "     <TextObject Name=\"Text11\" Left=\"340.2\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9" +
        "\" Text=\"[INFO.男方姓名]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text12\" Left=\"94." +
        "5\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"[INFO.女方姓名]\" Font=\"宋体, 9pt\"/>\r\n  " +
        "    <TextObject Name=\"Text13\" Left=\"9.45\" Top=\"56.7\" Width=\"75.6\" Height=\"18.9\" " +
        "Text=\"妻子姓名：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text14\" Left=\"255.15\" Top" +
        "=\"56.7\" Width=\"75.6\" Height=\"18.9\" Text=\"丈夫姓名：\" Font=\"宋体, 9pt\"/>\r\n      <TextObj" +
        "ect Name=\"Text15\" Left=\"567\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"[INFO.病" +
        "历编号]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text16\" Left=\"481.95\" Top=\"56.7\"" +
        " Width=\"75.6\" Height=\"18.9\" Text=\"病历编号：&#13;&#10;\" Font=\"宋体, 9pt\"/>\r\n      <Rich" +
        "Object Name=\"Rich1\" Left=\"9.45\" Top=\"75.6\" Width=\"689.85\" Height=\"18.9\" Border.L" +
        "ines=\"Top\"/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top";
      reportString += "=\"98.5\" Width=\"718.2\" Height=\"66.15\"/>\r\n    <DataBand Name=\"Data1\" Top=\"168.65\" " +
        "Width=\"718.2\" Height=\"812.7\" DataSource=\"SignatureOperator\">\r\n      <TextObject " +
        "Name=\"Text25\" Left=\"217.35\" Top=\"9.45\" Width=\"255.15\" Height=\"47.25\" Text=\"IVF-E" +
        "T实验室小结\" HorzAlign=\"Center\" Font=\"微软雅黑, 15.75pt, style=Bold\"/>\r\n      <TableObjec" +
        "t Name=\"Table1\" Left=\"9.45\" Top=\"75.6\" Width=\"680.4\" Height=\"509.41\">\r\n        <" +
        "TableColumn Name=\"Column1\" Width=\"39.69\"/>\r\n        <TableColumn Name=\"Column2\" " +
        "Width=\"266.49\"/>\r\n        <TableColumn Name=\"Column3\" Width=\"39.69\"/>\r\n        <" +
        "TableColumn Name=\"Column4\" Width=\"115.29\"/>\r\n        <TableColumn Name=\"Column5\"" +
        " Width=\"219.24\"/>\r\n        <TableRow Name=\"Row1\" Height=\"34.02\">\r\n          <Tab" +
        "leCell Name=\"Cell1\" Border.Lines=\"All\" Text=\"诊断：[INFO.诊断]\" VertAlign=\"Center\" Fo" +
        "nt=\"宋体, 9pt\" ColSpan=\"5\"/>\r\n          <TableCell Name=\"Cell2\" Font=\"宋体, 9pt\"/>\r\n" +
        "          <TableCell Name=\"Cell3\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"C";
      reportString += "ell4\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell5\" Font=\"宋体, 9pt\"/>\r\n    " +
        "    </TableRow>\r\n        <TableRow Name=\"Row2\" Height=\"34.02\">\r\n          <Table" +
        "Cell Name=\"Cell6\" Border.Lines=\"All\" Text=\"妻子年龄  [INFO.妻子年龄]\" VertAlign=\"Center\"" +
        " Font=\"宋体, 9pt\" ColSpan=\"3\"/>\r\n          <TableCell Name=\"Cell7\" Font=\"宋体, 9pt\"/" +
        ">\r\n          <TableCell Name=\"Cell8\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name" +
        "=\"Cell9\" Border.Lines=\"All\" Text=\"丈夫年龄  [INFO.丈夫年龄]\" VertAlign=\"Center\" Font=\"宋体" +
        ", 9pt\" ColSpan=\"2\"/>\r\n          <TableCell Name=\"Cell10\" Font=\"宋体, 9pt\"/>\r\n     " +
        "   </TableRow>\r\n        <TableRow Name=\"Row6\" Height=\"28.35\">\r\n          <TableC" +
        "ell Name=\"Cell26\" Border.Lines=\"All\" Text=\"LMP日  [INFO.LMP日]              OPU日  " +
        "[INFO.OPU日]              ET日   [INFO.ET日]\" VertAlign=\"Center\" Font=\"宋体, 9pt\" Col" +
        "Span=\"5\"/>\r\n          <TableCell Name=\"Cell27\" Font=\"宋体, 9pt\"/>\r\n          <Tabl" +
        "eCell Name=\"Cell28\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell29\" Font=\"宋";
      reportString += "体, 9pt\"/>\r\n          <TableCell Name=\"Cell30\" Font=\"宋体, 9pt\"/>\r\n        </TableR" +
        "ow>\r\n        <TableRow Name=\"Row3\" Height=\"81.27\">\r\n          <TableCell Name=\"C" +
        "ell11\" Border.Lines=\"All\" Text=\"实施技术\" VertAlign=\"Center\" Font=\"宋体, 9pt\" RowSpan=" +
        "\"2\"/>\r\n          <TableCell Name=\"Cell12\" Border.Lines=\"All\" Font=\"宋体, 9pt\" ColS" +
        "pan=\"4\">\r\n            <TextObject Name=\"Text1\" Left=\"9.45\" Top=\"9.45\" Width=\"94." +
        "5\" Height=\"18.9\" Text=\"技术：\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"" +
        "/>\r\n            <CheckBoxObject Name=\"CheckBox1\" Left=\"103.95\" Top=\"9.45\" Width=" +
        "\"18.9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO.常规Flag\" Expression=\"ToB" +
        "oolean([INFO.常规Flag])\"/>\r\n            <TextObject Name=\"Text2\" Left=\"122.85\" Top" +
        "=\"9.45\" Width=\"94.5\" Height=\"18.9\" Text=\"常规IVF-ET\" VertAlign=\"Bottom\" Font=\"宋体, " +
        "9pt\"/>\r\n            <TextObject Name=\"Text26\" Left=\"264.6\" Top=\"9.45\" Width=\"94." +
        "5\" Height=\"18.9\" Text=\"ICSI\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n            <C";
      reportString += "heckBoxObject Name=\"CheckBox2\" Left=\"245.7\" Top=\"9.45\" Width=\"18.9\" Height=\"18.9" +
        "\" Border.Lines=\"All\" DataColumn=\"INFO.ICSIFlag\" Expression=\"ToBoolean([INFO.ICSI" +
        "Flag])\"/>\r\n            <TextObject Name=\"Text27\" Left=\"415.8\" Top=\"9.45\" Width=\"" +
        "94.5\" Height=\"18.9\" Text=\"其他（[INFO.其他描述]）\" VertAlign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n" +
        "            <CheckBoxObject Name=\"CheckBox3\" Left=\"396.9\" Top=\"9.45\" Width=\"18.9" +
        "\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO.其他描述\" Expression=\"ToBoolean(" +
        "[INFO.其他Flag])\"/>\r\n            <TextObject Name=\"Text28\" Left=\"122.85\" Top=\"47.2" +
        "5\" Width=\"94.5\" Height=\"18.9\" Text=\"冷冻胚胎\" VertAlign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n " +
        "           <CheckBoxObject Name=\"CheckBox4\" Left=\"103.95\" Top=\"47.25\" Width=\"18." +
        "9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO.冷冻胚胎Flag\" Expression=\"ToBoo" +
        "lean([INFO.冷冻胚胎Flag])\"/>\r\n            <TextObject Name=\"Text29\" Left=\"264.6\" Top" +
        "=\"47.25\" Width=\"94.5\" Height=\"18.9\" Text=\"冷冻精子\" VertAlign=\"Bottom\" Font=\"宋体, 9pt";
      reportString += "\"/>\r\n            <CheckBoxObject Name=\"CheckBox5\" Left=\"245.7\" Top=\"47.25\" Width" +
        "=\"18.9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO.冷冻精子Flag\" Expression=\"" +
        "ToBoolean([INFO.冷冻精子Flag])\"/>\r\n          </TableCell>\r\n          <TableCell Name" +
        "=\"Cell13\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell14\" Border.Lines=\"All" +
        "\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell15\" Font=\"宋体, 9pt\"/>\r\n       " +
        " </TableRow>\r\n        <TableRow Name=\"Row7\" Height=\"85.05\">\r\n          <TableCel" +
        "l Name=\"Cell31\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"" +
        "Cell32\" Border.Lines=\"All\" Font=\"宋体, 9pt\" ColSpan=\"4\">\r\n            <TextObject " +
        "Name=\"Text30\" Left=\"9.45\" Top=\"18.9\" Width=\"94.5\" Height=\"18.9\" Text=\"配子：\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject N" +
        "ame=\"CheckBox6\" Left=\"103.95\" Top=\"18.9\" Width=\"18.9\" Height=\"18.9\" Border.Lines" +
        "=\"All\" DataColumn=\"INFO.夫精Flag\" Expression=\"ToBoolean([INFO.夫精Flag])\"/>\r\n       ";
      reportString += "     <TextObject Name=\"Text31\" Left=\"122.85\" Top=\"18.9\" Width=\"94.5\" Height=\"18." +
        "9\" Text=\"夫精\" VertAlign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n            <TextObject Name=\"" +
        "Text32\" Left=\"264.6\" Top=\"18.9\" Width=\"94.5\" Height=\"18.9\" Text=\"妻卵\" VertAlign=\"" +
        "Bottom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject Name=\"CheckBox7\" Left=\"245" +
        ".7\" Top=\"18.9\" Width=\"18.9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO.妻卵" +
        "Flag\" Expression=\"ToBoolean([INFO.妻卵Flag])\"/>\r\n            <TextObject Name=\"Tex" +
        "t33\" Left=\"415.8\" Top=\"18.9\" Width=\"94.5\" Height=\"18.9\" Text=\"他精\" VertAlign=\"Bot" +
        "tom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject Name=\"CheckBox8\" Left=\"396.9\"" +
        " Top=\"18.9\" Width=\"18.9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO.他精Fla" +
        "g\" Expression=\"ToBoolean([INFO.他精Flag])\"/>\r\n            <TextObject Name=\"Text34" +
        "\" Left=\"122.85\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"精液精子\" VertAlign=\"Bot" +
        "tom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject Name=\"CheckBox9\" Left=\"103.95";
      reportString += "\" Top=\"56.7\" Width=\"18.9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO.精液精子" +
        "Flag\" Expression=\"ToBoolean([INFO.精液精子Flag])\"/>\r\n            <TextObject Name=\"T" +
        "ext35\" Left=\"264.6\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"睾丸精子\" VertAlign=" +
        "\"Bottom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject Name=\"CheckBox10\" Left=\"2" +
        "45.7\" Top=\"56.7\" Width=\"18.9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"INFO." +
        "睾丸精子Flag\" Expression=\"ToBoolean([INFO.睾丸精子Flag])\"/>\r\n            <TextObject Nam" +
        "e=\"Text36\" Left=\"415.8\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"附睾精子\" VertAl" +
        "ign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject Name=\"CheckBox11\" Lef" +
        "t=\"396.9\" Top=\"56.7\" Width=\"18.9\" Height=\"18.9\" Border.Lines=\"All\" DataColumn=\"I" +
        "NFO.附睾精子Flag\" Expression=\"ToBoolean([INFO.附睾精子Flag])\"/>\r\n          </TableCell>\r" +
        "\n          <TableCell Name=\"Cell33\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n       " +
        "   <TableCell Name=\"Cell34\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <Tabl";
      reportString += "eCell Name=\"Cell35\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n  " +
        "      <TableRow Name=\"Row8\" Height=\"28.35\">\r\n          <TableCell Name=\"Cell36\" " +
        "Border.Lines=\"All\" Text=\"配子  与  胚胎\" VertAlign=\"Center\" Font=\"宋体, 9pt\" RowSpan=\"4" +
        "\"/>\r\n          <TableCell Name=\"Cell37\" Border.Lines=\"All\" Text=\"获卵：总共&lt;u&gt; " +
        "[INFO.获卵总数] &lt;/u&gt;个  III级卵&lt;u&gt; [INFO.三级卵数] &lt;/u&gt;个  II级卵&lt;u&gt; [" +
        "INFO.二级卵数] &lt;/u&gt;个  I级卵&lt;u&gt; [INFO.一级卵数] &lt;/u&gt;个  其他&lt;u&gt; [INFO." +
        "其他卵数] &lt;/u&gt;个\" VertAlign=\"Center\" Font=\"宋体, 9pt\" HtmlTags=\"true\" ColSpan=\"4\"" +
        "/>\r\n          <TableCell Name=\"Cell38\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n    " +
        "      <TableCell Name=\"Cell39\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <T" +
        "ableCell Name=\"Cell40\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r" +
        "\n        <TableRow Name=\"Row9\" Height=\"28.35\">\r\n          <TableCell Name=\"Cell4" +
        "1\" Border.Lines=\"All\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell ";
      reportString += "Name=\"Cell42\" Border.Lines=\"All\" Text=\"受精：共受精&lt;u&gt; [INFO.受精总数] &lt;/u&gt;个  " +
        "2PN&lt;u&gt; [INFO.2PN数] &lt;/u&gt;个  三个或以上PN&lt;u&gt; [INFO.3PN数] &lt;/u&gt;个\" " +
        "VertAlign=\"Center\" Font=\"宋体, 9pt\" HtmlTags=\"true\" ColSpan=\"4\"/>\r\n          <Tabl" +
        "eCell Name=\"Cell43\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Na" +
        "me=\"Cell44\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell" +
        "45\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow " +
        "Name=\"Row10\" Height=\"56.7\">\r\n          <TableCell Name=\"Cell46\" Border.Lines=\"Al" +
        "l\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell47\" Borde" +
        "r.Lines=\"All\" Text=\"胚胎：共有胚胎&lt;u&gt; [INFO.胚胎总数] &lt;/u&gt;个  I级胚胎&lt;u&gt; [INF" +
        "O.一级胚胎数] &lt;/u&gt;个 II级胚胎&lt;u&gt; [INFO.二级胚胎数] &lt;/u&gt;个&#13;&#10;      利用胚胎" +
        "&lt;u&gt; [INFO.利用胚胎数] &lt;/u&gt;个  ET&lt;u&gt; [INFO.ET胚胎数] &lt;/u&gt;个  冷冻&lt;" +
        "u&gt; [INFO.ET胚胎数] &lt;/u&gt;个 分（&lt;u&gt; [INFO.冷冻管数] &lt;/u&gt;）管&#13;&#10;\" V";
      reportString += "ertAlign=\"Center\" Font=\"宋体, 9pt\" HtmlTags=\"true\" ColSpan=\"4\"/>\r\n          <Table" +
        "Cell Name=\"Cell48\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Nam" +
        "e=\"Cell49\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell5" +
        "0\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow N" +
        "ame=\"Row11\" Height=\"37.8\">\r\n          <TableCell Name=\"Cell51\" Border.Lines=\"All" +
        "\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell52\" Border" +
        ".Lines=\"All\" Text=\"精子处理后情况：\" VertAlign=\"Center\" Font=\"宋体, 9pt\" ColSpan=\"4\">\r\n   " +
        "         <TextObject Name=\"Text37\" Left=\"132.3\" Top=\"9.45\" Width=\"37.8\" Height=\"" +
        "18.9\" Text=\"好\" VertAlign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject " +
        "Name=\"CheckBox12\" Left=\"113.4\" Top=\"9.45\" Width=\"18.9\" Height=\"18.9\" Border.Line" +
        "s=\"All\" DataColumn=\"INFO.精子好Flag\" Expression=\"ToBoolean([INFO.精子好Flag])\"/>\r\n    " +
        "        <TextObject Name=\"Text38\" Left=\"217.35\" Top=\"9.45\" Width=\"56.7\" Height=\"";
      reportString += "18.9\" Text=\"一般\" VertAlign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObject" +
        " Name=\"CheckBox13\" Left=\"198.45\" Top=\"9.45\" Width=\"18.9\" Height=\"18.9\" Border.Li" +
        "nes=\"All\" DataColumn=\"INFO.精子一般Flag\" Expression=\"ToBoolean([INFO.精子一般Flag])\"/>\r\n" +
        "            <TextObject Name=\"Text39\" Left=\"321.3\" Top=\"9.45\" Width=\"37.8\" Heigh" +
        "t=\"18.9\" Text=\"差\" VertAlign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n            <CheckBoxObje" +
        "ct Name=\"CheckBox14\" Left=\"302.4\" Top=\"9.45\" Width=\"18.9\" Height=\"18.9\" Border.L" +
        "ines=\"All\" DataColumn=\"INFO.精子差Flag\" Expression=\"ToBoolean([INFO.精子差Flag])\"/>\r\n " +
        "           <TextObject Name=\"Text40\" Left=\"415.8\" Top=\"9.45\" Width=\"113.4\" Heigh" +
        "t=\"18.9\" Text=\"只能供ICSI使用\" VertAlign=\"Bottom\" Font=\"宋体, 9pt\"/>\r\n            <Chec" +
        "kBoxObject Name=\"CheckBox15\" Left=\"396.9\" Top=\"9.45\" Width=\"18.9\" Height=\"18.9\" " +
        "Border.Lines=\"All\" DataColumn=\"INFO.精子ICSIFlag\" Expression=\"ToBoolean([INFO.精子IC" +
        "SIFlag])\"/>\r\n          </TableCell>\r\n          <TableCell Name=\"Cell53\" Border.L";
      reportString += "ines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell54\" Border.Lines=\"Al" +
        "l\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell55\" Border.Lines=\"All\" Font=" +
        "\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row12\" Height=\"28.35\">" +
        "\r\n          <TableCell Name=\"Cell56\" Border.Lines=\"All\" Text=\"解冻胚胎\" VertAlign=\"C" +
        "enter\" Font=\"宋体, 9pt\" RowSpan=\"2\"/>\r\n          <TableCell Name=\"Cell57\" Border.L" +
        "ines=\"All\" Text=\"解冻：解冻&lt;u&gt; [INFO.解冻管数] &lt;/u&gt;管，    &lt;u&gt;[INFO.解冻胚胎数" +
        "] &lt;/u&gt;个胚胎\" VertAlign=\"Center\" Font=\"宋体, 9pt\" HtmlTags=\"true\" ColSpan=\"4\"/>" +
        "\r\n          <TableCell Name=\"Cell58\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n      " +
        "    <TableCell Name=\"Cell59\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <Tab" +
        "leCell Name=\"Cell60\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n " +
        "       <TableRow Name=\"Row13\" Height=\"28.35\">\r\n          <TableCell Name=\"Cell61" +
        "\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell62\" Border";
      reportString += ".Lines=\"All\" Text=\"存活：存活&lt;u&gt; [INFO.解冻存活胚胎数] &lt;/u&gt;个    ET&lt;u&gt; [INF" +
        "O.解冻ET胚胎数] &lt;/u&gt;个胚胎\" VertAlign=\"Center\" Font=\"宋体, 9pt\" HtmlTags=\"true\" ColS" +
        "pan=\"4\"/>\r\n          <TableCell Name=\"Cell63\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/" +
        ">\r\n          <TableCell Name=\"Cell64\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n     " +
        "     <TableCell Name=\"Cell65\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n        </Tab" +
        "leRow>\r\n        <TableRow Name=\"Row14\" Height=\"38.8\">\r\n          <TableCell Name" +
        "=\"Cell66\" Border.Lines=\"All\" Text=\"其他记录\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n  " +
        "        <TableCell Name=\"Cell67\" Border.Lines=\"All\" Text=\"[INFO.其他记录]\" Font=\"宋体," +
        " 9pt\" ColSpan=\"4\"/>\r\n          <TableCell Name=\"Cell68\" Border.Lines=\"All\" Font=" +
        "\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell69\" Border.Lines=\"All\" Font=\"宋体, 9pt" +
        "\"/>\r\n          <TableCell Name=\"Cell70\" Border.Lines=\"All\" Font=\"宋体, 9pt\"/>\r\n   " +
        "     </TableRow>\r\n      </TableObject>\r\n      <TextObject Name=\"Text3\" Left=\"415";
      reportString += ".8\" Top=\"623.7\" Width=\"113.4\" Height=\"18.9\" Text=\"实验室人员签字：\" VertAlign=\"Center\" F" +
        "ont=\"宋体, 9pt\"/>\r\n      <PictureObject Name=\"Picture1\" Left=\"529.2\" Top=\"623.7\" W" +
        "idth=\"85.05\" Height=\"18.9\" DataColumn=\"SignatureOperator.SignatureOperator\"/>\r\n " +
        "     <TextObject Name=\"Text4\" Left=\"529.2\" Top=\"652.05\" Width=\"94.5\" Height=\"18." +
        "9\" Text=\"[INFO.签字时间]\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Nam" +
        "e=\"Text5\" Left=\"9.45\" Top=\"793.8\" Width=\"670.95\" Height=\"18.9\" Text=\"注：本表由实验人员在E" +
        "T后填写，连同所有实验室记录交与临床医生，与临床病历一同保管。\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n    </Data" +
        "Band>\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"985.35\" Width=\"718.2\" Height=" +
        "\"18.9\"/>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public LabSummaryReport()
    {
      InitializeComponent();
    }
    
  }
}
