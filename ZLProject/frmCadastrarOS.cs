using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;
using System.Linq;

namespace ZLProject
{
    public partial class frmCadastrarOS : Form
    {
        decimal total = 0;
        int i = 0;

        public frmCadastrarOS()
        {
            InitializeComponent();
        }

        double valor;

        private void frmCadastrarOS_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String date = now.GetDateTimeFormats('d')[0];
            txtDataOS.Text = date;

            //Instanciar objeto
            PesquisaClienteOS pesquisaclienteos = new PesquisaClienteOS();
            ClientesDTO dados = new ClientesDTO();

            //recebe dados do combobox
            dados.Nome = "";

            //executa o método
            pesquisaclienteos.CarregarCOMBOBOXClientes(dados);



            //carrega o dados do DataTable atraves de um loop
            /*foreach (DataRow linha in pesquisaclienteos.ClientesDataTableOS.Rows)
            {
                //Popula o ComboBox
                cmbCarregarClientes.Items.Add(linha.ItemArray[0]);

            }*/

            //Instanciar objeto
            PesquisaProdutosOS pesquisaprodutosos = new PesquisaProdutosOS();
            ProdutosDTO dadosproduto = new ProdutosDTO();

            //recebe dados do combobox
            dadosproduto.Descricao = "";

            //executa o método
            pesquisaprodutosos.CarregarCOMBOBOXProdutos(dadosproduto);


            //carrega o dados do DataTable atraves de um loop
            /*foreach (DataRow linha in pesquisaprodutosos.ProdutosDataTableOS.Rows)
            {
                //Popula o ComboBox
                cmbCarregarProdutos.Items.Add(linha.ItemArray[1]);

            }*/


        }


        private void cmbCarregarClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            //instancia o objeto
            PesquisaClienteOS popularclientesOS = new PesquisaClienteOS();
            ClientesDTO dados = new ClientesDTO();

            //recebe dados do combobox
            dados.Nome = cmbCarregarClientes.Text;

            //executa o método
            popularclientesOS.CarregarCOMBOBOXClientes(dados);

            //limpa os txt's
            txtEnderecoOS.Clear();
            txtBairroOS.Clear();
            txtCEPOS.Clear();
            txtCNPJOS.Clear();
            txtEmailOS.Clear();
            txtEmail_2OS.Clear();
            txtEstadoOS.Clear();
            txtIEOS.Clear();
            txtMunicipioOS.Clear();
            txtTelefone2OS.Clear();
            txtTelefoneOS.Clear();


