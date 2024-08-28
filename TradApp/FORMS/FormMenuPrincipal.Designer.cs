namespace TradApp
{
  partial class FormMenuPrincipal
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
      BoutonCommencerSerie = new Button();
      BoutonAddMot = new Button();
      BoutonExit = new Button();
      SuspendLayout();
      // 
      // BoutonCommencerSerie
      // 
      BoutonCommencerSerie.Location = new Point(317, 106);
      BoutonCommencerSerie.Name = "BoutonCommencerSerie";
      BoutonCommencerSerie.Size = new Size(200, 50);
      BoutonCommencerSerie.TabIndex = 0;
      BoutonCommencerSerie.Text = "Commencer une série";
      BoutonCommencerSerie.UseVisualStyleBackColor = true;
      BoutonCommencerSerie.Click += BoutonCommencerSerie_Click;
      // 
      // BoutonAddMot
      // 
      BoutonAddMot.Location = new Point(317, 187);
      BoutonAddMot.Name = "BoutonAddMot";
      BoutonAddMot.Size = new Size(200, 50);
      BoutonAddMot.TabIndex = 1;
      BoutonAddMot.Text = "Ajouter des mots";
      BoutonAddMot.UseVisualStyleBackColor = true;
      BoutonAddMot.Click += BoutonAddMot_Click;
      // 
      // BoutonExit
      // 
      BoutonExit.Location = new Point(317, 267);
      BoutonExit.Name = "BoutonExit";
      BoutonExit.Size = new Size(200, 50);
      BoutonExit.TabIndex = 2;
      BoutonExit.Text = "Quitter l'application";
      BoutonExit.UseVisualStyleBackColor = true;
      BoutonExit.Click += BoutonExit_Click;
      // 
      // FormMenuPrincipal
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(BoutonExit);
      Controls.Add(BoutonAddMot);
      Controls.Add(BoutonCommencerSerie);
      Name = "FormMenuPrincipal";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "FormMenuPrincipal";
      ResumeLayout(false);
    }

    #endregion

    private Button BoutonCommencerSerie;
    private Button BoutonAddMot;
    private Button BoutonExit;
  }
}