using System;
using System.Collections.Generic;

namespace proyecto_poo_aeropuerto
{
    class Aeropuerto{
        private string nombre;
        private string ciudad;
        private string pais;
        private int num_compania=0;
        private List<Compania> lista_companias = new List<Compania>();

        public Aeropuerto(string nombre, string ciudad, string pais){
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.pais = pais;
        }

        public Aeropuerto(string nombre, string ciudad, string pais, List<Compania> lista_companias){
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.pais = pais;
            this.lista_companias = lista_companias;
        }

        public string GetNombre(){
            return nombre;
        }

        public string GetCiudad(){
            return ciudad;
        }

        public string GetPais(){
            return pais;
        }

        public void InsertaCompania(Compania compania){
            lista_companias.Add(compania);
            num_compania++;
        }

        public List<Compania> GetListaCompanias(){
            return lista_companias;
        }

        public Compania GetCompania(string compania){
            Compania comp = new Compania("");
            for(int i=0; i<lista_companias.Count; i++){
                if(lista_companias[i].GetNombre().Equals(compania)){
                    comp = lista_companias[i];
                }
            }
            return comp;
        }

        public void EliminarCompania(string nombre){
            for(int i=0; i<lista_companias.Count; i++){
                if(lista_companias[i].GetNombre().Equals(nombre)){
                    lista_companias.Remove(lista_companias[i]);
                    break;
                }
            }
        }

        public void MostrarListaCompanias(){
            for(int i=0; i<lista_companias.Count; i++){
                Console.WriteLine(" "+lista_companias[i].GetNombre());
            }
        }
    }

    class AeropuertoPrivado:Aeropuerto{
        private string[] empresas_patrocinadoras;

        public AeropuertoPrivado(string[] empresas_patrocinadoras, string nombre, string ciudad, string pais):base(nombre, ciudad, pais){
            this.empresas_patrocinadoras = empresas_patrocinadoras;
        }

        public AeropuertoPrivado(string[] empresas_patrocinadoras, string nombre, string ciudad, string pais, List<Compania> lista_companias):base(nombre, ciudad, pais, lista_companias){
            this.empresas_patrocinadoras = empresas_patrocinadoras;
        }

        public void MostrarEmpresasPatrocinadoras(){
            for(int i=0; i<empresas_patrocinadoras.Length; i++){
                Console.WriteLine(empresas_patrocinadoras[i]);
            }
        }

        public string[] GetEmpresasPatrocinadoras(){
            return empresas_patrocinadoras;
        }

    }

    class AeropuertoPublico:Aeropuerto{

        private double fondos;
        public AeropuertoPublico(double fondos, string nombre, string ciudad, string pais):base(nombre, ciudad, pais){
            this.fondos = fondos;
        }

        public AeropuertoPublico(double fondos, string nombre, string ciudad, string pais, List<Compania> companias):base(nombre, ciudad, pais){
            this.fondos = fondos;
        }

        public double GetFondos(){
            return fondos;
        }
    }
}
