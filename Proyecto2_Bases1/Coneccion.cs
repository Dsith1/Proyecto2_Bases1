﻿using System;
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
                        else if (tipo == 2)//Entrar Quiniela
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("RTorneo", OracleDbType.Int16);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NParticipante", OracleDbType.Varchar2);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);


                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 3)//Registrar actualizar Resultado Usuario
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("RPartido", OracleDbType.Int16);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Elocal", OracleDbType.Int16);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Glocal", OracleDbType.Int16);
                            inval.Value = parametro[2];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Evisita", OracleDbType.Int16);
                            inval.Value = parametro[3];
                            cmd.Parameters.Add(inval);
                                                     
                            inval = new OracleParameter("Gvisita", OracleDbType.Int16);
                            inval.Value = parametro[4];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Usuario", OracleDbType.Varchar2);
                            inval.Value = parametro[5];
                            cmd.Parameters.Add(inval);


                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 4)//Registrar Resultado Real
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("RPartido", OracleDbType.Int16);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Elocal", OracleDbType.Int16);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Glocal", OracleDbType.Int16);
                            inval.Value = parametro[2];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Evisita", OracleDbType.Int16);
                            inval.Value = parametro[3];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Gvisita", OracleDbType.Int16);
                            inval.Value = parametro[4];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Ctorneo", OracleDbType.Int16);
                            inval.Value = parametro[5];
                            cmd.Parameters.Add(inval);


                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 5)//Registrar Pais
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("NNombre", OracleDbType.Varchar2);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            if (parametro[1].Equals(""))
                            {

                                inval = new OracleParameter("NFederacion", OracleDbType.Int16);
                                inval.Value = null;
                                cmd.Parameters.Add(inval);
                            }
                            else
                            {
                                inval = new OracleParameter("NFederacion", OracleDbType.Int16);
                                inval.Value = parametro[1];
                                cmd.Parameters.Add(inval);
                            }

                            

                           
                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 6)//Registrar Equipo
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("NNombre", OracleDbType.Varchar2);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NPais", OracleDbType.Int16);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);

                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 7)//Eliminar Equipo
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("Ncodigo", OracleDbType.Int16);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);


                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 8)//Eliminar Equipo
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("codigo", OracleDbType.Int16);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NNombre", OracleDbType.Varchar2);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NPais", OracleDbType.Int16);
                            inval.Value = parametro[2];
                            cmd.Parameters.Add(inval);


                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 9)//Crear Jugador
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("NNombre", OracleDbType.Varchar2);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Nposicion", OracleDbType.Varchar2);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Nestatura", OracleDbType.Int16);
                            inval.Value = parametro[2];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Npeso", OracleDbType.Int16);
                            inval.Value = parametro[3];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Npais", OracleDbType.Int16);
                            inval.Value = parametro[4];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Nnacimiento", OracleDbType.Varchar2);
                            inval.Value = parametro[5];
                            cmd.Parameters.Add(inval);

 
                            cmd.ExecuteNonQuery();


                        }
                        else if (tipo == 10)//Actualizar Jugador
                        {
                            string[] parametro = parametros.Split(',');


                            OracleParameter inval = new OracleParameter("Ncodigo", OracleDbType.Int16);
                            inval.Value = parametro[0];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("NNombre", OracleDbType.Varchar2);
                            inval.Value = parametro[1];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Nposicion", OracleDbType.Varchar2);
                            inval.Value = parametro[2];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Nestatura", OracleDbType.Int16);
                            inval.Value = parametro[3];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Npeso", OracleDbType.Int16);
                            inval.Value = parametro[4];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Ngoles", OracleDbType.Int16);
                            inval.Value = parametro[5];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Npais", OracleDbType.Int16);
                            inval.Value = parametro[6];
                            cmd.Parameters.Add(inval);

                            inval = new OracleParameter("Nnacimiento", OracleDbType.Varchar2);
                            inval.Value = parametro[7];
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
                        cmd.CommandText = "Select Nombre,goles,posicion,estatura,peso,(to_number(to_char(sysdate,'YYYY')) - to_number(to_char(nacimiento,'YYYY'))) as edad ,to_char(nacimiento,'yyyy-mm-dd') as nacimiento from jugador Where codigo=\'" + codigo + "\'";
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

                            respuesta += lector["Elocal"] + "," + lector["RLocal"] + "," + lector["Rvisitante"] + "," + lector["visitante"] + "," + lector["Partido"] + ";";
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

        public string getEquipos()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select C.Pais,D.nombre as Federacion,C.idequipo from (Select A.Nombre as Pais,B.Federacion,A.idequipo from (Select Nombre,Pais,idequipo from Equipo)A,(Select IDpais,Federacion from Pais)B Where A.Pais=B.IDpais)C,(Select codigo,nombre from Federacion)D Where C.Federacion=D.codigo ";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Pais"] + "," + lector["Federacion"] + "," + lector["idequipo"] + ";";
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

        public string getLEquipos()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select idEquipo,Nombre from Equipo";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["idEquipo"] + "," + lector["Nombre"] + ";";
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

        public string getRanking()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select rank() over (order by Puntos desc)Puesto ,Nombre,Puntos from Equipo";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Puesto"] + "," + lector["Nombre"] + "," + lector["Puntos"] + ";";
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

        public string getRankingU(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select rank() over (order by B.Puntos desc)Puesto,A.nombre,B.puntos from (Select idequipo,nombre from equipo)A,(Select equipo,puntos from Equipo_Participante Where Participante=\'"+codigo+ "\')B Where A.idequipo=B.equipo";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Puesto"] + "," + lector["Nombre"] + "," + lector["Puntos"] + ";";
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

        public string getRankingT(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select A.Puesto,B.nombre as Equipo,A.Puntos from (Select rank() over (order by Puntos desc)Puesto ,Equipo,Puntos from Torneo_Puntos Where Torneo="+codigo+")A,(Select idEquipo, Nombre from Equipo)B Where A.Equipo = B.Idequipo order by Puesto";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Puesto"] + "," + lector["Equipo"] + "," + lector["Puntos"] + ";";
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

        public string getRankingG(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select A.Puesto,B.nombre as Equipo,A.Puntos from (Select rank() over (order by Puntos desc)Puesto ,Equipo,Puntos from Equipo_Grupo Where Grupo=" + codigo + ")A,(Select idEquipo, Nombre from Equipo)B Where A.Equipo = B.Idequipo order by Puesto";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Puesto"] + "," + lector["Equipo"] + "," + lector["Puntos"] + ";";
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

        public string getRankingP(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select rank() over (order by Puntos desc)Puesto,Participante,Puntos from Quiniela where pago=1 and torneo=" + codigo;
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Puesto"] + "," + lector["Participante"] + "," + lector["Puntos"] + ";";
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

        public string getPlantel(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select B.Nombre,B.Posicion,A.Dorsal from (Select Equipo,Jugador,Dorsal from Plantel  Where Equipo=" + codigo + ")A,(Select Codigo,Nombre,Posicion from Jugador)B Where B.codigo=A.jugador";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Nombre"] + "," + lector["Posicion"] + "," + lector["Dorsal"] + ";";
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

        public string getTorneos()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select Codigo,Nombre from torneo";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Codigo"] + "," + lector["Nombre"] + ";";
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

        public string getGrupos(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select codigo,nombre from Grupo where Torneo="+codigo+" order by nombre ASC";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Codigo"] + "," + lector["Nombre"] + ";";
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

        public string getPartidoD(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select A.codigo,A.Sede,A.Fecha,to_char(A.HOra,'HH24:MI') as Hora,A.Torneo,B.nombre as Principal,C.nombre as Asistente1,D.nombre as Asistente2 from (Select A.codigo,A.Sede,A.Fecha,A.HOra,A.Torneo,B.Arbitro as Principal,C.Arbitro as Asistente1,D.Arbitro as Asistente2 from (Select C.codigo,D.nombre as Sede,C.Fecha,C.Hora,C.Torneo from (Select A.Codigo,A.Sede,A.Fecha,A.Hora,B.nombre as Torneo from (Select Codigo,Sede,Fecha,Hora,Torneo from Partido)A, (Select Codigo,nombre from torneo)B Where A.torneo=B.codigo)C, (Select Codigo, Nombre from Sede)D Where C.Sede=D.codigo)A, (Select Partido,Arbitro from Partido_Arbitro Where puesto=1)B, (Select Partido,Arbitro from Partido_Arbitro Where puesto=2)C, (Select Partido,Arbitro from Partido_Arbitro Where puesto=3)D Where A.codigo=B.partido and A.codigo=C.partido and A.codigo=D.partido)A, (Select Nombre,idarbitro from Arbitro)B, (Select Nombre,idarbitro from Arbitro)C, (Select Nombre,idarbitro from Arbitro)D Where A.Principal=B.idarbitro and A.Asistente1=c.idarbitro and A.Asistente2=D.idarbitro and A.codigo=\'" + codigo+"\'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Sede"] + "," + lector["Fecha"] + "," + lector["Hora"] + "," + lector["Torneo"] + "," + lector["Principal"] + "," + lector["Asistente1"] + "," + lector["Asistente2"];
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

        public string getQUinielas(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select B.codigo,B.Nombre as Torneo,A.Puntos,A.Pago from (Select Torneo,Puntos,Pago from Quiniela where participante=\'" + codigo + "\' )A,(Select nombre,codigo from torneo)B WHere A.Torneo=B.codigo";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Codigo"] + "," + lector["Torneo"] + "," + lector["Puntos"] + "," + lector["Pago"] + ";";
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

        public string getResultado(string usuario,string partido)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select codigo,golesL,golesV from Resultado Where codigo in(Select resultado from resultado_participante where participante=\'"+usuario+ "\' )and partido="+partido;
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Codigo"] + "," + lector["golesL"] + "," + lector["golesV"];
                        }



                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return "";
                }
            }


        }

        public string getEpartido(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select B.nombre as Elocal,C.nombre as visitante from (Select Elocal,Evisitante from Equipo_Partido Where partido="+codigo+ ")A,(Select idequipo,nombre from Equipo)B,(Select idequipo,nombre from Equipo)C Where A.Elocal=B.idequipo and A.Evisitante=C.idequipo";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Elocal"] + "," + lector["visitante"];
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

        public string getNOmbreE(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select idequipo from Equipo where nombre=\'" + codigo+"\'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["idequipo"] +"";
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

        public string getTorneoP(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select Torneo from Partido Where codigo=" + codigo;
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Torneo"] + "";
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

        public string getPartidoE(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select A.Partido,B.nombre as Elocal,to_char(A.golesL) as Glocal ,to_char(A.golesV) as Gvisitante ,C.nombre as Visitante from (Select A.Partido,A.Elocal,A.golesL,A.golesV,A.Evisitante from (Select A.Partido,A.Elocal,B.golesL,B.golesV,A.Evisitante from (Select Partido,Elocal,Evisitante from Equipo_Partido Where Partido in (Select Partido from Resultado where tipo=1))A, (Select Partido,golesL,golesV from Resultado)B Where A.Partido=B.Partido)A, (Select idequipo from Equipo Where idequipo=" + codigo + ")B Where A.Elocal=B.idequipo or A.Evisitante=B.idequipo)A,(Select idequipo,nombre from Equipo)B,(Select idequipo,nombre from Equipo)C WHere A.Elocal=B.idequipo and A.Evisitante=C.idequipo union Select A.partido,B.nombre as Elocal,'-' as Glocal,'-' as Gvisitante,C.nombre as Visitante from (Select A.Partido,A.Elocal,A.Evisitante from (Select Partido,Elocal,Evisitante from Equipo_Partido Where Partido not in (Select Partido from Resultado where tipo=1))A, (Select idequipo from Equipo Where idequipo=" + codigo+ ")B Where A.Elocal=B.idequipo or A.Evisitante=B.idequipo)A,(Select idequipo,nombre from Equipo)B,(Select idequipo,nombre from Equipo)C WHere A.Elocal=B.idequipo and A.Evisitante=C.idequipo";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Partido"] + "," + lector["Elocal"] + "," + lector["Glocal"] + "," + lector["Gvisitante"] + "," + lector["Visitante"]+";";
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

        public string getParticipantes()
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select Usuario,Nombre,Apellido,Edad from Participante Where Administrador=0";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Usuario"] + "," + lector["Nombre"] + "," + lector["Apellido"] + "," + lector["Edad"] + ";";
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

        public string getPaisN(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select idPais from Pais Where nombre=\'" + codigo + "\'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["idPais"];
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

        public bool getPaisNE(string codigo)
        {
            bool respuesta = false;
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select idPais from Pais Where nombre=\'" + codigo + "\'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        respuesta = lector.Read();

                    }

                    con.Close();

                    return respuesta;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    return false;
                }
            }


        }

        public string getPartidoN(string local,string visitante)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select Partido from Equipo_Partido Where Elocal=" + local + " and Evisitante="+visitante;
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Partido"];
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

        public string getEquipoN(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select idequipo from Equipo where nombre=\'" + codigo + "\'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["idequipo"];
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

        public string getEquipoNombre(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select nombre  from Equipo where idequipo=" + codigo ;
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["nombre"];
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

        public string getEquipoPais(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select Pais from Equipo where idequipo=" + codigo;
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["Pais"];
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

        public string getJugadorPais(string codigo)
        {
            string respuesta = "";
            using (OracleConnection con = new OracleConnection(Cadena))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select NACIONALIDAD from Jugador where codigo=" + codigo;
                        cmd.CommandType = System.Data.CommandType.Text;
                        OracleDataReader lector = cmd.ExecuteReader();

                        while (lector.Read())
                        {

                            respuesta += lector["NACIONALIDAD"];
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