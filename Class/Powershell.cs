using System;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Windows.Forms;

namespace DBSavior.Class
{
    public class Powershell
    {
        public string mensagem = "";

        public Powershell()
        {
        }

        /// <summary>
        /// Executa o comando no PowerShell
        /// <para><returns>Retorna um boolean se funcionou ou não</returns></para>
        /// <code>Armazena na variável "mensagem" a resposta do PowerShell</code>
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public bool PowerShell(String comando)
        {
            try
            {
                Application.DoEvents();
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                Pipeline pipeline = runspace.CreatePipeline();
                pipeline.Commands.AddScript(comando);
                pipeline.Commands.Add("Out-String");
                Collection<PSObject> results = pipeline.Invoke();
                runspace.Close();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (PSObject pSObject in results)
                    stringBuilder.Append(pSObject.ToString());
                mensagem = stringBuilder.ToString();
                return true;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return false;
            }
        }
    }
}
