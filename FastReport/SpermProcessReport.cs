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
  public class SpermProcessReport : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.Table.TableCell Cell113;
    public FastReport.Table.TableCell Cell114;
    public FastReport.Table.TableCell Cell115;
    public FastReport.Table.TableCell Cell116;
    public FastReport.Table.TableCell Cell117;
    public FastReport.Table.TableCell Cell118;
    public FastReport.Table.TableCell Cell119;
    public FastReport.Table.TableCell Cell120;
    public FastReport.Table.TableCell Cell121;
    public FastReport.Table.TableCell Cell122;
    public FastReport.Table.TableCell Cell123;
    public FastReport.Table.TableCell Cell124;
    public FastReport.Table.TableCell Cell125;
    public FastReport.Table.TableCell Cell126;
    public FastReport.Table.TableCell Cell127;
    public FastReport.Table.TableCell Cell128;
    public FastReport.Table.TableCell Cell129;
    public FastReport.Table.TableCell Cell130;
    public FastReport.Table.TableCell Cell131;
    public FastReport.Table.TableCell Cell132;
    public FastReport.Table.TableCell Cell133;
    public FastReport.Table.TableCell Cell134;
    public FastReport.Table.TableCell Cell135;
    public FastReport.Table.TableCell Cell136;
    public FastReport.Table.TableCell Cell137;
    public FastReport.Table.TableCell Cell33;
    public FastReport.Table.TableCell Cell34;
    public FastReport.Table.TableCell Cell35;
    public FastReport.Table.TableCell Cell36;
    public FastReport.Table.TableCell Cell37;
    public FastReport.Table.TableCell Cell38;
    public FastReport.Table.TableCell Cell42;
    public FastReport.Table.TableCell Cell43;
    public FastReport.Table.TableCell Cell45;
    public FastReport.Table.TableCell Cell46;
    public FastReport.Table.TableCell Cell48;
    public FastReport.Table.TableCell Cell49;
    public FastReport.Table.TableCell Cell51;
    public FastReport.Table.TableCell Cell52;
    public FastReport.Table.TableCell Cell54;
    public FastReport.Table.TableCell Cell55;
    public FastReport.Table.TableCell Cell57;
    public FastReport.Table.TableCell Cell58;
    public FastReport.Table.TableCell Cell59;
    public FastReport.Table.TableCell Cell60;
    public FastReport.Table.TableCell Cell61;
    public FastReport.Table.TableCell Cell62;
    public FastReport.Table.TableCell Cell63;
    public FastReport.Table.TableCell Cell64;
    public FastReport.Table.TableCell Cell65;
    public FastReport.Table.TableCell Cell66;
    public FastReport.Table.TableCell Cell67;
    public FastReport.Table.TableCell Cell69;
    public FastReport.Table.TableCell Cell70;
    public FastReport.Table.TableCell Cell71;
    public FastReport.Table.TableCell Cell73;
    public FastReport.Table.TableCell Cell74;
    public FastReport.Table.TableCell Cell75;
    public FastReport.Table.TableCell Cell76;
    public FastReport.Table.TableCell Cell77;
    public FastReport.Table.TableCell Cell81;
    public FastReport.Table.TableCell Cell82;
    public FastReport.Table.TableCell Cell86;
    public FastReport.Table.TableCell Cell87;
    public FastReport.Table.TableCell Cell88;
    public FastReport.Table.TableCell Cell89;
    public FastReport.Table.TableCell Cell90;
    public FastReport.Table.TableCell Cell91;
    public FastReport.Table.TableCell Cell92;
    public FastReport.Table.TableCell Cell93;
    public FastReport.Table.TableCell Cell94;
    public FastReport.Table.TableCell Cell95;
    public FastReport.Table.TableCell Cell96;
    public FastReport.Table.TableCell Cell97;
    public FastReport.ChildBand Child1;
    public FastReport.ChildBand Child2;
    public FastReport.ChildBand Child3;
    public FastReport.Table.TableColumn Column10;
    public FastReport.Table.TableColumn Column11;
    public FastReport.Table.TableColumn Column12;
    public FastReport.Table.TableColumn Column13;
    public FastReport.Table.TableColumn Column14;
    public FastReport.Table.TableColumn Column15;
    public FastReport.Table.TableColumn Column16;
    public FastReport.Table.TableColumn Column17;
    public FastReport.Table.TableColumn Column18;
    public FastReport.Table.TableColumn Column19;
    public FastReport.Table.TableColumn Column20;
    public FastReport.Table.TableColumn Column21;
    public FastReport.Table.TableColumn Column22;
    public FastReport.Table.TableColumn Column23;
    public FastReport.Table.TableColumn Column24;
    public FastReport.Table.TableColumn Column25;
    public FastReport.Table.TableColumn Column26;
    public FastReport.Table.TableColumn Column27;
    public FastReport.Table.TableColumn Column28;
    public FastReport.Table.TableColumn Column29;
    public FastReport.Table.TableColumn Column30;
    public FastReport.Table.TableColumn Column31;
    public FastReport.Table.TableColumn Column32;
    public FastReport.Table.TableColumn Column33;
    public FastReport.Table.TableColumn Column34;
    public FastReport.DataBand Data1;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.PictureObject Picture1;
    public FastReport.PictureObject Picture2;
    public FastReport.PictureObject Picture3;
    public FastReport.PictureObject Picture4;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.RichObject Rich1;
    public FastReport.Table.TableRow Row10;
    public FastReport.Table.TableRow Row11;
    public FastReport.Table.TableRow Row12;
    public FastReport.Table.TableRow Row13;
    public FastReport.Table.TableRow Row14;
    public FastReport.Table.TableRow Row15;
    public FastReport.Table.TableRow Row4;
    public FastReport.Table.TableRow Row5;
    public FastReport.Table.TableRow Row7;
    public FastReport.Table.TableRow Row8;
    public FastReport.Table.TableRow Row9;
    public FastReport.Table.TableObject Table1;
    public FastReport.Table.TableObject Table2;
    public FastReport.Table.TableObject Table3;
    public FastReport.Table.TableObject Table4;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text10;
    public FastReport.TextObject Text11;
    public FastReport.TextObject Text12;
    public FastReport.TextObject Text13;
    public FastReport.TextObject Text14;
    public FastReport.TextObject Text15;
    public FastReport.TextObject Text16;
    public FastReport.TextObject Text17;
    public FastReport.TextObject Text18;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text20;
    public FastReport.TextObject Text21;
    public FastReport.TextObject Text23;
    public FastReport.TextObject Text25;
    public FastReport.TextObject Text27;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text34;
    public FastReport.TextObject Text35;
    public FastReport.TextObject Text37;
    public FastReport.TextObject Text39;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text41;
    public FastReport.TextObject Text43;
    public FastReport.TextObject Text45;
    public FastReport.TextObject Text47;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text51;
    public FastReport.TextObject Text53;
    public FastReport.TextObject Text54;
    public FastReport.TextObject Text55;
    public FastReport.TextObject Text56;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text8;
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
        "nfo.Created=\"11/17/2018 18:21:44\" ReportInfo.Modified=\"01/15/2019 15:11:09\" Repo" +
        "rtInfo.CreatorVersion=\"2013.2.5.0\">\r\n  <Dictionary>\r\n    <TableDataSource Name=\"" +
        "SpermProcess\" ReferenceName=\"Data.SpermProcess\" DataType=\"System.Int32\" Enabled=" +
        "\"true\">\r\n      <Column Name=\"处理时间\" DataType=\"System.String\"/>\r\n      <Column Nam" +
        "e=\"精液量\" DataType=\"System.String\"/>\r\n      <Column Name=\"粘度\" DataType=\"System.Str" +
        "ing\"/>\r\n      <Column Name=\"液化时间\" DataType=\"System.String\"/>\r\n      <Column Name" +
        "=\"精子密度\" DataType=\"System.String\"/>\r\n      <Column Name=\"精子活力a\" DataType=\"System." +
        "String\"/>\r\n      <Column Name=\"精子活力b\" DataType=\"System.String\"/>\r\n      <Column " +
        "Name=\"精子活力c\" DataType=\"System.String\"/>\r\n      <Column Name=\"精子活力d\" DataType=\"Sy" +
        "stem.String\"/>\r\n      <Column Name=\"畸形率\" DataType=\"System.String\"/>\r\n      <Colu" +
        "mn Name=\"非精细胞\" DataType=\"System.String\"/>\r\n    </TableDataSource>\r\n    <TableDat" +
        "aSource Name=\"INFO\" ReferenceName=\"Data.INFO\" DataType=\"System.Int32\" Enabled=\"t";
      reportString += "rue\">\r\n      <Column Name=\"男方姓名\" DataType=\"System.String\"/>\r\n      <Column Name=" +
        "\"女方姓名\" DataType=\"System.String\"/>\r\n      <Column Name=\"病历编号\" DataType=\"System.St" +
        "ring\"/>\r\n      <Column Name=\"卵子来源\" DataType=\"System.String\"/>\r\n      <Column Nam" +
        "e=\"取卵日期\" DataType=\"System.String\"/>\r\n      <Column Name=\"精液保存\" DataType=\"System." +
        "String\"/>\r\n      <Column Name=\"供精者\" DataType=\"System.String\"/>\r\n      <Column Na" +
        "me=\"取精法\" DataType=\"System.String\"/>\r\n      <Column Name=\"取精/解冻日期\" DataType=\"Syst" +
        "em.String\"/>\r\n      <Column Name=\"精子法\" DataType=\"System.String\"/>\r\n      <Column" +
        " Name=\"精液处理时间\" DataType=\"System.String\"/>\r\n      <Column Name=\"精液处理表备注\" DataType" +
        "=\"System.String\"/>\r\n      <Column Name=\"授精时间\" DataType=\"System.String\"/>\r\n      " +
        "<Column Name=\"授精方式\" DataType=\"System.String\"/>\r\n      <Column Name=\"常规IVF培养箱号\" D" +
        "ataType=\"System.String\"/>\r\n      <Column Name=\"常规IVF存放点\" DataType=\"System.String" +
        "\"/>\r\n      <Column Name=\"常规授精方式\" DataType=\"System.String\"/>\r\n      <Column Name=";
      reportString += "\"ICSI时间\" DataType=\"System.String\"/>\r\n      <Column Name=\"ICSI培养箱号1\" DataType=\"Sy" +
        "stem.String\"/>\r\n      <Column Name=\"ICSI皿号1\" DataType=\"System.String\"/>\r\n      <" +
        "Column Name=\"ICSI培养箱号2\" DataType=\"System.String\"/>\r\n      <Column Name=\"ICSI皿号2\"" +
        " DataType=\"System.String\"/>\r\n      <Column Name=\"ICSI备注\" DataType=\"System.String" +
        "\"/>\r\n      <Column Name=\"ICSI存放点\" DataType=\"System.String\"/>\r\n      <Column Name" +
        "=\"精子活力24\" DataType=\"System.String\"/>\r\n      <Column Name=\"精子活力48\" DataType=\"Syst" +
        "em.String\"/>\r\n      <Column Name=\"精子活力72\" DataType=\"System.String\"/>\r\n    </Tabl" +
        "eDataSource>\r\n    <TableDataSource Name=\"SignatureOperatorIVF\" ReferenceName=\"Da" +
        "ta.SignatureOperatorIVF\" DataType=\"System.Int32\" Enabled=\"true\">\r\n      <Column " +
        "Name=\"SignatureOperatorIVF\" DataType=\"System.Byte[]\" BindableControl=\"Picture\"/>" +
        "\r\n    </TableDataSource>\r\n    <TableDataSource Name=\"SignatureCheckerIVF\" Refere" +
        "nceName=\"Data.SignatureCheckerIVF\" DataType=\"System.Int32\" Enabled=\"true\">\r\n    ";
      reportString += "  <Column Name=\"SignatureCheckerIVF\" DataType=\"System.Byte[]\" BindableControl=\"P" +
        "icture\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Name=\"SignatureOperatorI" +
        "CSI\" ReferenceName=\"Data.SignatureOperatorICSI\" DataType=\"System.Int32\" Enabled=" +
        "\"true\">\r\n      <Column Name=\"SignatureOperatorICSI\" DataType=\"System.Byte[]\" Bin" +
        "dableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Name=\"Sig" +
        "natureCheckerICSI\" ReferenceName=\"Data.SignatureCheckerICSI\" DataType=\"System.In" +
        "t32\" Enabled=\"true\">\r\n      <Column Name=\"SignatureCheckerICSI\" DataType=\"System" +
        ".Byte[]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataSour" +
        "ce Name=\"Oocytes\" ReferenceName=\"Data.Oocytes\" DataType=\"System.Int32\" Enabled=\"" +
        "true\">\r\n      <Column Name=\"皿号\" DataType=\"System.String\"/>\r\n      <Column Name=\"" +
        "卵子数量\" DataType=\"System.String\"/>\r\n      <Column Name=\"精子悬液量\" DataType=\"System.St" +
        "ring\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Name=\"ICSI1\" ReferenceName";
      reportString += "=\"Data.ICSI1\" DataType=\"System.Int32\" Enabled=\"true\">\r\n      <Column Name=\"卵号\" D" +
        "ataType=\"System.String\"/>\r\n      <Column Name=\"工作号\" DataType=\"System.String\"/>\r\n" +
        "      <Column Name=\"成熟\" DataType=\"System.String\"/>\r\n      <Column Name=\"经过\" Data" +
        "Type=\"System.String\"/>\r\n      <Column Name=\"授精情况\" DataType=\"System.String\"/>\r\n  " +
        "    <Column Name=\"特殊情况\" DataType=\"System.String\"/>\r\n    </TableDataSource>\r\n    " +
        "<TableDataSource Name=\"ICSI2\" ReferenceName=\"Data.ICSI2\" DataType=\"System.Int32\"" +
        " Enabled=\"true\">\r\n      <Column Name=\"卵号\" DataType=\"System.String\"/>\r\n      <Col" +
        "umn Name=\"工作号\" DataType=\"System.String\"/>\r\n      <Column Name=\"成熟\" DataType=\"Sys" +
        "tem.String\"/>\r\n      <Column Name=\"经过\" DataType=\"System.String\"/>\r\n      <Column" +
        " Name=\"授精情况\" DataType=\"System.String\"/>\r\n      <Column Name=\"特殊情况\" DataType=\"Sys" +
        "tem.String\"/>\r\n    </TableDataSource>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page" +
        "1\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=\"718.2\" Height=\"94.5\">\r\n    ";
      reportString += "  <TextObject Name=\"Text10\" Left=\"-9.45\" Width=\"699.3\" Height=\"47.25\" Text=\"华中科技" +
        "大学同济医学院附属荆州医院&#13;&#10;荆州市中心医院\" Format=\"Currency\" Format.UseLocale=\"true\" HorzAl" +
        "ign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 12pt\"/>\r\n      <TextObject Name=\"Text" +
        "11\" Left=\"340.2\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"[INFO.男方姓名]\" Font=\"" +
        "宋体, 9pt\"/>\r\n      <TextObject Name=\"Text12\" Left=\"94.5\" Top=\"56.7\" Width=\"94.5\" " +
        "Height=\"18.9\" Text=\"[INFO.女方姓名]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text1" +
        "3\" Left=\"9.45\" Top=\"56.7\" Width=\"75.6\" Height=\"18.9\" Text=\"妻子姓名：\" Font=\"宋体, 9pt\"" +
        "/>\r\n      <TextObject Name=\"Text14\" Left=\"255.15\" Top=\"56.7\" Width=\"75.6\" Height" +
        "=\"18.9\" Text=\"丈夫姓名：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text15\" Left=\"567" +
        "\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"[INFO.病历编号]\" Font=\"宋体, 9pt\"/>\r\n   " +
        "   <TextObject Name=\"Text16\" Left=\"481.95\" Top=\"56.7\" Width=\"75.6\" Height=\"18.9\"" +
        " Text=\"病历编号：&#13;&#10;\" Font=\"宋体, 9pt\"/>\r\n      <RichObject Name=\"Rich1\" Left=\"9";
      reportString += ".45\" Top=\"75.6\" Width=\"689.85\" Height=\"18.9\" Border.Lines=\"Top\"/>\r\n    </ReportT" +
        "itleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top=\"98.5\" Width=\"718.2\"/>\r\n  " +
        "  <DataBand Name=\"Data1\" Top=\"102.5\" Width=\"718.2\" Height=\"141.75\">\r\n      <Text" +
        "Object Name=\"Text1\" Left=\"9.45\" Top=\"47.25\" Width=\"179.55\" Height=\"18.9\" Text=\"卵" +
        "子来源：[INFO.卵子来源]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text3\" Left=\"321.3\" T" +
        "op=\"47.25\" Width=\"151.2\" Height=\"18.9\" Text=\"取卵日期：[INFO.取卵日期]\" Font=\"宋体, 9pt\"/>\r" +
        "\n      <TextObject Name=\"Text4\" Left=\"9.45\" Top=\"66.15\" Width=\"179.55\" Height=\"1" +
        "8.9\" Text=\"精液保存：[INFO.精液保存]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text5\" Le" +
        "ft=\"321.3\" Top=\"66.15\" Width=\"151.2\" Height=\"18.9\" Text=\"供精者：[INFO.供精者]\" Font=\"宋" +
        "体, 9pt\"/>\r\n      <TextObject Name=\"Text6\" Left=\"9.45\" Top=\"85.05\" Width=\"179.55\"" +
        " Height=\"18.9\" Text=\"取精法：[INFO.取精法]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"T" +
        "ext7\" Left=\"321.3\" Top=\"85.05\" Width=\"236.25\" Height=\"18.9\" Text=\"取精/解冻日期：[INFO.";
      reportString += "取精/解冻日期]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text8\" Left=\"9.45\" Top=\"103." +
        "95\" Width=\"179.55\" Height=\"18.9\" Text=\"精子法：[INFO.精子法]\" Font=\"宋体, 9pt\"/>\r\n      <" +
        "TextObject Name=\"Text17\" Left=\"217.35\" Width=\"283.5\" Height=\"28.35\" Text=\"IVF-ET" +
        "精液处理与受精记录\" Font=\"微软雅黑, 12pt, style=Bold\"/>\r\n      <ChildBand Name=\"Child1\" Top=\"" +
        "248.25\" Width=\"718.2\" Height=\"141.75\">\r\n        <TableObject Name=\"Table2\" Left=" +
        "\"9.45\" Top=\"47.25\" Width=\"623.7\" Height=\"76.6\">\r\n          <TableColumn Name=\"Co" +
        "lumn10\" Width=\"47.25\"/>\r\n          <TableColumn Name=\"Column11\" Width=\"56.7\"/>\r\n" +
        "          <TableColumn Name=\"Column12\" Width=\"47.25\"/>\r\n          <TableColumn N" +
        "ame=\"Column13\"/>\r\n          <TableColumn Name=\"Column20\" Width=\"85.05\"/>\r\n      " +
        "    <TableColumn Name=\"Column14\" Width=\"47.25\"/>\r\n          <TableColumn Name=\"C" +
        "olumn15\" Width=\"47.25\"/>\r\n          <TableColumn Name=\"Column16\" Width=\"47.25\"/>" +
        "\r\n          <TableColumn Name=\"Column17\" Width=\"47.25\"/>\r\n          <TableColumn";
      reportString += " Name=\"Column18\"/>\r\n          <TableColumn Name=\"Column19\"/>\r\n          <TableRo" +
        "w Name=\"Row4\" Height=\"19.9\">\r\n            <TableCell Name=\"Cell33\" Border.Lines=" +
        "\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=" +
        "\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/" +
        ">\r\n            <TableCell Name=\"Cell34\" Border.Lines=\"All\" Border.Color=\"LightGr" +
        "ay\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" T" +
        "ext=\"精液量\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <" +
        "TableCell Name=\"Cell35\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\"" +
        " Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"粘度\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"C" +
        "ell42\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tran" +
        "sparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"液化时间\" HorzAlign=\"Center\" Ver";
      reportString += "tAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell73\" Border.L" +
        "ines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.B" +
        "lend=\"0.47\" Fill.Hatch=\"false\" Text=\"精子密度\" HorzAlign=\"Center\" VertAlign=\"Bottom\"" +
        " Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell45\" Border.Lines=\"All\" Bord" +
        "er.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fil" +
        "l.Hatch=\"false\" Text=\"精子活力（%）\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, " +
        "9pt\" ColSpan=\"4\"/>\r\n            <TableCell Name=\"Cell48\" HorzAlign=\"Center\" Vert" +
        "Align=\"Center\" Font=\"宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell51\" Font=\"宋体, " +
        "9pt\"/>\r\n            <TableCell Name=\"Cell54\" Font=\"宋体, 9pt\"/>\r\n            <Tabl" +
        "eCell Name=\"Cell65\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fil" +
        "l.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"畸形率\" HorzAlign=" +
        "\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell";
      reportString += "69\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpa" +
        "rent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"非精细胞\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n          </TableRow>\r\n          <TableRow Name=" +
        "\"Row7\">\r\n            <TableCell Name=\"Cell57\" Border.Lines=\"All\" Border.Color=\"L" +
        "ightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"fa" +
        "lse\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <Table" +
        "Cell Name=\"Cell58\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill" +
        ".Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"(ml)\" HorzAlign=" +
        "\"Center\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell59\" Border.Lines=\"A" +
        "ll\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0" +
        ".47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n            <Table" +
        "Cell Name=\"Cell60\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill";
      reportString += ".Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"(min)\" HorzAlign" +
        "=\"Center\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell74\" Border.Lines=\"" +
        "All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"" +
        "0.47\" Fill.Hatch=\"false\" Text=\"（*10^6/ml）\" HorzAlign=\"Center\" VertAlign=\"Bottom\"" +
        " Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell61\" Border.Lines=\"All\" Bord" +
        "er.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fil" +
        "l.Hatch=\"false\" Text=\"a\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>" +
        "\r\n            <TableCell Name=\"Cell62\" Border.Lines=\"All\" Border.Color=\"LightGra" +
        "y\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Te" +
        "xt=\"b\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <Tab" +
        "leCell Name=\"Cell63\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fi" +
        "ll.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"c\" HorzAlign=\"";
      reportString += "Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell6" +
        "4\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpar" +
        "ent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"d\" HorzAlign=\"Center\" VertAlign=" +
        "\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell66\" Border.Lines=\"A" +
        "ll\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0" +
        ".47\" Fill.Hatch=\"false\" Text=\"（%）\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新" +
        "宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell70\" Border.Lines=\"All\" Border.Color" +
        "=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=" +
        "\"false\" Text=\"（*10^6）\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n" +
        "          </TableRow>\r\n          <TableRow Name=\"Row5\">\r\n            <TableCell " +
        "Name=\"Cell36\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Colo" +
        "r=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.处理时间]\" ";
      reportString += "HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell " +
        "Name=\"Cell37\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Colo" +
        "r=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.精液量]\" H" +
        "orzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell N" +
        "ame=\"Cell38\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color" +
        "=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.粘度]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Nam" +
        "e=\"Cell43\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"" +
        "Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.液化时间]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Nam" +
        "e=\"Cell75\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"" +
        "Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.精子密度]\" Hor";
      reportString += "zAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Nam" +
        "e=\"Cell46\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"" +
        "Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.精子活力a]\" Ho" +
        "rzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Na" +
        "me=\"Cell49\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=" +
        "\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.精子活力b]\" H" +
        "orzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell N" +
        "ame=\"Cell52\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color" +
        "=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.精子活力c]\" " +
        "HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell " +
        "Name=\"Cell55\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Colo" +
        "r=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.精子活力c]\"";
      reportString += " HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell" +
        " Name=\"Cell67\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Col" +
        "or=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.畸形率]\" " +
        "HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell " +
        "Name=\"Cell71\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Colo" +
        "r=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.非精细胞]\" " +
        "HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n          </TableRow>\r\n" +
        "          <TableRow Name=\"Row15\">\r\n            <TableCell Name=\"Cell127\" Border." +
        "Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill." +
        "Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体," +
        " 9pt\"/>\r\n            <TableCell Name=\"Cell128\" Border.Lines=\"All\" Border.Color=\"" +
        "LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"f";
      reportString += "alse\" Text=\"备注\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n       " +
        "     <TableCell Name=\"Cell129\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=" +
        "\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[INF" +
        "O.精液处理表备注]\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\" ColSpan=\"9\"/>\r\n            <Table" +
        "Cell Name=\"Cell130\" Font=\"宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell131\" Font" +
        "=\"宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell132\" Font=\"宋体, 9pt\"/>\r\n          " +
        "  <TableCell Name=\"Cell133\" Font=\"宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell1" +
        "34\" Font=\"宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell135\" Font=\"宋体, 9pt\"/>\r\n  " +
        "          <TableCell Name=\"Cell136\" Font=\"宋体, 9pt\"/>\r\n            <TableCell Nam" +
        "e=\"Cell137\" Font=\"宋体, 9pt\"/>\r\n          </TableRow>\r\n        </TableObject>\r\n   " +
        "     <TextObject Name=\"Text9\" Left=\"9.45\" Top=\"18.9\" Width=\"94.5\" Height=\"18.9\" " +
        "Text=\"精子处理记录\" Font=\"宋体, 9pt\"/>\r\n        <TextObject Name=\"Text18\" Left=\"340.2\" T";
      reportString += "op=\"18.9\" Width=\"217.35\" Height=\"18.9\" Text=\"精液处理时间：[INFO.精液处理时间]\" Font=\"宋体, 9pt" +
        "\"/>\r\n        <ChildBand Name=\"Child2\" Top=\"394\" Width=\"718.2\" Height=\"170.1\">\r\n " +
        "         <TableObject Name=\"Table1\" Left=\"9.45\" Top=\"75.6\" Width=\"170.1\" Height=" +
        "\"56.7\">\r\n            <TableColumn Name=\"Column21\" Width=\"103.95\"/>\r\n            " +
        "<TableColumn Name=\"Column22\"/>\r\n            <TableRow Name=\"Row8\">\r\n            " +
        "  <TableCell Name=\"Cell76\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Gla" +
        "ss\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"皿号\" Horz" +
        "Align=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n              <TableCell Na" +
        "me=\"Cell77\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=" +
        "\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[Oocytes.皿号]\" HorzAlign" +
        "=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            </TableRow>\r\n       " +
        "     <TableRow Name=\"Row9\">\r\n              <TableCell Name=\"Cell81\" Border.Lines";
      reportString += "=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend" +
        "=\"0.47\" Fill.Hatch=\"false\" Text=\"卵子数量\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Fon" +
        "t=\"新宋体, 9pt\"/>\r\n              <TableCell Name=\"Cell82\" Border.Lines=\"All\" Border" +
        ".Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill." +
        "Hatch=\"false\" Text=\"[Oocytes.卵子数量]\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"" +
        "新宋体, 9pt\"/>\r\n            </TableRow>\r\n            <TableRow Name=\"Row10\">\r\n     " +
        "         <TableCell Name=\"Cell86\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fi" +
        "ll=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"精" +
        "子悬液量\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n              <Ta" +
        "bleCell Name=\"Cell87\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" F" +
        "ill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[Oocytes.精子悬液" +
        "量]\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            </Table";
      reportString += "Row>\r\n          </TableObject>\r\n          <TextObject Name=\"Text20\" Left=\"292.95" +
        "\" Top=\"18.9\" Width=\"94.5\" Height=\"18.9\" Text=\"常规受精记录\" HorzAlign=\"Center\" Font=\"微" +
        "软雅黑, 12pt, style=Bold\"/>\r\n          <TextObject Name=\"Text21\" Left=\"9.45\" Top=\"5" +
        "6.7\" Width=\"170.1\" Height=\"18.9\" Text=\"授精时间：[INFO.授精时间]\" Font=\"宋体, 9pt\" HtmlTags" +
        "=\"true\"/>\r\n          <TextObject Name=\"Text23\" Left=\"264.6\" Top=\"56.7\" Width=\"19" +
        "8.45\" Height=\"18.9\" Text=\"授精方式：[INFO.常规授精方式]\" Font=\"宋体, 9pt\"/>\r\n          <TextO" +
        "bject Name=\"Text25\" Left=\"481.95\" Top=\"56.7\" Width=\"179.55\" Height=\"18.9\" Text=\"" +
        "培养箱号：[INFO.常规IVF培养箱号]\" Font=\"宋体, 9pt\"/>\r\n          <TextObject Name=\"Text27\" Lef" +
        "t=\"179.55\" Top=\"141.75\" Width=\"141.75\" Height=\"18.9\" Text=\"存放点：[INFO.常规IVF存放点]\" " +
        "Font=\"宋体, 9pt\"/>\r\n          <TextObject Name=\"Text55\" Left=\"529.2\" Top=\"141.75\" " +
        "Width=\"66.15\" Height=\"18.9\" Text=\"核对人：\" Font=\"宋体, 9pt\"/>\r\n          <PictureObje" +
        "ct Name=\"Picture3\" Left=\"595.35\" Top=\"141.75\" Width=\"75.6\" Height=\"18.9\" DataCol";
      reportString += "umn=\"SignatureCheckerIVF.SignatureCheckerIVF\"/>\r\n          <TextObject Name=\"Tex" +
        "t56\" Left=\"359.1\" Top=\"141.75\" Width=\"66.15\" Height=\"18.9\" Text=\"操作人：\" Font=\"宋体," +
        " 9pt\"/>\r\n          <PictureObject Name=\"Picture4\" Left=\"425.25\" Top=\"141.75\" Wid" +
        "th=\"75.6\" Height=\"18.9\" DataColumn=\"SignatureOperatorIVF.SignatureOperatorIVF\"/>" +
        "\r\n          <ChildBand Name=\"Child3\" Top=\"568.1\" Width=\"718.2\" Height=\"567\">\r\n  " +
        "          <TableObject Name=\"Table3\" Left=\"9.45\" Top=\"122.85\" Width=\"302.4\" Heig" +
        "ht=\"37.8\">\r\n              <TableColumn Name=\"Column23\" Width=\"37.8\"/>\r\n         " +
        "     <TableColumn Name=\"Column24\" Width=\"47.25\"/>\r\n              <TableColumn Na" +
        "me=\"Column25\" Width=\"47.25\"/>\r\n              <TableColumn Name=\"Column26\" Width=" +
        "\"37.8\"/>\r\n              <TableColumn Name=\"Column27\"/>\r\n              <TableColu" +
        "mn Name=\"Column28\"/>\r\n              <TableRow Name=\"Row11\">\r\n                <Ta" +
        "bleCell Name=\"Cell88\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" F";
      reportString += "ill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"卵号\" HorzAlign" +
        "=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=" +
        "\"Cell89\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tr" +
        "ansparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"工作号\" HorzAlign=\"Center\" Ve" +
        "rtAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell90\" Bor" +
        "der.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" F" +
        "ill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"成熟\" HorzAlign=\"Center\" VertAlign=\"Bott" +
        "om\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell91\" Border.Lines=\"Al" +
        "l\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0." +
        "47\" Fill.Hatch=\"false\" Text=\"经过\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体" +
        ", 9pt\"/>\r\n                <TableCell Name=\"Cell92\" Border.Lines=\"All\" Border.Col" +
        "or=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatc";
      reportString += "h=\"false\" Text=\"授精情况\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n " +
        "               <TableCell Name=\"Cell113\" Border.Lines=\"All\" Border.Color=\"LightG" +
        "ray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" " +
        "Text=\"特殊情况\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n           " +
        "   </TableRow>\r\n              <TableRow Name=\"Row12\">\r\n                <TableCel" +
        "l Name=\"Cell93\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Co" +
        "lor=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI1.卵号]\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Nam" +
        "e=\"Cell94\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"" +
        "Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI1.工作号]\" HorzAlign=\"" +
        "Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"C" +
        "ell95\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tran";
      reportString += "sparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI1.成熟]\" HorzAlign=\"Cente" +
        "r\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell96" +
        "\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpare" +
        "nt\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI1.经过]\" HorzAlign=\"Center\" Ve" +
        "rtAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell97\" Bor" +
        "der.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" F" +
        "ill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI1.授精情况]\" HorzAlign=\"Center\" VertA" +
        "lign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell114\" Borde" +
        "r.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fil" +
        "l.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI1.特殊情况]\" HorzAlign=\"Center\" VertAli" +
        "gn=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n              </TableRow>\r\n            </TableObj" +
        "ect>\r\n            <TableObject Name=\"Table4\" Left=\"340.2\" Top=\"122.85\" Width=\"30";
      reportString += "2.4\" Height=\"37.8\">\r\n              <TableColumn Name=\"Column29\" Width=\"37.8\"/>\r\n" +
        "              <TableColumn Name=\"Column30\" Width=\"47.25\"/>\r\n              <Table" +
        "Column Name=\"Column31\" Width=\"47.25\"/>\r\n              <TableColumn Name=\"Column3" +
        "2\" Width=\"37.8\"/>\r\n              <TableColumn Name=\"Column33\"/>\r\n              <" +
        "TableColumn Name=\"Column34\"/>\r\n              <TableRow Name=\"Row13\">\r\n          " +
        "      <TableCell Name=\"Cell115\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill" +
        "=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"卵号\"" +
        " HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <Table" +
        "Cell Name=\"Cell116\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fil" +
        "l.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"工作号\" HorzAlign=" +
        "\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"" +
        "Cell117\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tr";
      reportString += "ansparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"成熟\" HorzAlign=\"Center\" Ver" +
        "tAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell118\" Bor" +
        "der.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" F" +
        "ill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"经过\" HorzAlign=\"Center\" VertAlign=\"Bott" +
        "om\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell119\" Border.Lines=\"A" +
        "ll\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0" +
        ".47\" Fill.Hatch=\"false\" Text=\"授精情况\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"" +
        "新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell120\" Border.Lines=\"All\" Border" +
        ".Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill." +
        "Hatch=\"false\" Text=\"特殊情况\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/" +
        ">\r\n              </TableRow>\r\n              <TableRow Name=\"Row14\">\r\n           " +
        "     <TableCell Name=\"Cell121\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=";
      reportString += "\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICS" +
        "I2.卵号]\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n               " +
        " <TableCell Name=\"Cell122\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Gla" +
        "ss\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI2.工" +
        "作号]\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <T" +
        "ableCell Name=\"Cell123\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\"" +
        " Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI2.成熟]\"" +
        " HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <Table" +
        "Cell Name=\"Cell124\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fil" +
        "l.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI2.经过]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell" +
        " Name=\"Cell125\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Co";
      reportString += "lor=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI2.授精情况]\" HorzA" +
        "lign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell N" +
        "ame=\"Cell126\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Colo" +
        "r=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI2.特殊情况]\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n              </TableRow>\r\n   " +
        "         </TableObject>\r\n            <TextObject Name=\"Text34\" Left=\"292.95\" Top" +
        "=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"&lt;u&gt;ICSI情况&lt;/u&gt;\" HorzAlign=\"C" +
        "enter\" Font=\"微软雅黑, 12pt, style=Bold\" HtmlTags=\"true\"/>\r\n            <TextObject " +
        "Name=\"Text35\" Left=\"9.45\" Top=\"85.05\" Width=\"141.75\" Height=\"18.9\" Text=\"ICSI时间：" +
        "[INFO.ICSI时间]\" Font=\"宋体, 9pt\"/>\r\n            <TextObject Name=\"Text37\" Left=\"9.4" +
        "5\" Top=\"103.95\" Width=\"141.75\" Height=\"18.9\" Text=\"培养箱号：[INFO.ICSI培养箱号1]\" Font=\"" +
        "宋体, 9pt\"/>\r\n            <TextObject Name=\"Text39\" Left=\"151.2\" Top=\"103.95\" Widt";
      reportString += "h=\"160.65\" Height=\"18.9\" Text=\"皿号：[INFO.ICSI皿号1]\" HorzAlign=\"Center\" Font=\"宋体, 9" +
        "pt\"/>\r\n            <TextObject Name=\"Text41\" Left=\"340.2\" Top=\"103.95\" Width=\"16" +
        "0.65\" Height=\"18.9\" Text=\"培养箱号：[INFO.ICSI培养箱号2]\" Font=\"宋体, 9pt\"/>\r\n            <" +
        "TextObject Name=\"Text43\" Left=\"500.85\" Top=\"103.95\" Width=\"141.75\" Height=\"18.9\"" +
        " Text=\"皿号：[INFO.ICSI皿号2]\" Font=\"宋体, 9pt\"/>\r\n            <TextObject Name=\"Text45" +
        "\" Left=\"330.75\" Top=\"415.8\" Width=\"170.1\" Height=\"18.9\" Text=\"存放点：[INFO.ICSI存放点]" +
        "\" Font=\"宋体, 9pt\"/>\r\n            <TextObject Name=\"Text47\" Left=\"18.9\" Top=\"415.8" +
        "\" Width=\"226.8\" Height=\"37.8\" Text=\"备注：[INFO.ICSI备注]\" Font=\"宋体, 9pt\"/>\r\n        " +
        "    <TextObject Name=\"Text51\" Left=\"510.3\" Top=\"444.15\" Width=\"66.15\" Height=\"18" +
        ".9\" Text=\"核对人：\" Font=\"宋体, 9pt\"/>\r\n            <TextObject Name=\"Text53\" Left=\"9." +
        "45\" Top=\"519.75\" Width=\"434.7\" Height=\"18.9\" Text=\"精子活力24小时 &lt;u&gt;[INFO.精子活力2" +
        "4]&lt;/u&gt;%；48小时 &lt;u&gt;[INFO.精子活力48]&lt;/u&gt;%；72小时 &lt;u&gt;[INFO.精子活力72]";
      reportString += "&lt;/u&gt;%  \" Font=\"宋体, 9pt\" HtmlTags=\"true\"/>\r\n            <PictureObject Name" +
        "=\"Picture1\" Left=\"576.45\" Top=\"444.15\" Width=\"75.6\" Height=\"18.9\" DataColumn=\"Si" +
        "gnatureCheckerICSI.SignatureCheckerICSI\"/>\r\n            <TextObject Name=\"Text54" +
        "\" Left=\"330.75\" Top=\"444.15\" Width=\"66.15\" Height=\"18.9\" Text=\"操作人：\" Font=\"宋体, 9" +
        "pt\"/>\r\n            <PictureObject Name=\"Picture2\" Left=\"396.9\" Top=\"444.15\" Widt" +
        "h=\"75.6\" Height=\"18.9\" DataColumn=\"SignatureOperatorICSI.SignatureOperatorICSI\"/" +
        ">\r\n            <TextObject Name=\"Text2\" Left=\"189\" Top=\"491.4\" Width=\"283.5\" Hei" +
        "ght=\"18.9\" Text=\"实验体系精子存活观察（常规授精观察）\" Font=\"新宋体, 10pt\"/>\r\n          </ChildBand>\r" +
        "\n        </ChildBand>\r\n      </ChildBand>\r\n    </DataBand>\r\n    <PageFooterBand " +
        "Name=\"PageFooter1\" Top=\"1139.1\" Width=\"718.2\" Height=\"37.8\" Guides=\"47.25\"/>\r\n  " +
        "</ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      Table2.ManualBuild += Table2_ManualBuild;
      
    }

    public SpermProcessReport()
    {
      InitializeComponent();
    }

    private void Table1_ManualBuild(object sender, EventArgs e)
    {
      // get the data source by its name
      DataSourceBase rowData = Report.GetDataSource("Oocytes");
      // init the data source
      rowData.Init();
      
      // print the first table row - it is a header
      Table1.PrintColumn(0);
      // each PrintRow call must be followed by either PrintColumn or PrintColumns call
      // to print cells on the row
      Table1.PrintRows();

      
      // now enumerate the data source and print the table body
      while (rowData.HasMoreRows)
      {
        // print the table body  
        Table1.PrintColumn(1);
        Table1.PrintRows();
        
        // go next data source row
        rowData.Next();
      }
    }  
    
    private void Table2_ManualBuild(object sender, EventArgs e)
    {
      // get the data source by its name
      DataSourceBase rowData = Report.GetDataSource("SpermProcess");
      // init the data source
      rowData.Init();
      
      // print the first table row - it is a header
      Table2.PrintRow(0);
      // each PrintRow call must be followed by either PrintColumn or PrintColumns call
      // to print cells on the row
      Table2.PrintColumns();
      Table2.PrintRow(1);
      Table2.PrintColumns();
      
      // now enumerate the data source and print the table body
      while (rowData.HasMoreRows)
      {
        // print the table body  
        Table2.PrintRow(2);
        Table2.PrintColumns();
        
        // go next data source row
        rowData.Next();
      }
      Table2.PrintRow(3);
      Table2.PrintColumns();
    }
    
    
    private void Table3_ManualBuild(object sender, EventArgs e)
    {
      DataSourceBase rowData = Report.GetDataSource("ICSI1");
      rowData.Init();
      
      Table3.PrintRow(0);
      Table3.PrintColumns();

      while (rowData.HasMoreRows)
      {

        Table3.PrintRow(1);
        Table3.PrintColumns();

        rowData.Next();
      }
    }
    
    private void Table4_ManualBuild(object sender, EventArgs e)
    {
      DataSourceBase rowData = Report.GetDataSource("ICSI2");
      rowData.Init();
      
      Table4.PrintRow(0);
      Table4.PrintColumns();

      while (rowData.HasMoreRows)
      {

        Table4.PrintRow(1);
        Table4.PrintColumns();

        rowData.Next();
      }
    }
    
  }
}
