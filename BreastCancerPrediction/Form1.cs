using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreastCancerPrediction.DAO;
using LiveCharts;

namespace BreastCancerPrediction
{
    public partial class BreastCancer : Form
    {
        Process process = new Process();
        
        
        public BreastCancer()
        {
            InitializeComponent();
        }
        public void DoProcessing(IProgress<int> progress)
        {
            for (int i = 0; i != 100; ++i)
            {
                Thread.Sleep(100);
                if (progress != null)
                    progress.Report(i);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rbdensenet121.Checked = true;
            lableresult.Text = " ";
            lablemodel.Text = " ";
            labelaccuracy.Text = " " + " %";
            lbbenign.Text = " ";
            lbinsitu.Text = " ";
            lbinvasive.Text = " ";
            lbnormal.Text = " ";
        }
       
        private void btn_add_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files (*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pb.ImageLocation = imageLocation;                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pb.Image = null;
            foreach (var series in CChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in PChart.Series)
            {
                series.Points.Clear();
            }
            lableresult.Text = " ";
            lablemodel.Text = " ";
            labelaccuracy.Text = " " + " %";
            lbbenign.Text = " ";
            lbinsitu.Text = " ";
            lbinvasive.Text = " ";
            lbnormal.Text = " ";

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
         void FillChar(float n, float b, float iS, float iV)
        {
            foreach (var series in CChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in PChart.Series)
            {
                series.Points.Clear();
            }
            CChart.Series["Percent %"].Points.AddXY("Normal", n);
            CChart.Series["Percent %"].Points.AddXY("Benign", b);
            CChart.Series["Percent %"].Points.AddXY("InSitu", iS);
            CChart.Series["Percent %"].Points.AddXY("Invasive", iV);
            PChart.Series["Percent %"].Points.AddXY("Normal", n);
            PChart.Series["Percent %"].Points.AddXY("Benign", b);
            PChart.Series["Percent %"].Points.AddXY("InSitu", iS);
            PChart.Series["Percent %"].Points.AddXY("Invasive", iV);
        }

        private void btn_predict_Click(object sender, EventArgs e)
        {
            string modelname = "";
            if (pb.ImageLocation == null)
            {
                MessageBox.Show("Please import the picture to predict !");
            }
            else
            {
                


                if (rbdensenet121.Checked == true)
                {
                    modelname = "Densenet121";
                }
                else if(rbdensenet201.Checked==true)
                {
                    modelname = "Densenet201";
                }
                else
                {
                    modelname = "Xception";
                }
                try
                {
                    var model = process.PostReq(pb.ImageLocation, modelname);
                    FillChar(model.Normal, model.Benign, model.InSitu, model.Invasive);
                    lableresult.Text = model.result.ToString();
                    lablemodel.Text = modelname;
                    labelaccuracy.Text = Math.Round(model.accuracy, 3).ToString() + " %";
                    lbbenign.Text = Math.Round(model.Benign, 3).ToString() + " %";
                    lbinsitu.Text = Math.Round(model.InSitu, 3).ToString() + " %";
                    lbinvasive.Text = Math.Round(model.Invasive, 3).ToString() + " %";
                    lbnormal.Text = Math.Round(model.Normal, 3).ToString() + " %";
                }catch(Exception)
                {
                    MessageBox.Show(" Not API");
                }
                
            }
            
            
            
        }

      
    }
}
