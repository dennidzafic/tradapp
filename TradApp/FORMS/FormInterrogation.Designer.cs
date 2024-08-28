namespace TradApp.FORMS
{
  partial class FormInterrogation
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
      LabelSerie = new Label();
      TxtNumeroSerie = new TextBox();
      BoutonStart = new Button();
      BoutonRetour = new Button();
      SuspendLayout();
      // 
      // LabelSerie
      // 
      LabelSerie.AutoSize = true;
      LabelSerie.Font = new Font("Segoe UI", 12F);
      LabelSerie.Location = new Point(79, 156);
      LabelSerie.Name = "LabelSerie";
      LabelSerie.Size = new Size(193, 21);
      LabelSerie.TabIndex = 0;
      LabelSerie.Text = "Entrez le numéro de série :";
      // 
      // TxtNumeroSerie
      // 
      TxtNumeroSerie.Font = new Font("Segoe UI", 12F);
      TxtNumeroSerie.Location = new Point(278, 153);
      TxtNumeroSerie.MaxLength = 2;
      TxtNumeroSerie.Name = "TxtNumeroSerie";
      TxtNumeroSerie.Size = new Size(33, 29);
      TxtNumeroSerie.TabIndex = 1;
      // 
      // BoutonStart
      // 
      BoutonStart.Font = new Font("Segoe UI", 12F);
      BoutonStart.Location = new Point(357, 116);
      BoutonStart.Name = "BoutonStart";
      BoutonStart.Size = new Size(200, 100);
      BoutonStart.TabIndex = 2;
      BoutonStart.Text = "Commencer la série";
      BoutonStart.UseVisualStyleBackColor = true;
      BoutonStart.Click += BoutonStart_Click;
      // 
      // BoutonRetour
      // 
      BoutonRetour.Font = new Font("Segoe UI", 12F);
      BoutonRetour.Location = new Point(243, 264);
      BoutonRetour.Name = "BoutonRetour";
      BoutonRetour.Size = new Size(200, 40);
      BoutonRetour.TabIndex = 3;
      BoutonRetour.Text = "Retour";
      BoutonRetour.UseVisualStyleBackColor = true;
      BoutonRetour.Click += BoutonRetour_Click;
      // 
      // FormInterrogation
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(714, 339);
      Controls.Add(BoutonRetour);
      Controls.Add(BoutonStart);
      Controls.Add(TxtNumeroSerie);
      Controls.Add(LabelSerie);
      Name = "FormInterrogation";
      StartPosition = FormStartPosition.CenterScreen;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LabelSerie;
    private TextBox TxtNumeroSerie;
    private Button BoutonStart;
    private Button BoutonRetour;
  }
}