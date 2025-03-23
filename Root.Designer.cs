namespace FLQuery
{
  partial class Root
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.TabRoot = new System.Windows.Forms.TabControl();
      this.TabPageRegistry = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dtpRegistryFrom = new System.Windows.Forms.DateTimePicker();
      this.dtpRegistryTo = new System.Windows.Forms.DateTimePicker();
      this.lblFrom = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TabRoot.SuspendLayout();
      this.TabPageRegistry.SuspendLayout();
      this.SuspendLayout();
      // 
      // TabRoot
      // 
      this.TabRoot.Controls.Add(this.TabPageRegistry);
      this.TabRoot.Controls.Add(this.tabPage2);
      this.TabRoot.Location = new System.Drawing.Point(12, 12);
      this.TabRoot.Name = "TabRoot";
      this.TabRoot.SelectedIndex = 0;
      this.TabRoot.Size = new System.Drawing.Size(501, 274);
      this.TabRoot.TabIndex = 0;
      // 
      // TabPageRegistry
      // 
      this.TabPageRegistry.Controls.Add(this.label2);
      this.TabPageRegistry.Controls.Add(this.lblFrom);
      this.TabPageRegistry.Controls.Add(this.dtpRegistryTo);
      this.TabPageRegistry.Controls.Add(this.dtpRegistryFrom);
      this.TabPageRegistry.Location = new System.Drawing.Point(4, 22);
      this.TabPageRegistry.Name = "TabPageRegistry";
      this.TabPageRegistry.Padding = new System.Windows.Forms.Padding(3);
      this.TabPageRegistry.Size = new System.Drawing.Size(493, 248);
      this.TabPageRegistry.TabIndex = 0;
      this.TabPageRegistry.Text = "Registry";
      this.TabPageRegistry.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(192, 74);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dtpRegistryFrom
      // 
      this.dtpRegistryFrom.CustomFormat = "MMMM yyyy";
      this.dtpRegistryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpRegistryFrom.Location = new System.Drawing.Point(45, 6);
      this.dtpRegistryFrom.Name = "dtpRegistryFrom";
      this.dtpRegistryFrom.Size = new System.Drawing.Size(112, 20);
      this.dtpRegistryFrom.TabIndex = 0;
      // 
      // dtpRegistryTo
      // 
      this.dtpRegistryTo.CustomFormat = "MMMM yyyy";
      this.dtpRegistryTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpRegistryTo.Location = new System.Drawing.Point(45, 32);
      this.dtpRegistryTo.Name = "dtpRegistryTo";
      this.dtpRegistryTo.Size = new System.Drawing.Size(112, 20);
      this.dtpRegistryTo.TabIndex = 1;
      // 
      // lblFrom
      // 
      this.lblFrom.AutoSize = true;
      this.lblFrom.Location = new System.Drawing.Point(6, 10);
      this.lblFrom.Name = "lblFrom";
      this.lblFrom.Size = new System.Drawing.Size(33, 13);
      this.lblFrom.TabIndex = 2;
      this.lblFrom.Text = "From:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(23, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "To:";
      // 
      // Root
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(525, 298);
      this.Controls.Add(this.TabRoot);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "Root";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FL.Query";
      this.TabRoot.ResumeLayout(false);
      this.TabPageRegistry.ResumeLayout(false);
      this.TabPageRegistry.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl TabRoot;
    private System.Windows.Forms.TabPage TabPageRegistry;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DateTimePicker dtpRegistryTo;
    private System.Windows.Forms.DateTimePicker dtpRegistryFrom;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblFrom;
  }
}