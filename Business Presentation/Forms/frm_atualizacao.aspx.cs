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


public partial class atualizacao : System.Web.UI.Page
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

			TableCell obj_atualizacao = itemselecionado.Cells[1];
			this.txtatualizacao.Text = Convert.ToString(Server.HtmlDecode(obj_atualizacao.Text).ToString().Trim()) ;
		
			TableCell obj_produto = itemselecionado.Cells[2];
			this.txtproduto.Text = Convert.ToString(Server.HtmlDecode(obj_produto.Text).ToString().Trim()) ;
		
			TableCell obj_nome = itemselecionado.Cells[3];
			this.txtnome.Text = Convert.ToString(Server.HtmlDecode(obj_nome.Text).ToString().Trim()) ;
		
			TableCell obj_descricao = itemselecionado.Cells[4];
			this.txtdescricao.Text = Convert.ToString(Server.HtmlDecode(obj_descricao.Text).ToString().Trim()) ;
		
			TableCell obj_preco = itemselecionado.Cells[5];
			this.txtpreco.Text = Convert.ToString(Server.HtmlDecode(obj_preco.Text).ToString().Trim()) ;
		
			TableCell obj_diretoriodownload = itemselecionado.Cells[6];
			this.txtdiretoriodownload.Text = Convert.ToString(Server.HtmlDecode(obj_diretoriodownload.Text).ToString().Trim()) ;
		


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

			this.lblatualizacao.Enabled = false;
			txtatualizacao.Enabled = false;


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

			this.lblatualizacao.Enabled = false;
			txtatualizacao.Enabled = false;


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
            LojaElfez.BusinessRule.rul_atualizacao registro = new rul_atualizacao();

			if(txtatualizacao.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtatualizacao.Text ) )
					registro.atualizacao = Convert.ToInt32(txtatualizacao.Text);

			if(txtproduto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtproduto.Text ) )
					registro.produto = Convert.ToInt32(txtproduto.Text);

			if(txtnome.Text != String.Empty)
				registro.nome = Convert.ToString(txtnome.Text);

			if(txtdescricao.Text != String.Empty)
				registro.descricao = Convert.ToString(txtdescricao.Text);

			if(txtpreco.Text != String.Empty)
				if ( LojaElfez.Global.IsDecimal ( txtpreco.Text) )
					registro.preco = Convert.ToDecimal(txtpreco.Text);

			if(txtdiretoriodownload.Text != String.Empty)
				registro.diretoriodownload = Convert.ToString(txtdiretoriodownload.Text);




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

						this.lblatualizacao.Enabled = true;
						txtatualizacao.Enabled = true;


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

						this.lblatualizacao.Enabled = true;
						txtatualizacao.Enabled = true;


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
            LojaElfez.BusinessRule.rul_atualizacao registro = new rul_atualizacao();

			if(txtatualizacao.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtatualizacao.Text ) )
					registro.atualizacao = Convert.ToInt32(txtatualizacao.Text);

			if(txtproduto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtproduto.Text ) )
					registro.produto = Convert.ToInt32(txtproduto.Text);

			if(txtnome.Text != String.Empty)
				registro.nome = Convert.ToString(txtnome.Text);

			if(txtdescricao.Text != String.Empty)
				registro.descricao = Convert.ToString(txtdescricao.Text);

			if(txtpreco.Text != String.Empty)
				if ( LojaElfez.Global.IsDecimal ( txtpreco.Text) )
					registro.preco = Convert.ToDecimal(txtpreco.Text);

			if(txtdiretoriodownload.Text != String.Empty)
				registro.diretoriodownload = Convert.ToString(txtdiretoriodownload.Text);



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

            LojaElfez.BusinessRule.rul_atualizacao registro = new rul_atualizacao();

			if(txtatualizacao.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtatualizacao.Text ) )
					registro.atualizacao = Convert.ToInt32(txtatualizacao.Text);

			if(txtproduto.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtproduto.Text ) )
					registro.produto = Convert.ToInt32(txtproduto.Text);

			if(txtnome.Text != String.Empty)
				registro.nome = Convert.ToString(txtnome.Text);

			if(txtdescricao.Text != String.Empty)
				registro.descricao = Convert.ToString(txtdescricao.Text);

			if(txtpreco.Text != String.Empty)
				if ( LojaElfez.Global.IsDecimal ( txtpreco.Text) )
					registro.preco = Convert.ToDecimal(txtpreco.Text);

			if(txtdiretoriodownload.Text != String.Empty)
				registro.diretoriodownload = Convert.ToString(txtdiretoriodownload.Text);



            ds = registro.FindAllInDataSet();

            this.lblMensagemRetorno.Text = registro.mensagem;
 
            dtgRegistros.AutoGenerateColumns = false;

            dtgRegistros.DataSource = ds.Tables[0];

            dtgRegistros.Columns.Clear();

			//Criacao da coluna:atualizacao 
			BoundField bdfatualizacao = new BoundField();
			bdfatualizacao.HeaderText = "Atualizacao";
			bdfatualizacao.DataField ="atualizacao";
			dtgRegistros.Columns.Insert(0, bdfatualizacao);
			
			//Criacao da coluna:produto 
			BoundField bdfproduto = new BoundField();
			bdfproduto.HeaderText = "Produto";
			bdfproduto.DataField ="produto";
			dtgRegistros.Columns.Insert(1, bdfproduto);
			
			//Criacao da coluna:nome 
			BoundField bdfnome = new BoundField();
			bdfnome.HeaderText = "Nome";
			bdfnome.DataField ="nome";
			dtgRegistros.Columns.Insert(2, bdfnome);
			
			//Criacao da coluna:descricao 
			BoundField bdfdescricao = new BoundField();
			bdfdescricao.HeaderText = "Descricao";
			bdfdescricao.DataField ="descricao";
			dtgRegistros.Columns.Insert(3, bdfdescricao);
			
			//Criacao da coluna:preco 
			BoundField bdfpreco = new BoundField();
			bdfpreco.HeaderText = "Preco";
			bdfpreco.DataField ="preco";
			dtgRegistros.Columns.Insert(4, bdfpreco);
			
			//Criacao da coluna:diretoriodownload 
			BoundField bdfdiretoriodownload = new BoundField();
			bdfdiretoriodownload.HeaderText = "Diretoriodownload";
			bdfdiretoriodownload.DataField ="diretoriodownload";
			dtgRegistros.Columns.Insert(5, bdfdiretoriodownload);
			


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
				txtatualizacao.Text = String.Empty;
				txtproduto.Text = String.Empty;
				txtnome.Text = String.Empty;
				txtdescricao.Text = String.Empty;
				txtpreco.Text = String.Empty;
				txtdiretoriodownload.Text = String.Empty;

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