using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using StockerBO;

namespace StockerWinforms
{
    public partial class Facture : Form
    {
        List<Produit> _list;
        List<Stock> _lists;
        string _pFacture;
        string _pidcommande;
        string Filepath;
        DateTime _date;
        string avail;
        public Facture()
        {
            InitializeComponent();
                        
        }

        public Facture(List<Stock> lists, string filepath, DateTime date,string ava)
        {
            InitializeComponent();
            _lists = lists;
            Filepath = filepath;
            _date = date;
            avail = ava;
        }

        public Facture(List<Produit> Datasource,string idfacrure,DateTime date,string idcommande,string FilePath,string ava)
        {
            InitializeComponent();
            _list = Datasource;
            
            _pFacture=idfacrure;
            _pidcommande = idcommande;
            _date = date;
            Filepath = FilePath;
            avail = ava;
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = Filepath;
            
            this.reportViewer1.RefreshReport();
            bindingSource1.DataSource = _list;
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _list));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //bindingSource1.DataSource = _list;
            //bindingSource1.DataSource = _lists;
            this.reportViewer1.LocalReport.ReportPath = Filepath;
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _list));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _lists));
                if (avail == "facture")
                {
                        Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                        {
                        new Microsoft.Reporting.WinForms.ReportParameter("pFacture",_pFacture),
                        new Microsoft.Reporting.WinForms.ReportParameter("Fdate",_date.ToString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("pCommande",_pidcommande),
                       //new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date)
                        };
                    reportViewer1.LocalReport.SetParameters(para);
                }
                else if (avail == "stock")
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] paras = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        
                        new Microsoft.Reporting.WinForms.ReportParameter("Sdate",_date.ToString())
                        //new Microsoft.Reporting.WinForms.ReportParameter("pCommande",_pidcommande),
                        //new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date)
                    };
                    reportViewer1.LocalReport.SetParameters(paras);
                }


            this.reportViewer1.RefreshReport();
        }
    }
}
