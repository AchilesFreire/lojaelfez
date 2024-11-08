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


public partial class Cliente : System.Web.UI.Page
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

			TableCell obj_cliente = itemselecionado.Cells[1];
			this.txtcliente.Text = Convert.ToString(Server.HtmlDecode(obj_cliente.Text).ToString().Trim()) ;
		
			TableCell obj_cpf_cnpj = itemselecionado.Cells[2];
			this.txtcpf_cnpj.Text = Convert.ToString(Server.HtmlDecode(obj_cpf_cnpj.Text).ToString().Trim()) ;
		
			TableCell obj_nome = itemselecionado.Cells[3];
			this.txtnome.Text = Convert.ToString(Server.HtmlDecode(obj_nome.Text).ToString().Trim()) ;
		
			TableCell obj_email = itemselecionado.Cells[4];
			this.txtemail.Text = Convert.ToString(Server.HtmlDecode(obj_email.Text).ToString().Trim()) ;
		
			TableCell obj_endereco = itemselecionado.Cells[5];
			this.txtendereco.Text = Convert.ToString(Server.HtmlDecode(obj_endereco.Text).ToString().Trim()) ;
		
			TableCell obj_bairro = itemselecionado.Cells[6];
			this.txtbairro.Text = Convert.ToString(Server.HtmlDecode(obj_bairro.Text).ToString().Trim()) ;
		
			TableCell obj_cidade = itemselecionado.Cells[7];
			this.txtcidade.Text = Convert.ToString(Server.HtmlDecode(obj_cidade.Text).ToString().Trim()) ;
		
			TableCell obj_estado = itemselecionado.Cells[8];
			this.txtestado.Text = Convert.ToString(Server.HtmlDecode(obj_estado.Text).ToString().Trim()) ;
		
			TableCell obj_ddd = itemselecionado.Cells[9];
			this.txtddd.Text = Convert.ToString(Server.HtmlDecode(obj_ddd.Text).ToString().Trim()) ;
		
			TableCell obj_telefonefixo = itemselecionado.Cells[10];
			this.txttelefonefixo.Text = Convert.ToString(Server.HtmlDecode(obj_telefonefixo.Text).ToString().Trim()) ;
		
			TableCell obj_telefonecelular = itemselecionado.Cells[11];
			this.txttelefonecelular.Text = Convert.ToString(Server.HtmlDecode(obj_telefonecelular.Text).ToString().Trim()) ;
		
			TableCell obj_cep = itemselecionado.Cells[12];
			this.txtcep.Text = Convert.ToString(Server.HtmlDecode(obj_cep.Text).ToString().Trim()) ;
		
			TableCell obj_observacoes = itemselecionado.Cells[13];
			this.txtobservacoes.Text = Convert.ToString(Server.HtmlDecode(obj_observacoes.Text).ToString().Trim()) ;
		
			TableCell obj_login = itemselecionado.Cells[14];
			this.txtlogin.Text = Convert.ToString(Server.HtmlDecode(obj_login.Text).ToString().Trim()) ;
		
			TableCell obj_senha = itemselecionado.Cells[15];
			this.txtsenha.Text = Convert.ToString(Server.HtmlDecode(obj_senha.Text).ToString().Trim()) ;
		
			TableCell obj_datainclusao = itemselecionado.Cells[16];
			this.txtdatainclusao.Text = Convert.ToString(Server.HtmlDecode(obj_datainclusao.Text).ToString().Trim()) ;
		


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

			this.lblcliente.Enabled = false;
			txtcliente.Enabled = false;


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

			this.lblcliente.Enabled = false;
			txtcliente.Enabled = false;


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
            LojaElfez.BusinessRule.rul_Cliente registro = new rul_Cliente();

			if(txtcliente.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtcliente.Text ) )
					registro.cliente = Convert.ToInt32(txtcliente.Text);

			if(txtcpf_cnpj.Text != String.Empty)
				registro.cpf_cnpj = Convert.ToString(txtcpf_cnpj.Text);

			if(txtnome.Text != String.Empty)
				registro.nome = Convert.ToString(txtnome.Text);

			if(txtemail.Text != String.Empty)
				registro.email = Convert.ToString(txtemail.Text);

			if(txtendereco.Text != String.Empty)
				registro.endereco = Convert.ToString(txtendereco.Text);

			if(txtbairro.Text != String.Empty)
				registro.bairro = Convert.ToString(txtbairro.Text);

			if(txtcidade.Text != String.Empty)
				registro.cidade = Convert.ToString(txtcidade.Text);

			if(txtestado.Text != String.Empty)
				registro.estado = Convert.ToString(txtestado.Text);

			if(txtddd.Text != String.Empty)
				registro.ddd = Convert.ToString(txtddd.Text);

			if(txttelefonefixo.Text != String.Empty)
				registro.telefonefixo = Convert.ToString(txttelefonefixo.Text);

			if(txttelefonecelular.Text != String.Empty)
				registro.telefonecelular = Convert.ToString(txttelefonecelular.Text);

			if(txtcep.Text != String.Empty)
				registro.cep = Convert.ToString(txtcep.Text);

			if(txtobservacoes.Text != String.Empty)
				registro.observacoes = Convert.ToString(txtobservacoes.Text);

			if(txtlogin.Text != String.Empty)
				registro.login = Convert.ToString(txtlogin.Text);

			if(txtsenha.Text != String.Empty)
				registro.senha = Convert.ToString(txtsenha.Text);

			if(txtdatainclusao.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatainclusao.Text) )
					registro.datainclusao = Convert.ToDateTime(txtdatainclusao.Text );




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

						this.lblcliente.Enabled = true;
						txtcliente.Enabled = true;


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

						this.lblcliente.Enabled = true;
						txtcliente.Enabled = true;


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
            LojaElfez.BusinessRule.rul_Cliente registro = new rul_Cliente();

			if(txtcliente.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtcliente.Text ) )
					registro.cliente = Convert.ToInt32(txtcliente.Text);

			if(txtcpf_cnpj.Text != String.Empty)
				registro.cpf_cnpj = Convert.ToString(txtcpf_cnpj.Text);

			if(txtnome.Text != String.Empty)
				registro.nome = Convert.ToString(txtnome.Text);

			if(txtemail.Text != String.Empty)
				registro.email = Convert.ToString(txtemail.Text);

			if(txtendereco.Text != String.Empty)
				registro.endereco = Convert.ToString(txtendereco.Text);

			if(txtbairro.Text != String.Empty)
				registro.bairro = Convert.ToString(txtbairro.Text);

			if(txtcidade.Text != String.Empty)
				registro.cidade = Convert.ToString(txtcidade.Text);

			if(txtestado.Text != String.Empty)
				registro.estado = Convert.ToString(txtestado.Text);

			if(txtddd.Text != String.Empty)
				registro.ddd = Convert.ToString(txtddd.Text);

			if(txttelefonefixo.Text != String.Empty)
				registro.telefonefixo = Convert.ToString(txttelefonefixo.Text);

			if(txttelefonecelular.Text != String.Empty)
				registro.telefonecelular = Convert.ToString(txttelefonecelular.Text);

			if(txtcep.Text != String.Empty)
				registro.cep = Convert.ToString(txtcep.Text);

			if(txtobservacoes.Text != String.Empty)
				registro.observacoes = Convert.ToString(txtobservacoes.Text);

			if(txtlogin.Text != String.Empty)
				registro.login = Convert.ToString(txtlogin.Text);

			if(txtsenha.Text != String.Empty)
				registro.senha = Convert.ToString(txtsenha.Text);

			if(txtdatainclusao.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatainclusao.Text) )
					registro.datainclusao = Convert.ToDateTime(txtdatainclusao.Text );



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

            LojaElfez.BusinessRule.rul_Cliente registro = new rul_Cliente();

			if(txtcliente.Text != String.Empty)
				if ( LojaElfez.Global.IsNumeric ( txtcliente.Text ) )
					registro.cliente = Convert.ToInt32(txtcliente.Text);

			if(txtcpf_cnpj.Text != String.Empty)
				registro.cpf_cnpj = Convert.ToString(txtcpf_cnpj.Text);

			if(txtnome.Text != String.Empty)
				registro.nome = Convert.ToString(txtnome.Text);

			if(txtemail.Text != String.Empty)
				registro.email = Convert.ToString(txtemail.Text);

			if(txtendereco.Text != String.Empty)
				registro.endereco = Convert.ToString(txtendereco.Text);

			if(txtbairro.Text != String.Empty)
				registro.bairro = Convert.ToString(txtbairro.Text);

			if(txtcidade.Text != String.Empty)
				registro.cidade = Convert.ToString(txtcidade.Text);

			if(txtestado.Text != String.Empty)
				registro.estado = Convert.ToString(txtestado.Text);

			if(txtddd.Text != String.Empty)
				registro.ddd = Convert.ToString(txtddd.Text);

			if(txttelefonefixo.Text != String.Empty)
				registro.telefonefixo = Convert.ToString(txttelefonefixo.Text);

			if(txttelefonecelular.Text != String.Empty)
				registro.telefonecelular = Convert.ToString(txttelefonecelular.Text);

			if(txtcep.Text != String.Empty)
				registro.cep = Convert.ToString(txtcep.Text);

			if(txtobservacoes.Text != String.Empty)
				registro.observacoes = Convert.ToString(txtobservacoes.Text);

			if(txtlogin.Text != String.Empty)
				registro.login = Convert.ToString(txtlogin.Text);

			if(txtsenha.Text != String.Empty)
				registro.senha = Convert.ToString(txtsenha.Text);

			if(txtdatainclusao.Text != String.Empty)
				if ( LojaElfez.Global.IsDate ( txtdatainclusao.Text) )
					registro.datainclusao = Convert.ToDateTime(txtdatainclusao.Text );



            ds = registro.FindAllInDataSet();

            this.lblMensagemRetorno.Text = registro.mensagem;
 
            dtgRegistros.AutoGenerateColumns = false;

            dtgRegistros.DataSource = ds.Tables[0];

            dtgRegistros.Columns.Clear();

			//Criacao da coluna:cliente 
			BoundField bdfcliente = new BoundField();
			bdfcliente.HeaderText = "Cliente";
			bdfcliente.DataField ="cliente";
			dtgRegistros.Columns.Insert(0, bdfcliente);
			
			//Criacao da coluna:cpf_cnpj 
			BoundField bdfcpf_cnpj = new BoundField();
			bdfcpf_cnpj.HeaderText = "Cpf_cnpj";
			bdfcpf_cnpj.DataField ="cpf_cnpj";
			dtgRegistros.Columns.Insert(1, bdfcpf_cnpj);
			
			//Criacao da coluna:nome 
			BoundField bdfnome = new BoundField();
			bdfnome.HeaderText = "Nome";
			bdfnome.DataField ="nome";
			dtgRegistros.Columns.Insert(2, bdfnome);
			
			//Criacao da coluna:email 
			BoundField bdfemail = new BoundField();
			bdfemail.HeaderText = "Email";
			bdfemail.DataField ="email";
			dtgRegistros.Columns.Insert(3, bdfemail);
			
			//Criacao da coluna:endereco 
			BoundField bdfendereco = new BoundField();
			bdfendereco.HeaderText = "Endereco";
			bdfendereco.DataField ="endereco";
			dtgRegistros.Columns.Insert(4, bdfendereco);
			
			//Criacao da coluna:bairro 
			BoundField bdfbairro = new BoundField();
			bdfbairro.HeaderText = "Bairro";
			bdfbairro.DataField ="bairro";
			dtgRegistros.Columns.Insert(5, bdfbairro);
			
			//Criacao da coluna:cidade 
			BoundField bdfcidade = new BoundField();
			bdfcidade.HeaderText = "Cidade";
			bdfcidade.DataField ="cidade";
			dtgRegistros.Columns.Insert(6, bdfcidade);
			
			//Criacao da coluna:estado 
			BoundField bdfestado = new BoundField();
			bdfestado.HeaderText = "Estado";
			bdfestado.DataField ="estado";
			dtgRegistros.Columns.Insert(7, bdfestado);
			
			//Criacao da coluna:ddd 
			BoundField bdfddd = new BoundField();
			bdfddd.HeaderText = "Ddd";
			bdfddd.DataField ="ddd";
			dtgRegistros.Columns.Insert(8, bdfddd);
			
			//Criacao da coluna:telefonefixo 
			BoundField bdftelefonefixo = new BoundField();
			bdftelefonefixo.HeaderText = "Telefonefixo";
			bdftelefonefixo.DataField ="telefonefixo";
			dtgRegistros.Columns.Insert(9, bdftelefonefixo);
			
			//Criacao da coluna:telefonecelular 
			BoundField bdftelefonecelular = new BoundField();
			bdftelefonecelular.HeaderText = "Telefonecelular";
			bdftelefonecelular.DataField ="telefonecelular";
			dtgRegistros.Columns.Insert(10, bdftelefonecelular);
			
			//Criacao da coluna:cep 
			BoundField bdfcep = new BoundField();
			bdfcep.HeaderText = "Cep";
			bdfcep.DataField ="cep";
			dtgRegistros.Columns.Insert(11, bdfcep);
			
			//Criacao da coluna:observacoes 
			BoundField bdfobservacoes = new BoundField();
			bdfobservacoes.HeaderText = "Observacoes";
			bdfobservacoes.DataField ="observacoes";
			dtgRegistros.Columns.Insert(12, bdfobservacoes);
			
			//Criacao da coluna:login 
			BoundField bdflogin = new BoundField();
			bdflogin.HeaderText = "Login";
			bdflogin.DataField ="login";
			dtgRegistros.Columns.Insert(13, bdflogin);
			
			//Criacao da coluna:senha 
			BoundField bdfsenha = new BoundField();
			bdfsenha.HeaderText = "Senha";
			bdfsenha.DataField ="senha";
			dtgRegistros.Columns.Insert(14, bdfsenha);
			
			//Criacao da coluna:datainclusao 
			BoundField bdfdatainclusao = new BoundField();
			bdfdatainclusao.HeaderText = "Datainclusao";
			bdfdatainclusao.DataField ="datainclusao";
			dtgRegistros.Columns.Insert(15, bdfdatainclusao);
			


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
				txtcliente.Text = String.Empty;
				txtcpf_cnpj.Text = String.Empty;
				txtnome.Text = String.Empty;
				txtemail.Text = String.Empty;
				txtendereco.Text = String.Empty;
				txtbairro.Text = String.Empty;
				txtcidade.Text = String.Empty;
				txtestado.Text = String.Empty;
				txtddd.Text = String.Empty;
				txttelefonefixo.Text = String.Empty;
				txttelefonecelular.Text = String.Empty;
				txtcep.Text = String.Empty;
				txtobservacoes.Text = String.Empty;
				txtlogin.Text = String.Empty;
				txtsenha.Text = String.Empty;
				txtdatainclusao.Text = String.Empty;

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