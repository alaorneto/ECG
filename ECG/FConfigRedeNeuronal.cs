using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ECG.Framework;
using ECG.Framework.IA;

namespace ECG
{
    public partial class FConfigRedeNeuronal : Form
    {
        public FConfigRedeNeuronal()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FConfigRedeNeuronal_Load(object sender, EventArgs e)
        {
            AtualizarCombos();
        }

        private void buttonQRSCarregar_Click(object sender, EventArgs e)
        {
            DatabaseEntities entities = new DatabaseEntities();

            var query = from c in entities.CONFIG
                        where c.onda == "QRS"
                        select c;

            if (entities.CONFIG.Count(c => c.onda == "QRS") == 0)
            {
                CONFIG conf = new CONFIG();
                conf.onda = "QRS";
                conf.descr = comboBoxQRS.SelectedItem.ToString();
                entities.AddToCONFIG(conf);
                entities.SaveChanges();
            }
            else
            {
                CONFIG conf = (CONFIG)query.First();

                conf.descr = comboBoxQRS.SelectedItem.ToString();

                entities.SaveChanges();
            }

            MessageBox.Show("Rede carregada com sucesso!");
        }

        private void buttonQRSSalvar_Click(object sender, EventArgs e)
        {
            RedeAtivacao rede = new RedeAtivacao(new SigmoideFuncaoAtivacao(), int.Parse(textBoxQRSEntradas.Text), Utils.StringToInt(textBoxQRSNeuronios.Text));
            RedeServices service = new RedeServices();
            rede.Descricao = textBoxQRSDesc.Text;
            rede.Aleatorizar();
            service.Salvar(rede, RedeServices.Tipo.Ativacao, "QRS");
            MessageBox.Show("Rede salva com sucesso!");
            textBoxQRSDesc.Text = "";
            textBoxQRSEntradas.Text = "";
            textBoxQRSNeuronios.Text = "";

            AtualizarCombos();
        }

        private void AtualizarCombos()
        {
            DatabaseEntities entities = new DatabaseEntities();
            List<string> descsQRS = new List<string>();

            var queryqrs = from r in entities.REDE
                        where r.onda == "QRS"
                        select r;


            foreach (REDE r in queryqrs)
                descsQRS.Add(r.descricao);

            comboBoxQRS.DataSource = descsQRS;
            if(ECGConfig.RedeQRS() != null)
                comboBoxQRS.SelectedItem = ECGConfig.RedeQRS().Descricao;

            List<string> descsT = new List<string>();

            var queryt = from r in entities.REDE
                        where r.onda == "T"
                        select r;

            foreach (REDE r in queryt)
                descsT.Add(r.descricao);

            comboBoxT.DataSource = descsT;
            if(ECGConfig.RedeT() != null)
                comboBoxT.SelectedItem = ECGConfig.RedeT().Descricao;
        }

        private void buttonTSalvar_Click(object sender, EventArgs e)
        {
            RedeAtivacao rede = new RedeAtivacao(new SigmoideFuncaoAtivacao(), 
                int.Parse(textBoxTEntradas.Text), Utils.StringToInt(textBoxTNeuronios.Text));
            RedeServices service = new RedeServices();
            rede.Descricao = textBoxTDesc.Text;
            rede.Aleatorizar();
            service.Salvar(rede, RedeServices.Tipo.Ativacao, "T");
            MessageBox.Show("Rede salva com sucesso!");
            textBoxTDesc.Text = "";
            textBoxTEntradas.Text = "";
            textBoxTNeuronios.Text = "";

            AtualizarCombos();
        }

        private void buttonTCarregar_Click(object sender, EventArgs e)
        {
            DatabaseEntities entities = new DatabaseEntities();

            var query = from c in entities.CONFIG
                        where c.onda == "T"
                        select c;

            if (entities.CONFIG.Count(c => c.onda == "T") == 0)
            {
                CONFIG conf = new CONFIG();
                conf.onda = "T";
                conf.descr = comboBoxT.SelectedItem.ToString();
                entities.AddToCONFIG(conf);
                entities.SaveChanges();
            }
            else
            {
                CONFIG conf = (CONFIG)query.First();

                conf.descr = comboBoxT.SelectedItem.ToString();

                entities.SaveChanges();
            }

            MessageBox.Show("Rede carregada com sucesso!");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
