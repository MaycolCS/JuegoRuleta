using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebaMasivian.dao;

namespace pruebaMasivian
{
    public partial class Form1 : Form
    {

        private List<ruleta> listaRuletas = new List<ruleta> ();
        private List<cliente> listaClientes = new List<cliente> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_GenerarIdRuleta_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int randomIdRuleta = 0;
            if (listaRuletas.Count == 0)
            {
                randomIdRuleta = rand.Next(0, 100000);
            }
            else
            {
                int auxrandomIdRuleta = rand.Next(0, 100000);
                for (int i = 0; i < listaRuletas.Count; i++)
                {
                    if (listaRuletas[i].IdRuleta == auxrandomIdRuleta)
                    {
                        auxrandomIdRuleta = rand.Next(0, 100000);
                        i = 0;
                    }
                }
                randomIdRuleta = auxrandomIdRuleta;
            }
            ruleta nuevaRuleta = new ruleta();
            nuevaRuleta.IdRuleta = randomIdRuleta;
            nuevaRuleta.EstadoRuleta = "Abierta";
            nuevaRuleta.ValorApuestas = 0;
            listaRuletas.Add(nuevaRuleta);
            this.idRuleta.Text = nuevaRuleta.IdRuleta.ToString();
            this.comboBox_ListaRuletas.Items.Clear();
            this.comboBox_IdRuletaCerrada.Items.Clear();
            this.comboBox_IngresoIdRuleta.Items.Clear();
            for (int j = 0; j < listaRuletas.Count; j++)
            {
                this.comboBox_ListaRuletas.Items.Add(listaRuletas[j].IdRuleta);
                if (listaRuletas[j].EstadoRuleta == "Abierta")
                {
                    this.comboBox_IdRuletaCerrada.Items.Add(listaRuletas[j].IdRuleta);
                    this.comboBox_IngresoIdRuleta.Items.Add(listaRuletas[j].IdRuleta);
                }
            }
        }

        private string estateRuleta(int idRuleta)
        {
            string estate = "";
            for (int i = 0; i < listaRuletas.Count; i++)
            {
                if (listaRuletas[i].IdRuleta == idRuleta)
                {
                    estate = listaRuletas[i].EstadoRuleta;
                }
            }
            return estate;
        }

        private void crearCliente()
        {
            cliente nuevoCliente = new cliente();
            nuevoCliente.IdCliente = 123456789;
            nuevoCliente.SaldoCliente = 5000000;
            listaClientes.Add(nuevoCliente);
        }

