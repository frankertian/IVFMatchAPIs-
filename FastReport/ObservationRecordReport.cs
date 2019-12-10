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
  public class ObservationRecordReport : Report
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
    public FastReport.Table.TableCell Cell33;
    public FastReport.Table.TableCell Cell34;
    public FastReport.Table.TableCell Cell35;
    public FastReport.Table.TableCell Cell36;
    public FastReport.Table.TableCell Cell37;
    public FastReport.Table.TableCell Cell38;
    public FastReport.Table.TableCell Cell39;
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
    public FastReport.Table.TableCell Cell78;
    public FastReport.Table.TableCell Cell79;
    public FastReport.Table.TableCell Cell8;
    public FastReport.Table.TableCell Cell80;
    public FastReport.Table.TableCell Cell81;
    public FastReport.Table.TableCell Cell82;
    public FastReport.Table.TableCell Cell83;
    public FastReport.Table.TableCell Cell84;
    public FastReport.Table.TableCell Cell85;
    public FastReport.Table.TableCell Cell86;
    public FastReport.Table.TableCell Cell87;
    public FastReport.Table.TableCell Cell88;
    public FastReport.Table.TableCell Cell89;
    public FastReport.Table.TableColumn Column1;
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
    public FastReport.Table.TableColumn Column2;
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
    public FastReport.Table.TableColumn Column3;
    public FastReport.Table.TableColumn Column30;
    public FastReport.Table.TableColumn Column31;
    public FastReport.Table.TableColumn Column32;
    public FastReport.Table.TableColumn Column33;
    public FastReport.Table.TableColumn Column34;
    public FastReport.Table.TableColumn Column35;
    public FastReport.Table.TableColumn Column36;
    public FastReport.Table.TableColumn Column4;
    public FastReport.Table.TableColumn Column5;
    public FastReport.Table.TableColumn Column6;
    public FastReport.Table.TableColumn Column7;
    public FastReport.Table.TableColumn Column8;
    public FastReport.Table.TableColumn Column9;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.RichObject Rich1;
    public FastReport.Table.TableRow Row1;
    public FastReport.Table.TableRow Row2;
    public FastReport.Table.TableRow Row4;
    public FastReport.Table.TableObject Table1;
    public FastReport.Table.TableObject Table2;
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
        "﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Report ScriptLanguage=\"CSharp\" TextQua" +
        "lity=\"Regular\" ReportInfo.Description=\"Demonstrates how to print multiple Table " +
        "rows with a script. To do this:&#13;&#10;&#13;&#10;- select the Table object;&#1" +
        "3;&#10;&#13;&#10;- go to the &quot;Properties&quot; window and click the &quot;E" +
        "vents&quot; button to view list of available events;&#13;&#10;&#13;&#10;- double" +
        "click the &quot;ManualBuild&quot; event;&#13;&#10;&#13;&#10;- you will see the e" +
        "mpty event handler. You need to print rows using TableObject.PrintRow method; in" +
        " each row, you must also print all columns (using PrintColumns method). See the " +
        "script code for more details.&#13;&#10;&#13;&#10;When you run a report, the Tabl" +
        "e will repeat a row and fill it with data.\" ReportInfo.Created=\"01/17/2008 20:40" +
        ":24\" ReportInfo.Modified=\"11/29/2018 16:52:27\" ReportInfo.CreatorVersion=\"2013.2" +
        ".5.0\">\r\n  <Dictionary>\r\n    <TableDataSource Name=\"Observation\" ReferenceName=\"D" +
        "ata.Observation\" DataType=\"System.String\" Enabled=\"true\">\r\n      <Column Name=\"编" +
        "号\" DataType=\"System.String\"/>\r\n      <Column Name=\"受精备注\" DataType=\"System.String";
      reportString += "\"/>\r\n      <Column Name=\"D1PN\" DataType=\"System.String\"/>\r\n      <Column Name=\"D" +
        "1Z\" DataType=\"System.String\"/>\r\n      <Column Name=\"D1其他\" DataType=\"System.Strin" +
        "g\"/>\r\n      <Column Name=\"D2C\" DataType=\"System.String\"/>\r\n      <Column Name=\"D" +
        "2S\" DataType=\"System.String\"/>\r\n      <Column Name=\"D2F\" DataType=\"System.String" +
        "\"/>\r\n      <Column Name=\"D2G\" DataType=\"System.String\"/>\r\n      <Column Name=\"D3" +
        "C\" DataType=\"System.String\"/>\r\n      <Column Name=\"D3S\" DataType=\"System.String\"" +
        "/>\r\n      <Column Name=\"D3F\" DataType=\"System.String\"/>\r\n      <Column Name=\"D3G" +
        "\" DataType=\"System.String\"/>\r\n      <Column Name=\"D4C\" DataType=\"System.String\"/" +
        ">\r\n      <Column Name=\"D4F\" DataType=\"System.String\"/>\r\n      <Column Name=\"D4G\"" +
        " DataType=\"System.String\"/>\r\n      <Column Name=\"D5B\" DataType=\"System.String\"/>" +
        "\r\n      <Column Name=\"D5I\" DataType=\"System.String\"/>\r\n      <Column Name=\"D5T\" " +
        "DataType=\"System.String\"/>\r\n      <Column Name=\"D5其他\" DataType=\"System.String\"/>";
      reportString += "\r\n      <Column Name=\"处置\" DataType=\"System.String\"/>\r\n      <Column Name=\"处置其他\" " +
        "DataType=\"System.String\"/>\r\n      <Column Name=\"操作者\" DataType=\"System.String\"/>\r" +
        "\n      <Column Name=\"核对者\" DataType=\"System.String\"/>\r\n    </TableDataSource>\r\n  " +
        "  <TableDataSource Name=\"INFO\" ReferenceName=\"Data.INFO\" DataType=\"System.String" +
        "\" Enabled=\"true\">\r\n      <Column Name=\"男方姓名\" DataType=\"System.String\"/>\r\n      <" +
        "Column Name=\"女方姓名\" DataType=\"System.String\"/>\r\n      <Column Name=\"病历编号\" DataTyp" +
        "e=\"System.String\"/>\r\n      <Column Name=\"存放点\" DataType=\"System.String\"/>\r\n      " +
        "<Column Name=\"存放点操作者\" DataType=\"System.String\"/>\r\n      <Column Name=\"存放点核对者\" Da" +
        "taType=\"System.String\"/>\r\n    </TableDataSource>\r\n  </Dictionary>\r\n  <ReportPage" +
        " Name=\"Page1\" Landscape=\"true\" PaperWidth=\"297\" PaperHeight=\"210\" FirstPageSourc" +
        "e=\"256\" OtherPagesSource=\"256\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=" +
        "\"1047.06\" Height=\"737.1\">\r\n      <TextObject Name=\"Text2\" Left=\"9.45\" Top=\"28.35";
      reportString += "\" Width=\"982.8\" Height=\"47.25\" Text=\"华中科技大学同济医学院附属荆州医院&#13;&#10;荆州市中心医院\" Format=" +
        "\"Currency\" Format.UseLocale=\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新" +
        "宋体, 16pt\"/>\r\n      <TableObject Name=\"Table1\" Left=\"9.45\" Top=\"170.1\" Width=\"916" +
        ".65\" Height=\"37.8\">\r\n        <TableColumn Name=\"Column1\" Width=\"75.6\"/>\r\n       " +
        " <TableColumn Name=\"Column2\"/>\r\n        <TableColumn Name=\"Column3\" Width=\"37.8\"" +
        "/>\r\n        <TableColumn Name=\"Column4\" Width=\"37.8\"/>\r\n        <TableColumn Nam" +
        "e=\"Column5\" Width=\"37.8\"/>\r\n        <TableColumn Name=\"Column6\" Width=\"28.35\"/>\r" +
        "\n        <TableColumn Name=\"Column7\" Width=\"28.35\"/>\r\n        <TableColumn Name=" +
        "\"Column8\" Width=\"28.35\"/>\r\n        <TableColumn Name=\"Column9\" Width=\"28.35\"/>\r\n" +
        "        <TableColumn Name=\"Column10\" Width=\"28.35\"/>\r\n        <TableColumn Name=" +
        "\"Column11\" Width=\"28.35\"/>\r\n        <TableColumn Name=\"Column12\" Width=\"28.35\"/>" +
        "\r\n        <TableColumn Name=\"Column13\" Width=\"28.35\"/>\r\n        <TableColumn Nam";
      reportString += "e=\"Column14\" Width=\"28.35\"/>\r\n        <TableColumn Name=\"Column15\" Width=\"28.35\"" +
        "/>\r\n        <TableColumn Name=\"Column16\" Width=\"28.35\"/>\r\n        <TableColumn N" +
        "ame=\"Column17\" Width=\"28.35\"/>\r\n        <TableColumn Name=\"Column18\" Width=\"28.3" +
        "5\"/>\r\n        <TableColumn Name=\"Column19\" Width=\"28.35\"/>\r\n        <TableColumn" +
        " Name=\"Column20\" Width=\"47.25\"/>\r\n        <TableColumn Name=\"Column21\" Width=\"47" +
        ".25\"/>\r\n        <TableColumn Name=\"Column22\" Width=\"56.7\"/>\r\n        <TableColum" +
        "n Name=\"Column23\" Width=\"47.25\"/>\r\n        <TableColumn Name=\"Column24\"/>\r\n     " +
        "   <TableRow Name=\"Row1\">\r\n          <TableCell Name=\"Cell1\" Border.Lines=\"All\" " +
        "Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\"" +
        " Fill.Hatch=\"false\" Text=\"编号\" Padding=\"5, 0, 0, 0\" HorzAlign=\"Center\" VertAlign=" +
        "\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell2\" Border.Lines=\"All\"" +
        " Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47";
      reportString += "\" Fill.Hatch=\"false\" Text=\"受精备注\" Padding=\"0, 0, 5, 0\" HorzAlign=\"Center\" VertAli" +
        "gn=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell3\" Border.Lines=\"A" +
        "ll\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0" +
        ".47\" Fill.Hatch=\"false\" Text=\"PN\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋" +
        "体, 9pt\"/>\r\n          <TableCell Name=\"Cell17\" Border.Lines=\"All\" Border.Color=\"L" +
        "ightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"fa" +
        "lse\" Text=\"Z\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n         " +
        " <TableCell Name=\"Cell14\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glas" +
        "s\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"其他\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"C" +
        "ell20\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tran" +
        "sparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"C\" HorzAlign=\"Center\" VertAl";
      reportString += "ign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell23\" Border.Lines=" +
        "\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=" +
        "\"0.47\" Fill.Hatch=\"false\" Text=\"S\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新" +
        "宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell26\" Border.Lines=\"All\" Border.Color=\"" +
        "LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"f" +
        "alse\" Text=\"F\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n        " +
        "  <TableCell Name=\"Cell29\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Gla" +
        "ss\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"G\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"C" +
        "ell33\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tran" +
        "sparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"C\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell34\" Border.Lines=";
      reportString += "\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=" +
        "\"0.47\" Fill.Hatch=\"false\" Text=\"S\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新" +
        "宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell35\" Border.Lines=\"All\" Border.Color=\"" +
        "LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"f" +
        "alse\" Text=\"F\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n        " +
        "  <TableCell Name=\"Cell36\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Gla" +
        "ss\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"G\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"C" +
        "ell37\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tran" +
        "sparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"C\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell38\" Border.Lines=" +
        "\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=";
      reportString += "\"0.47\" Fill.Hatch=\"false\" Text=\"F\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新" +
        "宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell39\" Border.Lines=\"All\" Border.Color=\"" +
        "LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"f" +
        "alse\" Text=\"G\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n        " +
        "  <TableCell Name=\"Cell40\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Gla" +
        "ss\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"B\" HorzA" +
        "lign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"C" +
        "ell41\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tran" +
        "sparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"I\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell42\" Border.Lines=" +
        "\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=" +
        "\"0.47\" Fill.Hatch=\"false\" Text=\"T\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新";
      reportString += "宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell43\" Border.Lines=\"All\" Border.Color=\"" +
        "LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"f" +
        "alse\" Text=\"其他\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n       " +
        "   <TableCell Name=\"Cell44\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Gl" +
        "ass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"处置\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=" +
        "\"Cell45\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Tr" +
        "ansparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"其他\" HorzAlign=\"Center\" Ver" +
        "tAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell46\" Border.Lin" +
        "es=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Ble" +
        "nd=\"0.47\" Fill.Hatch=\"false\" Text=\"操作者\" HorzAlign=\"Center\" VertAlign=\"Center\" Fo" +
        "nt=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell47\" Border.Lines=\"All\" Border.Co";
      reportString += "lor=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hat" +
        "ch=\"false\" Text=\"核对者\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n " +
        "       </TableRow>\r\n        <TableRow Name=\"Row2\">\r\n          <TableCell Name=\"C" +
        "ell6\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.编号]\" Paddin" +
        "g=\"5, 0, 0, 0\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n     " +
        "     <TableCell Name=\"Cell32\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"" +
        "[Observation.受精备注]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n" +
        "          <TableCell Name=\"Cell8\" Border.Lines=\"All\" Border.Color=\"LightGray\" Te" +
        "xt=\"[Observation.D1PN]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"" +
        "/>\r\n          <TableCell Name=\"Cell18\" Border.Lines=\"All\" Border.Color=\"LightGra" +
        "y\" Text=\"[Observation.D1Z]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.2" +
        "5pt\"/>\r\n          <TableCell Name=\"Cell15\" Border.Lines=\"All\" Border.Color=\"Ligh";
      reportString += "tGray\" Text=\"[Observation.D1其他]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体" +
        ", 8.25pt\"/>\r\n          <TableCell Name=\"Cell21\" Border.Lines=\"All\" Border.Color=" +
        "\"LightGray\" Text=\"[Observation.D2C]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=" +
        "\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell24\" Border.Lines=\"All\" Border.Co" +
        "lor=\"LightGray\" Text=\"[Observation.D2S]\" HorzAlign=\"Center\" VertAlign=\"Center\" F" +
        "ont=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell27\" Border.Lines=\"All\" Borde" +
        "r.Color=\"LightGray\" Text=\"[Observation.D2F]\" HorzAlign=\"Center\" VertAlign=\"Cente" +
        "r\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell30\" Border.Lines=\"All\" B" +
        "order.Color=\"LightGray\" Text=\"[Observation.D2G]\" HorzAlign=\"Center\" VertAlign=\"C" +
        "enter\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell48\" Border.Lines=\"Al" +
        "l\" Border.Color=\"LightGray\" Text=\"[Observation.D3C]\" HorzAlign=\"Center\" VertAlig" +
        "n=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell49\" Border.Lines";
      reportString += "=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D3S]\" HorzAlign=\"Center\" Vert" +
        "Align=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell50\" Border.L" +
        "ines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D3F]\" HorzAlign=\"Center\" " +
        "VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell51\" Bord" +
        "er.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D3G]\" HorzAlign=\"Cent" +
        "er\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell52\" " +
        "Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D4C]\" HorzAlign=\"" +
        "Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"Cell" +
        "53\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D4F]\" HorzAli" +
        "gn=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Name=\"" +
        "Cell54\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D4G]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCell Na";
      reportString += "me=\"Cell55\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D5B]\"" +
        " HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <TableCel" +
        "l Name=\"Cell56\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observation.D" +
        "5I]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <Tabl" +
        "eCell Name=\"Cell57\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Observati" +
        "on.D5T]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n          <" +
        "TableCell Name=\"Cell58\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[Obser" +
        "vation.D5其他]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n      " +
        "    <TableCell Name=\"Cell59\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text=\"[" +
        "Observation.处置]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>\r\n   " +
        "       <TableCell Name=\"Cell60\" Border.Lines=\"All\" Border.Color=\"LightGray\" Text" +
        "=\"[Observation.处置其他]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25pt\"/>";
      reportString += "\r\n          <TableCell Name=\"Cell61\" Border.Lines=\"All\" Border.Color=\"LightGray\"" +
        " Text=\"[Observation.操作者]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8.25p" +
        "t\"/>\r\n          <TableCell Name=\"Cell62\" Border.Lines=\"All\" Border.Color=\"LightG" +
        "ray\" Text=\"[Observation.核对者]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 8" +
        ".25pt\"/>\r\n        </TableRow>\r\n      </TableObject>\r\n      <RichObject Name=\"Ric" +
        "h1\" Left=\"9.45\" Top=\"122.85\" Width=\"973.35\" Height=\"18.9\" Border.Lines=\"Top\"/>\r\n" +
        "      <TextObject Name=\"Text3\" Left=\"340.2\" Top=\"103.95\" Width=\"94.5\" Height=\"18" +
        ".9\" Text=\"[INFO.男方姓名]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text4\" Left=\"10" +
        "3.95\" Top=\"103.95\" Width=\"94.5\" Height=\"18.9\" Text=\"[INFO.女方姓名]\" Font=\"宋体, 9pt\"/" +
        ">\r\n      <TextObject Name=\"Text5\" Left=\"9.45\" Top=\"103.95\" Width=\"75.6\" Height=\"" +
        "18.9\" Text=\"妻子姓名：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text6\" Left=\"255.15" +
        "\" Top=\"103.95\" Width=\"75.6\" Height=\"18.9\" Text=\"丈夫姓名：\" Font=\"宋体, 9pt\"/>\r\n      <";
      reportString += "TextObject Name=\"Text7\" Left=\"567\" Top=\"103.95\" Width=\"94.5\" Height=\"18.9\" Text=" +
        "\"[INFO.病历编号]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text8\" Left=\"481.95\" Top" +
        "=\"103.95\" Width=\"75.6\" Height=\"18.9\" Text=\"病历编号：&#13;&#10;\" Font=\"宋体, 9pt\"/>\r\n  " +
        "    <TableObject Name=\"Table2\" Left=\"9.45\" Top=\"151.2\" Width=\"982.8\" Height=\"18." +
        "9\">\r\n        <TableColumn Name=\"Column25\" Width=\"75.6\"/>\r\n        <TableColumn N" +
        "ame=\"Column26\"/>\r\n        <TableColumn Name=\"Column27\" Width=\"75.6\"/>\r\n        <" +
        "TableColumn Name=\"Column28\" Width=\"37.79\"/>\r\n        <TableColumn Name=\"Column29" +
        "\" Width=\"113.4\"/>\r\n        <TableColumn Name=\"Column30\" Width=\"113.4\"/>\r\n       " +
        " <TableColumn Name=\"Column31\" Width=\"85.06\"/>\r\n        <TableColumn Name=\"Column" +
        "32\" Width=\"85.06\"/>\r\n        <TableColumn Name=\"Column33\" Width=\"47.24\"/>\r\n     " +
        "   <TableColumn Name=\"Column34\" Width=\"103.95\"/>\r\n        <TableColumn Name=\"Col" +
        "umn35\" Width=\"113.4\"/>\r\n        <TableColumn Name=\"Column36\"/>\r\n        <TableRo";
      reportString += "w Name=\"Row4\">\r\n          <TableCell Name=\"Cell78\" Border.Lines=\"All\" Border.Col" +
        "or=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatc" +
        "h=\"false\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <Ta" +
        "bleCell Name=\"Cell79\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" F" +
        "ill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" " +
        "VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell80\" Border." +
        "Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill." +
        "Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"D1\" HorzAlign=\"Center\" VertAlign=\"Center\" " +
        "Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell81\" Border.Lines=\"All\" Border." +
        "Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.H" +
        "atch=\"false\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          " +
        "<TableCell Name=\"Cell82\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass";
      reportString += "\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"D2\" HorzAl" +
        "ign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Ce" +
        "ll84\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Trans" +
        "parent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" Text=\"D3\" HorzAlign=\"Center\" VertAl" +
        "ign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell83\" Border.Lines=" +
        "\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=" +
        "\"0.47\" Fill.Hatch=\"false\" Text=\"D4\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"" +
        "新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell85\" Border.Lines=\"All\" Border.Color=" +
        "\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"" +
        "false\" Text=\"D5\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n      " +
        "    <TableCell Name=\"Cell86\" Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"G" +
        "lass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"C";
      reportString += "enter\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell87\" " +
        "Border.Lines=\"All\" Border.Color=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent" +
        "\" Fill.Blend=\"0.47\" Fill.Hatch=\"false\" HorzAlign=\"Center\" VertAlign=\"Center\" Fon" +
        "t=\"新宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell88\" Border.Lines=\"All\" Border.Col" +
        "or=\"LightGray\" Fill=\"Glass\" Fill.Color=\"Transparent\" Fill.Blend=\"0.47\" Fill.Hatc" +
        "h=\"false\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 9pt\"/>\r\n          <Ta" +
        "bleCell Name=\"Cell89\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n      </TableObject" +
        ">\r\n      <TextObject Name=\"Text1\" Left=\"9.45\" Top=\"680.4\" Width=\"321.3\" Height=\"" +
        "56.7\" Text=\"存放点：[INFO.存放点]  操作者：[INFO.存放点操作者]     核对者：[INFO.存放点核对者]&#13;&#10;&#1" +
        "3;&#10;备注：取卵日为D0天，观察原核为D1天\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n      <TextObje" +
        "ct Name=\"Text9\" Left=\"604.8\" Top=\"680.4\" Width=\"283.5\" Height=\"56.7\" Text=\"PN：原核" +
        "  Z：受精卵评分  C：细胞数  S：细胞大小均一成都  F：细胞碎片  G：胚胎分级V B：囊胚腔大小  T：滋养外胚层\" VertAlign=\"Cente";
      reportString += "r\" Font=\"宋体, 9pt\"/>\r\n    </ReportTitleBand>\r\n    <PageFooterBand Name=\"PageFoote" +
        "r1\" Top=\"741.1\" Width=\"1047.06\" Height=\"18.9\"/>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      Table1.ManualBuild += Table1_ManualBuild;
      
    }

    public ObservationRecordReport()
    {
      InitializeComponent();
    }

    private void Table1_ManualBuild(object sender, EventArgs e)
    {
      // get the data source by its name
      DataSourceBase rowData = Report.GetDataSource("Observation");
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