            foreach (DataRow linha in popularclientesOS.ClientesDataTableOS.Rows)
            {



                //Popula os txt's

                txtEnderecoOS.Text = linha.ItemArray[2].ToString();
                txtBairroOS.Text = linha.ItemArray[4].ToString();
                txtCEPOS.Text = linha.ItemArray[3].ToString();
                txtCNPJOS.Text = linha.ItemArray[1].ToString();
                txtEmailOS.Text = linha.ItemArray[10].ToString();
                txtEmail_2OS.Text = linha.ItemArray[11].ToString();
                txtEstadoOS.Text = linha.ItemArray[6].ToString();
                txtIEOS.Text = linha.ItemArray[7].ToString();
                txtMunicipioOS.Text = linha.ItemArray[5].ToString();
                txtTelefone2OS.Text = linha.ItemArray[9].ToString();
                txtTelefoneOS.Text = linha.ItemArray[8].ToString();



            }
        }

        private void cmbCarregarClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProdutos_SelectedValueChanged(object sender, EventArgs e)
        {
            //instancia o objeto
            PesquisaProdutosOS popularprodutosOS = new PesquisaProdutosOS();
            ProdutosDTO dados = new ProdutosDTO();

            //recebe dados do combobox
            dados.Descricao = cmbCarregarProdutos.Text;

            //executa o método
            popularprodutosOS.CarregarCOMBOBOXProdutos(dados);

            /*faz a limpeza do campo de quantidade e após a seleção de outro produto
               faz um tab direto para o txtquantidade */

            txtQuantidade.Clear();
            txtQuantidade.Focus();

            foreach (DataRow linha in popularprodutosOS.ProdutosDataTableOS.Rows)
            {








            }


        }

        public void MultiplicaGrid()
        {
            int x = dgvAddProdutos.Rows.Count - 2;

            for (i = 0; i < dgvAddProdutos.Rows.Count; i++)
            {

                if (i == x)
                {
                    total = total + Convert.ToDecimal(dgvAddProdutos.Rows[i].Cells["Valor"].Value) * Convert.ToDecimal(dgvAddProdutos.Rows[i].Cells["Qtd"].Value);

                }

            }


            txtTotal.Text = total.ToString();

        }

        private void calculaValorTotalGrid()
        {
            /*     if (dgvAddProdutos.Rows.Count > 0)
                     txtTotal.Text = Convert.ToDouble(total).ToString("C");*/
        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
              {
                // instanciar o objeto
                ConsultarProdutos PesquisarProdutos = new ConsultarProdutos();
                ProdutosDTO dados = new ProdutosDTO();

                if (txtQuantidade.Text == string.Empty)
                {
                    MessageBox.Show("Favor inserir uma quantidade para os produtos.", "Aviso");
                }

                else
                {

                    //Receber os dados do txtnome
                    dados.Descricao = cmbCarregarProdutos.Text;

                    //executar o método
                    PesquisarProdutos.CarregarGrid(dados);

                    //Carregar o grid com os dados do
                    //DataTable, através de um loop
                    foreach (DataRow linha in PesquisarProdutos.ProdutosDataTable.Rows)

                    {
                        //popular o grid
                        dgvAddProdutos.Rows.Add(linha.ItemArray[1], linha.ItemArray[2], linha.ItemArray[3], txtQuantidade.Text);



                    }



                    MultiplicaGrid();
                    //     calculaValorTotalGrid();
                }

            }
        }

        private void dgvAddProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCarregarProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            // Deleta a linha quando a contagem de linhas for maior que 1
            if (dgvAddProdutos.Rows.Count > 1)
            {

                dgvAddProdutos.Rows.Remove(dgvAddProdutos.Rows[dgvAddProdutos.CurrentRow.Index]);

            }
            else
            {

                MessageBox.Show("Não é possível apagar uma linha em branco!", "Aviso");

            }
        }

        /*public void LimparOS(Control controle)
        {
            foreach (Control ctle in controle.Controls)
            {
                if (ctle is TextBox)
                {
                    ((TextBox)ctle).Text = string.Empty;
                }
                else if (ctle.Controls.Count > 0)
                {
                    LimparOS(ctle);
                }
            }
        }*/
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //LimparOS(this);
            dgvAddProdutos.Rows.Clear();

            txtEnderecoOS.Clear();
            txtCNPJOS.Clear();
            txtMunicipioOS.Clear();
            txtBairroOS.Clear();
            txtIEOS.Clear();
            txtEstadoOS.Clear();
            txtCEPOS.Clear();
            txtTelefoneOS.Clear();
            txtTelefone2OS.Clear();
            txtEmailOS.Clear();
            txtEmail_2OS.Clear();


            txtQuantidade.Clear();
            txtTotal.Clear();
            txtOcorrenciaOS.Clear();
            txtFormaPag.Clear();
            txtEmitidopor.Clear();
            txtTecnico.Clear();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIndex frmindex = new FrmIndex();
            frmindex.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor = double.Parse(txtTotal.Text);
                txtTotal.Text = valor.ToString("C");
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                                
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var textOSTitle = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var txtTitles = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var txtSubTitles = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var txtSubTitles2 = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);

                var font = new PdfSharp.Drawing.XFont("Arial", 25);
                var fontTitle = new PdfSharp.Drawing.XFont("Coolvetica", 12);
                var fontSubTitle = new PdfSharp.Drawing.XFont("Coolvetica", 10);
                var fontSubTitle2 = new PdfSharp.Drawing.XFont("Coolvetica", 13);
                var fontTxts = new PdfSharp.Drawing.XFont("Arial", 20);

                //Logo ZL
                graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile(@"C:\Users\gabri\OneDrive\Documentos\Visual Studio 2019\ZL-Project\ZLProjectV13\ZLProject\ZLProject\img\zlBalacasLOGO.png"), 175, 10, 50, 70);

                //Primerio Título
                textOSTitle.DrawString("Ordem de Serviço - OS", fontTitle, PdfSharp.Drawing.XBrushes.LightGray, new PdfSharp.Drawing.XRect(400, 10, page.Width, page.Height));
                textOSTitle.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;

                //Cabeçalho
                textFormatter.DrawString("Z.L. Balanças ME", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(235, 43, page.Width, page.Height));
                textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;

                //Sub-Títulos
                txtSubTitles2.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                txtSubTitles2.DrawString("Assistência Técnica de Balanças e Máquinas", fontSubTitle2, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 85, page.Width - 60, page.Height - 60));

                //Sub-Títulos
                txtSubTitles.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                txtSubTitles.DrawString("Manutenção de Balanças Mecânicas, Eletrônicas, Comerciais e Industriais", fontSubTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 102, page.Width - 60, page.Height - 60));

                //Sub-Títulos
                txtSubTitles.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                txtSubTitles.DrawString("Vendas e Automação Comercial        Cel: (11) 99388-7206", fontSubTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 117, page.Width - 60, page.Height - 60));

                //Sub-Títulos
                txtSubTitles.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                txtSubTitles.DrawString("CNPJ: 07.048.933 / 0001 - 06    IE: 336.737.460.116", fontSubTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 133, page.Width - 60, page.Height - 60));

                //Linha de divisão
                //graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 100, 100, 100, 100);

                //Graphics gs = this.CreateGraphics();
                //Brush brush = new SolidBrush(Color.Black);
                //Pen pen = new Pen(brush);
                //gs.DrawLine(pen, new Point(200, 100), new Point(200, 100));


                //TXts Nome
                textOSTitle.DrawString("Nome:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-240, 170, page.Width, page.Height));
                txtTitles.DrawString(cmbCarregarClientes.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(85, 170, page.Width, page.Height));

                //TXts Endereço
                textOSTitle.DrawString("Endereço:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-230, 190, page.Width, page.Height));
                txtTitles.DrawString(txtEnderecoOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(100, 190, page.Width, page.Height));
                
                //TXts Estado
                textOSTitle.DrawString("Estado:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(100, 190, page.Width, page.Height));
                txtTitles.DrawString(txtEstadoOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(430, 190, page.Width, page.Height));
                
                //TXts Bairro
                textOSTitle.DrawString("Bairro:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-240, 210, page.Width, page.Height));
                txtTitles.DrawString(txtBairroOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(85, 210, page.Width, page.Height));

                //TXts CNPJ
                textOSTitle.DrawString("CNPJ:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(94.5, 210, page.Width, page.Height));
                txtTitles.DrawString(txtCNPJOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(415, 210, page.Width, page.Height));
  
                //TXts Município
                textOSTitle.DrawString("Município:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-230, 230, page.Width, page.Height));
                txtTitles.DrawString(txtMunicipioOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(100, 230, page.Width, page.Height));

                //TXts CEP
                textOSTitle.DrawString("CEP:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(94.1, 230, page.Width, page.Height));
                txtTitles.DrawString(txtCEPOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(415, 230, page.Width, page.Height));

                //TXts Data
                textOSTitle.DrawString("IE:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(95, 270, page.Width, page.Height));
                txtTitles.DrawString(txtIEOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(415, 270, page.Width, page.Height));

                //TXts Email 1
                textOSTitle.DrawString("Email:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-240, 250, page.Width, page.Height));
                txtTitles.DrawString(txtEmailOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(85, 250, page.Width, page.Height));

                //TXts Email 2
                textOSTitle.DrawString("/", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(13, 250, page.Width, page.Height));
                txtTitles.DrawString(txtEmail_2OS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(330, 250, page.Width, page.Height));


                //TXts Telefone  
                textOSTitle.DrawString("Celular:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-235, 290, page.Width, page.Height));
                txtTitles.DrawString(txtTelefoneOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(95, 290, page.Width, page.Height));

                //TXts IE
                textOSTitle.DrawString("Telefone:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-230, 270, page.Width, page.Height));
                txtTitles.DrawString(txtTelefone2OS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(100, 270, page.Width, page.Height));

                //TXts Celular
                textOSTitle.DrawString("Data:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(102, 290, page.Width, page.Height));
                txtTitles.DrawString(txtDataOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, 290, page.Width, page.Height));

                //E-mail para contato
                //textOSTitle.DrawString("Forma de Pagamento:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-195, 309, page.Width, page.Height));
                //txtTitles.DrawString(txtFormaPag.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(170, 309, page.Width, page.Height));
                
                //Titulo Ocorrências 
                textFormatter.DrawString("Ocorrências:", fontSubTitle2, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-215, 350, page.Width, page.Height));

                //TXTs Ocorrências 
                txtTitles.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
                txtTitles.DrawString(txtOcorrenciaOS.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(35, 370, page.Width - 90, page.Height - 90));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 370, 520, 110)); //MAX 120

                //TXTs Produtos
                textFormatter.DrawString("Qtd", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-255, 500, page.Width, page.Height));
                textFormatter.DrawString("Descrição", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-200, 500, page.Width, page.Height));
                textFormatter.DrawString("Unitário R$", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(105, 500, page.Width, page.Height));
                textFormatter.DrawString("Valor Total R$", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(213, 500, page.Width, page.Height));

                //Retangulos dos produtos - 1º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 520, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 520, 300, 18));
                                
                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 520, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 520, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                /*//Retangulos dos produtos - 2º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 538, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 538, 155, 18));
                               
                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 538, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 538, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                /*//Retangulos dos produtos - 3º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 556, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 556, 155, 18));
                                
                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 556, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 556, 80, 18));


                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                /*//Retangulos dos produtos - 4º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 574, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 574, 155, 18));
                                
                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 574, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 574, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                /*//Retangulos dos produtos - 5º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 592, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 592, 155, 18));

                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 592, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 592, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                /*//Retangulos dos produtos - 6º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 610, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 610, 155, 18));

                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 610, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 610, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                /*//Retangulos dos produtos - 7º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 628, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 628, 155, 18));

                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 628, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 628, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                /*//Retangulos dos produtos - 8º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 646, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 646, 155, 18));

                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 646, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 646, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

               /* //Retangulos dos produtos - 9º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 664.10, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 664.10, 155, 18));

                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 664.10, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 664.10, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                //Retangulos dos produtos - 10º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 682, 33, 18));

                //Descrição
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(67, 682, 155, 18));
                textFormatter.DrawString("M/O Conserto:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-155, 685, page.Width - 60, page.Height - 60));


                //Equipamento
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(223, 682, 145, 18));

                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 682, 105, 18));

                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 682, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                //Retangulos dos produtos - 11º linha
                //Garantia do Conserto
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 711.3, 334, 18));
                textFormatter.DrawString("Garantia do Conserto: 90 dias", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-150, 712, page.Width - 60, page.Height - 60));
            
                //Unitário R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(367, 711.3, 105, 18));
                textFormatter.DrawString("Total Nota:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(135, 712, page.Width - 60, page.Height - 60));


                //Valor total R$
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(472, 711.3, 80, 18));

                /*------------------------------------------------------------------------------------------------------------------------------------------*/

                //Retangulos dos produtos - 12  º linha
                //Quantidade
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(33, 730, 519, 18));
                textFormatter.DrawString("Forma de Pgto.:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-185, 732, page.Width - 60, page.Height - 60));
                textFormatter.DrawString(txtFormaPag.Text, fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-90, 733, page.Width - 60, page.Height - 60));
                
                /*------------------------------------------------------------------------------------------------------------------------------------------*/
                
                //Técnico 
                textFormatter.DrawString("Técnico:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(-180, 790, page.Width - 60, page.Height - 60));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(115, 800, 150, 1));

                //Cliente
                textFormatter.DrawString("Cliente:", fontTitle, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(90, 790, page.Width - 60, page.Height - 60));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(385, 800, 150, 1));

                //Final OS - Endereço Z.  L. Balanças
                textFormatter.DrawString("Rua Sombrio, 45 - Vila Isabel - Guarulhos/SP - CEP: 07241-380", fontTitle, PdfSharp.Drawing.XBrushes.DarkGray, new PdfSharp.Drawing.XRect(30, 818, page.Width - 60, page.Height - 60));
                               
                //Retangulos - Caixas onde estão as TXTs
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 168, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 188, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 208, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 228, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 248, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 268, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 288, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.DarkGray, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 816, 520, 18));
                graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.Transparent, new PdfSharp.Drawing.XRect(30, 308, 520, 18));


                doc.Save("arquivo.pdf");
                System.Diagnostics.Process.Start("arquivo.pdf");

            }
        }

        private void PPDFormOS_Load(object sender, EventArgs e)
        {

        }

        private void DocumentoOS_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            

        }
    }
}




 



