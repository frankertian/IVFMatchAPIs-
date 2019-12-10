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
  public class SimpleReport : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.Table.TableCell Cell113;
    public FastReport.Table.TableCell Cell114;
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
    public FastReport.DataBand Data1;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.Table.TableRow Row10;
    public FastReport.Table.TableRow Row11;
    public FastReport.Table.TableRow Row12;
    public FastReport.Table.TableRow Row4;
    public FastReport.Table.TableRow Row5;
    public FastReport.Table.TableRow Row7;
    public FastReport.Table.TableRow Row8;
    public FastReport.Table.TableRow Row9;
    public FastReport.Table.TableObject Table1;
    public FastReport.Table.TableObject Table2;
    public FastReport.Table.TableObject Table3;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text5;
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
        "nfo.Created=\"11/17/2018 18:21:44\" ReportInfo.Modified=\"11/27/2018 12:25:45\" Repo" +
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
        "em.String\"/>\r\n      <Column Name=\"精子法\" DataType=\"System.String\"/>\r\n    </TableDa" +
        "taSource>\r\n    <TableDataSource Name=\"Oocytes\" ReferenceName=\"Data.Oocytes\" Data" +
        "Type=\"System.Int32\" Enabled=\"true\">\r\n      <Column Name=\"皿号\" DataType=\"System.St" +
        "ring\"/>\r\n      <Column Name=\"卵子数量\" DataType=\"System.String\"/>\r\n      <Column Nam" +
        "e=\"精子悬液量\" DataType=\"System.String\"/>\r\n    </TableDataSource>\r\n    <TableDataSour" +
        "ce Name=\"ICSI\" ReferenceName=\"Data.ICSI\" DataType=\"System.Int32\" Enabled=\"true\">";
      reportString += "\r\n      <Column Name=\"卵号\" DataType=\"System.String\"/>\r\n      <Column Name=\"工作号\" D" +
        "ataType=\"System.String\"/>\r\n      <Column Name=\"成熟\" DataType=\"System.String\"/>\r\n " +
        "     <Column Name=\"经过\" DataType=\"System.String\"/>\r\n      <Column Name=\"授精情况\" Dat" +
        "aType=\"System.String\"/>\r\n      <Column Name=\"特殊情况\" DataType=\"System.String\"/>\r\n " +
        "   </TableDataSource>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page1\">\r\n    <Report" +
        "TitleBand Name=\"ReportTitle1\" Width=\"718.2\" Height=\"37.8\"/>\r\n    <PageHeaderBand" +
        " Name=\"PageHeader1\" Top=\"41.8\" Width=\"718.2\" Height=\"28.35\"/>\r\n    <DataBand Nam" +
        "e=\"Data1\" Top=\"74.15\" Width=\"718.2\" Height=\"94.5\">\r\n      <TextObject Name=\"Text" +
        "1\" Left=\"9.45\" Top=\"9.45\" Width=\"75.6\" Height=\"18.9\" Text=\"卵子来源：\" Font=\"宋体, 9pt\"" +
        "/>\r\n      <TextObject Name=\"Text2\" Left=\"85.05\" Top=\"9.45\" Width=\"94.5\" Height=\"" +
        "18.9\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text3\" Left=\"321.3\" Top=\"9.45\" W" +
        "idth=\"94.5\" Height=\"18.9\" Text=\"取卵日期：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=";
      reportString += "\"Text4\" Left=\"9.45\" Top=\"28.35\" Width=\"94.5\" Height=\"18.9\" Text=\"精液保存\" Font=\"宋体," +
        " 9pt\"/>\r\n      <TextObject Name=\"Text5\" Left=\"321.3\" Top=\"28.35\" Width=\"94.5\" He" +
        "ight=\"18.9\" Text=\"供精者：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text6\" Left=\"9" +
        ".45\" Top=\"47.25\" Width=\"94.5\" Height=\"18.9\" Text=\"取精法\" Font=\"宋体, 9pt\"/>\r\n      <" +
        "TextObject Name=\"Text7\" Left=\"321.3\" Top=\"47.25\" Width=\"113.4\" Height=\"18.9\" Tex" +
        "t=\"取精/解冻日期：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text8\" Left=\"9.45\" Top=\"6" +
        "6.15\" Width=\"94.5\" Height=\"18.9\" Text=\"精子法：\" Font=\"宋体, 9pt\"/>\r\n      <ChildBand " +
        "Name=\"Child1\" Top=\"172.65\" Width=\"718.2\" Height=\"198.45\">\r\n        <TableObject " +
        "Name=\"Table2\" Left=\"9.45\" Top=\"56.7\" Width=\"623.7\" Height=\"57.7\">\r\n          <Ta" +
        "bleColumn Name=\"Column10\" Width=\"47.25\"/>\r\n          <TableColumn Name=\"Column11" +
        "\" Width=\"56.7\"/>\r\n          <TableColumn Name=\"Column12\" Width=\"47.25\"/>\r\n      " +
        "    <TableColumn Name=\"Column13\"/>\r\n          <TableColumn Name=\"Column20\" Width";
      reportString += "=\"85.05\"/>\r\n          <TableColumn Name=\"Column14\" Width=\"47.25\"/>\r\n          <T" +
        "ableColumn Name=\"Column15\" Width=\"47.25\"/>\r\n          <TableColumn Name=\"Column1" +
        "6\" Width=\"47.25\"/>\r\n          <TableColumn Name=\"Column17\" Width=\"47.25\"/>\r\n    " +
        "      <TableColumn Name=\"Column18\"/>\r\n          <TableColumn Name=\"Column19\"/>\r\n" +
        "          <TableRow Name=\"Row4\" Height=\"19.9\">\r\n            <TableCell Name=\"Cel" +
        "l33\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transp" +
        "arent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom" +
        "\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell34\" Border.Lines=\"All\" Bor" +
        "der.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fi" +
        "ll.Hatch=\"false\" Text=\"精液量\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt" +
        "\"/>\r\n            <TableCell Name=\"Cell35\" Border.Lines=\"All\" Border.Color=\"Light" +
        "Gray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\"";
      reportString += " Text=\"粘度\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            " +
        "<TableCell Name=\"Cell42\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass" +
        "\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"液化时间\" Horz" +
        "Align=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name" +
        "=\"Cell73\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"T" +
        "ransparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"精子密度\" HorzAlign=\"Center\" " +
        "VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell45\" Borde" +
        "r.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fil" +
        "l.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"精子活力（%）\" HorzAlign=\"Center\" VertAlign=\"B" +
        "ottom\" Font=\"新宋体, 9pt\" ColSpan=\"4\"/>\r\n            <TableCell Name=\"Cell48\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n            <TableCell Name=\"" +
        "Cell51\" Font=\"宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell54\" Font=\"宋体, 9pt\"/>\r";
      reportString += "\n            <TableCell Name=\"Cell65\" Border.Lines=\"All\" Border.Color=\"LightGray" +
        "\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Tex" +
        "t=\"畸形率\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <Ta" +
        "bleCell Name=\"Cell69\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" F" +
        "ill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"非精细胞\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n          </TableRow>\r\n       " +
        "   <TableRow Name=\"Row7\">\r\n            <TableCell Name=\"Cell57\" Border.Lines=\"Al" +
        "l\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0." +
        "47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n" +
        "            <TableCell Name=\"Cell58\" Border.Lines=\"All\" Border.Color=\"LightGray\"" +
        " Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text" +
        "=\"(ml)\" HorzAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell5";
      reportString += "9\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpar" +
        "ent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n" +
        "            <TableCell Name=\"Cell60\" Border.Lines=\"All\" Border.Color=\"LightGray\"" +
        " Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text" +
        "=\"(min)\" HorzAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell" +
        "74\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpa" +
        "rent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"（*10^6/ml）\" HorzAlign=\"Center\" " +
        "VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell61\" Borde" +
        "r.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fil" +
        "l.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"a\" HorzAlign=\"Center\" VertAlign=\"Bottom\"" +
        " Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell62\" Border.Lines=\"All\" Bord" +
        "er.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fil";
      reportString += "l.Hatch=\"false\" Text=\"b\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>" +
        "\r\n            <TableCell Name=\"Cell63\" Border.Lines=\"All\" Border.Color=\"LightGra" +
        "y\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Te" +
        "xt=\"c\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <Tab" +
        "leCell Name=\"Cell64\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fi" +
        "ll.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"d\" HorzAlign=\"" +
        "Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell6" +
        "6\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpar" +
        "ent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"（%）\" HorzAlign=\"Center\" VertAlig" +
        "n=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell70\" Border.Lines=" +
        "\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=" +
        "\"0.47\" Fill.Hatch=\"false\" Text=\"（*10^6）\" HorzAlign=\"Center\" VertAlign=\"Bottom\" F";
      reportString += "ont=\"新宋体, 9pt\"/>\r\n          </TableRow>\r\n          <TableRow Name=\"Row5\">\r\n     " +
        "       <TableCell Name=\"Cell36\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill" +
        "=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign" +
        "=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cel" +
        "l37\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transp" +
        "arent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[SpermProcess.精液量]\" HorzAlign=" +
        "\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell" +
        "38\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpa" +
        "rent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\"" +
        " Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell43\" Border.Lines=\"All\" Bord" +
        "er.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fil" +
        "l.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n       ";
      reportString += "     <TableCell Name=\"Cell75\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"" +
        "Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"" +
        "Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell4" +
        "6\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpar" +
        "ent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" " +
        "Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell49\" Border.Lines=\"All\" Borde" +
        "r.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill" +
        ".Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n        " +
        "    <TableCell Name=\"Cell52\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"G" +
        "lass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"C" +
        "enter\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell55" +
        "\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transpare";
      reportString += "nt\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" F" +
        "ont=\"新宋体, 9pt\"/>\r\n            <TableCell Name=\"Cell67\" Border.Lines=\"All\" Border" +
        ".Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill." +
        "Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n         " +
        "   <TableCell Name=\"Cell71\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Gl" +
        "ass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Ce" +
        "nter\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n          </TableRow>\r\n        </Tab" +
        "leObject>\r\n        <TextObject Name=\"Text9\" Left=\"9.45\" Top=\"18.9\" Width=\"94.5\" " +
        "Height=\"18.9\" Text=\"精子处理记录\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        <ChildB" +
        "and Name=\"Child2\" Top=\"375.1\" Width=\"718.2\" Height=\"122.85\">\r\n          <TableOb" +
        "ject Name=\"Table1\" Left=\"9.45\" Top=\"56.7\" Width=\"170.1\" Height=\"56.7\">\r\n        " +
        "    <TableColumn Name=\"Column21\" Width=\"103.95\"/>\r\n            <TableColumn Name";
      reportString += "=\"Column22\"/>\r\n            <TableRow Name=\"Row8\">\r\n              <TableCell Name" +
        "=\"Cell76\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"T" +
        "ransparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"皿号\" HorzAlign=\"Center\" Ve" +
        "rtAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n              <TableCell Name=\"Cell77\" Borde" +
        "r.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fil" +
        "l.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[Oocytes.皿号]\" HorzAlign=\"Center\" VertAli" +
        "gn=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            </TableRow>\r\n            <TableRow Na" +
        "me=\"Row9\">\r\n              <TableCell Name=\"Cell81\" Border.Lines=\"All\" Border.Col" +
        "or=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatc" +
        "h=\"false\" Text=\"卵子数量\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n " +
        "             <TableCell Name=\"Cell82\" Border.Lines=\"All\" Border.Color=\"LightGray" +
        "\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Tex";
      reportString += "t=\"[Oocytes.卵子数量]\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n    " +
        "        </TableRow>\r\n            <TableRow Name=\"Row10\">\r\n              <TableCe" +
        "ll Name=\"Cell86\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.C" +
        "olor=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"精子悬液量\" HorzAlign=\"" +
        "Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n              <TableCell Name=\"Cel" +
        "l87\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transp" +
        "arent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[Oocytes.精子悬液量]\" HorzAlign=\"Ce" +
        "nter\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n            </TableRow>\r\n          <" +
        "/TableObject>\r\n          <ChildBand Name=\"Child3\" Top=\"501.95\" Width=\"718.2\" Hei" +
        "ght=\"141.75\">\r\n            <TableObject Name=\"Table3\" Left=\"9.45\" Top=\"9.45\" Wid" +
        "th=\"302.4\" Height=\"37.8\">\r\n              <TableColumn Name=\"Column23\" Width=\"37." +
        "8\"/>\r\n              <TableColumn Name=\"Column24\" Width=\"47.25\"/>\r\n              ";
      reportString += "<TableColumn Name=\"Column25\" Width=\"47.25\"/>\r\n              <TableColumn Name=\"C" +
        "olumn26\" Width=\"37.8\"/>\r\n              <TableColumn Name=\"Column27\"/>\r\n         " +
        "     <TableColumn Name=\"Column28\"/>\r\n              <TableRow Name=\"Row11\">\r\n    " +
        "            <TableCell Name=\"Cell88\" Border.Lines=\"All\" Border.Color=\"LightGray\"" +
        " Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text" +
        "=\"卵号\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <" +
        "TableCell Name=\"Cell89\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\"" +
        " Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"工作号\" HorzAl" +
        "ign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Na" +
        "me=\"Cell90\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=" +
        "\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"成熟\" HorzAlign=\"Center\" " +
        "VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell91\" B";
      reportString += "order.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\"" +
        " Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"经过\" HorzAlign=\"Center\" VertAlign=\"Bo" +
        "ttom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell92\" Border.Lines=\"" +
        "All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"" +
        "0.47\" Fill.Hatch=\"false\" Text=\"授精情况\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=" +
        "\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell113\" Border.Lines=\"All\" Borde" +
        "r.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill" +
        ".Hatch=\"false\" Text=\"特殊情况\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"" +
        "/>\r\n              </TableRow>\r\n              <TableRow Name=\"Row12\">\r\n          " +
        "      <TableCell Name=\"Cell93\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=" +
        "\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICS" +
        "I.卵号]\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                ";
      reportString += "<TableCell Name=\"Cell94\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass" +
        "\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI.工作号]" +
        "\" HorzAlign=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <Tabl" +
        "eCell Name=\"Cell95\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fil" +
        "l.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI.成熟]\" Horz" +
        "Align=\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell " +
        "Name=\"Cell96\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Colo" +
        "r=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI.经过]\" HorzAlign=" +
        "\"Center\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"" +
        "Cell97\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tra" +
        "nsparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI.授精情况]\" HorzAlign=\"Cen" +
        "ter\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n                <TableCell Name=\"Cell";
      reportString += "114\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transp" +
        "arent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"[ICSI.特殊情况]\" HorzAlign=\"Center" +
        "\" VertAlign=\"Bottom\" Font=\"新宋体, 9pt\"/>\r\n              </TableRow>\r\n            <" +
        "/TableObject>\r\n          </ChildBand>\r\n        </ChildBand>\r\n      </ChildBand>\r" +
        "\n    </DataBand>\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"647.7\" Width=\"718." +
        "2\" Height=\"396.9\" Guides=\"47.25\"/>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      Table1.ManualBuild += Table1_ManualBuild;
      Table2.ManualBuild += Table2_ManualBuild;
      Table3.ManualBuild += Table3_ManualBuild;
        }

    public SimpleReport()
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
      
      
    }
    
    
    private void Table3_ManualBuild(object sender, EventArgs e)
    {
      DataSourceBase rowData = Report.GetDataSource("ICSI");
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
  }
}
