namespace TradApp
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      ButtonToMenu = new Button();
      SuspendLayout();
      // 
      // ButtonToMenu
      // 
      ButtonToMenu.Location = new Point(291, 155);
      ButtonToMenu.Name = "ButtonToMenu";
      ButtonToMenu.Size = new Size(197, 111);
      ButtonToMenu.TabIndex = 0;
      ButtonToMenu.Text = "C'est parti!";
      ButtonToMenu.UseVisualStyleBackColor = true;
      ButtonToMenu.Click += ButtonToMenu_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(ButtonToMenu);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
    }

    #endregion

    private Button ButtonToMenu;
  }
}