        private string addBetRuleta(int valueBet, int numberBet, string colorBet, int idRuleta, int idCliente)
        {
            string message = "";
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].IdCliente == idCliente)
                {
                    for (int j = 0; j < listaRuletas.Count; j++)
                    {
                        if (listaRuletas[j].IdRuleta == idRuleta)
                        {
                            if (listaClientes[i].IdApuestaCliente.Count == 0)
                            {
                                listaClientes[i].IdApuestaCliente.Add(1);
                            }
                            else if (listaClientes[i].IdApuestaCliente.Count != 0)
                            {
                                listaClientes[i].IdApuestaCliente.Add(listaClientes[i].IdApuestaCliente.Count+1);
                            }
                            listaClientes[i].ValorApuestaCliente.Add(valueBet);
                            listaClientes[i].IdRuletaApuesta = idRuleta;
                            listaClientes[i].SaldoCliente -= valueBet;
                            listaRuletas[j].Clientes_apostadores.Add(idCliente);
                            listaRuletas[j].ValorApuestas += valueBet;
                            if (numberBet != (-1))
                            {
                                listaClientes[i].ApuestaCliente.Add(numberBet.ToString());
                                switch (numberBet)
                                {
                                    case 0:
                                        listaRuletas[j].Apuesta_num0.Add(valueBet);
                                        break;
                                    case 1:
                                        listaRuletas[j].Apuesta_num1.Add(valueBet);
                                        break;
                                    case 2:
                                        listaRuletas[j].Apuesta_num2.Add(valueBet);
                                        break;
                                    case 3:
                                        listaRuletas[j].Apuesta_num3.Add(valueBet);
                                        break;
                                    case 4:
                                        listaRuletas[j].Apuesta_num4.Add(valueBet);
                                        break;
                                    case 5:
                                        listaRuletas[j].Apuesta_num5.Add(valueBet);
                                        break;
                                    case 6:
                                        listaRuletas[j].Apuesta_num6.Add(valueBet);
                                        break;
                                    case 7:
                                        listaRuletas[j].Apuesta_num7.Add(valueBet);
                                        break;
                                    case 8:
                                        listaRuletas[j].Apuesta_num8.Add(valueBet);
                                        break;
                                    case 9:
                                        listaRuletas[j].Apuesta_num9.Add(valueBet);
                                        break;
                                    case 10:
                                        listaRuletas[j].Apuesta_num10.Add(valueBet);
                                        break;
                                    case 11:
                                        listaRuletas[j].Apuesta_num11.Add(valueBet);
                                        break;
                                    case 12:
                                        listaRuletas[j].Apuesta_num12.Add(valueBet);
                                        break;
                                    case 13:
                                        listaRuletas[j].Apuesta_num13.Add(valueBet);
                                        break;
                                    case 14:
                                        listaRuletas[j].Apuesta_num14.Add(valueBet);
                                        break;
                                    case 15:
                                        listaRuletas[j].Apuesta_num15.Add(valueBet);
                                        break;
                                    case 16:
                                        listaRuletas[j].Apuesta_num16.Add(valueBet);
                                        break;
                                    case 17:
                                        listaRuletas[j].Apuesta_num17.Add(valueBet);
                                        break;
                                    case 18:
                                        listaRuletas[j].Apuesta_num18.Add(valueBet);
                                        break;
                                    case 19:
                                        listaRuletas[j].Apuesta_num19.Add(valueBet);
                                        break;
                                    case 20:
                                        listaRuletas[j].Apuesta_num20.Add(valueBet);
                                        break;
                                    case 21:
                                        listaRuletas[j].Apuesta_num21.Add(valueBet);
                                        break;
                                    case 22:
                                        listaRuletas[j].Apuesta_num22.Add(valueBet);
                                        break;
                                    case 23:
                                        listaRuletas[j].Apuesta_num23.Add(valueBet);
                                        break;
                                    case 24:
                                        listaRuletas[j].Apuesta_num24.Add(valueBet);
                                        break;
                                    case 25:
                                        listaRuletas[j].Apuesta_num25.Add(valueBet);
                                        break;
                                    case 26:
                                        listaRuletas[j].Apuesta_num26.Add(valueBet);
                                        break;
                                    case 27:
                                        listaRuletas[j].Apuesta_num27.Add(valueBet);
                                        break;
                                    case 28:
                                        listaRuletas[j].Apuesta_num28.Add(valueBet);
                                        break;
                                    case 29:
                                        listaRuletas[j].Apuesta_num29.Add(valueBet);
                                        break;
                                    case 30:
                                        listaRuletas[j].Apuesta_num30.Add(valueBet);
                                        break;
                                    case 31:
                                        listaRuletas[j].Apuesta_num31.Add(valueBet);
                                        break;
                                    case 32:
                                        listaRuletas[j].Apuesta_num32.Add(valueBet);
                                        break;
                                    case 33:
                                        listaRuletas[j].Apuesta_num33.Add(valueBet);
                                        break;
                                    case 34:
                                        listaRuletas[j].Apuesta_num34.Add(valueBet);
                                        break;
                                    case 35:
                                        listaRuletas[j].Apuesta_num35.Add(valueBet);
                                        break;
                                    case 36:
                                        listaRuletas[j].Apuesta_num36.Add(valueBet);
                                        break;
                                }
                                message = "Apuesta al " + numberBet + " agregada por valor de: " + valueBet;
                            }
                            else
                            {
                                if (colorBet == "Negro")
                                {
                                    listaRuletas[j].ColorApuesta_Negro.Add(valueBet);
                                }
                                else if (colorBet == "Rojo")
                                {
                                    listaRuletas[j].ColorApuesta_Rojo.Add(valueBet);
                                }
                                listaClientes[i].ApuestaCliente.Add(colorBet);
                                message = "Apuesta al color " + colorBet + " agregada por valor de: " + valueBet;
                            }
                        }
                    }
                    
                }
            }
            return message;
        }

        private void button_ConsultarEstadoRuleta_Click(object sender, EventArgs e)
        {
            if (listaRuletas.Count != 0)
            {
                if (this.comboBox_ListaRuletas.SelectedItem != null)
                {
                    int valueRuletaSelected = Convert.ToInt32(this.comboBox_ListaRuletas.SelectedItem.ToString());
                    this.label_EstadoRuletaConsultada.Text = estateRuleta(valueRuletaSelected);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un ID de la ruleta a consultar");
                }
            }
            else
            {
                MessageBox.Show("Aún no hay ruletas creadas");
            }
            
        }

        private bool validRuleta(int idRuleta)
        {
            bool valid = false;
            for (int i = 0; i < listaRuletas.Count; i++)
            {
                if (listaRuletas[i].IdRuleta == idRuleta)
                {
                    if (listaRuletas[i].EstadoRuleta == "Abierta")
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        private bool validValueBetsRuleta(int idRuleta)
        {
            bool valid = false;
            for (int i = 0; i < listaRuletas.Count; i++)
            {
                if (listaRuletas[i].IdRuleta == idRuleta)
                {
                    if (listaRuletas[i].ValorApuestas <= 10000)
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        private bool validCliente(int idCliente)
        {
            bool valid = false;
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].IdCliente == idCliente)
                {
                    valid = true;
                }
            }
            return valid;
        }

        private void button_RealizarApuesta_Click(object sender, EventArgs e)
        {
            if (this.comboBox_IngresoIdRuleta.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un ID de la ruleta en la que desea hacer la apuesta");
            }
            else if (!validRuleta(Convert.ToInt32(this.comboBox_IngresoIdRuleta.SelectedItem.ToString())))
            {
                MessageBox.Show("Debe ingresar un ID de ruleta que exista o se encuentre abierta");
            }
            else if (this.textBox_IngresoIdCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID del cliente que desea hacer la apuesta");
            }
            else if (!validCliente(Convert.ToInt32(this.textBox_IngresoIdCliente.Text)))
            {
                MessageBox.Show("Debe ingresar un ID del cliente que exista");
            }
            else if (this.comboBox_IngresoColorApuesta.SelectedItem == null && this.comboBox_IngresoNumeroApuesta.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un color o un número para la apuesta");
            }
            else if (this.textBox_IngresoValorApuesta.Text == "" || this.textBox_IngresoValorApuesta.Text == "0")
            {
                MessageBox.Show("Debe ingresar un valor para la apuesta");
            }
            else if (!validValueBetsRuleta(Convert.ToInt32(this.comboBox_IngresoIdRuleta.SelectedItem.ToString())))
            {
                MessageBox.Show("No se pueden ingresar más apuestas a la mesa " + this.comboBox_IngresoIdRuleta.SelectedItem.ToString());
            }
            else
            {
                int idRuleta = Convert.ToInt32(this.comboBox_IngresoIdRuleta.SelectedItem.ToString());
                int idCliente = Convert.ToInt32(this.textBox_IngresoIdCliente.Text);
                string colorApuesta = "";
                if (this.comboBox_IngresoColorApuesta.SelectedItem != null)
                {
                    colorApuesta = this.comboBox_IngresoColorApuesta.SelectedItem.ToString();
                }
                int numeroApuesta = -1;
                if (this.comboBox_IngresoNumeroApuesta.SelectedItem != null)
                {
                    numeroApuesta = Convert.ToInt32(this.comboBox_IngresoNumeroApuesta.SelectedItem.ToString());
                }
                int valorAPuesta = Convert.ToInt32(this.textBox_IngresoValorApuesta.Text);
                string messageBet = addBetRuleta(valorAPuesta, numeroApuesta, colorApuesta, idRuleta, idCliente);
                MessageBox.Show(messageBet);
                this.comboBox_IngresoIdRuleta.SelectedIndex = -1;
                this.textBox_IngresoIdCliente.Clear();
                this.textBox_IngresoValorApuesta.Clear();
                this.comboBox_IngresoColorApuesta.SelectedIndex = -1;
                this.comboBox_IngresoNumeroApuesta.SelectedIndex = -1;
            }
        }

        private List<int> winnerBets(int idRuleta, int winnerNumber, string winnerColor)
        {
            List<int> winners = new List<int>();
            
            for (int i = 0; i < listaRuletas.Count; i++)
            {
                if (listaRuletas[i].IdRuleta == idRuleta)
                {
                    for (int j = 0; j < listaRuletas[i].Clientes_apostadores.Count; j++)
                    {
                        for (int k = 0; k < listaClientes.Count; k++)
                        {
                            if (listaClientes[k].IdCliente == listaRuletas[i].Clientes_apostadores[j] &&
                                listaClientes[k].IdRuletaApuesta == idRuleta)
                            {
                                for (int h = 0; h < listaClientes[k].ApuestaCliente.Count; h++)
                                {
                                    bool valid_idApuestaCliente = false;
                                    if (winners.Count != 0)
                                    {
                                        for (int u = 0; u < winners.Count; u++)
                                        {
                                            if (winners[u + 1] == listaClientes[k].IdApuestaCliente[h])
                                            {
                                                valid_idApuestaCliente = true;
                                            }
                                            u += 3;
                                        }
                                    }
                                    if (listaClientes[k].ApuestaCliente[h] == winnerColor)
                                    {
                                        if (!valid_idApuestaCliente)
                                        {
                                            winners.Add(listaClientes[k].IdCliente);
                                            winners.Add(listaClientes[k].IdApuestaCliente[h]);
                                            if (listaClientes[k].ApuestaCliente[h] == "Rojo")
                                            {
                                                winners.Add(40);
                                            }
                                            else if (listaClientes[k].ApuestaCliente[h] == "Negro")
                                            {
                                                winners.Add(41);
                                            }
                                            winners.Add(listaClientes[k].ValorApuestaCliente[h]);
                                        }
                                    }
                                    else if (listaClientes[k].ApuestaCliente[h] == winnerNumber.ToString())
                                    {
                                        if (!valid_idApuestaCliente)
                                        {
                                            winners.Add(listaClientes[k].IdCliente);
                                            winners.Add(listaClientes[k].IdApuestaCliente[h]);
                                            winners.Add(Convert.ToInt32(listaClientes[k].ApuestaCliente[h]));
                                            winners.Add(listaClientes[k].ValorApuestaCliente[h]);
                                        }
                                    }
                                } 
                            }
                        }
                    }
                }
            }

            return winners;
        }

        private double calcularGananciaApuesta(int optionBet, int valueBet)
        {
            double gananciaObtenida = 0;
            if (optionBet == 40 || optionBet == 41)
            {
                gananciaObtenida = valueBet * 1.8;
            }
            else
            {
                gananciaObtenida = valueBet * 5;
            }

            return gananciaObtenida;
        }

        private void addGananciaCliente(int idCliente, double valueGanancia)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].IdCliente == idCliente)
                {
                    listaClientes[i].SaldoCliente += valueGanancia;
                    listaClientes[i].GananciasCliente += valueGanancia;
                    listaClientes[i].IdApuestaCliente.Clear();
                    listaClientes[i].ApuestaCliente.Clear();
                    listaClientes[i].ValorApuestaCliente.Clear();
                    listaClientes[i].IdRuletaApuesta = 0;
                }
            }
        }

        private void closeEstateClientes(int idRuleta)
        {
            for (int i = 0; i < listaRuletas.Count; i++)
            {
                if (listaRuletas[i].IdRuleta == idRuleta)
                {
                    for (int j = 0; j < listaRuletas[i].Clientes_apostadores.Count; j++)
                    {
                        for (int k = 0; k < listaClientes.Count; k++)
                        {
                            if (listaClientes[k].IdCliente == listaRuletas[i].Clientes_apostadores[j])
                            {
                                listaClientes[k].IdApuestaCliente.Clear();
                                listaClientes[k].ApuestaCliente.Clear();
                                listaClientes[k].ValorApuestaCliente.Clear();
                                listaClientes[k].IdRuletaApuesta = 0;
                            }
                        }
                    }
                }
            }
        }

        private void button_CerrarRuleta_Click(object sender, EventArgs e)
        {
            
            if (this.comboBox_IdRuletaCerrada.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un ID de la ruleta en la que desea cerrar");
            }
            else if (!validRuleta(Convert.ToInt32(this.comboBox_IdRuletaCerrada.SelectedItem.ToString())))
            {
                MessageBox.Show("Debe ingresar un ID de ruleta que exista o se encuentre abierta");
            }
            else
            {
                var randomValue = new Random();
                int winnerValue = randomValue.Next(0, 36);
                int idRuleta = Convert.ToInt32(this.comboBox_IdRuletaCerrada.SelectedItem.ToString());
                string colorNumber = "";
                if (winnerValue == 0)
                {
                    colorNumber = "Rojo";
                }
                else
                {
                    colorNumber = (winnerValue % 2 == 0) ? "Rojo" : "Negro";
                }
                this.textBox_ResultadoApuestas.Text = "Número ganador: " + winnerValue + "\r\n" +
                    "Color ganador: " + colorNumber + "\r\n";

                for (int i = 0; i < listaRuletas.Count; i++)
                {
                    if (listaRuletas[i].IdRuleta == idRuleta)
                    {
                        listaRuletas[i].EstadoRuleta = "Cerrada";
                        this.textBox_ResultadoApuestas.Text += "Valor total apuestas: " + listaRuletas[i].ValorApuestas + "\r\n";
                    }
                }

                List<int> listWinnersBets = winnerBets(idRuleta, winnerValue, colorNumber);
                if (listWinnersBets.Count != 0)
                {
                    this.textBox_ResultadoApuestas.Text += "Lista de ganadores: " + "\r\n";
                    for (int j = 0; j < listWinnersBets.Count; j++)
                    {
                        int optionWinner = listWinnersBets[j + 2];
                        this.textBox_ResultadoApuestas.Text += "\t Id ganador: " + listWinnersBets[j] + "\r\n";
                        if (optionWinner == 40)
                        {
                            this.textBox_ResultadoApuestas.Text += "\t Color apostado: Rojo" + "\r\n";
                        }
                        else if (optionWinner == 41)
                        {
                            this.textBox_ResultadoApuestas.Text += "\t Color apostado: Negro" + "\r\n";
                        }
                        else
                        {
                            this.textBox_ResultadoApuestas.Text += "\t Número apostado: " + optionWinner + "\r\n";
                        }
                        this.textBox_ResultadoApuestas.Text += "\t Valor apuesta: " + listWinnersBets[(j + 3)] + "\r\n";
                        double gananciaCliente = calcularGananciaApuesta(optionWinner, listWinnersBets[(j + 3)]);
                        this.textBox_ResultadoApuestas.Text += "\t Ganancia obtenida: " + gananciaCliente + "\r\n";
                        this.textBox_ResultadoApuestas.Text += "\r\n";
                        addGananciaCliente(listWinnersBets[j], gananciaCliente);
                        j += 3;
                    }
                }
                else
                {
                    this.textBox_ResultadoApuestas.Text += "Nadie gano la apuesta" + "\r\n";
                    closeEstateClientes(idRuleta);
                }
            }
        }

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            crearCliente();
            MessageBox.Show("Cliente creado: " + listaClientes[0].IdCliente);
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            this.comboBox_IdRuletaCerrada.SelectedIndex = -1;
            this.comboBox_IngresoIdRuleta.SelectedIndex = -1;
            this.textBox_IngresoIdCliente.Clear();
            this.textBox_IngresoValorApuesta.Clear();
            this.textBox_ResultadoApuestas.Clear();
            this.idRuleta.Text = "";
            this.label_EstadoRuletaConsultada.Text = "";
            this.comboBox_IngresoColorApuesta.SelectedIndex = -1;
            this.comboBox_IngresoNumeroApuesta.SelectedIndex = -1;
            this.comboBox_ListaRuletas.SelectedIndex = -1;
        }

        private void button_CloseApp_Click(object sender, EventArgs e)
        {
            string message = "¿Desea confirmar el cierre de la aplicación?";
            string title = "Cerrar Aplicación";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
