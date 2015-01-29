using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorHoteleiro
{
    class Comum
    {

        public static string MSG_SEMREGISTRO = "Sem registros para edição.";
        public static string MSG_EDICAO      = "Por favor conclua a operação antes de sair.";
        public static string MSG_EXCLUSAO    = "Deseja realmente excluir o registro?";

        public static string[] buscacep(string cep)
        {
            string[] saida = new string[4];
            try
            {
                HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaEnderecoAction.do?Metodo=listaLogradouro&CEP=" + cep + "&TipoConsulta=cep");
                HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();
                int cont;
                byte[] buffer = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp; Stream stream = resposta.GetResponseStream();
                do
                {
                    cont = stream.Read(buffer, 0, buffer.Length);
                    temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                    sb.Append(temp);
                } while (cont > 0);
                string pagina = sb.ToString();
                if (pagina.IndexOf("<font color=\"black\">CEP NAO ENCONTRADO</font>") >= 0)
                {
                    MessageBox.Show("CEP Não encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    saida[0] = Regex.Match(pagina, "<td width=\"268\" style=\"padding: 2px\">(.*)</td>").Groups[1].Value;
                    saida[1] = Regex.Matches(pagina, "<td width=\"140\" style=\"padding: 2px\">(.*)</td>")[0].Groups[1].Value;
                    saida[2] = Regex.Matches(pagina, "<td width=\"140\" style=\"padding: 2px\">(.*)</td>")[1].Groups[1].Value;
                    saida[3] = Regex.Match(pagina, "<td width=\"25\" style=\"padding: 2px\">(.*)</td>").Groups[1].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao buscar CEP no sistema de correios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return saida;
        }

        
    }

    
}
