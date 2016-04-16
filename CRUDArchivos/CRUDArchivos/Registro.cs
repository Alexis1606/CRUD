using System;
using System.Collections;
using Classes;
using System.Data.SqlClient;

namespace CRUDArchivos
{
	public class Registro
	{
		public int noCuenta;
		public string nombre;
		public string direccion;
		public string telefono;
		public string correo;

		public Registro (int noCuenta, String nombre, string direccion, string telefono, string correo)
		{
			this.noCuenta = noCuenta;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
			this.correo = correo;
		}
		public Registro ()
		{
			this.noCuenta = -1;
			this.nombre = null;
			this.direccion = null;
			this.telefono = null;
			this.correo = null;
		}

		override public string ToString(){
			return this.noCuenta + "|" + this.nombre + "|" + this.direccion + "|" + this.telefono + "|" + this.correo;
		}

		public static String[] StructToString(ArrayList array) {
			Registro[] r = arrayListToRegistroArray (array);
			string[] res = new String[array.Count];

			for (int i = 0; i < res.Length; i++) {

				res [i] = r [i].ToString ();
			}
			return res;
		}
		public static Registro[] arrayListToRegistroArray(ArrayList array){
			CRUDArchivos.Registro[] r = new CRUDArchivos.Registro[array.Count];

			for (int i = 0; i < array.Count; i++) {
				r [i] = new CRUDArchivos.Registro ();
				r [i].correo = ((Registro)array [i]).correo;
				r [i].direccion = ((Registro)array [i]).direccion;
				r [i].noCuenta = ((Registro)array [i]).noCuenta;
				r [i].nombre = ((Registro)array [i]).nombre;
				r [i].telefono = ((Registro)array [i]).telefono;
			}
			return r;
		}
		public static ArrayList LlenarRegistros(String path)
		{
			ArrayList res = new ArrayList ();
			//contregistros = 0;
			String[] Archivo = Archivos.leerArchivo(path);
			for (int i = 0; i < Archivo.Length; i++) {
				//obtenemos cada palabra
				if (Archivo[i] != "\n")
				{
					String[] temp = ProcesamientoTexto.renglonAPalabras(Archivo[i], '|');
					Registro contenedor = new Registro ();
					contenedor.noCuenta = Convert.ToInt32(temp[0]);
					contenedor.nombre = temp[1];
					contenedor.direccion = temp[2];
					contenedor.telefono = temp[3];
					contenedor.correo = temp[4];
					//contregistros++;
					res.Add (contenedor);
				}
			}
			return res;
		}
		public static ArrayList LlenarRegistros(DataBase db)
		{
			ArrayList res = new ArrayList ();
			ArrayList temp = db.obtenerTodo ("AlumnosIng");
			for (int i = 0; i < temp.Count; i++) {
				Registro contenedor = new Registro ();
                contenedor.noCuenta = Convert.ToInt32(((String[])(temp[i]))[0]);
				contenedor.nombre = ((String[])(temp[i]))[1];
				contenedor.direccion = ((String[])(temp[i]))[2];
				contenedor.telefono = ((String[])(temp[i]))[3];
				contenedor.correo = ((String[])(temp[i]))[4];
				//contregistros++;
				res.Add (contenedor);
			}



			return res;
		}





		//Convierte el array list en arreglo de registros para buscar si existe el numero de cuenta

		public static int buscar(int noCuenta, ArrayList array)
		{
			Registro[] r =CRUDArchivos.Registro.arrayListToRegistroArray (array);
			int posicion = -1;
			for (int i = 0; i < r.Length; i++)
			{
				if (r[i].noCuenta == noCuenta)
					posicion = i;
			}
			return posicion;
		}
	}
}