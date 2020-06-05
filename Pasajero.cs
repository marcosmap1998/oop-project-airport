using System;

namespace proyecto_poo_aeropuerto
{
    class Pasajero{
        private string nombre;
        private string pasaporte;
        private string nacionalidad;

        public Pasajero(string nombre, string pasaporte, string nacionalidad){
            this.nombre = nombre;
            this.pasaporte = pasaporte;
            this.nacionalidad = nacionalidad;
        }

        public string GetNombre(){
            return nombre;
        }

        public string GetPasaporte(){
            return pasaporte;
        }

        public string GetNacionalidad(){
            return nacionalidad;
        }

    }
}