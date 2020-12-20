using System;

namespace Wesley
{
    class VOO
    {
        public int Id_VOO { get; set; } 
        public string Data_VOO { get; set; }
        public double Custo { get; set; }
        public int Distancia { get; set; }
        public string Captura { get; set; }
        public int Nivel_Dor { get; set; }

        public VOO(int id_VOO, string data_VOO, double custo, int distancia, string captura, int nivel_Dor)
        {
            Id_VOO = id_VOO;
            Data_VOO = data_VOO;
            Custo = custo;
            Distancia = distancia;
            Captura = captura;
            Nivel_Dor = nivel_Dor;
        }

        public VOO() { }

    }
}


/* ID_VOO int; 
DATA_VOO Date
CUSTO double
DISTANCIA int 
CAPTURA char
NIVEL_DOR int */