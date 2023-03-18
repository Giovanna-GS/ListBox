using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }
        //aréa reservada para declarar variaveis globais 
        int flag = 0; //flag para botão que add itens inseridos pelo usuario

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            string[] bichos = new string[7] { "Gato", "Cobra", "Macaco", "Baleia", "Cachorro", "Golfinho", "Lobo" };
            cmbAnimais.Items.Add("Burro");//adicionar um item no comboBox
            cmbAnimais.Items.AddRange(bichos);//adicionar todos os itens da array no comboBox
        }

        private void btnGeraNovaLista_Click(object sender, EventArgs e)
        {
            cmbAnimais.Items.Clear();
            cmbAnimais.Text= string.Empty; //limpa itens que estão selecionado 
            string[] lugares = new string[7] { "Paris", "Nova York", "Barcelona", "Roma", "Rio de Janeiro", "Tóquio", "Viena" };
            cmbAnimais.Items.AddRange(lugares);
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(flag == 0) 
            {
                //limpa lista para add itens do usuario
                cmbAnimais.Items.Clear();
                cmbAnimais.Text= string.Empty;

                //sinal para indicar se a lista deve ser limpa ou nao 
                flag = 1;

                //adicionar item
                cmbAnimais.Items.Add(txtItem.Text);
                txtItem.Text= string.Empty;
                txtItem.Focus();
            }
            else
            {
                //adicionar item
                cmbAnimais.Items.Add(txtItem.Text);
                txtItem.Text= string.Empty;
                txtItem.Focus();
            }

        }


        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            cmbAnimais.Items.Clear();
            cmbAnimais.Text = string.Empty;
            string[] alimentos = new string[7] { "Pizza", "Salgadinho", "Macarrao", "Sopa", "Batata Frita", "Hot Dog", "Pure" };
            cmbAnimais.Items.AddRange(alimentos);
        }

        private void lstAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAnimais.Items.Add(cmbAnimais.SelectedItem);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Clear();
            
        }

        private void btnRemoverSelect_Click(object sender, EventArgs e)
        {
            for(int i = lstAnimais.SelectedIndices.Count -1; i >= 0; i--)
            {
                lstAnimais.Items.RemoveAt(lstAnimais.SelectedIndices[i]);
        }    /* É possivel selecionar varios itens de uma vez ajustando a propriedade SelectiontMode da caixa de listagem
             * None= Não é possivel selecionar nenhum item
             * One = selecionar apenas um item
             * MultiSimple = selecionar varios itens (CTRL)
             * MultiExtended = Selecionar varios itens e o usuario pode usar SHIFT, CTRL e as telas de setas para fazer a seleção*/
            }
        private void btnDesselecionar_Click(object sender, EventArgs e)
        {
            //Desselecionar todos os itens da ListBox de uma vez
            for(int x = 0; x < lstAnimais.Items.Count; x++)
            {
                lstAnimais.SetSelected(x, false);
            }
        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            lstAnimais.Sorted= true;

        }

        private void btnSelecionarTudo_Click(object sender, EventArgs e)
        {
            lstAnimais.BeginUpdate();
            for (int x = 0; x < lstAnimais.Items.Count; x++)
            {
                lstAnimais.SetSelected(x, true);
            }
            lstAnimais.EndUpdate();//
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumeros_Click(object sender, EventArgs e)
        {

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int limite;
            bool eNumero = int.TryParse(txtNumeros.Text.Trim(), out limite);
            if (eNumero)
            {
                lstAnimais.Items.Clear();
                for(int a = 1; a <= limite; a++)
                {
                    lstNumeros.Items.Add(a);
                }
            }
            else
                {
                    MessageBox.Show("Digite um número!", "Valor invalido");
                    txtNumeros.Focus();
                }
            
        }

        private void btnLimparNum_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
        }
    }
}
