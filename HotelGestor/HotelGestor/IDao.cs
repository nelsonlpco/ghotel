using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestor
{
    interface IDao
    {
        bool SavePrompt { get; set; }
        bool IsInclude { get; set; }

        void salvar();
        void incluir();
        void excluir();
        void cancelar();
        void selecionar();

        void filtro();

        bool isEmptyDataset();

        
    }
}
