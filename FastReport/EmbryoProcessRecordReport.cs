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
  public class EmbryoProcessRecordReport : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.Table.TableCell Cell100;
    public FastReport.Table.TableCell Cell101;
    public FastReport.Table.TableCell Cell103;
    public FastReport.Table.TableCell Cell106;
    public FastReport.Table.TableCell Cell108;
    public FastReport.Table.TableCell Cell111;
    public FastReport.Table.TableCell Cell113;
    public FastReport.Table.TableCell Cell116;
    public FastReport.Table.TableCell Cell118;
    public FastReport.Table.TableCell Cell121;
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
    public FastReport.Table.TableCell Cell138;
    public FastReport.Table.TableCell Cell139;
    public FastReport.Table.TableCell Cell140;
    public FastReport.Table.TableCell Cell141;
    public FastReport.Table.TableCell Cell142;
    public FastReport.Table.TableCell Cell143;
    public FastReport.Table.TableCell Cell144;
    public FastReport.Table.TableCell Cell145;
    public FastReport.Table.TableCell Cell146;
    public FastReport.Table.TableCell Cell147;
    public FastReport.Table.TableCell Cell148;
    public FastReport.Table.TableCell Cell149;
    public FastReport.Table.TableCell Cell150;
    public FastReport.Table.TableCell Cell34;
    public FastReport.Table.TableCell Cell35;
    public FastReport.Table.TableCell Cell36;
    public FastReport.Table.TableCell Cell37;
    public FastReport.Table.TableCell Cell39;
    public FastReport.Table.TableCell Cell40;
    public FastReport.Table.TableCell Cell41;
    public FastReport.Table.TableCell Cell42;
    public FastReport.Table.TableCell Cell44;
    public FastReport.Table.TableCell Cell45;
    public FastReport.Table.TableCell Cell46;
    public FastReport.Table.TableCell Cell47;
    public FastReport.Table.TableCell Cell49;
    public FastReport.Table.TableCell Cell50;
    public FastReport.Table.TableCell Cell51;
    public FastReport.Table.TableCell Cell52;
    public FastReport.Table.TableCell Cell54;
    public FastReport.Table.TableCell Cell55;
    public FastReport.Table.TableCell Cell56;
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
    public FastReport.Table.TableCell Cell68;
    public FastReport.Table.TableCell Cell69;
    public FastReport.Table.TableCell Cell70;
    public FastReport.Table.TableCell Cell71;
    public FastReport.Table.TableCell Cell72;
    public FastReport.Table.TableCell Cell73;
    public FastReport.Table.TableCell Cell74;
    public FastReport.Table.TableCell Cell75;
    public FastReport.Table.TableCell Cell76;
    public FastReport.Table.TableCell Cell77;
    public FastReport.Table.TableCell Cell78;
    public FastReport.Table.TableCell Cell79;
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
    public FastReport.Table.TableCell Cell90;
    public FastReport.Table.TableCell Cell91;
    public FastReport.Table.TableCell Cell92;
    public FastReport.Table.TableCell Cell93;
    public FastReport.Table.TableCell Cell94;
    public FastReport.Table.TableCell Cell95;
    public FastReport.Table.TableCell Cell96;
    public FastReport.Table.TableCell Cell97;
    public FastReport.Table.TableCell Cell98;
    public FastReport.Table.TableCell Cell99;
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
    public FastReport.Table.TableColumn Column24;
    public FastReport.Table.TableColumn Column25;
    public FastReport.Table.TableColumn Column26;
    public FastReport.Table.TableColumn Column27;
    public FastReport.DataBand Data1;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.PictureObject Picture1;
    public FastReport.PictureObject Picture2;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.RichObject Rich1;
    public FastReport.Table.TableRow Row10;
    public FastReport.Table.TableRow Row11;
    public FastReport.Table.TableRow Row12;
    public FastReport.Table.TableRow Row13;
    public FastReport.Table.TableRow Row14;
    public FastReport.Table.TableRow Row15;
    public FastReport.Table.TableRow Row16;
    public FastReport.Table.TableRow Row17;
    public FastReport.Table.TableRow Row18;
    public FastReport.Table.TableRow Row19;
    public FastReport.Table.TableRow Row20;
    public FastReport.Table.TableRow Row21;
    public FastReport.Table.TableRow Row22;
    public FastReport.Table.TableRow Row23;
    public FastReport.Table.TableRow Row24;
    public FastReport.Table.TableRow Row25;
    public FastReport.Table.TableRow Row26;
    public FastReport.Table.TableRow Row27;
    public FastReport.Table.TableRow Row28;
    public FastReport.Table.TableRow Row3;
    public FastReport.Table.TableRow Row4;
    public FastReport.Table.TableRow Row5;
    public FastReport.Table.TableRow Row6;
    public FastReport.Table.TableRow Row7;
    public FastReport.Table.TableRow Row8;
    public FastReport.Table.TableRow Row9;
    public FastReport.Table.TableObject Table1;
    public FastReport.Table.TableObject Table2;
    public FastReport.Table.TableObject Table3;
    public FastReport.Table.TableObject Table4;
    public FastReport.Table.TableObject Table5;
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
    public FastReport.TextObject Text19;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text20;
    public FastReport.TextObject Text3;
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
        "nfo.Created=\"11/29/2018 13:38:01\" ReportInfo.Modified=\"01/15/2019 14:44:07\" Repo" +
        "rtInfo.CreatorVersion=\"2013.2.5.0\">\r\n  <Dictionary>\r\n    <TableDataSource Name=\"" +
        "INFO\" ReferenceName=\"Data.INFO\" DataType=\"System.Int32\" Enabled=\"true\">\r\n      <" +
        "Column Name=\"男方姓名\" DataType=\"System.String\"/>\r\n      <Column Name=\"女方姓名\" DataTyp" +
        "e=\"System.String\"/>\r\n      <Column Name=\"病历编号\" DataType=\"System.String\"/>\r\n     " +
        " <Column Name=\"日期\" DataType=\"System.String\"/>\r\n      <Column Name=\"ET后检查\" DataTy" +
        "pe=\"System.String\"/>\r\n      <Column Name=\"遗弃数\" DataType=\"System.String\"/>\r\n     " +
        " <Column Name=\"科研用数\" DataType=\"System.String\"/>\r\n      <Column Name=\"遗失数\" DataTy" +
        "pe=\"System.String\"/>\r\n      <Column Name=\"移植胚胎1\" DataType=\"System.String\"/>\r\n   " +
        "   <Column Name=\"移植胚胎2\" DataType=\"System.String\"/>\r\n      <Column Name=\"移植胚胎3\" D" +
        "ataType=\"System.String\"/>\r\n      <Column Name=\"移植胚胎4\" DataType=\"System.String\"/>" +
        "\r\n    </TableDataSource>\r\n    <TableDataSource Name=\"FrozenEmbryo\" ReferenceName";
      reportString += "=\"Data.FrozenEmbryo\" DataType=\"System.Int32\" Enabled=\"true\">\r\n      <Column Name" +
        "=\"管号\" DataType=\"System.String\"/>\r\n      <Column Name=\"胚胎个数\" DataType=\"System.Str" +
        "ing\"/>\r\n      <Column Name=\"标记\" DataType=\"System.String\"/>\r\n      <Column Name=\"" +
        "位置\" DataType=\"System.String\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Nam" +
        "e=\"SignaturePatient\" ReferenceName=\"Data.SignaturePatient\" DataType=\"System.Int3" +
        "2\" Enabled=\"true\">\r\n      <Column Name=\"SignaturePatient\" DataType=\"System.Byte[" +
        "]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataSource Nam" +
        "e=\"SignatureOperator\" ReferenceName=\"Data.SignatureOperator\" DataType=\"System.In" +
        "t32\" Enabled=\"true\">\r\n      <Column Name=\"SignatureOperator\" DataType=\"System.By" +
        "te[]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n    <TableDataSource " +
        "Name=\"SignatureChecker\" ReferenceName=\"Data.SignatureChecker\" DataType=\"System.I" +
        "nt32\" Enabled=\"true\">\r\n      <Column Name=\"SignatureChecker\" DataType=\"System.By";
      reportString += "te[]\" BindableControl=\"Picture\"/>\r\n    </TableDataSource>\r\n  </Dictionary>\r\n  <R" +
        "eportPage Name=\"Page1\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=\"718.2\" " +
        "Height=\"94.5\">\r\n      <TextObject Name=\"Text10\" Left=\"9.45\" Top=\"9.45\" Width=\"69" +
        "9.3\" Height=\"47.25\" Text=\"华中科技大学同济医学院附属荆州医院&#13;&#10;荆州市中心医院\" Format=\"Currency\" " +
        "Format.UseLocale=\"true\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"新宋体, 12pt\"/>" +
        "\r\n      <TextObject Name=\"Text11\" Left=\"340.2\" Top=\"56.7\" Width=\"94.5\" Height=\"1" +
        "8.9\" Text=\"[INFO.男方姓名]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text12\" Left=\"" +
        "94.5\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"[INFO.女方姓名]\" Font=\"宋体, 9pt\"/>\r" +
        "\n      <TextObject Name=\"Text13\" Left=\"9.45\" Top=\"56.7\" Width=\"75.6\" Height=\"18." +
        "9\" Text=\"妻子姓名：\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text14\" Left=\"255.15\" " +
        "Top=\"56.7\" Width=\"75.6\" Height=\"18.9\" Text=\"丈夫姓名：\" Font=\"宋体, 9pt\"/>\r\n      <Text" +
        "Object Name=\"Text15\" Left=\"567\" Top=\"56.7\" Width=\"94.5\" Height=\"18.9\" Text=\"[INF";
      reportString += "O.病历编号]\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text16\" Left=\"481.95\" Top=\"56" +
        ".7\" Width=\"75.6\" Height=\"18.9\" Text=\"病历编号：&#13;&#10;\" Font=\"宋体, 9pt\"/>\r\n      <R" +
        "ichObject Name=\"Rich1\" Left=\"9.45\" Top=\"75.6\" Width=\"689.85\" Height=\"18.9\" Borde" +
        "r.Lines=\"Top\"/>\r\n    </ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" " +
        "Top=\"98.5\" Width=\"718.2\" Height=\"75.6\"/>\r\n    <DataBand Name=\"Data1\" Top=\"178.1\"" +
        " Width=\"718.2\" Height=\"529.2\">\r\n      <TextObject Name=\"Text1\" Left=\"245.7\" Top=" +
        "\"9.45\" Width=\"236.25\" Height=\"28.35\" Text=\"配子，合子，胚胎处置记录\" HorzAlign=\"Center\" Vert" +
        "Align=\"Center\" Font=\"微软雅黑, 12pt, style=Bold\"/>\r\n      <TableObject Name=\"Table1\"" +
        " Left=\"198.45\" Top=\"189\" Width=\"340.2\" Height=\"170.1\">\r\n        <TableColumn Nam" +
        "e=\"Column10\" Width=\"75.6\"/>\r\n        <TableColumn Name=\"Column11\" Width=\"75.6\"/>" +
        "\r\n        <TableColumn Name=\"Column12\" Width=\"94.5\"/>\r\n        <TableColumn Name" +
        "=\"Column13\" Width=\"94.5\"/>\r\n        <TableRow Name=\"Row3\">\r\n          <TableCell";
      reportString += " Name=\"Cell34\" Border.Lines=\"All\" Text=\"管号\" HorzAlign=\"Center\" VertAlign=\"Center" +
        "\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell35\" Border.Lines=\"All\" Text=\"" +
        "胚胎个数号\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableC" +
        "ell Name=\"Cell36\" Border.Lines=\"All\" Text=\"标记\" HorzAlign=\"Center\" VertAlign=\"Cen" +
        "ter\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell37\" Border.Lines=\"All\" Tex" +
        "t=\"位置\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableR" +
        "ow Name=\"Row4\">\r\n          <TableCell Name=\"Cell39\" Border.Lines=\"All\" Text=\"[Fr" +
        "ozenEmbryo.管号]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"" +
        "Cell40\" Border.Lines=\"All\" Text=\"[FrozenEmbryo.胚胎个数]\" HorzAlign=\"Center\" Font=\"宋" +
        "体, 9pt\"/>\r\n          <TableCell Name=\"Cell41\" Border.Lines=\"All\" Text=\"[FrozenEm" +
        "bryo.标记]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell42" +
        "\" Border.Lines=\"All\" Text=\"[FrozenEmbryo.位置]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/";
      reportString += ">\r\n        </TableRow>\r\n        <TableRow Name=\"Row5\">\r\n          <TableCell Nam" +
        "e=\"Cell44\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <Ta" +
        "bleCell Name=\"Cell45\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n  " +
        "        <TableCell Name=\"Cell46\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体," +
        " 9pt\"/>\r\n          <TableCell Name=\"Cell47\" Border.Lines=\"All\" HorzAlign=\"Center" +
        "\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row6\">\r\n       " +
        "   <TableCell Name=\"Cell49\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"" +
        "/>\r\n          <TableCell Name=\"Cell50\" Border.Lines=\"All\" HorzAlign=\"Center\" Fon" +
        "t=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell51\" Border.Lines=\"All\" HorzAlign=\"" +
        "Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell52\" Border.Lines=\"All\" " +
        "HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name" +
        "=\"Row7\">\r\n          <TableCell Name=\"Cell54\" Border.Lines=\"All\" HorzAlign=\"Cente";
      reportString += "r\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell55\" Border.Lines=\"All\" HorzA" +
        "lign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell56\" Border.Lines=" +
        "\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell57\" Bo" +
        "rder.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n     " +
        "   <TableRow Name=\"Row20\">\r\n          <TableCell Name=\"Cell125\" Border.Lines=\"Al" +
        "l\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell126\" Bord" +
        "er.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"C" +
        "ell127\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <Table" +
        "Cell Name=\"Cell128\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n    " +
        "    </TableRow>\r\n        <TableRow Name=\"Row21\">\r\n          <TableCell Name=\"Cel" +
        "l129\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCe" +
        "ll Name=\"Cell130\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n      ";
      reportString += "    <TableCell Name=\"Cell131\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9p" +
        "t\"/>\r\n          <TableCell Name=\"Cell132\" Border.Lines=\"All\" HorzAlign=\"Center\" " +
        "Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row22\">\r\n        " +
        "  <TableCell Name=\"Cell133\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"" +
        "/>\r\n          <TableCell Name=\"Cell134\" Border.Lines=\"All\" HorzAlign=\"Center\" Fo" +
        "nt=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell135\" Border.Lines=\"All\" HorzAlign" +
        "=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell136\" Border.Lines=\"Al" +
        "l\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow N" +
        "ame=\"Row23\">\r\n          <TableCell Name=\"Cell137\" Border.Lines=\"All\" HorzAlign=\"" +
        "Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell138\" Border.Lines=\"All\"" +
        " HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell139\" Border" +
        ".Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cel";
      reportString += "l140\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </TableRow" +
        ">\r\n      </TableObject>\r\n      <TableObject Name=\"Table2\" Left=\"9.45\" Top=\"189\" " +
        "Width=\"188.99\" Height=\"170.1\">\r\n        <TableColumn Name=\"Column14\" Width=\"103." +
        "94\"/>\r\n        <TableColumn Name=\"Column25\" Width=\"85.05\"/>\r\n        <TableRow N" +
        "ame=\"Row8\" Height=\"170.1\">\r\n          <TableCell Name=\"Cell58\" Border.Lines=\"All" +
        "\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell124\" Borde" +
        "r.Lines=\"All\" Text=\"冷冻\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n" +
        "        </TableRow>\r\n      </TableObject>\r\n      <TableObject Name=\"Table3\" Left" +
        "=\"9.45\" Top=\"75.6\" Width=\"529.2\" Height=\"113.4\">\r\n        <TableColumn Name=\"Col" +
        "umn15\" Width=\"103.95\"/>\r\n        <TableColumn Name=\"Column16\" Width=\"85.05\"/>\r\n " +
        "       <TableColumn Name=\"Column17\" Width=\"85.05\"/>\r\n        <TableColumn Name=\"" +
        "Column18\"/>\r\n        <TableColumn Name=\"Column19\"/>\r\n        <TableColumn Name=\"";
      reportString += "Column20\"/>\r\n        <TableColumn Name=\"Column21\" Width=\"56.7\"/>\r\n        <Table" +
        "Row Name=\"Row9\">\r\n          <TableCell Name=\"Cell59\" Border.Lines=\"All\" Text=\"日期" +
        "\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell N" +
        "ame=\"Cell60\" Border.Lines=\"All\" Text=\"去向\" HorzAlign=\"Center\" VertAlign=\"Center\" " +
        "Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell61\" Border.Lines=\"All\" Text=\"配子" +
        "，合子，胚胎\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\" ColSpan=\"5\"/>\r\n    " +
        "      <TableCell Name=\"Cell62\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <T" +
        "ableCell Name=\"Cell63\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell" +
        " Name=\"Cell84\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell89\" Font=\"宋体, 9p" +
        "t\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row10\">\r\n          <TableCell" +
        " Name=\"Cell64\" Border.Lines=\"All\" Text=\"[INFO.日期]\" HorzAlign=\"Center\" Font=\"宋体, " +
        "9pt\" RowSpan=\"2\"/>\r\n          <TableCell Name=\"Cell65\" Border.Lines=\"All\" Text=\"";
      reportString += "自体移植\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\" RowSpan=\"2\"/>\r\n      " +
        "    <TableCell Name=\"Cell66\" Border.Lines=\"All\" Text=\"移植胚胎\" HorzAlign=\"Center\" V" +
        "ertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell67\" Border.Li" +
        "nes=\"All\" Text=\"[INFO.移植胚胎1]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <Ta" +
        "bleCell Name=\"Cell68\" Border.Lines=\"All\" Text=\"[INFO.移植胚胎2]\" HorzAlign=\"Center\" " +
        "Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell85\" Border.Lines=\"All\" Text=\"[I" +
        "NFO.移植胚胎3]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell" +
        "90\" Border.Lines=\"All\" Text=\"[INFO.移植胚胎4]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n" +
        "        </TableRow>\r\n        <TableRow Name=\"Row11\">\r\n          <TableCell Name=" +
        "\"Cell69\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <Tabl" +
        "eCell Name=\"Cell70\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n    " +
        "      <TableCell Name=\"Cell71\" Border.Lines=\"All\" Text=\"ET后检查\" HorzAlign=\"Center";
      reportString += "\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell72\" Border" +
        ".Lines=\"All\" Text=\"[INFO.ET后检查]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\" ColSpan=\"4\"/>" +
        "\r\n          <TableCell Name=\"Cell73\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name" +
        "=\"Cell86\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell91\" Font=\"宋体, 9pt\"/>\r" +
        "\n        </TableRow>\r\n        <TableRow Name=\"Row12\">\r\n          <TableCell Name" +
        "=\"Cell74\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <Tab" +
        "leCell Name=\"Cell75\" Border.Lines=\"All\" Text=\"遗弃\" HorzAlign=\"Center\" VertAlign=\"" +
        "Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell76\" Border.Lines=\"All\" " +
        "Text=\"[INFO.遗弃数]\" HorzAlign=\"Center\" Font=\"宋体, 9pt\" ColSpan=\"5\"/>\r\n          <Ta" +
        "bleCell Name=\"Cell77\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n  " +
        "        <TableCell Name=\"Cell78\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体," +
        " 9pt\"/>\r\n          <TableCell Name=\"Cell87\" Border.Lines=\"All\" HorzAlign=\"Center";
      reportString += "\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell92\" Border.Lines=\"All\" HorzAl" +
        "ign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row1" +
        "3\">\r\n          <TableCell Name=\"Cell79\" Border.Lines=\"All\" HorzAlign=\"Center\" Fo" +
        "nt=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell80\" Border.Lines=\"All\" Text=\"科研用\"" +
        " HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Na" +
        "me=\"Cell81\" Border.Lines=\"All\" Text=\"[INFO.科研用数]\" HorzAlign=\"Center\" Font=\"宋体, 9" +
        "pt\" ColSpan=\"5\"/>\r\n          <TableCell Name=\"Cell82\" Border.Lines=\"All\" HorzAli" +
        "gn=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell83\" Border.Lines=\"A" +
        "ll\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell88\" Bord" +
        "er.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"C" +
        "ell93\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </TableRo" +
        "w>\r\n        <TableRow Name=\"Row14\">\r\n          <TableCell Name=\"Cell94\" Border.L";
      reportString += "ines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell9" +
        "5\" Border.Lines=\"All\" Text=\"遗失\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"宋体, " +
        "9pt\"/>\r\n          <TableCell Name=\"Cell96\" Border.Lines=\"All\" Text=\"[INFO.遗失数]\" " +
        "HorzAlign=\"Center\" Font=\"宋体, 9pt\" ColSpan=\"5\"/>\r\n          <TableCell Name=\"Cell" +
        "97\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell" +
        " Name=\"Cell98\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n         " +
        " <TableCell Name=\"Cell99\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>" +
        "\r\n          <TableCell Name=\"Cell100\" Border.Lines=\"All\" HorzAlign=\"Center\" Font" +
        "=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n      </TableObject>\r\n      <TableObject Name" +
        "=\"Table4\" Left=\"538.65\" Top=\"75.6\" Width=\"151.2\" Height=\"113.4\">\r\n        <Table" +
        "Column Name=\"Column22\" Width=\"75.6\"/>\r\n        <TableColumn Name=\"Column24\" Widt" +
        "h=\"75.6\"/>\r\n        <TableRow Name=\"Row15\">\r\n          <TableCell Name=\"Cell101\"";
      reportString += " Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Na" +
        "me=\"Cell103\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        </T" +
        "ableRow>\r\n        <TableRow Name=\"Row16\">\r\n          <TableCell Name=\"Cell106\" B" +
        "order.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\" RowSpan=\"4\">\r\n            <P" +
        "ictureObject Name=\"Picture1\" Left=\"9.45\" Top=\"9.45\" Width=\"56.7\" Height=\"18.9\" D" +
        "ataColumn=\"SignatureOperator.SignatureOperator\"/>\r\n          </TableCell>\r\n     " +
        "     <TableCell Name=\"Cell108\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9" +
        "pt\" RowSpan=\"4\">\r\n            <PictureObject Name=\"Picture2\" Left=\"9.45\" Top=\"9." +
        "45\" Width=\"56.7\" Height=\"18.9\" DataColumn=\"SignatureChecker.SignatureChecker\"/>\r" +
        "\n          </TableCell>\r\n        </TableRow>\r\n        <TableRow Name=\"Row17\">\r\n " +
        "         <TableCell Name=\"Cell111\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"" +
        "Cell113\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row18\">\r";
      reportString += "\n          <TableCell Name=\"Cell116\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name" +
        "=\"Cell118\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row19\"" +
        " Height=\"37.8\">\r\n          <TableCell Name=\"Cell121\" Font=\"宋体, 9pt\"/>\r\n         " +
        " <TableCell Name=\"Cell123\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n      </TableO" +
        "bject>\r\n      <TableObject Name=\"Table5\" Left=\"538.65\" Top=\"189\" Width=\"151.2\" H" +
        "eight=\"170.1\">\r\n        <TableColumn Name=\"Column26\" Width=\"75.6\"/>\r\n        <Ta" +
        "bleColumn Name=\"Column27\" Width=\"75.6\"/>\r\n        <TableRow Name=\"Row24\" Height=" +
        "\"30.24\">\r\n          <TableCell Name=\"Cell141\" Border.Lines=\"All\" HorzAlign=\"Cent" +
        "er\" Font=\"宋体, 9pt\" RowSpan=\"5\"/>\r\n          <TableCell Name=\"Cell142\" Border.Lin" +
        "es=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\" RowSpan=\"5\"/>\r\n        </TableRow>\r\n " +
        "       <TableRow Name=\"Row25\" Height=\"30.24\">\r\n          <TableCell Name=\"Cell14" +
        "3\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n          <TableCell ";
      reportString += "Name=\"Cell144\" Border.Lines=\"All\" HorzAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n        <" +
        "/TableRow>\r\n        <TableRow Name=\"Row26\" Height=\"30.24\">\r\n          <TableCell" +
        " Name=\"Cell145\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Cell146\" Font=\"宋体, " +
        "9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row27\" Height=\"30.24\">\r\n   " +
        "       <TableCell Name=\"Cell147\" Font=\"宋体, 9pt\"/>\r\n          <TableCell Name=\"Ce" +
        "ll148\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n        <TableRow Name=\"Row28\" Hei" +
        "ght=\"49.14\">\r\n          <TableCell Name=\"Cell149\" Font=\"宋体, 9pt\"/>\r\n          <T" +
        "ableCell Name=\"Cell150\" Font=\"宋体, 9pt\"/>\r\n        </TableRow>\r\n      </TableObje" +
        "ct>\r\n      <TextObject Name=\"Text2\" Left=\"9.45\" Top=\"368.55\" Width=\"519.75\" Heig" +
        "ht=\"37.8\" Text=\"经认真考虑，我们同意对以上配子，合子，胚胎所进行的处置。\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/" +
        ">\r\n      <TextObject Name=\"Text3\" Left=\"9.45\" Top=\"425.25\" Width=\"94.5\" Height=\"" +
        "18.9\" Text=\"妻子签名：\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"";
      reportString += "Text17\" Left=\"236.25\" Top=\"425.25\" Width=\"94.5\" Height=\"18.9\" Text=\"丈夫签名：\" VertA" +
        "lign=\"Center\" Font=\"宋体, 9pt\"/>\r\n      <TextObject Name=\"Text18\" Left=\"425.25\" To" +
        "p=\"425.25\" Width=\"94.5\" Height=\"18.9\" Text=\"谈话者签名：\" VertAlign=\"Center\" Font=\"宋体," +
        " 9pt\"/>\r\n      <TextObject Name=\"Text19\" Left=\"425.25\" Top=\"463.05\" Width=\"94.5\"" +
        " Height=\"18.9\" Text=\"日期：\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n      <TextObject" +
        " Name=\"Text20\" Left=\"481.95\" Top=\"56.7\" Width=\"113.4\" Height=\"18.9\" Text=\"临床移植者签" +
        "名：\" VertAlign=\"Center\" Font=\"宋体, 9pt\"/>\r\n    </DataBand>\r\n    <PageFooterBand Na" +
        "me=\"PageFooter1\" Top=\"711.3\" Width=\"718.2\" Height=\"18.9\"/>\r\n  </ReportPage>\r\n</R" +
        "eport>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public EmbryoProcessRecordReport()
    {
      InitializeComponent();
    }
    private void Table1_ManualBuild(object sender, EventArgs e)
    {
      // get the data source by its name
      DataSourceBase rowData = Report.GetDataSource("FrozenEmbryo");
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
