using System;
using System.Windows.Forms;
/* *********************************************************************************
** 
**   Name:        ExceptionManager.cs
**
**   Decription:  Logs and processes all application exceptions. 
**                
**   Remarks:     This class has the same structure as the Microsoft Exception Management
**                Application Block for .NET. For more information, see 
**                http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnbda/html/daag.asp
**
**                By using this generic structure, the Extrasoft Exception Manager
**                can be replaced with the one developed by Microsoft. In time,
**                we will replace this class with the one from Microsoft.
**
** Remarks:       This class was developed as part of VS.NET beta 2. Microsoft 
**                are planning a version of this class around April 2002 which 
**                will be released for the VS.NET RTM version.
**
************************************************************************************
**  Change No:   Date:          Author:   Description:
**  _________    ___________    ______    ______________________________________
**     001       14-Mar-2002    Extrasoft Created.
**     002       07-Aug-2002    Extrasoft Added warning if no stored proc found.
**                                
** ****************************************************************************** */
public sealed class ExceptionManager
{


    /// <summary>
    /// Private constructor to restrict an instance of this class from being 
    /// created with "new ExceptionManager()".
    /// </summary>
    private ExceptionManager() {}


    /// <summary>
    /// Static method to publish the exception information.
    /// </summary>
    /// <remarks>
    /// At the moment, this proc only displays the exception to the user. When
    /// the Micrsoft Exception Management Block will be used, this method will
    /// be able to log the exception to various places (e.g. database, log file).
    /// </remarks>
    public static void Publish(Exception ex)
    {
          //Change 002: ensure users have generated stored procs and installed them on the database.
		//TODO: Please remove this check. It is only included for users new to Extrasoft.NET.
		
		if (ex.GetType().ToString() == "System.Data.SqlClient.SqlException")
		{
			System.Data.SqlClient.SqlException erro = 	(System.Data.SqlClient.SqlException) ex;
			string mensagem = "";
			string mensagem2 = "";
			
			if (erro.Errors.Count > 0 )
			{
				foreach ( System.Data.SqlClient.SqlError err in erro.Errors  )
				{
					if (err.Number == 25100)
					{
						mensagem = err.Message;
					}
					if (err.Number == 1222)
						mensagem = "Registro em uso por outra aplicação";

					mensagem2 += "\n\r" + err.Message;
				}
			}
			else
				mensagem2 = erro.Message;

			if (mensagem == string.Empty)
				MessageBox.Show( mensagem2, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
			else
                MessageBox.Show(mensagem, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}
		else
		{
		
			if (ex.Message.ToUpper().StartsWith("COULD NOT FIND STORED PROCEDURE"))
			{
				MessageBox.Show(ex.Message + "\n\r\n\r" + "Please make sure that you have generated the SQL scripts and that you have installed them on the database." + "\n\r\n\r" + "For more information, please consult Tutorial 3.0 of the Extrasoft.NET Tutorial document.", "Infocel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (ex.Message.ToUpper() == "TIMESTAMP ERROR")
			{
				MessageBox.Show("The changes you made were not sucessfully saved because another user updated the record while you were performing the operation.\n\r\n\rPlease close the screen, refresh the data and try the operation again.", "Infocel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if ((ex.Message.ToUpper().IndexOf("YEAR, MONTH") > 0) & (ex.StackTrace.ToUpper().IndexOf("IBM.DATA.DB2") > 0))
			{
				MessageBox.Show("There is a mismatch between the server date format and the date format for DB2. Please see http://www7b.software.ibm.com/dmdd/library/techarticle/0211yip/0211yip3.html for more information. Please note that this is not a problem with the generated code.", "Infocel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			else if (ex.Message.ToUpper() == "SQLCONNECTION DOES NOT SUPPORT PARALLEL TRANSACTIONS.")
			{
				MessageBox.Show("Você não pode bloquear mais de um registro", "Infocel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else

			{
				//MessageBox.Show(ex.Source + "\n\r\n\r" + ex.Message + "\n\r\n\r" + ex.StackTrace, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				string caminhoerro = ex.StackTrace;
				string[] erros = new string[100];
				erros = caminhoerro.Split('\n');


				MessageBox.Show(ex.Source + "\n\r\n\r" + ex.Message + "\n\r\n\r" + erros[erros.Length-1].ToString().Trim() , "Infocel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}
    }


}




