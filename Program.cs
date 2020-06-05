using System;
using System.Collections.Generic;

namespace proyecto_poo_aeropuerto
{
    class Program
    {
        static Aeropuerto[] aeropuertos = new Aeropuerto[3];

        static void Main(string[] args)
        {

            // cargamos los aeropuertos definidos al sistema
            InsertarAeropuertos(aeropuertos);
            // menu de opciones del sistema
            Menu();

        }

        static void InsertarAeropuertos(Aeropuerto[] aero){
            aero[0] = new AeropuertoPublico(50000000,"Benito Juárez", "Ciudad de México", "México");
            aero[0].InsertaCompania(new Compania("AeroMexico"));
            aero[0].InsertaCompania(new Compania("Interjet"));
            aero[0].InsertaCompania(new Compania("Volaris"));
            aero[0].InsertaCompania(new Compania("VivaAerobus"));
            aero[0].GetCompania("AeroMexico").InsertarVuelo(new Vuelo("AM100","Ciudad de México","Auckland",389.99,150));
            aero[0].GetCompania("AeroMexico").InsertarVuelo(new Vuelo("AM101","Ciudad de México","Calgary",250.50,200));
            aero[0].GetCompania("Interjet").InsertarVuelo(new Vuelo("IJ500","Ciudad de México","Nueva York",400,100));
            aero[0].GetCompania("Volaris").InsertarVuelo(new Vuelo("VL300","Ciudad de México","Florencia",650.90,180));
            aero[0].GetCompania("VivaAerobus").InsertarVuelo(new Vuelo("VA200","Ciudad de México","Tokio",800.0, 250));

            aero[1] = new AeropuertoPublico(10080050.50, "Aeropuerto internacional de Monterrey","Monterrey", "México");
            aero[1].InsertaCompania(new Compania("AeroMexico"));
            aero[1].InsertaCompania(new Compania("Interjet"));
            aero[1].InsertaCompania(new Compania("Volaris"));
            aero[0].GetCompania("AeroMexico").InsertarVuelo(new Vuelo("AM150","Monterrey","Auckland",340.90,100));
            aero[0].GetCompania("AeroMexico").InsertarVuelo(new Vuelo("AM151","Monterrey","Calgary",250.50,200));
            aero[0].GetCompania("Interjet").InsertarVuelo(new Vuelo("IJ005","Monterrey","Los Angeles",250.90,120));
            aero[0].GetCompania("Volaris").InsertarVuelo(new Vuelo("VL050","Monterrey","Bruselas",700.90,150));

            string[] empresas = new string[5];
            empresas[0] = "Teléfonos Mexicanos";
            empresas[1] = "ASD";
            empresas[2] = "Fundación ABC";
            empresas[3] = "Seguros AEP";
            empresas[4] = "Viajes Internacionales SA de CV";

            aero[2] = new AeropuertoPrivado(empresas,"Aeropuerto MX", "Ciudad de México", "México");
            aero[2].InsertaCompania(new Compania("LATAM Airlines"));
            aero[2].InsertaCompania(new Compania("American Airlines"));
            aero[2].InsertaCompania(new Compania("Avianca"));
            aero[2].InsertaCompania(new Compania("AeroMexico"));
            aero[2].InsertaCompania(new Compania("Copa Airlines"));
            aero[2].GetCompania("LATAM Airlines").InsertarVuelo(new Vuelo("LTA1001", "Ciudad de México","Escocia",650.90,120));
            aero[2].GetCompania("American Airlines").InsertarVuelo(new Vuelo("AA2000","Ciudad de México", "Los Angeles", 200.50,100));
            aero[2].GetCompania("Avianca").InsertarVuelo(new Vuelo("AV8001","Ciudad de México","Auckland",800,150));
            aero[2].GetCompania("AeroMexico").InsertarVuelo(new Vuelo("AM9002","Ciudad de México","Tokio",900.80,150));
            aero[2].GetCompania("Copa Airlines").InsertarVuelo(new Vuelo("CA3000","Florencia","Ciudad de México",600,120));
        }
    
        static void Menu(){
            
            Boolean ejecutar = true;
            string opcion;

            while(ejecutar){
                Console.WriteLine(" BuscaVuelos México");
                Console.WriteLine("\n 1. Consultar aeropuertos registrados\n 2. Consultar empresas patrocinadoras y fondos asignados\n 3. Consultar las aerolineas de un aeropuerto\n 4. Mostrar los vuelos de una aerolínea\n 5. Buscar vuelos\n 6. Salir\n");
                Console.Write(" Esocge una opción: ");
                opcion = Console.ReadLine();
                Console.WriteLine("");

                if(opcion.Equals("1")){
                    ConsultarAeropuertos(aeropuertos);
                }
                else if(opcion.Equals("2")){
                    ConsultarEmpresasYFondos(aeropuertos);
                }
                else if(opcion.Equals("3")){
                    MostrarListaComp(aeropuertos);
                }
                else if(opcion.Equals("4")){
                    MostrarVuelos(aeropuertos);
                }
                else if(opcion.Equals("5")){
                    BuscarVuelos(aeropuertos);
                }
                else if(opcion.Equals("6")){
                    Console.WriteLine(" Gracias por su preferencia... vuelva pronto.");
                    ejecutar = false;
                }

            }

        }

