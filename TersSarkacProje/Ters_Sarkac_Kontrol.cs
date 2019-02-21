using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotFuzzy;
using ZedGraph;

namespace TersSarkacProjeFormUygulamasi
{
    public partial class Ters_Sarkac_Kontrol : Form
    {

        FuzzyEngine fengine = new FuzzyEngine();

        CurveItem aciEgrisi;
        CurveItem hizEgrisi;
        CurveItem momentEgrisi;

        PointPairList aciliste = new PointPairList();
        PointPairList hizliste = new PointPairList();
        PointPairList momentliste = new PointPairList();
        bool notfirst = false;


        public Ters_Sarkac_Kontrol()
        {
            InitializeComponent();
            
            fengine.Load("TersSarkac1.xml");
            
            GraphPane levha = zedGraphControl1.GraphPane;
            // Set the titles
            levha.Title.Text = "Ters Sarkaç";
            levha.XAxis.Title.Text = "Zaman";
            //            myPane.YAxis.Title.Text = "Axis";

        }

        void InitFuzzySystem()
        {
            LinguisticVariable aci = new LinguisticVariable("aci");
            LinguisticVariable hiz = new LinguisticVariable("hiz");
            LinguisticVariable moment = new LinguisticVariable("moment");

            aci.MembershipFunctionCollection.Add(new MembershipFunction("Negatif", -180, -2, -2, 0));
            aci.MembershipFunctionCollection.Add(new MembershipFunction("Sifir", -2, 0, 0, 2));
            aci.MembershipFunctionCollection.Add(new MembershipFunction("Pozitif", 0, 2, 2, 180));

            hiz.MembershipFunctionCollection.Add(new MembershipFunction("Negatif", -1000, -5, -5, 0));
            hiz.MembershipFunctionCollection.Add(new MembershipFunction("Sifir", -5, 0, 0, 5));
            hiz.MembershipFunctionCollection.Add(new MembershipFunction("Pozitif", 0, 5, 5, 1000));

            moment.MembershipFunctionCollection.Add(new MembershipFunction("NegatifBuyuk", -24, -16, -16, -8));
            moment.MembershipFunctionCollection.Add(new MembershipFunction("Negatif", -16, -8, -8, 0));
            moment.MembershipFunctionCollection.Add(new MembershipFunction("Sifir", -8, 0, 0, 8));
            moment.MembershipFunctionCollection.Add(new MembershipFunction("Pozitif", 0, 8, 8, 16));
            moment.MembershipFunctionCollection.Add(new MembershipFunction("PozitifBuyuk", 8, 16, 16, 24));

            fengine.LinguisticVariableCollection.Add(aci);
            fengine.LinguisticVariableCollection.Add(hiz);
            fengine.LinguisticVariableCollection.Add(moment);
            fengine.Consequent = "Moment";
            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Negatif) AND (hiz IS Negatif) THEN Moment IS NegatifBuyuk"));

            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Pozitif) AND (hiz IS Sifir) THEN Moment IS Pozitif"));
            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Sifir) AND (hiz IS Pozitif)  THEN Moment IS Pozitif"));

            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Negatif) AND (hiz IS Sifir) THEN Moment IS Negatif"));
            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Sifir) AND (hiz IS Negatif) THEN Moment IS Negatif"));

            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Negatif) AND (hiz IS Pozitif) THEN Moment IS Sifir"));
            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Pozitif) AND (hiz IS Negatif) THEN Moment IS Sifir"));
            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Sifir) AND (hiz IS Sifir)  THEN Moment IS Sifir"));

            fengine.FuzzyRuleCollection.Add(new FuzzyRule("IF (aci IS Pozitif) AND (hiz IS Pozitif) THEN Moment IS PozitifBuyuk"));
            


        }
        private void btnSimBaslat_Click(object sender, EventArgs e)
        {
            InitFuzzySystem();
            LinguisticVariable aci;
            LinguisticVariable hiz;
            double a = double.Parse(txtIlkAci.Text);
            double v = double.Parse(textBox2.Text);
            double m = 0;

            aci = fengine.LinguisticVariableCollection[0];
            hiz = fengine.LinguisticVariableCollection[1];

            aci.InputValue = a;
            hiz.InputValue = v;
            string s;

            listBox1.Items.Clear();
            //            


            aciliste.Clear();
            hizliste.Clear();
            momentliste.Clear();
            if (notfirst)
            {
                aciEgrisi.Clear();
                hizEgrisi.Clear();
                momentEgrisi.Clear();

            }
            else
            {
                notfirst = true;
                aciEgrisi = zedGraphControl1.GraphPane.AddCurve("AÇI", aciliste, Color.Green, SymbolType.Diamond);
                hizEgrisi = zedGraphControl1.GraphPane.AddCurve("HIZ", hizliste, Color.Blue, SymbolType.Diamond);
                momentEgrisi = zedGraphControl1.GraphPane.AddCurve("MOMENTUM", momentliste, Color.Red, SymbolType.Diamond);
            }

            aciliste.Add(0, a);
            hizliste.Add(0, v);
            momentliste.Add(0, m);


            for (int i = 1; i < 20; i++)
            {
                try
                {
                    m = fengine.Defuzzify();
                    s = String.Format("AÇI : {0:f2} \t HIZ : {1:f2} \t MOMENT : {2:f2}", a, v, m);

                    aciliste.Add(i, a);
                    hizliste.Add(i, v);
                    momentliste.Add(i, m);
                    listBox1.Items.Add(s);
                    aci.InputValue = a + v;
                    hiz.InputValue = a + v - m;
                    a = aci.InputValue;
                    v = hiz.InputValue;



                    zedGraphControl1.Refresh();
                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Refresh();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }
            }
        }
        private void btnModelYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "*.Xml";
            if (op.ShowDialog() == DialogResult.OK)
            {
                fengine = new FuzzyEngine();
                fengine.Load(op.FileName);

            }

        }
      
    



    }
}
