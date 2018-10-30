using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace Proyecto2_Bases1
{
    public class Coneccion
    {
        readonly string Cadena = "User Id=Dannek;Password=bobafet;Data Source=localhost:1521/orcl;";

        public Coneccion()
        {

        }

        public Coneccion(string Procedimiento, string parametros, int tipo)
        {
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = Procedimiento;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (tipo == 1)//SigUP
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("NUSER", OracleDbType.Varchar2);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NNombre", OracleDbType.Varchar2);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NApellido", OracleDbType.Varchar2);
                            inval.Value = parametro[2];
                            cmd.Parameters.Add(inval);


                            inval = new OracleParameter("NContra", OracleDbType.Varchar2);
                            inval.Value = parametro[3];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NPais", OracleDbType.Int16);
                            inval.Value = parametro[4];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NEdad", OracleDbType.Int16);
                            inval.Value = parametro[5];
                            cmd.Parameters.Add(inval);

                            cmd.ExecuteNonQuery();


                        }

                    }

                    con.Close();

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }

        public string Login(string Usuario, string contra)
        {
            string respuesta = "Error";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select Usuario,contra,administrador from participante Where Usuario=\'" + Usuario + "\' and Contra=\'" + contra + "\'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta = lector["administrador"] + "";
                        }



                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return null;
                }
            }


        }

        public string getPaises()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select idPais,Nombre from Pais";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["idPais"] + "," + lector["Nombre"] + ";";
                        }



                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return null;
                }
            }


        }

        public string getJugadores()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select A.codigo,A.Nombre,A.Posicion,B.Nombre as Pais from (Select codigo,Nombre,Posicion,Nacionalidad from Jugador)A, (Select idPais,Nombre from Pais)B Where A.Nacionalidad=B.idPais";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["codigo"] + "," + lector["Nombre"] + "," + lector["Posicion"] + "," + lector["Pais"] + ";";
                        }



                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return null;
                }
            }


        }

        public string getJugadoresD(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select Nombre,goles,posicion,estatura,peso,(to_number(to_char(sysdate,'YYYY')) - to_number(to_char(nacimiento,'YYYY'))) as edad ,to_char(nacimiento,'dd/mm/yyyy') as nacimiento from jugador Where codigo=\'" + codigo + "\'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Nombre"] + "," + lector["goles"] + "," + lector["Posicion"] + "," + lector["estatura"] + "," + lector["peso"] + "," + lector["edad"] + "," + lector["nacimiento"];
                        }



                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return null;
                }
            }


        }

        public string getGoleadores()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select A.codigo,A.Nombre,B.Nombre as Pais,A.Goles from (Select codigo,Nombre,Goles,Nacionalidad from Jugador)A,(Select idPais,Nombre from Pais)B Where A.Nacionalidad=B.idPais Order by Goles Desc";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["codigo"] + "," + lector["Nombre"] + "," + lector["Pais"] + "," + lector["Goles"] + ";";
                        }



                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return null;
                }
            }


        }

        public string getResultados()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select F.Partido,F.Elocal,F.RLocal,F.Rvisitante,G.nombre as visitante from (select D.Partido,E.nombre as Elocal,D.RLocal,D.Rvisitante,D.Evisitante from (Select A.Partido, A.ELocal,to_char(B.GolesL)as RLocal,to_char(B.GolesV) as Rvisitante,A.Evisitante from (Select Partido,ELocal,Evisitante from Equipo_Partido Where Partido in (Select Partido from Resultado where tipo=1))A, (Select Partido,GolesL,GolesV from Resultado where tipo=1)B Where A.Partido=B.Partido union Select Partido,ELocal,'-','-',Evisitante from (Select Partido,ELocal,Evisitante from Equipo_Partido Where Partido not in (Select Partido from Resultado where tipo=1)))D, (Select idequipo,nombre from Equipo)E Where D.ELocal=E.idequipo)F, (Select idequipo,nombre from Equipo)G Where F.Evisitante=G.idequipo order by partido";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Elocal"] + "," + lector["RLocal"] + "," + lector["Rvisitante"] + "," + lector["visitante"] + ";";
                        }



                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return null;
                }
            }


        }

    }
}