        static void ConsultarAeropuertos(Aeropuerto[] aeros){
            AeropuertoPublico publico = new AeropuertoPublico(0,"","","");
            for(int i=0; i<aeros.Length; i++){
                if(aeros[i].GetType().IsAssignableFrom(publico.GetType())){
                    Console.WriteLine(" Aeropuerto público");
                    Console.WriteLine(" Nombre: "+ aeros[i].GetNombre());
                    Console.WriteLine(" Ciudad: "+ aeros[i].GetCiudad());
                    Console.WriteLine(" País: "+ aeros[i].GetPais()+"\n");
                }
                else{
                    Console.WriteLine(" Aeropuerto privado");
                    Console.WriteLine(" Nombre: "+ aeros[i].GetNombre());
                    Console.WriteLine(" Ciudad: "+ aeros[i].GetCiudad());
                    Console.WriteLine(" País: "+ aeros[i].GetPais()+"\n");
                }
            }
        }

        static void ConsultarEmpresasYFondos(Aeropuerto[] aeros){
            int j=0;
            int k=0;
            AeropuertoPublico[] aero_pub = new AeropuertoPublico[2];
            AeropuertoPrivado[] aero_priv = new AeropuertoPrivado[1];
            AeropuertoPublico publico = new AeropuertoPublico(0,"","","");
            for(int i=0; i<aeros.Length; i++){
                if(aeros[i].GetType().IsAssignableFrom(publico.GetType())){
                    aero_pub.SetValue(aeros[i],j);
                    j++;
                }
                else{
                    aero_priv.SetValue(aeros[i],k);
                    k++;
                }
            }

            for(int i=0; i<aero_pub.Length; i++){
                Console.WriteLine("\n Aeropuerto público");
                Console.WriteLine(" Nombre: "+aero_pub[i].GetNombre());
                Console.WriteLine(" Fondos: "+aero_pub[i].GetFondos());
            }

            for(int i=0; i<aero_priv.Length; i++){
                Console.WriteLine("\n Aeropuerto público");
                Console.WriteLine(" Nombre: "+aero_priv[i].GetNombre());
                Console.WriteLine(" Empresas patocinadoras:\n");
                aero_priv[i].MostrarEmpresasPatrocinadoras();
            }
            Console.WriteLine("\n");
        }
    
        static void MostrarListaComp(Aeropuerto[] aeros){
            Console.Write(" Ingresa el nombre del aeropuerto: ");
            string nombre = Console.ReadLine();

            for(int i=0; i<aeros.Length; i++){
                if(aeros[i].GetNombre().Equals(nombre)){
                    aeros[i].MostrarListaCompanias();
                }
            }
            Console.WriteLine("\n");
        }
        
        static void MostrarVuelos(Aeropuerto[] aeros){
            for(int i=0; i<aeros.Length; i++){
                Console.WriteLine(" "+(i+1)+". "+aeros[i].GetNombre());
            }
            Console.Write("\n Ingresa el aeropuerto: ");
            string aero = Console.ReadLine();
            Console.WriteLine("");

            for(int i=0; i<aeros.Length; i++){
                if(aeros[i].GetNombre().Equals(aero)){
                    aeros[i].MostrarListaCompanias();
                }
            }
            Console.Write("\n Ingresa la aerolínea: ");
            string aerolinea = Console.ReadLine();
            Console.WriteLine("");

            for(int i=0; i<aeros.Length; i++){
                aeros[i].GetCompania(aerolinea).MostrarVuelos();    
            }
            Console.WriteLine("\n");
        }

        static void BuscarVuelos(Aeropuerto[] aeros){
            List<Compania> lista = new List<Compania>();
            Console.Write(" Ingresa la ciudad origen: ");
            string origen = Console.ReadLine();
            Console.Write(" Ingresa la ciudad destino: ");
            string destino = Console.ReadLine();

            for(int i=0; i<aeros.Length; i++){
                lista = aeros[i].GetListaCompanias();
                for(int j=0; j<lista.Count; j++){
                    aeros[i].GetCompania(lista[j].GetNombre()).BuscarVuelo(origen, destino);
                }
            }
            Console.WriteLine("");
        }

    }
}
