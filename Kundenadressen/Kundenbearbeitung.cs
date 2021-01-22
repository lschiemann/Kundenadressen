using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Kundenadressen
{
  public partial class Kundenbearbeitung : Form
  {
    private readonly DataContext _context;
    private readonly IList<Kunde> _data;
    private BindingList<Kunde> _filteredKunden;
    private BindingList<Adresse> _currentAdressen;

    public Kundenbearbeitung(DataContext context)
    {
      InitializeComponent();

      //used dependency injection for being better testable
      _context = context;

      _data = _context.Load();

      //fill kunden grid with data from json file
      //there are many other ways to fill a grid, e.g. https://www.c-sharpcorner.com/UploadFile/deveshomar/ways-to-bind-datagridview-in-window-forms-C-Sharp/ but this was the easiest way with minimal overhead
      _filteredKunden = new BindingList<Kunde>(_data.ToList()); //make a copy here
      KundenGrid.DataSource = _filteredKunden;

      if (_filteredKunden.Count > 0)
      {
        KundenGrid.Rows[0].Selected = true;
      }
    }

    private void RemoveKunden_Click(object sender, EventArgs e)
    {
      var kunde = (Kunde)KundenGrid.SelectedRows[0].DataBoundItem;
      _filteredKunden.Remove(kunde);
      _data.Remove(kunde);
    }

    private void RemoveAdresse_Click(object sender, EventArgs e)
    {
      var adresse = (Adresse)AdressenGrid.SelectedRows[0].DataBoundItem;
      _currentAdressen.Remove(adresse);
    }

    private void SaveData_Click(object sender, EventArgs e)
    {
      _context.Save(_filteredKunden);
    }

    private void FilterText_TextChanged(object sender, EventArgs e)
    {
      var filterText = FilterText.Text.ToLower();
      var filtered = _data.Where(k => k.Name.ToLower().Contains(filterText) || k.Adressen.Any(a => a.Strasse.ToLower().Contains(filterText) || a.PLZ.ToLower().Contains(filterText) || a.Ort.ToLower().Contains(filterText)));

      _filteredKunden = new BindingList<Kunde>(filtered.ToList());
      KundenGrid.DataSource = _filteredKunden;
    }

    private void AddKunde_Click(object sender, EventArgs e)
    {
      var kunde = new Kunde();
      _filteredKunden.Add(kunde);
      _data.Add(kunde);
    }

    private void AddAdresse_Click(object sender, EventArgs e)
    {
      _currentAdressen.Add(new Adresse());
    }

    private void KundenGrid_SelectionChanged(object sender, EventArgs e)
    {
      if (KundenGrid.SelectedRows.Count == 0)
      {
        ClearAdressenGrid();
        DisableAllSelectionDependentControls();
        return;
      }

      var kunde = (Kunde)KundenGrid.SelectedRows[0].DataBoundItem;

      //fill adressen grid with adressen of selected kunde
      _currentAdressen = new BindingList<Adresse>(kunde.Adressen);
      AdressenGrid.DataSource = _currentAdressen;

      //allow user interaction with selection dependent ui elements
      RemoveKunden.Enabled = true;
      AdressenGrid.Enabled = true;
      AddAdresse.Enabled = true;
    }

    private void AdressenGrid_SelectionChanged(object sender, EventArgs e)
    {
      if (AdressenGrid.SelectedRows.Count == 0)
      {
        DisableAdressenSelectionDependentControls();
        return;
      }

      RemoveAdresse.Enabled = true;
    }

    private void ClearAdressenGrid()
    {
      AdressenGrid.DataSource = null;
    }

    private void DisableAllSelectionDependentControls()
    {
      RemoveKunden.Enabled = false;
      AdressenGrid.Enabled = false;
      AddAdresse.Enabled = false;
      DisableAdressenSelectionDependentControls();
    }

    private void DisableAdressenSelectionDependentControls()
    {
      RemoveAdresse.Enabled = false;
    }
  }
}
