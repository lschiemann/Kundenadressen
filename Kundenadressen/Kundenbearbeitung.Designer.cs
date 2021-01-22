
namespace Kundenadressen
{
  partial class Kundenbearbeitung
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.KundenGrid = new System.Windows.Forms.DataGridView();
      this.AdressenGrid = new System.Windows.Forms.DataGridView();
      this.RemoveKunden = new System.Windows.Forms.Button();
      this.SaveData = new System.Windows.Forms.Button();
      this.RemoveAdresse = new System.Windows.Forms.Button();
      this.FilterText = new System.Windows.Forms.TextBox();
      this.FilterLabel = new System.Windows.Forms.Label();
      this.AddKunde = new System.Windows.Forms.Button();
      this.AddAdresse = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.KundenGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.AdressenGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // KundenGrid
      // 
      this.KundenGrid.AllowUserToAddRows = false;
      this.KundenGrid.AllowUserToDeleteRows = false;
      this.KundenGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.KundenGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.KundenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.KundenGrid.Location = new System.Drawing.Point(0, 42);
      this.KundenGrid.MultiSelect = false;
      this.KundenGrid.Name = "KundenGrid";
      this.KundenGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.KundenGrid.Size = new System.Drawing.Size(800, 200);
      this.KundenGrid.TabIndex = 0;
      this.KundenGrid.SelectionChanged += new System.EventHandler(this.KundenGrid_SelectionChanged);
      // 
      // AdressenGrid
      // 
      this.AdressenGrid.AllowUserToAddRows = false;
      this.AdressenGrid.AllowUserToDeleteRows = false;
      this.AdressenGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.AdressenGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.AdressenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.AdressenGrid.Enabled = false;
      this.AdressenGrid.Location = new System.Drawing.Point(0, 277);
      this.AdressenGrid.MultiSelect = false;
      this.AdressenGrid.Name = "AdressenGrid";
      this.AdressenGrid.Size = new System.Drawing.Size(800, 214);
      this.AdressenGrid.TabIndex = 1;
      this.AdressenGrid.SelectionChanged += new System.EventHandler(this.AdressenGrid_SelectionChanged);
      // 
      // RemoveKunden
      // 
      this.RemoveKunden.Enabled = false;
      this.RemoveKunden.Location = new System.Drawing.Point(81, 248);
      this.RemoveKunden.Name = "RemoveKunden";
      this.RemoveKunden.Size = new System.Drawing.Size(75, 23);
      this.RemoveKunden.TabIndex = 3;
      this.RemoveKunden.Text = "Entfernen";
      this.RemoveKunden.UseVisualStyleBackColor = true;
      this.RemoveKunden.Click += new System.EventHandler(this.RemoveKunden_Click);
      // 
      // SaveData
      // 
      this.SaveData.Location = new System.Drawing.Point(0, 12);
      this.SaveData.Name = "SaveData";
      this.SaveData.Size = new System.Drawing.Size(75, 23);
      this.SaveData.TabIndex = 4;
      this.SaveData.Text = "Speichern";
      this.SaveData.UseVisualStyleBackColor = true;
      this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
      // 
      // RemoveAdresse
      // 
      this.RemoveAdresse.Enabled = false;
      this.RemoveAdresse.Location = new System.Drawing.Point(81, 497);
      this.RemoveAdresse.Name = "RemoveAdresse";
      this.RemoveAdresse.Size = new System.Drawing.Size(75, 23);
      this.RemoveAdresse.TabIndex = 7;
      this.RemoveAdresse.Text = "Entfernen";
      this.RemoveAdresse.UseVisualStyleBackColor = true;
      this.RemoveAdresse.Click += new System.EventHandler(this.RemoveAdresse_Click);
      // 
      // FilterText
      // 
      this.FilterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.FilterText.Location = new System.Drawing.Point(180, 16);
      this.FilterText.Name = "FilterText";
      this.FilterText.Size = new System.Drawing.Size(620, 20);
      this.FilterText.TabIndex = 8;
      this.FilterText.TextChanged += new System.EventHandler(this.FilterText_TextChanged);
      // 
      // FilterLabel
      // 
      this.FilterLabel.AutoSize = true;
      this.FilterLabel.Location = new System.Drawing.Point(143, 19);
      this.FilterLabel.Name = "FilterLabel";
      this.FilterLabel.Size = new System.Drawing.Size(29, 13);
      this.FilterLabel.TabIndex = 9;
      this.FilterLabel.Text = "Filter";
      // 
      // AddKunde
      // 
      this.AddKunde.Location = new System.Drawing.Point(0, 248);
      this.AddKunde.Name = "AddKunde";
      this.AddKunde.Size = new System.Drawing.Size(75, 23);
      this.AddKunde.TabIndex = 10;
      this.AddKunde.Text = "Hinzufügen";
      this.AddKunde.UseVisualStyleBackColor = true;
      this.AddKunde.Click += new System.EventHandler(this.AddKunde_Click);
      // 
      // AddAdresse
      // 
      this.AddAdresse.Enabled = false;
      this.AddAdresse.Location = new System.Drawing.Point(0, 497);
      this.AddAdresse.Name = "AddAdresse";
      this.AddAdresse.Size = new System.Drawing.Size(75, 23);
      this.AddAdresse.TabIndex = 11;
      this.AddAdresse.Text = "Hinzufügen";
      this.AddAdresse.UseVisualStyleBackColor = true;
      this.AddAdresse.Click += new System.EventHandler(this.AddAdresse_Click);
      // 
      // Kundenbearbeitung
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 532);
      this.Controls.Add(this.AddAdresse);
      this.Controls.Add(this.AddKunde);
      this.Controls.Add(this.FilterLabel);
      this.Controls.Add(this.FilterText);
      this.Controls.Add(this.RemoveAdresse);
      this.Controls.Add(this.SaveData);
      this.Controls.Add(this.RemoveKunden);
      this.Controls.Add(this.AdressenGrid);
      this.Controls.Add(this.KundenGrid);
      this.Name = "Kundenbearbeitung";
      this.Text = "Kundenbearbeitung";
      ((System.ComponentModel.ISupportInitialize)(this.KundenGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.AdressenGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView KundenGrid;
    private System.Windows.Forms.DataGridView AdressenGrid;
    private System.Windows.Forms.Button RemoveKunden;
    private System.Windows.Forms.Button SaveData;
    private System.Windows.Forms.Button RemoveAdresse;
    private System.Windows.Forms.TextBox FilterText;
    private System.Windows.Forms.Label FilterLabel;
    private System.Windows.Forms.Button AddKunde;
    private System.Windows.Forms.Button AddAdresse;
  }
}

