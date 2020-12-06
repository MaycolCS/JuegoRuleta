using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaMasivian.dao
{
    class ruleta
    {
        private Int32 idRuleta;
        private string estadoRuleta;
        private Int32 valorApuestas;
        private List<Int32?> colorApuesta_Rojo = new List<Int32?>();
        private List<Int32?> colorApuesta_Negro = new List<Int32?>();
        private List<Int32?> apuesta_num0 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num1 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num2 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num3 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num4 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num5 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num6 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num7 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num8 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num9 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num10 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num11 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num12 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num13 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num14 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num15 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num16 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num17 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num18 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num19 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num20 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num21 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num22 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num23 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num24 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num25 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num26 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num27 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num28 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num29 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num30 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num31 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num32 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num33 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num34 = new List<Int32?>(); //red
        private List<Int32?> apuesta_num35 = new List<Int32?>(); //black
        private List<Int32?> apuesta_num36 = new List<Int32?>(); //red
        private List<Int32?> clientes_apostadores = new List<Int32?> ();

        public int IdRuleta { get => idRuleta; set => idRuleta = value; }
        public string EstadoRuleta { get => estadoRuleta; set => estadoRuleta = value; }
        public int ValorApuestas { get => valorApuestas; set => valorApuestas = value; }
        public List<int?> ColorApuesta_Rojo { get => colorApuesta_Rojo; set => colorApuesta_Rojo = value; }
        public List<int?> ColorApuesta_Negro { get => colorApuesta_Negro; set => colorApuesta_Negro = value; }
        public List<int?> Apuesta_num0 { get => apuesta_num0; set => apuesta_num0 = value; }
        public List<int?> Apuesta_num1 { get => apuesta_num1; set => apuesta_num1 = value; }
        public List<int?> Apuesta_num2 { get => apuesta_num2; set => apuesta_num2 = value; }
        public List<int?> Apuesta_num3 { get => apuesta_num3; set => apuesta_num3 = value; }
        public List<int?> Apuesta_num4 { get => apuesta_num4; set => apuesta_num4 = value; }
        public List<int?> Apuesta_num5 { get => apuesta_num5; set => apuesta_num5 = value; }
        public List<int?> Apuesta_num6 { get => apuesta_num6; set => apuesta_num6 = value; }
        public List<int?> Apuesta_num7 { get => apuesta_num7; set => apuesta_num7 = value; }
        public List<int?> Apuesta_num8 { get => apuesta_num8; set => apuesta_num8 = value; }
        public List<int?> Apuesta_num9 { get => apuesta_num9; set => apuesta_num9 = value; }
        public List<int?> Apuesta_num10 { get => apuesta_num10; set => apuesta_num10 = value; }
        public List<int?> Apuesta_num11 { get => apuesta_num11; set => apuesta_num11 = value; }
        public List<int?> Apuesta_num12 { get => apuesta_num12; set => apuesta_num12 = value; }
        public List<int?> Apuesta_num13 { get => apuesta_num13; set => apuesta_num13 = value; }
        public List<int?> Apuesta_num14 { get => apuesta_num14; set => apuesta_num14 = value; }
        public List<int?> Apuesta_num15 { get => apuesta_num15; set => apuesta_num15 = value; }
        public List<int?> Apuesta_num16 { get => apuesta_num16; set => apuesta_num16 = value; }
        public List<int?> Apuesta_num17 { get => apuesta_num17; set => apuesta_num17 = value; }
        public List<int?> Apuesta_num18 { get => apuesta_num18; set => apuesta_num18 = value; }
        public List<int?> Apuesta_num19 { get => apuesta_num19; set => apuesta_num19 = value; }
        public List<int?> Apuesta_num20 { get => apuesta_num20; set => apuesta_num20 = value; }
        public List<int?> Apuesta_num21 { get => apuesta_num21; set => apuesta_num21 = value; }
        public List<int?> Apuesta_num22 { get => apuesta_num22; set => apuesta_num22 = value; }
        public List<int?> Apuesta_num23 { get => apuesta_num23; set => apuesta_num23 = value; }
        public List<int?> Apuesta_num24 { get => apuesta_num24; set => apuesta_num24 = value; }
        public List<int?> Apuesta_num25 { get => apuesta_num25; set => apuesta_num25 = value; }
        public List<int?> Apuesta_num26 { get => apuesta_num26; set => apuesta_num26 = value; }
        public List<int?> Apuesta_num27 { get => apuesta_num27; set => apuesta_num27 = value; }
        public List<int?> Apuesta_num28 { get => apuesta_num28; set => apuesta_num28 = value; }
        public List<int?> Apuesta_num29 { get => apuesta_num29; set => apuesta_num29 = value; }
        public List<int?> Apuesta_num30 { get => apuesta_num30; set => apuesta_num30 = value; }
        public List<int?> Apuesta_num31 { get => apuesta_num31; set => apuesta_num31 = value; }
        public List<int?> Apuesta_num32 { get => apuesta_num32; set => apuesta_num32 = value; }
        public List<int?> Apuesta_num33 { get => apuesta_num33; set => apuesta_num33 = value; }
        public List<int?> Apuesta_num34 { get => apuesta_num34; set => apuesta_num34 = value; }
        public List<int?> Apuesta_num35 { get => apuesta_num35; set => apuesta_num35 = value; }
        public List<int?> Apuesta_num36 { get => apuesta_num36; set => apuesta_num36 = value; }
        public List<int?> Clientes_apostadores { get => clientes_apostadores; set => clientes_apostadores = value; }
    }
}
