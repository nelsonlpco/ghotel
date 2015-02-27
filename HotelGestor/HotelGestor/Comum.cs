using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor
{
    class Comum
    {
        public static string EMPRESA = "Gestor Hoteleiro";

        public static string MSG_EXCLUIR     = "Deseja excluir este registro?";
        public static string MSG_SEMREGISTRO = "Não existem registros!";
        public static string MSG_EMEDICAO    = "Cancele ou conclua a operação!";

        public static string screenStats(char e)
        {
            switch (e)
            {
                case 'c': return "Consulta de registros."; break;
                case 'i': return "Inclusão de registro."; break;
                case 'd': return "Exclusão de registro."; break;
                case 'e': return "Edição de registro."; break;
                case 't': return "Seleção de registro."; break;
            }
            return "";
        }

        public static bool msgExcluir(string msg)
        {
            bool saida = false;
            if(MessageBox.Show(msg, "Pergunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                saida = true;
            return saida;
        }

        public static void msgAlert(string msg)
        {
            MessageBox.Show(msg, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void msgErro(string msg)
        {
            MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string[] buscacep(string cep)
        {
            HotelDBDataSet dataset = new HotelGestor.HotelDBDataSet();
            System.Windows.Forms.BindingSource enderecoBindingSource = new System.Windows.Forms.BindingSource() ;
            HotelDBDataSetTableAdapters.enderecoTableAdapter enderecoTableAdapter = 
                new HotelGestor.HotelDBDataSetTableAdapters.enderecoTableAdapter(); 
            
            enderecoBindingSource.DataMember = "endereco";
            enderecoBindingSource.DataSource = dataset;
            
            DataTable dt = enderecoTableAdapter.GetDataByCep(cep);
            
            string[] saida = new string[5];


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    saida[0] = row[2].ToString();
                    saida[1] = row[3].ToString();
                    saida[2] = row[4].ToString();
                    saida[3] = row[5].ToString();
                }
            }
            else
            {
                try
                {
                    HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaEnderecoAction.do?Metodo=listaLogradouro&CEP=" + cep + "&TipoConsulta=cep");
                    HttpWebResponse resposta  = (HttpWebResponse)requisicao.GetResponse();
                    int cont;
                    byte[] buffer = new byte[1000];
                    StringBuilder sb = new StringBuilder();
                    string temp;
                    Stream stream = resposta.GetResponseStream();
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
                        enderecoBindingSource.AddNew();
                        DataRowView current = (DataRowView)enderecoBindingSource.Current;
                        current["cep"]      = cep;
                        current["cidade"]   = saida[2];
                        current["uf"]       = saida[3];
                        current["bairro"]   = saida[1];
                        current["endereco"] = saida[0];
                        enderecoBindingSource.EndEdit();
                        enderecoTableAdapter.Update(dataset.endereco);
                    }
                }
                catch (Exception ex)
                {
                    Comum.msgErro("Problema ao buscar CEP no sistema de correios.");
                }
            }
            
            
            

            return saida;
        }

    
    }
}
