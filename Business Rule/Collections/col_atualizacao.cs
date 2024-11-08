	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Collection Layer                         * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: frm_atualizacao                          * 
	 *                                                    * 
	 *  Objeto gerado automaticamente pelo TierGenerator  * 
	 *                                                    * 
	 *  Versao do programa:                 *  
	 *                                                    * 
	 *  Data da criacao: 26/10/2010                       * 
	 *  Hora de criacao: 09:42:18                         * 
	 *                                                    *  
	 *                                                    *  
	*********************************************************/

using System;
using LojaElfez.BusinessRule;

namespace LojaElfez.BusinessCollection
{  
	/// <summary>
	/// Definicao da collection col_atualizacao
	/// Esta classe representa uma lista de objetos da tabela atualizacao (representados pela classe rul_atualizacao) no banco de dados
	/// 
	/// </summary>
	public class col_atualizacao : System.Collections.CollectionBase 
	{
		public col_atualizacao()
		{
		}
		public col_atualizacao( int par_atualizacao)
		{
			rul_atualizacao atualizacao = new rul_atualizacao();


			atualizacao.atualizacao = par_atualizacao;
 

			col_atualizacao lista = atualizacao.GetAll();
				
			foreach (rul_atualizacao item in lista)
			{
				this.Add(item);
			}

		}

		public void Add (rul_atualizacao item)
		{
			List.Add( item);
		}

		public void Remove (rul_atualizacao item)
		{
			List.Remove(item);
		}

		public int Find(rul_atualizacao item)
		{
			return List.IndexOf(item);
		}

		public rul_atualizacao Item(int index)
		{
			return (rul_atualizacao) List[index];
		}
	}
}