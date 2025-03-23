using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace FLQuery;

[ComVisible(true)]
public class FLQueryRibbon : IRibbonExtensibility
{
  private IRibbonUI ribbon;

  #region IRibbonExtensibility Members

  public string GetCustomUI(string ribbonID)
  {
    return GetResourceText("FLQuery.FLQueryRibbon.xml");
  }

  #endregion

  #region Ribbon Callbacks
  //Create callback methods here. For more information about adding callback methods, visit https://go.microsoft.com/fwlink/?LinkID=271226

  public void OnRibbonLoaded(IRibbonUI ribbonUI)
  {
    ribbon = ribbonUI;
    ribbon.ActivateTab("rxFLQueryTab");
  }

  public void OnRunQuery(IRibbonControl control)
  {
    Root root = new();
    root.Show();
  }

  #endregion

  #region Helpers

  private static string GetResourceText(string resourceName)
  {
    Assembly asm = Assembly.GetExecutingAssembly();
    string[] resourceNames = asm.GetManifestResourceNames();
    for (int i = 0; i < resourceNames.Length; ++i)
    {
      if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
      {
        using StreamReader resourceReader = new(asm.GetManifestResourceStream(resourceNames[i]));
        if (resourceReader is not null)
        {
          return resourceReader.ReadToEnd();
        }
      }
    }
    return null;
  }

  #endregion
}