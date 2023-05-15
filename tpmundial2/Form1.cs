using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace tpmundial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        MySqlConnection conexion = new MySqlConnection("server=****; port=****; user id=m*****; password=*******; database=*******; ");
        string equipo2;

        private void button9_Click(object sender, EventArgs e)
        {
            int combo = comboBoxA.SelectedIndex;
            switch (combo)
            {
                case 0:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 1;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;








                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 3;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }



                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 18;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 19;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 34;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 33;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;

            }


        }


        private void button1_Click(object sender, EventArgs e)
        {

            int lista = comboBoxA.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 1;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox1.Text + ", marcador2= " + textBox2.Text + ", tajeta_roja_E1=" + textBox4.Text + " , tarjeta_roja_E2=" + textBox9.Text + ", tarjeta_amarilla_E1=" + textBox5.Text + ", tarjeta_amarilla_E2 =" + textBox10.Text + ", goles_favor_EQ1=" + textBox1.Text + ", goles_favor_EQ2=" + textBox2.Text + ", goles_contra_EQ1=" + textBox2.Text + ", goles_contra_EQ2=" + textBox1.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");
                      
                        conexion.Close();

                    }


                    try
                    {
                        int cod = 1;
                        int marcador1 = Convert.ToInt32(textBox1.Text);
                        int marcador2 = Convert.ToInt32(textBox2.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();
                    }


                    break;
                case 1:

                    nropartido = 3;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox1.Text + ", marcador2= " + textBox2.Text + ", tajeta_roja_E1=" + textBox4.Text + " , tarjeta_roja_E2=" + textBox9.Text + ", tarjeta_amarilla_E1=" + textBox5.Text + ", tarjeta_amarilla_E2 =" + textBox10.Text + ", goles_favor_EQ1=" + textBox1.Text + ", goles_favor_EQ2=" + textBox2.Text + ", goles_contra_EQ1=" + textBox2.Text + ", goles_contra_EQ2=" + textBox1.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException )
                    {
                        MessageBox.Show("Debes llenar todos los campos");

                        conexion.Close();

                    }

                    try
                    {
                        int cod = 3;
                        int marcador1 = Convert.ToInt32(textBox1.Text);
                        int marcador2 = Convert.ToInt32(textBox2.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();
                    }


                    break;
                case 2:

                    nropartido = 18;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox1.Text + ", marcador2= " + textBox2.Text + ", tajeta_roja_E1=" + textBox4.Text + " , tarjeta_roja_E2=" + textBox9.Text + ", tarjeta_amarilla_E1=" + textBox5.Text + ", tarjeta_amarilla_E2 =" + textBox10.Text + ", goles_favor_EQ1=" + textBox1.Text + ", goles_favor_EQ2=" + textBox2.Text + ", goles_contra_EQ1=" + textBox2.Text + ", goles_contra_EQ2=" + textBox1.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {

                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();

                    }

                    try
                    {
                        int cod = 18;
                        int marcador1 = Convert.ToInt32(textBox1.Text);
                        int marcador2 = Convert.ToInt32(textBox2.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 3:
                    nropartido = 19;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox1.Text + ", marcador2= " + textBox2.Text + ", tajeta_roja_E1=" + textBox4.Text + " , tarjeta_roja_E2=" + textBox9.Text + ", tarjeta_amarilla_E1=" + textBox5.Text + ", tarjeta_amarilla_E2 =" + textBox10.Text + ", goles_favor_EQ1=" + textBox1.Text + ", goles_favor_EQ2=" + textBox2.Text + ", goles_contra_EQ1=" + textBox2.Text + ", goles_contra_EQ2=" + textBox1.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();

                    }

                    try
                    {
                        int cod = 19;
                        int marcador1 = Convert.ToInt32(textBox1.Text);
                        int marcador2 = Convert.ToInt32(textBox2.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 4:
                    nropartido = 34;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox1.Text + ", marcador2= " + textBox2.Text + ", tajeta_roja_E1=" + textBox4.Text + " , tarjeta_roja_E2=" + textBox9.Text + ", tarjeta_amarilla_E1=" + textBox5.Text + ", tarjeta_amarilla_E2 =" + textBox10.Text + ", goles_favor_EQ1=" + textBox1.Text + ", goles_favor_EQ2=" + textBox2.Text + ", goles_contra_EQ1=" + textBox2.Text + ", goles_contra_EQ2=" + textBox1.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {

                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();

                    }

                    try
                    {
                        int cod = 34;
                        int marcador1 = Convert.ToInt32(textBox1.Text);
                        int marcador2 = Convert.ToInt32(textBox2.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 5:
                    nropartido = 33;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox1.Text + ", marcador2= " + textBox2.Text + ", tajeta_roja_E1=" + textBox4.Text + " , tarjeta_roja_E2=" + textBox9.Text + ", tarjeta_amarilla_E1=" + textBox5.Text + ", tarjeta_amarilla_E2 =" + textBox10.Text + ", goles_favor_EQ1=" + textBox1.Text + ", goles_favor_EQ2=" + textBox2.Text + ", goles_contra_EQ1=" + textBox2.Text + ", goles_contra_EQ2=" + textBox1.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();

                    }

                    try
                    {
                        int cod = 33;
                        int marcador1 = Convert.ToInt32(textBox1.Text);
                        int marcador2 = Convert.ToInt32(textBox2.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int combo = comboBoxB.SelectedIndex;
            switch (combo)
            {
                case 0:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 2;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;

                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 4;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 17;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 20;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 36;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 35;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lista = comboBoxB.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 2;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox28.Text + ", marcador2= " + textBox27.Text + ", tajeta_roja_E1=" + textBox25.Text + " , tarjeta_roja_E2=" + textBox23.Text + ", tarjeta_amarilla_E1=" + textBox22.Text + ", tarjeta_amarilla_E2 =" + textBox21.Text + ", goles_favor_EQ1=" + textBox28.Text + ", goles_contra_EQ1=" + textBox27.Text + ", goles_favor_EQ2=" + textBox27.Text + ", goles_contra_EQ2=" + textBox28.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {

                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();

                    }


                    try
                    {
                        int cod = 2;
                        int marcador1 = Convert.ToInt32(textBox28.Text);
                        int marcador2 = Convert.ToInt32(textBox27.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 1:

                    nropartido = 4;

                    try
                    {
                        conexion.Open();

                         string datoPartido = "update partidos set marcador1=" + textBox28.Text + ", marcador2= " + textBox27.Text + ", tajeta_roja_E1=" + textBox25.Text + " , tarjeta_roja_E2=" + textBox23.Text + ", tarjeta_amarilla_E1=" + textBox22.Text + ", tarjeta_amarilla_E2 =" + textBox21.Text + ", goles_favor_EQ1=" + textBox28.Text + ", goles_contra_EQ1=" + textBox27.Text + ", goles_favor_EQ2=" + textBox27.Text + ", goles_contra_EQ2=" + textBox28.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                        string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");
                        conexion.Close();
                    }

                    try
                    {
                        int cod = 4;
                        int marcador1 = Convert.ToInt32(textBox28.Text);
                        int marcador2 = Convert.ToInt32(textBox27.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 2:

                    nropartido = 17;


                    try
                    {
                        conexion.Open();

                     string datoPartido = "update partidos set marcador1=" + textBox28.Text + ", marcador2= " + textBox27.Text + ", tajeta_roja_E1=" + textBox25.Text + " , tarjeta_roja_E2=" + textBox23.Text + ", tarjeta_amarilla_E1=" + textBox22.Text + ", tarjeta_amarilla_E2 =" + textBox21.Text + ", goles_favor_EQ1=" + textBox28.Text + ", goles_contra_EQ1=" + textBox27.Text + ", goles_favor_EQ2=" + textBox27.Text + ", goles_contra_EQ2=" + textBox28.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {
                        int cod = 17;
                        int marcador1 = Convert.ToInt32(textBox28.Text);
                        int marcador2 = Convert.ToInt32(textBox27.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 3:
                    nropartido = 20;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox28.Text + ", marcador2= " + textBox27.Text + ", tajeta_roja_E1=" + textBox25.Text + " , tarjeta_roja_E2=" + textBox23.Text + ", tarjeta_amarilla_E1=" + textBox22.Text + ", tarjeta_amarilla_E2 =" + textBox21.Text + ", goles_favor_EQ1=" + textBox28.Text + ", goles_contra_EQ1=" + textBox27.Text + ", goles_favor_EQ2=" + textBox27.Text + ", goles_contra_EQ2=" + textBox28.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException )
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {
                        int cod = 20;
                        int marcador1 = Convert.ToInt32(textBox28.Text);
                        int marcador2 = Convert.ToInt32(textBox27.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 4:
                    nropartido = 36;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox28.Text + ", marcador2= " + textBox27.Text + ", tajeta_roja_E1=" + textBox25.Text + " , tarjeta_roja_E2=" + textBox23.Text + ", tarjeta_amarilla_E1=" + textBox22.Text + ", tarjeta_amarilla_E2 =" + textBox21.Text + ", goles_favor_EQ1=" + textBox28.Text + ", goles_contra_EQ1=" + textBox27.Text + ", goles_favor_EQ2=" + textBox27.Text + ", goles_contra_EQ2=" + textBox28.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {
                        int cod = 36;
                        int marcador1 = Convert.ToInt32(textBox28.Text);
                        int marcador2 = Convert.ToInt32(textBox27.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 5:
                    nropartido = 35;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox28.Text + ", marcador2= " + textBox27.Text + ", tajeta_roja_E1=" + textBox25.Text + " , tarjeta_roja_E2=" + textBox23.Text + ", tarjeta_amarilla_E1=" + textBox22.Text + ", tarjeta_amarilla_E2 =" + textBox21.Text + ", goles_favor_EQ1=" + textBox28.Text + ", goles_contra_EQ1=" + textBox27.Text + ", goles_favor_EQ2=" + textBox27.Text + ", goles_contra_EQ2=" + textBox28.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {
                        int cod = 35;
                        int marcador1 = Convert.ToInt32(textBox28.Text);
                        int marcador2 = Convert.ToInt32(textBox27.Text);

                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int combo = comboBoxC.SelectedIndex;

            switch (combo)
            {
                case 0:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 5;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;

                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 7;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }



                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 22;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }

                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 24;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 39;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 40;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }

                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lista = comboBoxC.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 5;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox42.Text + ", marcador2= " + textBox41.Text + ", tajeta_roja_E1=" + textBox39.Text + " , tarjeta_roja_E2=" + textBox37.Text + ", tarjeta_amarilla_E1=" + textBox36.Text + ", tarjeta_amarilla_E2 =" + textBox35.Text + ", goles_favor_EQ1=" + textBox42.Text + ", goles_contra_EQ1=" + textBox41.Text + ", goles_favor_EQ2=" + textBox41.Text + ", goles_contra_EQ2=" + textBox42.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;



                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 5;
                        int marcador1 = Convert.ToInt32(textBox42.Text);
                        int marcador2 = Convert.ToInt32(textBox41.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 1:
                    nropartido = 7;

                    try
                    {
                        conexion.Open();

                          string datoPartido = "update partidos set marcador1=" + textBox42.Text + ", marcador2= " + textBox41.Text + ", tajeta_roja_E1=" + textBox39.Text + " , tarjeta_roja_E2=" + textBox37.Text + ", tarjeta_amarilla_E1=" + textBox36.Text + ", tarjeta_amarilla_E2 =" + textBox35.Text + ", goles_favor_EQ1=" + textBox42.Text + ", goles_contra_EQ1=" + textBox41.Text + ", goles_favor_EQ2=" + textBox41.Text + ", goles_contra_EQ2=" + textBox42.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {

                        int cod = 7;
                        int marcador1 = Convert.ToInt32(textBox42.Text);
                        int marcador2 = Convert.ToInt32(textBox41.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 2:
                    nropartido = 22;


                    try
                    {
                        conexion.Open();

                          string datoPartido = "update partidos set marcador1=" + textBox42.Text + ", marcador2= " + textBox41.Text + ", tajeta_roja_E1=" + textBox39.Text + " , tarjeta_roja_E2=" + textBox37.Text + ", tarjeta_amarilla_E1=" + textBox36.Text + ", tarjeta_amarilla_E2 =" + textBox35.Text + ", goles_favor_EQ1=" + textBox42.Text + ", goles_contra_EQ1=" + textBox41.Text + ", goles_favor_EQ2=" + textBox41.Text + ", goles_contra_EQ2=" + textBox42.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {

                        int marcador1 = Convert.ToInt32(textBox42.Text);
                        int marcador2 = Convert.ToInt32(textBox41.Text);
                        int cod = 22;
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 3:
                    nropartido = 24;

                    try
                    {
                        conexion.Open();

                          string datoPartido = "update partidos set marcador1=" + textBox42.Text + ", marcador2= " + textBox41.Text + ", tajeta_roja_E1=" + textBox39.Text + " , tarjeta_roja_E2=" + textBox37.Text + ", tarjeta_amarilla_E1=" + textBox36.Text + ", tarjeta_amarilla_E2 =" + textBox35.Text + ", goles_favor_EQ1=" + textBox42.Text + ", goles_contra_EQ1=" + textBox41.Text + ", goles_favor_EQ2=" + textBox41.Text + ", goles_contra_EQ2=" + textBox42.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {

                        int cod = 24;
                        int marcador1 = Convert.ToInt32(textBox42.Text);
                        int marcador2 = Convert.ToInt32(textBox41.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 4:
                    nropartido = 39;


                    try
                    {
                        conexion.Open();

                          string datoPartido = "update partidos set marcador1=" + textBox42.Text + ", marcador2= " + textBox41.Text + ", tajeta_roja_E1=" + textBox39.Text + " , tarjeta_roja_E2=" + textBox37.Text + ", tarjeta_amarilla_E1=" + textBox36.Text + ", tarjeta_amarilla_E2 =" + textBox35.Text + ", goles_favor_EQ1=" + textBox42.Text + ", goles_contra_EQ1=" + textBox41.Text + ", goles_favor_EQ2=" + textBox41.Text + ", goles_contra_EQ2=" + textBox42.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 39;
                        int marcador1 = Convert.ToInt32(textBox42.Text);
                        int marcador2 = Convert.ToInt32(textBox41.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 5:
                    nropartido = 40;

                    try
                    {
                        conexion.Open();

                          string datoPartido = "update partidos set marcador1=" + textBox42.Text + ", marcador2= " + textBox41.Text + ", tajeta_roja_E1=" + textBox39.Text + " , tarjeta_roja_E2=" + textBox37.Text + ", tarjeta_amarilla_E1=" + textBox36.Text + ", tarjeta_amarilla_E2 =" + textBox35.Text + ", goles_favor_EQ1=" + textBox42.Text + ", goles_contra_EQ1=" + textBox41.Text + ", goles_favor_EQ2=" + textBox41.Text + ", goles_contra_EQ2=" + textBox42.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {

                        int cod = 40;
                        int marcador1 = Convert.ToInt32(textBox42.Text);
                        int marcador2 = Convert.ToInt32(textBox41.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int combo = comboBoxD.SelectedIndex;

            switch (combo)
            {
                case 0:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 6;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;


                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 8;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }



                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 21;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 23;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 37;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 38;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int lista = comboBoxD.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 6;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox56.Text + ", marcador2= " + textBox55.Text + ", tajeta_roja_E1=" + textBox53.Text + " , tarjeta_roja_E2=" + textBox51.Text + ", tarjeta_amarilla_E1=" + textBox50.Text + ", tarjeta_amarilla_E2 =" + textBox49.Text + ", goles_favor_EQ1=" + textBox56.Text + ", goles_contra_EQ1=" + textBox55.Text + ", goles_favor_EQ2=" + textBox55.Text + ", goles_contra_EQ2=" + textBox56.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;



                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 6;
                        int marcador1 = Convert.ToInt32(textBox56.Text);
                        int marcador2 = Convert.ToInt32(textBox55.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 1:
                    nropartido = 8;

                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox56.Text + ", marcador2= " + textBox55.Text + ", tajeta_roja_E1=" + textBox53.Text + " , tarjeta_roja_E2=" + textBox51.Text + ", tarjeta_amarilla_E1=" + textBox50.Text + ", tarjeta_amarilla_E2 =" + textBox49.Text + ", goles_favor_EQ1=" + textBox56.Text + ", goles_contra_EQ1=" + textBox55.Text + ", goles_favor_EQ2=" + textBox55.Text + ", goles_contra_EQ2=" + textBox56.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {

                        int cod = 8;
                        int marcador1 = Convert.ToInt32(textBox56.Text);
                        int marcador2 = Convert.ToInt32(textBox55.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 2:
                    nropartido = 21;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox56.Text + ", marcador2= " + textBox55.Text + ", tajeta_roja_E1=" + textBox53.Text + " , tarjeta_roja_E2=" + textBox51.Text + ", tarjeta_amarilla_E1=" + textBox50.Text + ", tarjeta_amarilla_E2 =" + textBox49.Text + ", goles_favor_EQ1=" + textBox56.Text + ", goles_contra_EQ1=" + textBox55.Text + ", goles_favor_EQ2=" + textBox55.Text + ", goles_contra_EQ2=" + textBox56.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }

                    try
                    {

                        int cod = 21;
                        int marcador1 = Convert.ToInt32(textBox56.Text);
                        int marcador2 = Convert.ToInt32(textBox55.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 3:
                    nropartido = 23;

                    try
                    {
                        conexion.Open();

                            string datoPartido = "update partidos set marcador1=" + textBox56.Text + ", marcador2= " + textBox55.Text + ", tajeta_roja_E1=" + textBox53.Text + " , tarjeta_roja_E2=" + textBox51.Text + ", tarjeta_amarilla_E1=" + textBox50.Text + ", tarjeta_amarilla_E2 =" + textBox49.Text + ", goles_favor_EQ1=" + textBox56.Text + ", goles_contra_EQ1=" + textBox55.Text + ", goles_favor_EQ2=" + textBox55.Text + ", goles_contra_EQ2=" + textBox56.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int marcador1 = Convert.ToInt32(textBox56.Text);
                        int marcador2 = Convert.ToInt32(textBox55.Text);
                        int cod = 23;
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 4:
                    nropartido = 37;


                    try
                    {
                        conexion.Open();

                            string datoPartido = "update partidos set marcador1=" + textBox56.Text + ", marcador2= " + textBox55.Text + ", tajeta_roja_E1=" + textBox53.Text + " , tarjeta_roja_E2=" + textBox51.Text + ", tarjeta_amarilla_E1=" + textBox50.Text + ", tarjeta_amarilla_E2 =" + textBox49.Text + ", goles_favor_EQ1=" + textBox56.Text + ", goles_contra_EQ1=" + textBox55.Text + ", goles_favor_EQ2=" + textBox55.Text + ", goles_contra_EQ2=" + textBox56.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 37;
                        int marcador1 = Convert.ToInt32(textBox56.Text);
                        int marcador2 = Convert.ToInt32(textBox55.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 5:
                    nropartido = 38;

                    try
                    {
                        conexion.Open();

                            string datoPartido = "update partidos set marcador1=" + textBox56.Text + ", marcador2= " + textBox55.Text + ", tajeta_roja_E1=" + textBox53.Text + " , tarjeta_roja_E2=" + textBox51.Text + ", tarjeta_amarilla_E1=" + textBox50.Text + ", tarjeta_amarilla_E2 =" + textBox49.Text + ", goles_favor_EQ1=" + textBox56.Text + ", goles_contra_EQ1=" + textBox55.Text + ", goles_favor_EQ2=" + textBox55.Text + ", goles_contra_EQ2=" + textBox56.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 38;
                        int marcador1 = Convert.ToInt32(textBox56.Text);
                        int marcador2 = Convert.ToInt32(textBox55.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int combo = comboBoxE.SelectedIndex;

            switch (combo)
            {
                case 0:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 10;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;

                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 11;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }

                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 25;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }

                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 28;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }

                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 43;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 44;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int lista = comboBoxE.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 10;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox70.Text + ", marcador2= " + textBox69.Text + ", tajeta_roja_E1=" + textBox67.Text + " , tarjeta_roja_E2=" + textBox65.Text + ", tarjeta_amarilla_E1=" + textBox64.Text + ", tarjeta_amarilla_E2 =" + textBox63.Text + ", goles_favor_EQ1=" + textBox70.Text + ", goles_contra_EQ1=" + textBox69.Text + ", goles_favor_EQ2=" + textBox69.Text + ", goles_contra_EQ2=" + textBox70.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;



                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException )
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 10;
                        int marcador1 = Convert.ToInt32(textBox70.Text);
                        int marcador2 = Convert.ToInt32(textBox69.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 1:
                    nropartido = 11;



                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox70.Text + ", marcador2= " + textBox69.Text + ", tajeta_roja_E1=" + textBox67.Text + " , tarjeta_roja_E2=" + textBox65.Text + ", tarjeta_amarilla_E1=" + textBox64.Text + ", tarjeta_amarilla_E2 =" + textBox63.Text + ", goles_favor_EQ1=" + textBox70.Text + ", goles_contra_EQ1=" + textBox69.Text + ", goles_favor_EQ2=" + textBox69.Text + ", goles_contra_EQ2=" + textBox70.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 11;
                        int marcador1 = Convert.ToInt32(textBox70.Text);
                        int marcador2 = Convert.ToInt32(textBox69.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 2:
                    nropartido = 25;


                    try
                    {
                        conexion.Open();

                       string datoPartido = "update partidos set marcador1=" + textBox70.Text + ", marcador2= " + textBox69.Text + ", tajeta_roja_E1=" + textBox67.Text + " , tarjeta_roja_E2=" + textBox65.Text + ", tarjeta_amarilla_E1=" + textBox64.Text + ", tarjeta_amarilla_E2 =" + textBox63.Text + ", goles_favor_EQ1=" + textBox70.Text + ", goles_contra_EQ1=" + textBox69.Text + ", goles_favor_EQ2=" + textBox69.Text + ", goles_contra_EQ2=" + textBox70.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 25;
                        int marcador1 = Convert.ToInt32(textBox70.Text);
                        int marcador2 = Convert.ToInt32(textBox69.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 3:
                    nropartido = 28;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox70.Text + ", marcador2= " + textBox69.Text + ", tajeta_roja_E1=" + textBox67.Text + " , tarjeta_roja_E2=" + textBox65.Text + ", tarjeta_amarilla_E1=" + textBox64.Text + ", tarjeta_amarilla_E2 =" + textBox63.Text + ", goles_favor_EQ1=" + textBox70.Text + ", goles_contra_EQ1=" + textBox69.Text + ", goles_favor_EQ2=" + textBox69.Text + ", goles_contra_EQ2=" + textBox70.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 28;
                        int marcador1 = Convert.ToInt32(textBox70.Text);
                        int marcador2 = Convert.ToInt32(textBox69.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 4:
                    nropartido = 43;


                    try
                    {
                        conexion.Open();

                       string datoPartido = "update partidos set marcador1=" + textBox70.Text + ", marcador2= " + textBox69.Text + ", tajeta_roja_E1=" + textBox67.Text + " , tarjeta_roja_E2=" + textBox65.Text + ", tarjeta_amarilla_E1=" + textBox64.Text + ", tarjeta_amarilla_E2 =" + textBox63.Text + ", goles_favor_EQ1=" + textBox70.Text + ", goles_contra_EQ1=" + textBox69.Text + ", goles_favor_EQ2=" + textBox69.Text + ", goles_contra_EQ2=" + textBox70.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();


                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 43;
                        int marcador1 = Convert.ToInt32(textBox70.Text);
                        int marcador2 = Convert.ToInt32(textBox69.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 5:
                    nropartido = 44;

                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox70.Text + ", marcador2= " + textBox69.Text + ", tajeta_roja_E1=" + textBox67.Text + " , tarjeta_roja_E2=" + textBox65.Text + ", tarjeta_amarilla_E1=" + textBox64.Text + ", tarjeta_amarilla_E2 =" + textBox63.Text + ", goles_favor_EQ1=" + textBox70.Text + ", goles_contra_EQ1=" + textBox69.Text + ", goles_favor_EQ2=" + textBox69.Text + ", goles_contra_EQ2=" + textBox70.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                       string datoequipo = " update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo1 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ1 where partidos.id_nroPartido = " + nropartido + " ; update equipo join partidos on equipo.id_equipo = partidos.id_equipo2 set equipo.dif_goles = equipo.dif_goles + partidos.goles_dif_EQ2 where partidos.id_nroPartido = " + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();

                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 44;
                        int marcador1 = Convert.ToInt32(textBox70.Text);
                        int marcador2 = Convert.ToInt32(textBox69.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int combo = comboBoxF.SelectedIndex;

            switch (combo)
            {
                case 0:
                    try
                    {

                        int nropartido = 9;
                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }



                    break;

                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 12;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }



                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 26;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 27;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 41;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 42;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int lista = comboBoxF.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 9;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox84.Text + ", marcador2= " + textBox83.Text + ", tajeta_roja_E1=" + textBox81.Text + " , tarjeta_roja_E2=" + textBox79.Text + ", tarjeta_amarilla_E1=" + textBox78.Text + ", tarjeta_amarilla_E2 =" + textBox77.Text + ", goles_favor_EQ1=" + textBox84.Text + ", goles_contra_EQ1=" + textBox83.Text  + ", goles_favor_EQ2=" + textBox83.Text + ", goles_contra_EQ2=" + textBox84.Text + " , goles_dif_EQ1 = partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2 = partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido = " + nropartido;


                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 9;
                        int marcador1 = Convert.ToInt32(textBox84.Text);
                        int marcador2 = Convert.ToInt32(textBox83.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 1:

                    nropartido = 12;

                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox84.Text + ", marcador2= " + textBox83.Text + ", tajeta_roja_E1=" + textBox81.Text + " , tarjeta_roja_E2=" + textBox79.Text + ", tarjeta_amarilla_E1=" + textBox78.Text + ", tarjeta_amarilla_E2 =" + textBox77.Text + ", goles_favor_EQ1=" + textBox84.Text + ", goles_contra_EQ1=" + textBox83.Text  + ", goles_favor_EQ2=" + textBox83.Text + ", goles_contra_EQ2=" + textBox84.Text + " , goles_dif_EQ1 = partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2 = partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido = " + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 12;
                        int marcador1 = Convert.ToInt32(textBox84.Text);
                        int marcador2 = Convert.ToInt32(textBox83.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 2:
                    nropartido = 26;


                    try
                    {
                        conexion.Open();

                       string datoPartido = "update partidos set marcador1=" + textBox84.Text + ", marcador2= " + textBox83.Text + ", tajeta_roja_E1=" + textBox81.Text + " , tarjeta_roja_E2=" + textBox79.Text + ", tarjeta_amarilla_E1=" + textBox78.Text + ", tarjeta_amarilla_E2 =" + textBox77.Text + ", goles_favor_EQ1=" + textBox84.Text + ", goles_contra_EQ1=" + textBox83.Text  + ", goles_favor_EQ2=" + textBox83.Text + ", goles_contra_EQ2=" + textBox84.Text + " , goles_dif_EQ1 = partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2 = partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido = " + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 26;
                        int marcador1 = Convert.ToInt32(textBox84.Text);
                        int marcador2 = Convert.ToInt32(textBox83.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 3:
                    nropartido = 27;

                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox84.Text + ", marcador2= " + textBox83.Text + ", tajeta_roja_E1=" + textBox81.Text + " , tarjeta_roja_E2=" + textBox79.Text + ", tarjeta_amarilla_E1=" + textBox78.Text + ", tarjeta_amarilla_E2 =" + textBox77.Text + ", goles_favor_EQ1=" + textBox84.Text + ", goles_contra_EQ1=" + textBox83.Text  + ", goles_favor_EQ2=" + textBox83.Text + ", goles_contra_EQ2=" + textBox84.Text + " , goles_dif_EQ1 = partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2 = partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido = " + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 27;
                        int marcador1 = Convert.ToInt32(textBox84.Text);
                        int marcador2 = Convert.ToInt32(textBox83.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 4:
                    nropartido = 41;

                    try
                    {
                        conexion.Open();

                     string datoPartido = "update partidos set marcador1=" + textBox84.Text + ", marcador2= " + textBox83.Text + ", tajeta_roja_E1=" + textBox81.Text + " , tarjeta_roja_E2=" + textBox79.Text + ", tarjeta_amarilla_E1=" + textBox78.Text + ", tarjeta_amarilla_E2 =" + textBox77.Text + ", goles_favor_EQ1=" + textBox84.Text + ", goles_contra_EQ1=" + textBox83.Text  + ", goles_favor_EQ2=" + textBox83.Text + ", goles_contra_EQ2=" + textBox84.Text + " , goles_dif_EQ1 = partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2 = partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido = " + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 41;
                        int marcador1 = Convert.ToInt32(textBox84.Text);
                        int marcador2 = Convert.ToInt32(textBox83.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 5:
                    nropartido = 42;

                    try
                    {
                        conexion.Open();

                       string datoPartido = "update partidos set marcador1=" + textBox84.Text + ", marcador2= " + textBox83.Text + ", tajeta_roja_E1=" + textBox81.Text + " , tarjeta_roja_E2=" + textBox79.Text + ", tarjeta_amarilla_E1=" + textBox78.Text + ", tarjeta_amarilla_E2 =" + textBox77.Text + ", goles_favor_EQ1=" + textBox84.Text + ", goles_contra_EQ1=" + textBox83.Text  + ", goles_favor_EQ2=" + textBox83.Text + ", goles_contra_EQ2=" + textBox84.Text + " , goles_dif_EQ1 = partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2 = partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido = " + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 42;
                        int marcador1 = Convert.ToInt32(textBox84.Text);
                        int marcador2 = Convert.ToInt32(textBox83.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int combo = comboBoxG.SelectedIndex;
            switch (combo)
            {
                case 0:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 13;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;



                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 15;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }



                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 29;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }

                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 31;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 46;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 47;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int lista = comboBoxG.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 13;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox98.Text + ", marcador2= " + textBox97.Text + ", tajeta_roja_E1=" + textBox95.Text + " , tarjeta_roja_E2=" + textBox93.Text + ", tarjeta_amarilla_E1=" + textBox92.Text + ", tarjeta_amarilla_E2 =" + textBox91.Text + ", goles_favor_EQ1=" + textBox98.Text + ", goles_contra_EQ1=" + textBox97.Text + ", goles_favor_EQ2=" + textBox97.Text + ", goles_contra_EQ2=" + textBox98.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;

                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 13;
                        int marcador1 = Convert.ToInt32(textBox98.Text);
                        int marcador2 = Convert.ToInt32(textBox97.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 1:
                    nropartido = 15;

                    try
                    {
                        conexion.Open();

                         string datoPartido = "update partidos set marcador1=" + textBox98.Text + ", marcador2= " + textBox97.Text + ", tajeta_roja_E1=" + textBox95.Text + " , tarjeta_roja_E2=" + textBox93.Text + ", tarjeta_amarilla_E1=" + textBox92.Text + ", tarjeta_amarilla_E2 =" + textBox91.Text + ", goles_favor_EQ1=" + textBox98.Text + ", goles_contra_EQ1=" + textBox97.Text + ", goles_favor_EQ2=" + textBox97.Text + ", goles_contra_EQ2=" + textBox98.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 15;
                        int marcador1 = Convert.ToInt32(textBox98.Text);
                        int marcador2 = Convert.ToInt32(textBox97.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 2:
                    nropartido = 29;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox98.Text + ", marcador2= " + textBox97.Text + ", tajeta_roja_E1=" + textBox95.Text + " , tarjeta_roja_E2=" + textBox93.Text + ", tarjeta_amarilla_E1=" + textBox92.Text + ", tarjeta_amarilla_E2 =" + textBox91.Text + ", goles_favor_EQ1=" + textBox98.Text + ", goles_contra_EQ1=" + textBox97.Text + ", goles_favor_EQ2=" + textBox97.Text + ", goles_contra_EQ2=" + textBox98.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 29;
                        int marcador1 = Convert.ToInt32(textBox98.Text);
                        int marcador2 = Convert.ToInt32(textBox97.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 3:
                    nropartido = 31;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox98.Text + ", marcador2= " + textBox97.Text + ", tajeta_roja_E1=" + textBox95.Text + " , tarjeta_roja_E2=" + textBox93.Text + ", tarjeta_amarilla_E1=" + textBox92.Text + ", tarjeta_amarilla_E2 =" + textBox91.Text + ", goles_favor_EQ1=" + textBox98.Text + ", goles_contra_EQ1=" + textBox97.Text + ", goles_favor_EQ2=" + textBox97.Text + ", goles_contra_EQ2=" + textBox98.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 31;
                        int marcador1 = Convert.ToInt32(textBox98.Text);
                        int marcador2 = Convert.ToInt32(textBox97.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }



                    break;
                case 4:
                    nropartido = 46;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox98.Text + ", marcador2= " + textBox97.Text + ", tajeta_roja_E1=" + textBox95.Text + " , tarjeta_roja_E2=" + textBox93.Text + ", tarjeta_amarilla_E1=" + textBox92.Text + ", tarjeta_amarilla_E2 =" + textBox91.Text + ", goles_favor_EQ1=" + textBox98.Text + ", goles_contra_EQ1=" + textBox97.Text + ", goles_favor_EQ2=" + textBox97.Text + ", goles_contra_EQ2=" + textBox98.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;

                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 46;
                        int marcador1 = Convert.ToInt32(textBox98.Text);
                        int marcador2 = Convert.ToInt32(textBox97.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 5:
                    nropartido = 47;

                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox98.Text + ", marcador2= " + textBox97.Text + ", tajeta_roja_E1=" + textBox95.Text + " , tarjeta_roja_E2=" + textBox93.Text + ", tarjeta_amarilla_E1=" + textBox92.Text + ", tarjeta_amarilla_E2 =" + textBox91.Text + ", goles_favor_EQ1=" + textBox98.Text + ", goles_contra_EQ1=" + textBox97.Text + ", goles_favor_EQ2=" + textBox97.Text + ", goles_contra_EQ2=" + textBox98.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 47;
                        int marcador1 = Convert.ToInt32(textBox98.Text);
                        int marcador2 = Convert.ToInt32(textBox97.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int combo = comboBoxH.SelectedIndex;
            switch (combo)
            {
                case 0:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 14;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro = comando.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro.Read())
                        {
                            equipo2 += registro["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;








                case 1:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 16;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }



                    break;
                case 2:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 30;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }




                    break;
                case 3:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 32;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }

                    break;
                case 4:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 48;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;
                case 5:
                    try
                    {

                        conexion.Open();
                        MessageBox.Show("se ha establecido la conexion a la base de datos");
                        int nropartido = 45;

                        string buscar = "SELECT equipo.id_equipo,equipo.pais,equipo.id_equipo,equipo.pais FROM equipo left join partidos ON (equipo.id_equipo = partidos.id_equipo1 or equipo.id_equipo = partidos.id_equipo2) WHERE id_nroPartido=" + nropartido;


                        MySqlCommand comando1 = new MySqlCommand(buscar, conexion);
                        MySqlDataReader registro1 = comando1.ExecuteReader();

                        equipo2 = "el partido ";

                        while (registro1.Read())
                        {
                            equipo2 += registro1["pais"].ToString();
                            equipo2 += "   ";
                        }

                        equipo2 += "existe";

                        MessageBox.Show(equipo2);
                        conexion.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        conexion.Close();

                    }


                    break;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int lista = comboBoxH.SelectedIndex;
            switch (lista)
            {
                case 0:
                    int nropartido = 14;


                    try
                    {
                        conexion.Open();

                        string datoPartido = "update partidos set marcador1=" + textBox112.Text + ", marcador2= " + textBox111.Text + ", tajeta_roja_E1=" + textBox109.Text + " , tarjeta_roja_E2=" + textBox107.Text + ", tarjeta_amarilla_E1=" + textBox106.Text + ", tarjeta_amarilla_E2 =" + textBox105.Text + ", goles_favor_EQ1=" + textBox112.Text + ", goles_contra_EQ1=" + textBox111.Text +  ", goles_favor_EQ2=" + textBox111.Text + ", goles_contra_EQ2=" + textBox112.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;


                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();



                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 14;
                        int marcador1 = Convert.ToInt32(textBox112.Text);
                        int marcador2 = Convert.ToInt32(textBox111.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 1:
                    nropartido = 16;



                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox112.Text + ", marcador2= " + textBox111.Text + ", tajeta_roja_E1=" + textBox109.Text + " , tarjeta_roja_E2=" + textBox107.Text + ", tarjeta_amarilla_E1=" + textBox106.Text + ", tarjeta_amarilla_E2 =" + textBox105.Text + ", goles_favor_EQ1=" + textBox112.Text + ", goles_contra_EQ1=" + textBox111.Text +  ", goles_favor_EQ2=" + textBox111.Text + ", goles_contra_EQ2=" + textBox112.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 16;
                        int marcador1 = Convert.ToInt32(textBox112.Text);
                        int marcador2 = Convert.ToInt32(textBox111.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 2:
                    nropartido = 30;


                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox112.Text + ", marcador2= " + textBox111.Text + ", tajeta_roja_E1=" + textBox109.Text + " , tarjeta_roja_E2=" + textBox107.Text + ", tarjeta_amarilla_E1=" + textBox106.Text + ", tarjeta_amarilla_E2 =" + textBox105.Text + ", goles_favor_EQ1=" + textBox112.Text + ", goles_contra_EQ1=" + textBox111.Text +  ", goles_favor_EQ2=" + textBox111.Text + ", goles_contra_EQ2=" + textBox112.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();

                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 30;
                        int marcador1 = Convert.ToInt32(textBox112.Text);
                        int marcador2 = Convert.ToInt32(textBox111.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 3:
                    nropartido = 32;

                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox112.Text + ", marcador2= " + textBox111.Text + ", tajeta_roja_E1=" + textBox109.Text + " , tarjeta_roja_E2=" + textBox107.Text + ", tarjeta_amarilla_E1=" + textBox106.Text + ", tarjeta_amarilla_E2 =" + textBox105.Text + ", goles_favor_EQ1=" + textBox112.Text + ", goles_contra_EQ1=" + textBox111.Text +  ", goles_favor_EQ2=" + textBox111.Text + ", goles_contra_EQ2=" + textBox112.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException )
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 32;
                        int marcador1 = Convert.ToInt32(textBox112.Text);
                        int marcador2 = Convert.ToInt32(textBox111.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }

                    break;
                case 4:
                    nropartido = 48;


                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox112.Text + ", marcador2= " + textBox111.Text + ", tajeta_roja_E1=" + textBox109.Text + " , tarjeta_roja_E2=" + textBox107.Text + ", tarjeta_amarilla_E1=" + textBox106.Text + ", tarjeta_amarilla_E2 =" + textBox105.Text + ", goles_favor_EQ1=" + textBox112.Text + ", goles_contra_EQ1=" + textBox111.Text +  ", goles_favor_EQ2=" + textBox111.Text + ", goles_contra_EQ2=" + textBox112.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int marcador1 = Convert.ToInt32(textBox112.Text);
                        int marcador2 = Convert.ToInt32(textBox111.Text);
                        int cod = 48;
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
                case 5:
                    nropartido = 45;

                    try
                    {
                        conexion.Open();

                      string datoPartido = "update partidos set marcador1=" + textBox112.Text + ", marcador2= " + textBox111.Text + ", tajeta_roja_E1=" + textBox109.Text + " , tarjeta_roja_E2=" + textBox107.Text + ", tarjeta_amarilla_E1=" + textBox106.Text + ", tarjeta_amarilla_E2 =" + textBox105.Text + ", goles_favor_EQ1=" + textBox112.Text + ", goles_contra_EQ1=" + textBox111.Text +  ", goles_favor_EQ2=" + textBox111.Text + ", goles_contra_EQ2=" + textBox112.Text + ", goles_dif_EQ1= partidos.goles_favor_EQ1 - partidos.goles_favor_EQ2 " + ", goles_dif_EQ2= partidos.goles_favor_EQ2 - partidos.goles_favor_EQ1 where id_nroPartido=" + nropartido;
                        MySqlCommand comando = new MySqlCommand(datoPartido, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        conexion.Close();

                        conexion.Open();


                        string datoequipo = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E1  where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ1 where partidos.id_nroPartido=" + nropartido + ";update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tajeta_roja_E1 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ1 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2 set equipo.tarjeta_amarilla=equipo.tarjeta_amarilla+partidos.tarjeta_amarilla_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.goles_contra=equipo.goles_contra+partidos.goles_contra_EQ2 where partidos.id_nroPartido=" + nropartido + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set equipo.tarjeta_roja=equipo.tarjeta_roja+partidos.tarjeta_roja_E2 where partidos.id_nroPartido=" + nropartido + ";  update equipo join partidos on equipo.id_equipo=partidos.id_equipo2   set equipo.goles_favor=equipo.goles_favor+partidos.goles_favor_EQ2 where partidos.id_nroPartido=" + nropartido;


                        MySqlCommand comandol = new MySqlCommand(datoequipo, conexion);
                        int cantl;
                        cantl = comandol.ExecuteNonQuery();
                        conexion.Close();




                        if (cant == 1)
                        {
                            MessageBox.Show("se actualizaron los datos y se cierra la conexion");

                        }
                        else
                        {
                            MessageBox.Show("No se pudieron modificar los datos");

                        }

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Debes completar todos los campos");

                        conexion.Close();

                    }


                    try
                    {

                        int cod = 45;
                        int marcador1 = Convert.ToInt32(textBox112.Text);
                        int marcador2 = Convert.ToInt32(textBox111.Text);
                        if (marcador1 > marcador2)
                        {

                            conexion.Open();

                            string partidos = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;
                            MySqlCommand command = new MySqlCommand(partidos, conexion);
                            int cantP;
                            cantP = command.ExecuteNonQuery();
                            conexion.Close();


                        }
                        else if (marcador1 < marcador2)
                        {

                            conexion.Open();

                            string partidosl = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+3 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_ganados=partidos_ganados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set  partidos_perdidos=partidos_perdidos+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandP = new MySqlCommand(partidosl, conexion);
                            int cantPa;
                            cantPa = commandP.ExecuteNonQuery();
                            conexion.Close();

                        }
                        else
                        {

                            conexion.Open();

                            string partidosE = "update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set puntos=puntos+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_jugados=partidos_jugados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo1 set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod + "; update equipo join partidos on equipo.id_equipo=partidos.id_equipo2  set partidos_empatados=partidos_empatados+1 where  partidos.id_nroPartido=" + cod;


                            MySqlCommand commandE = new MySqlCommand(partidosE, conexion);
                            int cantE;
                            cantE = commandE.ExecuteNonQuery();
                            conexion.Close();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }


                    break;
            }
        }

 



        private void button18_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string octavos = "SELECT * FROM equipo where puntos <=100 and grupo ='a'order by puntos | dif_goles desc limit 0,1;";
            MySqlCommand comando = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {


                oct1.Text = registro["pais"].ToString();
                conexion.Close();

            }

            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <=100 and grupo ='a'order by puntos | dif_goles desc limit 1,1;";
            MySqlCommand comando1 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro1 = comando1.ExecuteReader();
            if (registro1.Read())
            {

                oct3.Text = registro1["pais"].ToString();
                conexion.Close();
            }

            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <=100 and grupo ='b'order by puntos | dif_goles desc limit 1,1;";
            MySqlCommand comando2 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {


                oct4.Text = registro2["pais"].ToString();
                conexion.Close();

            }

            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'b'order by puntos | dif_goles desc limit 0,1; ";
            MySqlCommand comando3 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro3 = comando3.ExecuteReader();
            if (registro3.Read())
            {

                oct2.Text = registro3["pais"].ToString();
                conexion.Close();
            }

            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'c'order by puntos | dif_goles desc limit 0,1; ";
            MySqlCommand comando4 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro4 = comando4.ExecuteReader();
            if (registro4.Read())
            {

                oct5.Text = registro4["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'c'order by puntos | dif_goles desc limit 1,1; ";
            MySqlCommand comando5 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro5 = comando5.ExecuteReader();
            if (registro5.Read())
            {

                oct7.Text = registro5["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'd'order by puntos| dif_goles desc limit 0,1; ";
            MySqlCommand comando6 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro6 = comando6.ExecuteReader();
            if (registro6.Read())
            {

                oct8.Text = registro6["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'd'order by puntos| dif_goles desc limit 1,1; ";
            MySqlCommand comando7 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro7 = comando7.ExecuteReader();
            if (registro7.Read())
            {

                oct6.Text = registro7["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'e'order by puntos | dif_goles desc limit 0,1; ";
            MySqlCommand comando8 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro8 = comando8.ExecuteReader();
            if (registro8.Read())
            {

                oct9.Text = registro8["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'e'order by puntos| dif_goles desc limit 1,1; ";
            MySqlCommand comando9 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro9 = comando9.ExecuteReader();
            if (registro9.Read())
            {

                oct11.Text = registro9["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'f'order by puntos| dif_goles desc limit 0,1; ";
            MySqlCommand comando10 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro10 = comando10.ExecuteReader();
            if (registro10.Read())
            {

                oct12.Text = registro10["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'f'order by puntos | dif_goles desc limit 1,1; ";
            MySqlCommand comando11 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro11 = comando11.ExecuteReader();
            if (registro11.Read())
            {

                oct10.Text = registro11["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'g'order by puntos| dif_goles desc limit 0,1; ";
            MySqlCommand comando12 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro12 = comando12.ExecuteReader();
            if (registro12.Read())
            {

                oct13.Text = registro12["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'g'order by puntos | dif_goles desc limit 1,1; ";
            MySqlCommand comando13 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro13 = comando13.ExecuteReader();
            if (registro13.Read())
            {

                oct15.Text = registro13["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'h'order by puntos| dif_goles desc limit 0,1; ";
            MySqlCommand comando14 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro14 = comando14.ExecuteReader();
            if (registro14.Read())
            {

                oct16.Text = registro14["pais"].ToString();
                conexion.Close();
            }
            conexion.Open();
            octavos = "SELECT * FROM equipo where puntos <= 100 and grupo = 'h'order by puntos| dif_goles desc limit 1,1; ";
            MySqlCommand comando15 = new MySqlCommand(octavos, conexion);
            MySqlDataReader registro15 = comando15.ExecuteReader();
            if (registro15.Read())
            {

                oct14.Text = registro15["pais"].ToString();
                conexion.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string campeon = "select * from equipo where puntos between 0 and 100 order by puntos | dif_goles  desc limit 1;";
            MySqlCommand comando3 = new MySqlCommand(campeon, conexion);
            MySqlDataReader registro3 = comando3.ExecuteReader();
            if (registro3.Read())
            {

                textBox113.Text = registro3["pais"].ToString();
                conexion.Close();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            
            int marcador1 = Convert.ToInt32(textBox160.Text);
            int marcador2 = Convert.ToInt32(textBox115.Text);
           
            int penal1= Convert.ToInt32(textBox161.Text);
            int penal2 = Convert.ToInt32(textBox131.Text);

            if (marcador1 > marcador2 || penal1 > penal2 )
            {
               label193.Text= oct1.Text;

            }
            else
            {
                label193.Text = oct2.Text;
            }

            int marcador3 = Convert.ToInt32(textBox116.Text);
            int marcador4 = Convert.ToInt32(textBox117.Text);

            int penal3 = Convert.ToInt32(textBox132.Text);
            int penal4 = Convert.ToInt32(textBox133.Text);

            if (marcador3 > marcador4 || penal3 > penal4)
            {
                label209.Text = oct3.Text;

            }
            else
            {
                label209.Text = oct4.Text;
            }

            int marcador5 = Convert.ToInt32(textBox118.Text);
            int marcador6 = Convert.ToInt32(textBox119.Text);

            int penal5 = Convert.ToInt32(textBox134.Text);
            int penal6 = Convert.ToInt32(textBox135.Text);

            if (marcador5 > marcador6 || penal5 > penal6)
            {
                label210.Text = oct5.Text;

            }
            else
            {
                label210.Text = oct6.Text;
            }

            int marcador7 = Convert.ToInt32(textBox120.Text);
            int marcador8 = Convert.ToInt32(textBox121.Text);

            int penal7 = Convert.ToInt32(textBox136.Text);
            int penal8 = Convert.ToInt32(textBox137.Text);

            if (marcador7 > marcador8 || penal7 > penal8)
            {
                label211.Text = oct7.Text;

            }
            else
            {
                label211.Text = oct8.Text;
            }

            int marcador9 = Convert.ToInt32(textBox123.Text);
            int marcador10 = Convert.ToInt32(textBox122.Text);

            int penal9 = Convert.ToInt32(textBox138.Text);
            int penal10 = Convert.ToInt32(textBox139.Text);

            if (marcador9 > marcador10 || penal9 > penal10)
            {
                label212.Text = oct9.Text;

            }
            else
            {
                label212.Text = oct10.Text;
            }
            int marcador11 = Convert.ToInt32(textBox125.Text);
            int marcador12 = Convert.ToInt32(textBox124.Text);

            int penal11 = Convert.ToInt32(textBox140.Text);
            int penal12 = Convert.ToInt32(textBox141.Text);

            if (marcador11 > marcador12 || penal11 > penal12)
            {
                label213.Text = oct11.Text;

            }
            else
            {
                label213.Text = oct12.Text;
            }

            int marcador13 = Convert.ToInt32(textBox127.Text);
            int marcador14 = Convert.ToInt32(textBox126.Text);

            int penal13 = Convert.ToInt32(textBox142.Text);
            int penal14 = Convert.ToInt32(textBox143.Text);

            if (marcador13 > marcador14 || penal13 > penal14)
            {
                label214.Text = oct13.Text;

            }
            else
            {
                label214.Text = oct14.Text;
            }
            int marcador15 = Convert.ToInt32(textBox129.Text);
            int marcador16 = Convert.ToInt32(textBox128.Text);

            int penal15 = Convert.ToInt32(textBox144.Text);
            int penal16 = Convert.ToInt32(textBox145.Text);

            if (marcador15 > marcador16 || penal14 > penal15)
            {
                label215.Text = oct15.Text;

            }
            else
            {
                label215.Text = oct16.Text;
            }


        }

        private void button28_Click(object sender, EventArgs e)
        {
            int marcador17 = Convert.ToInt32(textBox114.Text);
            int marcador18 = Convert.ToInt32(textBox146.Text);

            int penal17 = Convert.ToInt32(textBox130.Text);
            int penal18 = Convert.ToInt32(textBox147.Text);

            if (marcador17 > marcador18 || penal17 > penal18)
            {
                label217.Text = label193.Text;

            }
            else
            {
                label217.Text = label209.Text;
            }

            int marcador19 = Convert.ToInt32(textBox148.Text);
            int marcador20 = Convert.ToInt32(textBox150.Text);

            int penal19 = Convert.ToInt32(textBox149.Text);
            int penal20 = Convert.ToInt32(textBox151.Text);

            if (marcador19 > marcador20 || penal19 > penal20)
            {
                label218.Text = label210.Text;

            }
            else
            {
                label218.Text = label211.Text;
            }

            int marcador21 = Convert.ToInt32(textBox152.Text);
            int marcador22 = Convert.ToInt32(textBox154.Text);

            int penal21 = Convert.ToInt32(textBox153.Text);
            int penal22 = Convert.ToInt32(textBox155.Text);

            if (marcador21 > marcador22 || penal21 > penal22)
            {
                label219.Text = label212.Text;

            }
            else
            {
                label219.Text = label213.Text;
            }

            int marcador23 = Convert.ToInt32(textBox156.Text);
            int marcador24 = Convert.ToInt32(textBox158.Text);

            int penal23 = Convert.ToInt32(textBox157.Text);
            int penal24 = Convert.ToInt32(textBox159.Text);

            if (marcador23 > marcador24 || penal23 > penal24)
            {
                label220.Text = label214.Text;

            }
            else
            {
                label220.Text = label215.Text;
            }



        }

        private void button30_Click(object sender, EventArgs e)
        {
            int marcador25 = Convert.ToInt32(textBox172.Text);
            int marcador26 = Convert.ToInt32(textBox164.Text);

            int penal25 = Convert.ToInt32(textBox173.Text);
            int penal26 = Convert.ToInt32(textBox165.Text);

            if (marcador25 > marcador26 || penal25 > penal26)
            {
                label223.Text = label217.Text;

            }
            else
            {
                label223.Text = label218.Text;
            }

            int marcador27 = Convert.ToInt32(textBox166.Text);
            int marcador28 = Convert.ToInt32(textBox168.Text);

            int penal27 = Convert.ToInt32(textBox167.Text);
            int penal28 = Convert.ToInt32(textBox169.Text);

            if (marcador27 > marcador28 || penal27 > penal28)
            {
                label221.Text = label219.Text;

            }
            else
            {
                label221.Text = label220.Text;
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            int marcador29 = Convert.ToInt32(textBox162.Text);
            int marcador30 = Convert.ToInt32(textBox170.Text);

            int penal29 = Convert.ToInt32(textBox163.Text);
            int penal30 = Convert.ToInt32(textBox171.Text);

            if (marcador29 > marcador30 || penal29 > penal30)
            {
                label222.Text = label223.Text;

            }
            else
            {
                label222.Text = label221.Text;
            }
        }

        // Ordenar tablas de posiciones

      

        private void button20_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'a' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            conexion.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'b' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView2.DataSource = tabla;

            conexion.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'c' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView3.DataSource = tabla;

            conexion.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'd' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView4.DataSource = tabla;

            conexion.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'e' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView5.DataSource = tabla;

            conexion.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'f' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView6.DataSource = tabla;

            conexion.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'g' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView7.DataSource = tabla;

            conexion.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select  puntos , pais from equipo  where grupo= 'h' order by puntos DESC", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView8.DataSource = tabla;

            conexion.Close();
        }
    }
}



