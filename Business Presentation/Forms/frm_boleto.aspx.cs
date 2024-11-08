	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 ** Projeto:LojaElfez                                 **
	 *                                                    * 
	 *  Objeto gerado automaticamente pelo TierGenerator  * 
	 *                                                    * 
	 *  Versao do programa:                 *  
	 *                                                    * 
	 *  Data da criacao: 26/10/2010                       * 
	 *  Hora de criacao: 09:42:19                         * 
	 *                                                    *  
	 *                                                    *  
	*********************************************************/

using System;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using LojaElfez;
using LojaElfez.BusinessRule;
using LojaElfez.BusinessCollection;


public partial class boleto : System.Web.UI.Page
{
    #region "Variaveis"

    public static LojaElfez.Global.Acao AcaoAtual = LojaElfez.Global.Acao.Indefinido;

    #endregion

    #region "Eventos"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.HabilitaBotoes();
            this.CarregaComboBox();	
        }
    }

    protected void btnNovo_Click(Object sender, ImageClickEventArgs e)
    {
        this.HabilitaInclusao();
    }

    protected void btnEditar_Click(Object sender, ImageClickEventArgs e)
    {
        this.HabilitaAlteracao();
    }

    protected void btnSalvar_Click(Object sender, ImageClickEventArgs e)
    {
        this.SalvaRegistro();
    }
    protected void btnExcluir_Click(Object sender, ImageClickEventArgs e)
    {
        this.HabilitaExclusao();
    }

    protected void btnLocalizar_Click(Object sender, ImageClickEventArgs e)
    {
	    this.HabilitaPesquisa();
    }

    protected void btnAtualizar_Click(Object sender, ImageClickEventArgs e)
    {
        this.AtualizaGrid();
    }

    protected void btnImprimir_Click(Object sender, ImageClickEventArgs e)
    {
        this.ImprimeRelatorio();
    }

    protected void btnVisualizar_Click(Object sender, ImageClickEventArgs e)
    {
        this.VisualizaRelatorio();
    }

    protected void btnSair_Click(Object sender, ImageClickEventArgs e)
    {
        this.FechaAplicacao();
    }

    protected void dtgRegistros_SelectedIndexChanged(Object sender, EventArgs e)
    {
        try
        {
            GridViewRow itemselecionado = this.dtgRegistros.SelectedRow;

			TableCell obj_boleto = itemselecionado.Cells[1];
			this.txtboleto.Text = Convert.ToString(Server.HtmlDecode(obj_boleto.Text).ToString().Trim()) ;
		
			TableCell obj_cliente = itemselecionado.Cells[2];
			this.txtcliente.Text = Convert.ToString(Server.HtmlDecode(obj_cliente.Text).ToString().Trim()) ;
		
			TableCell obj_cpf_cnpj = itemselecionado.Cells[3];
			this.txtcpf_cnpj.Text = Convert.ToString(Server.HtmlDecode(obj_cpf_cnpj.Text).ToString().Trim()) ;
		
			TableCell obj_produto = itemselecionado.Cells[4];
			this.txtproduto.Text = Convert.ToString(Server.HtmlDecode(obj_produto.Text).ToString().Trim()) ;
		
			TableCell obj_cedente = itemselecionado.Cells[5];
			this.txtcedente.Text = Convert.ToString(Server.HtmlDecode(obj_cedente.Text).ToString().Trim()) ;
		
			TableCell obj_cnpj = itemselecionado.Cells[6];
			this.txtcnpj.Text = Convert.ToString(Server.HtmlDecode(obj_cnpj.Text).ToString().Trim()) ;
		
			TableCell obj_banco = itemselecionado.Cells[7];
			this.txtbanco.Text = Convert.ToString(Server.HtmlDecode(obj_banco.Text).ToString().Trim()) ;
		
			TableCell obj_agencia = itemselecionado.Cells[8];
			this.txtagencia.Text = Convert.ToString(Server.HtmlDecode(obj_agencia.Text).ToString().Trim()) ;
		
			TableCell obj_conta = itemselecionado.Cells[9];
			this.txtconta.Text = Convert.ToString(Server.HtmlDecode(obj_conta.Text).ToString().Trim()) ;
		
			TableCell obj_digito = itemselecionado.Cells[10];
			this.txtdigito.Text = Convert.ToString(Server.HtmlDecode(obj_digito.Text).ToString().Trim()) ;
		
			TableCell obj_carteira = itemselecionado.Cells[11];
			this.txtcarteira.Text = Convert.ToString(Server.HtmlDecode(obj_carteira.Text).ToString().Trim()) ;
		
			TableCell obj_vencimento = itemselecionado.Cells[12];
			this.txtvencimento.Text = Convert.ToString(Server.HtmlDecode(obj_vencimento.Text).ToString().Trim()) ;
		
			TableCell obj_quantidade = itemselecionado.Cells[13];
			this.txtquantidade.Text = Convert.ToString(Server.HtmlDecode(obj_quantidade.Text).ToString().Trim()) ;
		
			TableCell obj_preco = itemselecionado.Cells[14];
			this.txtpreco.Text = Convert.ToString(Server.HtmlDecode(obj_preco.Text).ToString().Trim()) ;
		
			TableCell obj_datacriacao = itemselecionado.Cells[15];
			this.txtdatacriacao.Text = Convert.ToString(Server.HtmlDecode(obj_datacriacao.Text).ToString().Trim()) ;
		
			TableCell obj_datapagamento = itemselecionado.Cells[16];
			this.txtdatapagamento.Text = Convert.ToString(Server.HtmlDecode(obj_datapagamento.Text).ToString().Trim()) ;
		
			TableCell obj_atualizacao = itemselecionado.Cells[17];
			this.txtatualizacao.Text = Convert.ToString(Server.HtmlDecode(obj_atualizacao.Text).ToString().Trim()) ;
		


            HabilitaBotao(this.btnEditar,  LojaElfez.Global.EnumBarraFerramentas.BtnEditar);
            HabilitaBotao(this.btnExcluir, LojaElfez.Global.EnumBarraFerramentas.BtnExcluir);
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
        
    }

    #endregion

    #region "Controle da Aplicacao"


    private void HabilitaInclusao()
    {
        try
        {
            
            this.pnlControles.Enabled = true;

			this.lblboleto.Enabled = false;
			txtboleto.Enabled = false;


            this.lblMensagemRetorno.Text ="";
            
            AcaoAtual = LojaElfez.Global.Acao.Inclusao;

            this.DesabilitaBotoes();

            this.LimpaConteudoControles();

        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void HabilitaAlteracao()
    {
        try
        {
            
            this.pnlControles.Enabled = true;

			this.lblboleto.Enabled = false;
			txtboleto.Enabled = false;


            this.lblMensagemRetorno.Text ="";

            AcaoAtual = LojaElfez.Global.Acao.Alteracao;

            this.DesabilitaBotoes();

        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void HabilitaExclusao()
    {
        try
        {
            
            this.lblMensagemRetorno.Text ="";

            if (AcaoAtual == LojaElfez.Global.Acao.Exclusao)
            {
                this.ExcluiRegistro();

                this.LimpaConteudoControles();

                this.HabilitaBotoes();

            }
            else
            {

                AcaoAtual = LojaElfez.Global.Acao.Exclusao;

                this.lblMensagemRetorno.Text = "Para confirmar a exclus�o do registro selecionado, pressione novamente o botao \"Excluir\"";

                this.DesabilitaBotoesExclusao();
            }    

            this.pnlControles.Enabled = false;

        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void HabilitaPesquisa()
    {
        try
        {
            AcaoAtual = LojaElfez.Global.Acao.Pesquisa;

            this.pnlControles.Enabled = true;

            this.LimpaConteudoControles();

            this.DesabilitaBotao	(this.btnNovo		, LojaElfez.Global.EnumBarraFerramentas.BtnNovo);
            this.DesabilitaBotao	(this.btnEditar		, LojaElfez.Global.EnumBarraFerramentas.BtnEditar);
            this.DesabilitaBotao	(this.btnSalvar		, LojaElfez.Global.EnumBarraFerramentas.BtnSalvar);
            this.DesabilitaBotao	(this.btnExcluir	, LojaElfez.Global.EnumBarraFerramentas.BtnExcluir);
            this.DesabilitaBotao	(this.btnLocalizar	, LojaElfez.Global.EnumBarraFerramentas.BtnLocalizar);
            this.HabilitaBotao		(this.btnAtualizar	, LojaElfez.Global.EnumBarraFerramentas.BtnAtualizar);
            this.DesabilitaBotao	(this.btnImprimir	, LojaElfez.Global.EnumBarraFerramentas.BtnImprimir);
            this.DesabilitaBotao	(this.btnVisualizar	, LojaElfez.Global.EnumBarraFerramentas.BtnVisualizar);
            this.HabilitaBotao		(this.btnSair		, LojaElfez.Global.EnumBarraFerramentas.BtnSair);

        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void HabilitaVisualizacaoGrid()
    {
        try
        {
            this.lblMensagemRetorno.Text = "";
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }           
    }


    private void SalvaRegistro()
    {
        try
        {
            this.lblMensagemRetorno.Text = "";
            
            
            // Este objeto fara todas as validacoes necessrias
            // e vai retornar para a apresentacao mensagem de erro ou
            // indicativo de sucesso da operacao (inclusao/alteracao)
            //
            LojaElfez.BusinessRule.rul_boleto registro = new rul_boleto();

			if(txtboleto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtboleto.Text ) )
					registro.boleto = Convert.ToInt32(txtboleto.Text);

			if(txtcliente.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtcliente.Text ) )
					registro.cliente = Convert.ToInt32(txtcliente.Text);

			if(txtcpf_cnpj.Text != String.Empty)
				registro.cpf_cnpj = Convert.ToString(txtcpf_cnpj.Text);

			if(txtproduto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtproduto.Text ) )
					registro.produto = Convert.ToInt32(txtproduto.Text);

			if(txtcedente.Text != String.Empty)
				registro.cedente = Convert.ToString(txtcedente.Text);

			if(txtcnpj.Text != String.Empty)
				registro.cnpj = Convert.ToString(txtcnpj.Text);

			if(txtbanco.Text != String.Empty)
				registro.banco = Convert.ToString(txtbanco.Text);

			if(txtagencia.Text != String.Empty)
				registro.agencia = Convert.ToString(txtagencia.Text);

			if(txtconta.Text != String.Empty)
				registro.conta = Convert.ToString(txtconta.Text);

			if(txtdigito.Text != String.Empty)
				registro.digito = Convert.ToString(txtdigito.Text);

			if(txtcarteira.Text != String.Empty)
				registro.carteira = Convert.ToString(txtcarteira.Text);

			if(txtvencimento.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtvencimento.Text) )
					registro.vencimento = Convert.ToDateTime(txtvencimento.Text );

			if(txtquantidade.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtquantidade.Text ) )
					registro.quantidade = Convert.ToInt32(txtquantidade.Text);

			if(txtpreco.Text != String.Empty)
				if ( LojaElfez.Global.IsDecimal ( txtpreco.Text) )
					registro.preco = Convert.ToDecimal(txtpreco.Text);

			if(txtdatacriacao.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatacriacao.Text) )
					registro.datacriacao = Convert.ToDateTime(txtdatacriacao.Text );

			if(txtdatapagamento.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatapagamento.Text) )
					registro.datapagamento = Convert.ToDateTime(txtdatapagamento.Text );

			if(txtatualizacao.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtatualizacao.Text ) )
					registro.atualizacao = Convert.ToInt32(txtatualizacao.Text);




            switch (AcaoAtual)
            {
                case LojaElfez.Global.Acao.Inclusao:
                    if (registro.ValidateInsert())
                    {
                        this.HabilitaBotoes();

                        this.HabilitaVisualizacaoGrid();

                        this.AtualizaGrid();

                        AcaoAtual = LojaElfez.Global.Acao.Indefinido;

                        this.LimpaConteudoControles();

                        this.pnlControles.Enabled = false;

						this.lblboleto.Enabled = true;
						txtboleto.Enabled = true;


                    }
                    else
                        this.lblMensagemRetorno.Text = registro.mensagem;

                    break;

                case LojaElfez.Global.Acao.Alteracao:
                    if (registro.ValidateUpdate())
                    {
                        this.HabilitaBotoes();

                        this.HabilitaVisualizacaoGrid();

                        this.AtualizaGrid();

                        AcaoAtual = LojaElfez.Global.Acao.Indefinido;

                        this.LimpaConteudoControles();

                        this.pnlControles.Enabled = false;

						this.lblboleto.Enabled = true;
						txtboleto.Enabled = true;


                    }
                    else
                        this.lblMensagemRetorno.Text = registro.mensagem;

                    break;
                case LojaElfez.Global.Acao.Indefinido:
                    // Erro
                    break;
                default:
                    break;
            }

        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void ExcluiRegistro()
    {
        try
        {
            this.lblMensagemRetorno.Text ="";
            
            // Este objeto fara todas as validacoes necessrias
            // e vai retornar para a apresentacao mensagem de erro ou
            // indicativo de sucesso da operacao (inclusao/alteracao)
            //
            LojaElfez.BusinessRule.rul_boleto registro = new rul_boleto();

			if(txtboleto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtboleto.Text ) )
					registro.boleto = Convert.ToInt32(txtboleto.Text);

			if(txtcliente.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtcliente.Text ) )
					registro.cliente = Convert.ToInt32(txtcliente.Text);

			if(txtcpf_cnpj.Text != String.Empty)
				registro.cpf_cnpj = Convert.ToString(txtcpf_cnpj.Text);

			if(txtproduto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtproduto.Text ) )
					registro.produto = Convert.ToInt32(txtproduto.Text);

			if(txtcedente.Text != String.Empty)
				registro.cedente = Convert.ToString(txtcedente.Text);

			if(txtcnpj.Text != String.Empty)
				registro.cnpj = Convert.ToString(txtcnpj.Text);

			if(txtbanco.Text != String.Empty)
				registro.banco = Convert.ToString(txtbanco.Text);

			if(txtagencia.Text != String.Empty)
				registro.agencia = Convert.ToString(txtagencia.Text);

			if(txtconta.Text != String.Empty)
				registro.conta = Convert.ToString(txtconta.Text);

			if(txtdigito.Text != String.Empty)
				registro.digito = Convert.ToString(txtdigito.Text);

			if(txtcarteira.Text != String.Empty)
				registro.carteira = Convert.ToString(txtcarteira.Text);

			if(txtvencimento.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtvencimento.Text) )
					registro.vencimento = Convert.ToDateTime(txtvencimento.Text );

			if(txtquantidade.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtquantidade.Text ) )
					registro.quantidade = Convert.ToInt32(txtquantidade.Text);

			if(txtpreco.Text != String.Empty)
				if ( LojaElfez.Global.IsDecimal ( txtpreco.Text) )
					registro.preco = Convert.ToDecimal(txtpreco.Text);

			if(txtdatacriacao.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatacriacao.Text) )
					registro.datacriacao = Convert.ToDateTime(txtdatacriacao.Text );

			if(txtdatapagamento.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatapagamento.Text) )
					registro.datapagamento = Convert.ToDateTime(txtdatapagamento.Text );

			if(txtatualizacao.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtatualizacao.Text ) )
					registro.atualizacao = Convert.ToInt32(txtatualizacao.Text);



            if (registro.ValidateDelete())
            {
                this.HabilitaVisualizacaoGrid();

                this.AtualizaGrid();

                AcaoAtual = LojaElfez.Global.Acao.Indefinido;
                this.lblMensagemRetorno.Text = "";
            }
            else
            {
                this.lblMensagemRetorno.Text = registro.mensagem;
            }
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void AtualizaGrid()
    {
        try
        {
            this.lblMensagemRetorno.Text = "";


            System.Data.DataSet ds;

            LojaElfez.BusinessRule.rul_boleto registro = new rul_boleto();

			if(txtboleto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtboleto.Text ) )
					registro.boleto = Convert.ToInt32(txtboleto.Text);

			if(txtcliente.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtcliente.Text ) )
					registro.cliente = Convert.ToInt32(txtcliente.Text);

			if(txtcpf_cnpj.Text != String.Empty)
				registro.cpf_cnpj = Convert.ToString(txtcpf_cnpj.Text);

			if(txtproduto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtproduto.Text ) )
					registro.produto = Convert.ToInt32(txtproduto.Text);

			if(txtcedente.Text != String.Empty)
				registro.cedente = Convert.ToString(txtcedente.Text);

			if(txtcnpj.Text != String.Empty)
				registro.cnpj = Convert.ToString(txtcnpj.Text);

			if(txtbanco.Text != String.Empty)
				registro.banco = Convert.ToString(txtbanco.Text);

			if(txtagencia.Text != String.Empty)
				registro.agencia = Convert.ToString(txtagencia.Text);

			if(txtconta.Text != String.Empty)
				registro.conta = Convert.ToString(txtconta.Text);

			if(txtdigito.Text != String.Empty)
				registro.digito = Convert.ToString(txtdigito.Text);

			if(txtcarteira.Text != String.Empty)
				registro.carteira = Convert.ToString(txtcarteira.Text);

			if(txtvencimento.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtvencimento.Text) )
					registro.vencimento = Convert.ToDateTime(txtvencimento.Text );

			if(txtquantidade.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtquantidade.Text ) )
					registro.quantidade = Convert.ToInt32(txtquantidade.Text);

			if(txtpreco.Text != String.Empty)
				if ( LojaElfez.Global.IsDecimal ( txtpreco.Text) )
					registro.preco = Convert.ToDecimal(txtpreco.Text);

			if(txtdatacriacao.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatacriacao.Text) )
					registro.datacriacao = Convert.ToDateTime(txtdatacriacao.Text );

			if(txtdatapagamento.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatapagamento.Text) )
					registro.datapagamento = Convert.ToDateTime(txtdatapagamento.Text );

			if(txtatualizacao.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtatualizacao.Text ) )
					registro.atualizacao = Convert.ToInt32(txtatualizacao.Text);



            ds = registro.FindAllInDataSet();

            this.lblMensagemRetorno.Text = registro.mensagem;
 
            dtgRegistros.AutoGenerateColumns = false;

            dtgRegistros.DataSource = ds.Tables[0];

            dtgRegistros.Columns.Clear();

			//Criacao da coluna:boleto 
			BoundField bdfboleto = new BoundField();
			bdfboleto.HeaderText = "Boleto";
			bdfboleto.DataField ="boleto";
			dtgRegistros.Columns.Insert(0, bdfboleto);
			
			//Criacao da coluna:cliente 
			BoundField bdfcliente = new BoundField();
			bdfcliente.HeaderText = "Cliente";
			bdfcliente.DataField ="cliente";
			dtgRegistros.Columns.Insert(1, bdfcliente);
			
			//Criacao da coluna:cpf_cnpj 
			BoundField bdfcpf_cnpj = new BoundField();
			bdfcpf_cnpj.HeaderText = "Cpf_cnpj";
			bdfcpf_cnpj.DataField ="cpf_cnpj";
			dtgRegistros.Columns.Insert(2, bdfcpf_cnpj);
			
			//Criacao da coluna:produto 
			BoundField bdfproduto = new BoundField();
			bdfproduto.HeaderText = "Produto";
			bdfproduto.DataField ="produto";
			dtgRegistros.Columns.Insert(3, bdfproduto);
			
			//Criacao da coluna:cedente 
			BoundField bdfcedente = new BoundField();
			bdfcedente.HeaderText = "Cedente";
			bdfcedente.DataField ="cedente";
			dtgRegistros.Columns.Insert(4, bdfcedente);
			
			//Criacao da coluna:cnpj 
			BoundField bdfcnpj = new BoundField();
			bdfcnpj.HeaderText = "Cnpj";
			bdfcnpj.DataField ="cnpj";
			dtgRegistros.Columns.Insert(5, bdfcnpj);
			
			//Criacao da coluna:banco 
			BoundField bdfbanco = new BoundField();
			bdfbanco.HeaderText = "Banco";
			bdfbanco.DataField ="banco";
			dtgRegistros.Columns.Insert(6, bdfbanco);
			
			//Criacao da coluna:agencia 
			BoundField bdfagencia = new BoundField();
			bdfagencia.HeaderText = "Agencia";
			bdfagencia.DataField ="agencia";
			dtgRegistros.Columns.Insert(7, bdfagencia);
			
			//Criacao da coluna:conta 
			BoundField bdfconta = new BoundField();
			bdfconta.HeaderText = "Conta";
			bdfconta.DataField ="conta";
			dtgRegistros.Columns.Insert(8, bdfconta);
			
			//Criacao da coluna:digito 
			BoundField bdfdigito = new BoundField();
			bdfdigito.HeaderText = "Digito";
			bdfdigito.DataField ="digito";
			dtgRegistros.Columns.Insert(9, bdfdigito);
			
			//Criacao da coluna:carteira 
			BoundField bdfcarteira = new BoundField();
			bdfcarteira.HeaderText = "Carteira";
			bdfcarteira.DataField ="carteira";
			dtgRegistros.Columns.Insert(10, bdfcarteira);
			
			//Criacao da coluna:vencimento 
			BoundField bdfvencimento = new BoundField();
			bdfvencimento.HeaderText = "Vencimento";
			bdfvencimento.DataField ="vencimento";
			dtgRegistros.Columns.Insert(11, bdfvencimento);
			
			//Criacao da coluna:quantidade 
			BoundField bdfquantidade = new BoundField();
			bdfquantidade.HeaderText = "Quantidade";
			bdfquantidade.DataField ="quantidade";
			dtgRegistros.Columns.Insert(12, bdfquantidade);
			
			//Criacao da coluna:preco 
			BoundField bdfpreco = new BoundField();
			bdfpreco.HeaderText = "Preco";
			bdfpreco.DataField ="preco";
			dtgRegistros.Columns.Insert(13, bdfpreco);
			
			//Criacao da coluna:datacriacao 
			BoundField bdfdatacriacao = new BoundField();
			bdfdatacriacao.HeaderText = "Datacriacao";
			bdfdatacriacao.DataField ="datacriacao";
			dtgRegistros.Columns.Insert(14, bdfdatacriacao);
			
			//Criacao da coluna:datapagamento 
			BoundField bdfdatapagamento = new BoundField();
			bdfdatapagamento.HeaderText = "Datapagamento";
			bdfdatapagamento.DataField ="datapagamento";
			dtgRegistros.Columns.Insert(15, bdfdatapagamento);
			
			//Criacao da coluna:atualizacao 
			BoundField bdfatualizacao = new BoundField();
			bdfatualizacao.HeaderText = "Atualizacao";
			bdfatualizacao.DataField ="atualizacao";
			dtgRegistros.Columns.Insert(16, bdfatualizacao);
			


            dtgRegistros.DataBind();

            this.pnlControles.Enabled = false;

            this.LimpaConteudoControles();
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;            
        }        
    } 
   
    private void ImprimeRelatorio()
    {
        try
        {
            this.lblMensagemRetorno.Text = "Os relatorios das tabelas ainda nao foram implentados";
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;            
        }
    }

    private void VisualizaRelatorio()
    {
        try
        {
            this.lblMensagemRetorno.Text = "Os relatorios das tabelas ainda nao foram implentados";
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void FechaAplicacao()
    {
        try
        {
            this.lblMensagemRetorno.Text = "";

            switch (AcaoAtual)
            {
                case LojaElfez.Global.Acao.Inclusao:
                    {
                        AcaoAtual = LojaElfez.Global.Acao.Indefinido;

                        this.LimpaConteudoControles();

                        this.pnlControles.Enabled = false;
                        break;
                    }
                case LojaElfez.Global.Acao.Alteracao:
                    {
                        AcaoAtual = LojaElfez.Global.Acao.Indefinido;

                        this.LimpaConteudoControles();

                        this.pnlControles.Enabled = false;

                        this.dtgRegistros.SelectedIndex = -1;

                        break;
                    }
                case LojaElfez.Global.Acao.Exclusao:
                    {
                        AcaoAtual = LojaElfez.Global.Acao.Indefinido;

                        this.LimpaConteudoControles();


                        this.pnlControles.Enabled = false;

                        this.dtgRegistros.SelectedIndex = -1 ;

                        break;
                    }
                case LojaElfez.Global.Acao.Pesquisa:
                    {
                        AcaoAtual = LojaElfez.Global.Acao.Indefinido;

                        this.LimpaConteudoControles();

                        this.pnlControles.Enabled = false;

                        this.dtgRegistros.SelectedIndex = -1;

                        break;
                    }
                case LojaElfez.Global.Acao.Indefinido:
                    {                        
                        //  Saindo da janela
                        HttpResponse rsp = this.Response;
                    
                        rsp.Redirect("~/Default.aspx");

                        break;
                    }
                default:
                    {
                        break;
                    }                
            }
            
            AcaoAtual = LojaElfez.Global.Acao.Indefinido;

            this.HabilitaBotoes();
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void LimpaConteudoControles()
    {
        try
        {
				txtboleto.Text = String.Empty;
				txtcliente.Text = String.Empty;
				txtcpf_cnpj.Text = String.Empty;
				txtproduto.Text = String.Empty;
				txtcedente.Text = String.Empty;
				txtcnpj.Text = String.Empty;
				txtbanco.Text = String.Empty;
				txtagencia.Text = String.Empty;
				txtconta.Text = String.Empty;
				txtdigito.Text = String.Empty;
				txtcarteira.Text = String.Empty;
				txtvencimento.Text = String.Empty;
				txtquantidade.Text = String.Empty;
				txtpreco.Text = String.Empty;
				txtdatacriacao.Text = String.Empty;
				txtdatapagamento.Text = String.Empty;
				txtatualizacao.Text = String.Empty;

        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void CarregaComboBox()
    {
        try
        {
			//Carregando Combobox com dados da tabela estrangeira

        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void DesabilitaBotoes()
    {
        try
        {
            this.DesabilitaBotao(this.btnNovo, LojaElfez.Global.EnumBarraFerramentas.BtnNovo);
            this.DesabilitaBotao(this.btnEditar, LojaElfez.Global.EnumBarraFerramentas.BtnEditar);
            this.HabilitaBotao(this.btnSalvar, LojaElfez.Global.EnumBarraFerramentas.BtnSalvar);
            this.DesabilitaBotao(this.btnExcluir, LojaElfez.Global.EnumBarraFerramentas.BtnExcluir);
            this.DesabilitaBotao(this.btnLocalizar, LojaElfez.Global.EnumBarraFerramentas.BtnLocalizar);
            this.DesabilitaBotao(this.btnAtualizar, LojaElfez.Global.EnumBarraFerramentas.BtnAtualizar);
            this.DesabilitaBotao(this.btnImprimir, LojaElfez.Global.EnumBarraFerramentas.BtnImprimir);
            this.DesabilitaBotao(this.btnVisualizar, LojaElfez.Global.EnumBarraFerramentas.BtnVisualizar);
            this.HabilitaBotao(this.btnSair, LojaElfez.Global.EnumBarraFerramentas.BtnSair);
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }

    }

    private void DesabilitaBotoesExclusao()
    {
        try
        {
            this.DesabilitaBotao(this.btnNovo, LojaElfez.Global.EnumBarraFerramentas.BtnNovo);
            this.DesabilitaBotao(this.btnEditar, LojaElfez.Global.EnumBarraFerramentas.BtnEditar);
            this.DesabilitaBotao(this.btnSalvar, LojaElfez.Global.EnumBarraFerramentas.BtnSalvar);
            this.HabilitaBotao(this.btnExcluir, LojaElfez.Global.EnumBarraFerramentas.BtnExcluir);
            this.DesabilitaBotao(this.btnLocalizar, LojaElfez.Global.EnumBarraFerramentas.BtnLocalizar);
            this.DesabilitaBotao(this.btnAtualizar, LojaElfez.Global.EnumBarraFerramentas.BtnAtualizar);
            this.DesabilitaBotao(this.btnImprimir, LojaElfez.Global.EnumBarraFerramentas.BtnImprimir);
            this.DesabilitaBotao(this.btnVisualizar, LojaElfez.Global.EnumBarraFerramentas.BtnVisualizar);
            this.HabilitaBotao(this.btnSair, LojaElfez.Global.EnumBarraFerramentas.BtnSair);
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }
    }

    private void HabilitaBotoes()
    {
        try
        {
            this.HabilitaBotao(this.btnNovo, LojaElfez.Global.EnumBarraFerramentas.BtnNovo);
            this.DesabilitaBotao(this.btnEditar, LojaElfez.Global.EnumBarraFerramentas.BtnEditar);
            this.DesabilitaBotao(this.btnSalvar, LojaElfez.Global.EnumBarraFerramentas.BtnSalvar);
            this.DesabilitaBotao(this.btnExcluir, LojaElfez.Global.EnumBarraFerramentas.BtnExcluir);
            this.HabilitaBotao(this.btnLocalizar, LojaElfez.Global.EnumBarraFerramentas.BtnLocalizar);
            this.HabilitaBotao(this.btnAtualizar, LojaElfez.Global.EnumBarraFerramentas.BtnAtualizar);
            this.HabilitaBotao(this.btnImprimir, LojaElfez.Global.EnumBarraFerramentas.BtnImprimir);
            this.HabilitaBotao(this.btnVisualizar, LojaElfez.Global.EnumBarraFerramentas.BtnVisualizar);
            this.HabilitaBotao(this.btnSair, LojaElfez.Global.EnumBarraFerramentas.BtnSair);
        }
        catch (Exception ex)
        {
            this.lblMensagemRetorno.Text = ex.Message;
        }

    }

    private void HabilitaBotao(ImageButton botao, LojaElfez.Global.EnumBarraFerramentas tipo )
    {
        botao.Enabled = true;
        switch (tipo)
        {
            case LojaElfez.Global.EnumBarraFerramentas.BtnNovo:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/01-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnEditar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/02-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnSalvar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/03-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnExcluir:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/04-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnLocalizar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/05-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnAtualizar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/06-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnImprimir:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/07-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnVisualizar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/08-N.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnSair:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/12.gif";
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    private void DesabilitaBotao(ImageButton botao, LojaElfez.Global.EnumBarraFerramentas tipo)
    {
        botao.Enabled = true;
        switch (tipo)
        {
            case LojaElfez.Global.EnumBarraFerramentas.BtnNovo:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/01-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnEditar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/02-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnSalvar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/03-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnExcluir:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/04-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnLocalizar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/05-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnAtualizar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/06-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnImprimir:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/07-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnVisualizar:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/08-D.gif";
                    break;
                }
            case LojaElfez.Global.EnumBarraFerramentas.BtnSair:
                {
                    botao.ImageUrl = "~/Imagens/Toolbar/12.gif";
                    break;
                }
            default:
                {
                    break;
                }
        }
    } 

    #endregion
}