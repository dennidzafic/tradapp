namespace TradApp.FORMS
{
  partial class AjoutMot
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
      MotFr = new Label();
      MotEn = new Label();
      TxtMotEn = new TextBox();
      ExitAddMot = new Button();
      SubmitMot = new Button();
      TxtMotFr = new TextBox();
      Serie = new Label();
      TxtSerie = new TextBox();
      SuspendLayout();
      // 
      // MotFr
      // 
      MotFr.AutoSize = true;
      MotFr.Font = new Font("Segoe UI", 12F);
      MotFr.Location = new Point(88, 37);
      MotFr.Name = "MotFr";
      MotFr.Size = new Size(103, 21);
      MotFr.TabIndex = 0;
      MotFr.Text = "Mot français :";
      // 
      // MotEn
      // 
      MotEn.AutoSize = true;
      MotEn.Font = new Font("Segoe UI", 12F);
      MotEn.Location = new Point(337, 37);
      MotEn.Name = "MotEn";
      MotEn.Size = new Size(98, 21);
      MotEn.TabIndex = 1;
      MotEn.Text = "Mot anglais :";
      // 
      // TxtMotEn
      // 
      TxtMotEn.Font = new Font("Segoe UI", 12F);
      TxtMotEn.Location = new Point(441, 34);
      TxtMotEn.Name = "TxtMotEn";
      TxtMotEn.Size = new Size(100, 29);
      TxtMotEn.TabIndex = 8;
      // 
      // ExitAddMot
      // 
      ExitAddMot.Location = new Point(490, 94);
      ExitAddMot.Name = "ExitAddMot";
      ExitAddMot.Size = new Size(200, 30);
      ExitAddMot.TabIndex = 11;
      ExitAddMot.Text = "Retour";
      ExitAddMot.UseVisualStyleBackColor = true;
      ExitAddMot.Click += ExitAddMot_Click;
      // 
      // SubmitMot
      // 
      SubmitMot.Location = new Point(167, 94);
      SubmitMot.Name = "SubmitMot";
      SubmitMot.Size = new Size(200, 30);
      SubmitMot.TabIndex = 10;
      SubmitMot.Text = "Ajouter mots";
      SubmitMot.UseVisualStyleBackColor = true;
      SubmitMot.Click += SubmitMot_Click;
      // 
      // TxtMotFr
      // 
      TxtMotFr.Font = new Font("Segoe UI", 12F);
      TxtMotFr.Location = new Point(197, 34);
      TxtMotFr.Name = "TxtMotFr";
      TxtMotFr.Size = new Size(100, 29);
      TxtMotFr.TabIndex = 7;
      // 
      // Serie
      // 
      Serie.AutoSize = true;
      Serie.Font = new Font("Segoe UI", 12F);
      Serie.Location = new Point(580, 37);
      Serie.Name = "Serie";
      Serie.Size = new Size(52, 21);
      Serie.TabIndex = 8;
      Serie.Text = "Série :";
      // 
      // TxtSerie
      // 
      TxtSerie.Font = new Font("Segoe UI", 12F);
      TxtSerie.Location = new Point(638, 34);
      TxtSerie.Name = "TxtSerie";
      TxtSerie.Size = new Size(100, 29);
      TxtSerie.TabIndex = 9;
      // 
      // AjoutMot
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(806, 154);
      Controls.Add(TxtSerie);
      Controls.Add(Serie);
      Controls.Add(TxtMotFr);
      Controls.Add(SubmitMot);
      Controls.Add(ExitAddMot);
      Controls.Add(TxtMotEn);
      Controls.Add(MotEn);
      Controls.Add(MotFr);
      Name = "AjoutMot";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "AjoutMot";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label MotFr;
    private Label MotEn;
    private TextBox TxtMotEn;
    private Button ExitAddMot;
    private Button SubmitMot;
    private TextBox TxtMotFr;
    private Label Serie;
    private TextBox TxtSerie;
  }
}