using System;
using System.Collections.Generic;

namespace proyecto_poo_aeropuerto
{
    class Compania{

        private string nombre;
        private List<Vuelo> lista_vuelos = new List<Vuelo>();

        public Compania(string nombre){
            this.nombre = nombre;
        }

        public string GetNombre(){
            return nombre;
        }

        public List<Vuelo> GetListaVuelos(){
            return lista_vuelos;
        }

        public void InsertarVuelo(Vuelo vuelo){
            lista_vuelos.Add(vuelo);
        }

        public void MostrarVuelos(){
            for(int i=0; i<lista_vuelos.Count; i++){
                Console.WriteLine("\n ID vuelo: "+lista_vuelos[i].GetIdVuelo());
                Console.WriteLine(" Ciudad origen: "+lista_vuelos[i].GetCdOrigen());
                Console.WriteLine(" Ciudad destino: "+lista_vuelos[i].GetCdDestino());
                Console.WriteLine(" Precio: $"+lista_vuelos[i].GetPrecio());
            }
        }

        public void BuscarVuelo(string cd_origen, string cd_destino){
            for(int i=0; i<lista_vuelos.Count; i++){
                if(lista_vuelos[i].GetCdOrigen().Equals(cd_origen) && lista_vuelos[i].GetCdDestino().Equals(cd_destino)){
                    Console.WriteLine("\n ID vuelo: "+lista_vuelos[i].GetIdVuelo());
                    Console.WriteLine(" Precio: "+lista_vuelos[i].GetPrecio());
                }
            }
        }

    }
}
