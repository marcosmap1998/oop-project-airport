using System;
using System.Collections.Generic;

namespace proyecto_poo_aeropuerto
{
    class Vuelo{

        private string id_vuelo;
        private string ciudad_origen;
        private string ciudad_destino;
        private double precio;
        private int num_max_pasajeros;
        private int num_pasajeros;
        private Pasajero[] lista_pasajeros;

        public Vuelo(string id_vuelo, string ciudad_origen, string ciudad_destino, double precio, int num_max_pasajeros){
            this.id_vuelo = id_vuelo;
            this.ciudad_origen = ciudad_origen;
            this.ciudad_destino = ciudad_destino;
            this.precio = precio;
            this.num_max_pasajeros = num_max_pasajeros;
        }

        public string GetIdVuelo(){
            return id_vuelo;
        }

        public string GetCdOrigen(){
            return ciudad_origen;
        }

        public string GetCdDestino(){
            return ciudad_destino;
        }

        public double GetPrecio(){
            return precio;
        }

        public int GetMaxPasajeros(){
            return num_max_pasajeros;
        }

    }
}