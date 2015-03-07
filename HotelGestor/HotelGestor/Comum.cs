using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor
{

    enum HOSPEDAGEM_STATS
    {
        ABERTA = 1,
        EDEICAO = 2,
        FECHADA
    };



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
                    saida[2] = row[2].ToString();
                    saida[3] = row[3].ToString();
                    saida[1] = row[4].ToString();
                    saida[0] = row[5].ToString();
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

        public static void confNomeProprio(object Sender )
        {
            string entrada = ((TextBox)Sender).Text;
            if (string.IsNullOrEmpty(entrada))
                return;
            string saida = "";
            saida += Char.ToUpper(entrada[0]);
            for (int i = 1; i < entrada.Length; i++)
            {
                try
                {
                    if (entrada[i - 1] == ' ' && ((entrada[i+2] != ' ') && (entrada[i+3] != ' ')) && !Char.IsDigit(entrada[i]))
                    {
                        saida += Char.ToUpper(entrada[i]);
                    }
                    else
                        saida += entrada[i];
                }catch(Exception e){
                    saida += entrada[i];
                }
            }
            
            ((TextBox)Sender).Text = saida;
        }

        public static void toUpper(object Sender)
        {
            string entrada = ((TextBox)Sender).Text;
            ((TextBox)Sender).Text = entrada.ToUpper();
        }

        public static void firstUpper(object Sender)
        {
            string entrada = ((TextBox)Sender).Text;
            ((TextBox)Sender).Text = Char.ToUpper(entrada[0]) + entrada.Substring(1);
        }

        public static void dinamicMasck(object sender)
        {  
            TextBox tb = sender as TextBox;
            if (tb.Text.Length > 0)
            {
                decimal cubic = Convert.ToDecimal(tb.Text);
                tb.Text = string.Format("{0:c}", Convert.ToDecimal(cubic));
            }
        }

     
        public static void moneyMask(object sender)
        {
            TextBox txt = sender as TextBox;
            

            string n = txt.Text.Replace(",", "").Replace(".", "");
            double v = 0;
            if (n.Equals(""))
                n = "";
            n = n.PadLeft(3, '0');
            if ((n.Length > 3) && n.Substring(0, 1) == "0")
            {
                n = n.Substring(1, n.Length-1);
            }
            v = Convert.ToDouble(n) / 100;
            txt.Text = string.Format("{0:N}", v);
            txt.SelectionStart = txt.Text.Length;
        }

        public static double strToDouble(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
                return 0;
            entrada.Replace(".","");
            entrada.Replace(",",".");
            return double.Parse(entrada, NumberStyles.AllowDecimalPoint);
        }

    
    }
}
