namespace TradApp.FORMS
{
  partial class FormSerie
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
      labelMotTraduire = new Label();
      labelTraduction = new Label();
      TxtTraduction = new TextBox();
      BoutonValider = new Button();
      labelATrad = new Label();
      SuspendLayout();
      // 
      // labelMotTraduire
      // 
      labelMotTraduire.AutoSize = true;
      labelMotTraduire.Font = new Font("Segoe UI", 12F);
      labelMotTraduire.Location = new Point(147, 98);
      labelMotTraduire.Name = "labelMotTraduire";
      labelMotTraduire.Size = new Size(116, 21);
      labelMotTraduire.TabIndex = 0;
      labelMotTraduire.Text = "Mot à traduire :";
      // 
      // labelTraduction
      // 
      labelTraduction.AutoSize = true;
      labelTraduction.Font = new Font("Segoe UI", 12F);
      labelTraduction.Location = new Point(173, 159);
      labelTraduction.Name = "labelTraduction";
      labelTraduction.Size = new Size(90, 21);
      labelTraduction.TabIndex = 1;
      labelTraduction.Text = "Traduction :";
      // 
      // TxtTraduction
      // 
      TxtTraduction.Font = new Font("Segoe UI", 12F);
      TxtTraduction.Location = new Point(273, 156);
      TxtTraduction.Name = "TxtTraduction";
      TxtTraduction.Size = new Size(136, 29);
      TxtTraduction.TabIndex = 2;
      // 
      // BoutonValider
      // 
      BoutonValider.Font = new Font("Segoe UI", 12F);
      BoutonValider.Location = new Point(273, 232);
      BoutonValider.Name = "BoutonValider";
      BoutonValider.Size = new Size(136, 32);
      BoutonValider.TabIndex = 3;
      BoutonValider.Text = "Valider";
      BoutonValider.UseVisualStyleBackColor = true;
      BoutonValider.Click += BoutonValider_Click;
      // 
      // labelATrad
      // 
      labelATrad.AutoSize = true;
      labelATrad.Font = new Font("Segoe UI", 12F);
      labelATrad.Location = new Point(273, 98);
      labelATrad.Name = "labelATrad";
      labelATrad.Size = new Size(0, 21);
      labelATrad.TabIndex = 4;
      // 
      // FormSerie
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(688, 400);
      Controls.Add(labelATrad);
      Controls.Add(BoutonValider);
      Controls.Add(TxtTraduction);
      Controls.Add(labelTraduction);
      Controls.Add(labelMotTraduire);
      Name = "FormSerie";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "NumeroSerie";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label labelMotTraduire;
    private Label labelTraduction;
    private TextBox TxtTraduction;
    private Button BoutonValider;
    private Label labelATrad;
  }
}