using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Frequência_Cardíaca
{
    class FrequenciaCardiaca
    {
        private int idade;
        private char sexo;

        public void setDados(int idade, char sexo)
        {
            if (idade <= 0)
            {
                throw new IdadeException();
            }

            this.idade = idade;
            this.sexo = sexo;
        }

        public int CalculaFcMax()
        {
            if (sexo.Equals('m'))
            {
                return 220 - idade;
            }

            return 226 - idade;
        }

        public IntervaloFcMax CalculaFcMaxCaminhada()
        {
            IntervaloFcMax MaxCaminhada = new IntervaloFcMax();
            int fcMax = CalculaFcMax();

            MaxCaminhada.minFc = fcMax * 0.55;
            MaxCaminhada.maxFc = fcMax * 0.6;

            return MaxCaminhada;
        }

        public IntervaloFcMax CalculaFcMaxCorridaLeve()
        {
            IntervaloFcMax MaxCorridaLeve = new IntervaloFcMax();
            int fcMax = CalculaFcMax();

            MaxCorridaLeve.minFc = fcMax * 0.75;
            MaxCorridaLeve.maxFc = fcMax * 0.8;

            return MaxCorridaLeve;
        }

        public IntervaloFcMax CalculaFcMaxCorridaIntensa()
        {
            IntervaloFcMax MaxCorridaIntensa = new IntervaloFcMax();
            int fcMax = CalculaFcMax();

            MaxCorridaIntensa.minFc = fcMax * 0.95;
            MaxCorridaIntensa.maxFc = fcMax;

            return MaxCorridaIntensa;
        }
    }
}
