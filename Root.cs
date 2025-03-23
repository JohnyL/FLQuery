using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLQuery;

public partial class Root : Form
{
  public Root() => InitializeComponent();

  private void OnFormLoaded(object sender, EventArgs e)
  {
    SetDayAsOne(dtpRegistryFrom);
    SetDayAsOne(dtpRegistryTo);
  }

  private void OnPeriodChanged(object sender, EventArgs e) => SetDayAsOne((DateTimePicker)sender);

  private void SetDayAsOne(DateTimePicker dtp) => dtp.Value = dtp.Value.AddDays(-(dtp.Value.Day - 1));
}