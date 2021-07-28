using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro.Entidades
{
    class ClsCarro
    {
        private String color  ; 
        private String marca;
        private String modelo;
        private int peso ;
        private int capacidad;

        public string Color { get => color; set => color = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
    }
}
