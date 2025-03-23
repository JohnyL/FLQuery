using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using System.Runtime.InteropServices;
using Microsoft.Office.Core;

namespace FLQuery;

[ComVisible(true)]
public interface IThisWorkbook
{
  void ShowMsg();
  void PrintNumbers();
}

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
public partial class ThisWorkbook : IThisWorkbook
{
  private void ThisWorkbook_Startup(object sender, EventArgs e) { }

  private void ThisWorkbook_Shutdown(object sender, EventArgs e) { }

  protected override object GetAutomationObject() => this;

  protected override IRibbonExtensibility CreateRibbonExtensibilityObject() => new FLQueryRibbon();

  public void ShowMsg()
  {
    MessageBox.Show("Well done from VSTO!");
  }

  public void PrintNumbers()
  {
    //Excel.Application xlApp = GetExcelApp();
    Excel.Application xlApp = ExcelApp;
    Excel.Worksheet sheet = xlApp.ActiveSheet;
    for (int r = 1; r <= 10; ++r)
    {
      sheet.Cells[r, 1].Value = r;
    }
  }

  //private Excel.Application GetExcelApp() => Globals.ThisWorkbook.Application;
  private Excel.Application ExcelApp => Globals.ThisWorkbook.Application;

  #region VSTO Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InternalStartup()
  {
    this.Startup += new EventHandler(ThisWorkbook_Startup);
    this.Shutdown += new EventHandler(ThisWorkbook_Shutdown);
  }

  #endregion

}