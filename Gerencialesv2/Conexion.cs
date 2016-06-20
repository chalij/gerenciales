using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Gerencialesv2
{
    class Conexion
    {
        private String server;
        private OdbcConnection DbConnection;
        private String serverT;
        private OdbcConnection DbConnectionT;
        private OdbcConnection DbConnectionG;
        public frmLogin login;
        public frmPrincipal principal;
        public Conexion()
        {
            server = "Dsn=bdgerencial";
            serverT = "Dsn=administrador";
            DbConnection = new OdbcConnection(server);
            DbConnectionG = new OdbcConnection(server);
            DbConnectionT = new OdbcConnection(serverT);
            String s = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
           // MessageBox.Show(s,"Separador");
           // System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        public void CrearMenu(MenuStrip menu, String usuario,String password)
        {
            menu.Items.Clear();
            CargarMenu(DbConnection, 0, null, menu, usuario, password);
        }
        private void CargarMenu(OdbcConnection DbConnection, Int32 idPadre, ToolStripMenuItem menuPadre, MenuStrip menu, String usuario,String password)
        {
            try
            {
                DbConnection.Open();
                OdbcCommand DbCommand = DbConnection.CreateCommand();
                DbCommand.CommandText = "select id_menu,descripcion,count from (SELECT a.id_menu, a.descripcion, Deriv1.Count,a.id_rol FROM menu a  LEFT OUTER JOIN (SELECT id_padre, COUNT(*) AS Count FROM menu GROUP BY id_padre) Deriv1 ON a.id_menu = Deriv1.id_padre WHERE a.id_padre=" + idPadre + ") m2,rol r, usuario u WHERE m2.id_rol = r.id_rol AND r.id_rol = u.id_rol and u.usuario ='" + usuario+"' and u.password='"+password+"'";
                
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                List<ArrayList> lista = new List<ArrayList>();
                ArrayList filas;
                while (DbReader.Read())
                {
                    filas = new ArrayList();
                    filas.Add(DbReader[0]);
                    filas.Add(DbReader[1]);
                    filas.Add(DbReader[2]);
                    lista.Add(filas);
                }

                DbConnection.Close();
                DbConnectionT.Close();

                foreach (ArrayList fila in lista)
                {
                    ToolStripMenuItem MenuHijo = new ToolStripMenuItem();
                    MenuHijo.Text = fila[1] + "";
                    MenuHijo.Name = fila[0] + "";
                    MenuHijo.Click += new EventHandler(Eventos);
                    if (menuPadre == null)
                    {
                        menu.Items.Add(MenuHijo);
                        //Funcion Recursiva para cargar menu
                        CargarMenu(DbConnection, int.Parse(fila[0] + ""), MenuHijo, menu, usuario,password);
                    }
                    else
                    {
                        //Carga Hijos
                        menuPadre.DropDownItems.Add(MenuHijo);
                    }
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        private void Eventos(Object sender, EventArgs e)
        {
            ToolStripMenuItem ItemClick = (ToolStripMenuItem)sender;
            principal.label1.Visible = false;
            //Agregar condicion Para mostrar vista
            if (Convert.ToInt32(ItemClick.Name) == 5)
            {
                filtros.FiltroGastosAdmin f1 = new filtros.FiltroGastosAdmin();
                f1.principal = principal;
                f1.MdiParent=principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 7)
            {
                filtros.FiltroIngresoNeto f1 = new filtros.FiltroIngresoNeto();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 8)
            {
                filtros.FiltroCostoBeneficio f1 = new filtros.FiltroCostoBeneficio();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 9)
            {
                filtros.FiltroGastoViajes f1 = new filtros.FiltroGastoViajes();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 10)
            {
                filtros.FiltroIngresosViajesMes f1 = new filtros.FiltroIngresosViajesMes();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 17)
            {
                filtros.FiltroIngresosViajes f1 = new filtros.FiltroIngresosViajes();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 18)
            {
                filtros.FiltroGastoViajesSF f1 = new filtros.FiltroGastoViajesSF();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 19)
            {
                filtros.FiltroUsuarioUnidades f1 = new filtros.FiltroUsuarioUnidades();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 20)
            {
                filtros.FiltroUsuarioViaje f1 = new filtros.FiltroUsuarioViaje();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 21)
            {
                filtros.FiltroGastosCombustible f1 = new filtros.FiltroGastosCombustible();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 22)
            {
                filtros.FiltroComparativoIngresos f1 = new filtros.FiltroComparativoIngresos();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 25)
            {
                principal.Hide();
                login.Show();
            }

            if (Convert.ToInt32(ItemClick.Name) == 28)
            {
                filtros.FiltroIngresosViajes f1 = new filtros.FiltroIngresosViajes();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 29)
            {
                filtros.FiltroGastoViajesSF f1 = new filtros.FiltroGastoViajesSF();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 30)
            {
                filtros.FiltroUsuarioUnidades f1 = new filtros.FiltroUsuarioUnidades();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 31)
            {
                filtros.FiltroUsuarioViaje f1 = new filtros.FiltroUsuarioViaje();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 32)
            {
                filtros.FiltroGastosCombustible f1 = new filtros.FiltroGastosCombustible();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 33)
            {
                filtros.FiltroComparativoIngresos f1 = new filtros.FiltroComparativoIngresos();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }

            if (Convert.ToInt32(ItemClick.Name) == 34)
            {
                principal.Hide();
                login.Show();
            }

            if (Convert.ToInt32(ItemClick.Name) == 36)
            {
                filtros.FiltroGastosAdmin f1 = new filtros.FiltroGastosAdmin();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 37)
            {
                filtros.FiltroIngresoNeto f1 = new filtros.FiltroIngresoNeto();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 38)
            {
                filtros.FiltroCostoBeneficio f1 = new filtros.FiltroCostoBeneficio();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 39)
            {
                filtros.FiltroGastoViajes f1 = new filtros.FiltroGastoViajes();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 40)
            {
                filtros.FiltroIngresosViajesMes f1 = new filtros.FiltroIngresosViajesMes();
                f1.principal = principal;
                f1.MdiParent = principal;
                //Se muestra vista
                f1.Show();
            }

            if (Convert.ToInt32(ItemClick.Name) == 16)
            {
                principal.Hide();
                login.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 15)
            {
                formularios.mtUser mtUsu = new formularios.mtUser();
                mtUsu.MdiParent = principal;
                //Se muestra vista
                mtUsu.Show();
            }
            if (Convert.ToInt32(ItemClick.Name) == 12)
            {
                formularios.confirmETL etl = new formularios.confirmETL();
                etl.MdiParent = principal;
                //Se muestra vista
                etl.Show();
            }
        }
        public Boolean usuarioVerificacion(String usuario, String Password)
        {
            Boolean verificacion = false;
            try
            {
                DbConnection.Open();
                OdbcCommand DbCommand = DbConnection.CreateCommand();
                DbCommand.CommandText = "select * from usuario where usuario='" + usuario + "' and password='" + Password + "'";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                List<ArrayList> lista = new List<ArrayList>();
                ArrayList filas;
                while (DbReader.Read())
                {
                    verificacion = true;
                    filas = new ArrayList();
                    filas.Add(DbReader[0]);
                    filas.Add(DbReader[1]);
                    filas.Add(DbReader[2]);
                    lista.Add(filas);
                }

                DbConnection.Close();
                return verificacion;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public void ETL(Label label1,ProgressBar progressBar1)
        {
            try
            {

               

                DbConnectionT.Open();
                DbConnectionG.Open();
                String Destruccion = "select * from destruirCrear()";
                OdbcCommand DbCommandT = DbConnectionT.CreateCommand();
                DbCommandT.CommandText = "select * from selectCon() as f(id_conductor integer,nombre varchar(50))";
                OdbcDataReader DbReaderT = DbCommandT.ExecuteReader();

                OdbcCommand DbCommandG = DbConnectionG.CreateCommand();
                DbCommandG.CommandText = Destruccion;
                OdbcDataReader DbReaderG = DbCommandG.ExecuteReader();
                label1.Text = "Ingresando Conductores..";
                label1.Refresh();
                while (DbReaderT.Read())
                {

                    label1.Text = "Ingresando Conductores...";
                    label1.Refresh();
                    DbCommandG = DbConnectionG.CreateCommand();
                    DbCommandG.CommandText = "INSERT INTO conductor(id_conductor,nombre)VALUES ('" + DbReaderT[0] + "','" + DbReaderT[1] + "');";
                    DbReaderG = DbCommandG.ExecuteReader();
                }
                String etlPropietario = "select * from selectProp() as f(propietario integer,nombree character varying(50),dui character varying(15),nit character varying(15));";

                OdbcCommand CommandTprop = DbConnectionT.CreateCommand();
                CommandTprop.CommandText = etlPropietario;
                DbReaderT = CommandTprop.ExecuteReader();

                label1.Text = "Ingresando Propietarios..";
                label1.Refresh();
                while (DbReaderT.Read())
                {
                    label1.Text = "Ingresando Propietarios...";
                    label1.Refresh();
                    OdbcCommand CommandGprop = DbConnectionG.CreateCommand();
                    CommandGprop.CommandText = "INSERT INTO propietario(id_propietario,nombre_empresario,nit,dui)VALUES ('" + DbReaderT[0] + "','" + DbReaderT[1] + "','" + DbReaderT[2] + "','" + DbReaderT[3] + "');";
                    CommandGprop.ExecuteReader();
                }


                String etlGasto = "select * from selectGasto() f(idgasto integer,nombreg character varying(30),descripcion character varying(80),esgadmin character varying(15));";

                OdbcCommand CommandTgasto = DbConnectionT.CreateCommand();
                CommandTgasto.CommandText = etlGasto;
                DbReaderT = CommandTgasto.ExecuteReader();

                label1.Text = "Ingresando Gastos..";
                label1.Refresh();
                while (DbReaderT.Read())
                {
                    label1.Text = "Ingresando Gastos...";
                    label1.Refresh();
                    OdbcCommand CommandGprop = DbConnectionG.CreateCommand();
                    CommandGprop.CommandText = "INSERT INTO gasto(id_gasto,nombre_gasto,descripcion,es_gasto_admin)VALUES ('" + DbReaderT[0] + "','" + DbReaderT[1] + "','" + DbReaderT[2] + "','" + DbReaderT[3] + "');";
                    CommandGprop.ExecuteReader();
                }


                String etlEquipo = "select * from selectEquipo() f(equipo integer,conductorfk integer,empresariofk integer,marca character varying(30),placa character varying(10));";

                OdbcCommand CommandTequipo = DbConnectionT.CreateCommand();
                CommandTequipo.CommandText = etlEquipo;
                DbReaderT = CommandTequipo.ExecuteReader();

                label1.Text = "Ingresando Equipos..";
                label1.Refresh();
                while (DbReaderT.Read())
                {
                    label1.Text = "Ingresando Equipos...";
                    label1.Refresh();
                    OdbcCommand CommandGprop = DbConnectionG.CreateCommand();
                    CommandGprop.CommandText = "INSERT INTO equipo(id_equipo,id_conductor,id_propietario,marca,placa)VALUES ('" + DbReaderT[0] + "','" + DbReaderT[1] + "','" + DbReaderT[2] + "','" + DbReaderT[3] + "','" + DbReaderT[4]  + "');";
                    CommandGprop.ExecuteReader();
                }
                //select * from selectMD() as f(iddiario integer,fechai date,equipofk integer,minicio numeric(10,0),mfinal numeric(10,0),nviajes numeric(5,0),conductorfk integer,pasajea double precision,ineto double precision,ibruto double precision,gastosT double precision,gastosComb double precision,gastosAdmin double precision,gastosOtros double precision,gastosAhorro  double precision);

                String etlMdiario = "select * from selectMD() as f(iddiario integer,fechai text,equipofk integer,minicio numeric(10,0),mfinal numeric(10,0),nviajes numeric(5,0),conductorfk integer,pasajea double precision,ineto double precision,ibruto double precision,gastosT double precision,gastosComb double precision,gastosAdmin double precision,gastosOtros double precision,gastosAhorro  double precision,dayi  double precision,monthi  double precision,yeari  double precision);";
                OdbcCommand CommandTMdiario = DbConnectionT.CreateCommand();
                CommandTMdiario.CommandText = etlMdiario;
                DbReaderT = CommandTMdiario.ExecuteReader();

                label1.Text = "Ingresando Movimiento Diario..";
                label1.Refresh();
                while (DbReaderT.Read())
                {

                    label1.Text = "Ingresando Movimiento Diario...";
                    label1.Refresh();
                    //  MessageBox.Show(DbReaderT[7] + "", "esto");
                    OdbcCommand CommandGprop = DbConnectionG.CreateCommand();
                    // MessageBox.Show("INSERT INTO movimiento_diario(id_movimiento_diario,fecha_ingreso,id_equipo,maquina_inicio,maquina_final,numro_viajes,id_conductor,pasaje_actual,ingreso_neto,ingreso_bruto,gastos_totales,gastos_combutible,gastos_administrativos,otros_gastos,ahorro)VALUES ('" + DbReaderT[0] + "','" + DbReaderT[1] + "','" + DbReaderG3[0] + "','" + DbReaderT[3] + "','" + DbReaderT[4] + "','" + DbReaderT[5] + "','" + DbReaderG4[0] + "','" + DbReaderT[7] + "','" + DbReaderT[8] + "','" + DbReaderT[9] + "','" + DbReaderT[10] + "','" + DbReaderT[11] + "','" + DbReaderT[12] + "','" + DbReaderT[13] + "','" + DbReaderT[14] + "');", "Completado");
                    CommandGprop.CommandText = "INSERT INTO movimiento_diario(id_movimiento_diario,fecha_ingreso,id_equipo,maquina_inicio,maquina_final,numro_viajes,id_conductor,pasaje_actual,ingreso_neto,ingreso_bruto,gastos_totales,gastos_combutible,gastos_administrativos,otros_gastos,ahorro,dia,mes,yeari)VALUES ('" + DbReaderT[0] + "','" + DbReaderT[1] + "','" + DbReaderT[2] + "','" + DbReaderT[3] + "','" + DbReaderT[4] + "','" + DbReaderT[5] + "','" + DbReaderT[6] + "'," + DbReaderT[7] + "," + DbReaderT[8] + "," + DbReaderT[9] + "," + DbReaderT[10] + "," + DbReaderT[11] + "," + DbReaderT[12] + "," + DbReaderT[13] + "," + DbReaderT[14] + ",'" + DbReaderT[15] + "','" + DbReaderT[16] + "','" + DbReaderT[17] + "');";
                    CommandGprop.ExecuteReader();
                }

                /*
                String etlDeposito = "select * from cuentaae";

                OdbcCommand CommandTdep = DbConnectionT.CreateCommand();
                CommandTdep.CommandText = etlDeposito;
                DbReaderT = CommandTdep.ExecuteReader();

                label1.Text = "Ingresando Deposito..";
                label1.Refresh();
                while (DbReaderT.Read())
                {
                    label1.Text = "Ingresando Deposito...";
                    label1.Refresh();
                    OdbcCommand CommandGprop = DbConnectionG.CreateCommand();
                    CommandGprop.CommandText = "INSERT INTO deposito(id_deposito,valor_deposito,concepto,id_equipo)VALUES (" + DbReaderT[0] + ",'" + DbReaderT[1] + "','" + DbReaderT[2] + "','" + DbReaderT[3] + "');";
                    CommandGprop.ExecuteReader();

                    OdbcCommand DbCommandG2 = DbConnectionG.CreateCommand();
                    DbCommandG2.CommandText = "SELECT MAX(id_deposito) FROM deposito;";
                    OdbcDataReader DbReaderG2 = DbCommandG2.ExecuteReader();

                    while (DbReaderG2.Read())
                    {
                        OdbcCommand DbCommandGTemp = DbConnectionG.CreateCommand();
                        DbCommandGTemp.CommandText = "INSERT INTO temporal(id_gerencial,id_transaccional,tabla_gerencial)VALUES ('" + DbReaderG2[0] + "','" + DbReaderT[0] + "','deposito');";
                        DbCommandGTemp.ExecuteReader();
                        label1.Text = "Ingresando Deposito..";
                        label1.Refresh();
                    }
                }*/


                /*
                String etlLgasto = "select idgastol,valor,diariofk,idgasto from lgastos l,gasto g where gastofk=nombreg";

                OdbcCommand CommandTlGast = DbConnectionT.CreateCommand();
                CommandTlGast.CommandText = etlLgasto;
                DbReaderT = CommandTlGast.ExecuteReader();

                label1.Text = "Ingresando Lista de Gastos..";
                label1.Refresh();
                while (DbReaderT.Read())
                {
                    label1.Text = "Ingresando Lista de Gastos...";
                    label1.Refresh();
                    OdbcCommand CommandGprop = DbConnectionG.CreateCommand();
                    CommandGprop.CommandText = "INSERT INTO lista_gasto(id_lista_gasto,id_gasto,valor,id_movimiento_diario,gasto_fk)VALUES (" + DbReaderT[0] + "," + DbReaderT[3] + "," + DbReaderT[1] + "," + DbReaderT[2] + "," + DbReaderT[3] + ");";
                    CommandGprop.ExecuteReader();

                    OdbcCommand DbCommandG2 = DbConnectionG.CreateCommand();
                    DbCommandG2.CommandText = "SELECT MAX(id_lista_gasto) FROM lista_gasto;";
                    OdbcDataReader DbReaderG2 = DbCommandG2.ExecuteReader();

                    while (DbReaderG2.Read())
                    {
                        OdbcCommand DbCommandGTemp = DbConnectionG.CreateCommand();
                        DbCommandGTemp.CommandText = "INSERT INTO temporal(id_gerencial,id_transaccional,tabla_gerencial)VALUES ('" + DbReaderG2[0] + "','" + DbReaderT[0] + "','lista_gasto');";
                        DbCommandGTemp.ExecuteReader();
                        label1.Text = "Ingresando Lista de Gastos..";
                        label1.Refresh();
                    }
                }*/

                DbConnectionG.Close();
                DbConnectionT.Close();
                label1.Text = "Datos Correctamente Cargados..";
              //  MessageBox.Show("Datos Cargados", "Completado");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public String encriptar(String _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public String unCript(String _cadenaAdesencriptar)
        {
            String result = "";
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        public Boolean ifEncryp(String cad)
        {
            try 
            {
                unCript(cad);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public Dictionary<string, string> ListaUsuarios()
        {
            List<Item> usuarios = new List<Item>();
            Dictionary<string, string> test = new Dictionary<string, string>();
            try
            {
                DbConnection.Open();
                OdbcCommand DbCommand = DbConnection.CreateCommand();
                DbCommand.CommandText = "select * from rol order by id_rol";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    test.Add(DbReader[0] + "", DbReader[1] + "");
                }
                DbConnection.Close();
                return test;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Boolean validarClave(String clave)
        {
            Char lmin = 'a';
            Char num = '0';
            Char lmay = 'A';
            Char auxmin = 'a';
            Char auxmax = 'a';
            Char auxnum = 'a';
            if (clave.Length > 10)
            {
                int cn = 0;
                int cmay = 0;
                int cmin = 0;
                for (int h = 0; h < clave.Length; h++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        int auxamin = lmin + i;
                        int auxamax = lmay + i;

                        auxmin = (Char)auxamin;
                        auxmax = (Char)auxamax;
                        if (clave[h]==auxmin)
                        {
                            cmin++;
                        }
                        if (clave[h] == auxmax)
                        {
                            cmay++;
                        }
                        //  MessageBox.Show(auxmin+","+auxmax, "alf");
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        int auxanum = num + i;
                        auxnum = (Char)auxanum;
                        if (clave[h] == auxnum)
                        {
                            cn++;
                        }
                        //MessageBox.Show(auxnum+"", "alf");
                    }
                }
               // MessageBox.Show(cn+","+cmay+","+cmin+","+clave[0], "alf");
                if (cn >= 1 && cmay >= 1 && cmin >= 3)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }


    }
}
