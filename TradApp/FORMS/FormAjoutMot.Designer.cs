namespace TradApp
{
  partial class FormAjoutMot
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
      labelChoixLangue = new Label();
      comboBoxLangues = new ComboBox();
      BoutonRetourMenu = new Button();
      SuspendLayout();
      // 
      // labelChoixLangue
      // 
      labelChoixLangue.AutoSize = true;
      labelChoixLangue.Font = new Font("Segoe UI", 16F);
      labelChoixLangue.Location = new Point(84, 156);
      labelChoixLangue.Name = "labelChoixLangue";
      labelChoixLangue.Size = new Size(279, 30);
      labelChoixLangue.TabIndex = 0;
      labelChoixLangue.Text = "Veuillez choisir une langue :";
      // 
      // comboBoxLangues
      // 
      comboBoxLangues.Font = new Font("Segoe UI", 12F);
      comboBoxLangues.FormattingEnabled = true;
      comboBoxLangues.Items.AddRange(new object[] { "Anglais" });
      comboBoxLangues.Location = new Point(378, 160);
      comboBoxLangues.Name = "comboBoxLangues";
      comboBoxLangues.Size = new Size(121, 29);
      comboBoxLangues.TabIndex = 1;
      comboBoxLangues.Text = "Choix langue";
      comboBoxLangues.SelectedIndexChanged += ComboBoxLangues_SelectedIndexChanged;
      // 
      // BoutonRetourMenu
      // 
      BoutonRetourMenu.Font = new Font("Segoe UI", 12F);
      BoutonRetourMenu.Location = new Point(269, 242);
      BoutonRetourMenu.Name = "BoutonRetourMenu";
      BoutonRetourMenu.Size = new Size(200, 50);
      BoutonRetourMenu.TabIndex = 2;
      BoutonRetourMenu.Text = "Retour";
      BoutonRetourMenu.UseVisualStyleBackColor = true;
      BoutonRetourMenu.Click += BoutonRetourMenu_Click;
      // 
      // FormAjoutMot
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(BoutonRetourMenu);
      Controls.Add(comboBoxLangues);
      Controls.Add(labelChoixLangue);
      Name = "FormAjoutMot";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "FormAjoutMot";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label labelChoixLangue;
    private ComboBox comboBoxLangues;
    private Button BoutonRetourMenu;
  }
}