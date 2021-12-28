using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockerBO;

namespace StockerWinforms
{
    public partial class Facture : Form
    {
        List<Produit> _list;
        string _pFacture;
        string _pidcommande;
        string Filepath;
        DateTime _date;
        public Facture()
        {
            InitializeComponent();
                        
        }
        public Facture(List<Produit> Datasource,string idfacrure,DateTime date,string idcommande,string FilePath)
        {
            InitializeComponent();
            _list = Datasource;
            _pFacture=idfacrure;
            _pidcommande = idcommande;
            _date = date;
            Filepath = FilePath;
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Fac.rdlc";
            this.reportViewer1.RefreshReport();
            bindingSource1.DataSource = _list;
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _list));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = _list;
            this.reportViewer1.LocalReport.ReportPath = Filepath;
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _list));
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pFacture",_pFacture),
                new Microsoft.Reporting.WinForms.ReportParameter("Fdate",_date.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pCommande",_pidcommande),
                //new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date)
            };
            reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
