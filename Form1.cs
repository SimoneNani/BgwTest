using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Threading;

namespace BgwTest
{
    public partial class frmMain : Form
    {
        BackgroundWorker bwg1, bwg2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnAvvio100.Text = "Avvio 100";
            btnAvvio2.Text = "Avvio 2";
            btnStop100.Text = "Stop 100";
            btnStop2.Text = "Stop 2";

        }

        private void btnAvvio2_Click(object sender, EventArgs e)
        {
            bwg1 = new BackgroundWorker();
            bwg1.WorkerReportsProgress = true;
            bwg1.WorkerSupportsCancellation = true;
            bwg1.DoWork += Bwg_DoWork;
            bwg1.RunWorkerCompleted += Bwg_RunWorkerCompleted;
            bwg1.ProgressChanged += Bwg_ProgressChanged;

            bwg2 = new BackgroundWorker();
            bwg2.WorkerReportsProgress = true;
            bwg2.WorkerSupportsCancellation = true;
            bwg2.DoWork += Bwg_DoWork;
            bwg2.RunWorkerCompleted += Bwg_RunWorkerCompleted;
            bwg2.ProgressChanged += Bwg_ProgressChanged;

            bwg1.RunWorkerAsync(txtavvio2);
            bwg2.RunWorkerAsync(txtavvio2);
            
        }


        private void Bwg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TextBox tb = e.UserState as TextBox;
            tb.Text = e.ProgressPercentage + Environment.NewLine + tb.Text;
        }

        private void Bwg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var (completato, tb) = (ValueTuple<bool, TextBox>)e.Result;
            tb.Text = completato ? "concluso" + Environment.NewLine + tb.Text :
                "cancellato" + Environment.NewLine + tb.Text;
        }
        private void btnStop2_Click(object sender, EventArgs e)
        {
            bwg1.CancelAsync();
            bwg2.CancelAsync();
        }

        BackgroundWorker [] v = new BackgroundWorker[100];
        private void btnAvvio100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                BackgroundWorker bwg1 = new BackgroundWorker();
                bwg1.WorkerReportsProgress = true;
                bwg1.WorkerSupportsCancellation = true;
                bwg1.DoWork += Bwg_DoWork;
                bwg1.RunWorkerCompleted += Bwg_RunWorkerCompleted;
                bwg1.ProgressChanged += Bwg_ProgressChanged;
                v[i] = bwg1;
            }
            foreach (var bwg in v)
            {
                bwg.RunWorkerAsync(txtAvvia100);
            }
        }

        private void btnStop100_Click(object sender, EventArgs e)
        {
            foreach (var bwg in v)
            {
                bwg.CancelAsync();
            }
        }
        private void Bwg_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bwg = sender as BackgroundWorker;
            TextBox tb = e.Argument as TextBox;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                bwg.ReportProgress(i,tb);
                if (bwg.CancellationPending)
                {
                    e.Result=(false,tb);
                    return;
                }
                e.Result= (true,tb);
            }
        }
    }
}
