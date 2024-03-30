using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaPokemon_juego
{
    public class Pokemon
    {
        //Atributos
        private int numero;
        private string nombre;
        private string tipo1;
        private string tipo2;
        private int vida;
        private int ataque;
        private int defensa;
        private int velAtaque;
        private int velDefensa;
        private int velocidad;
        private string estado;
        private string imagenFrente;
        private string imagenEspalda;
        private string imagen;
        private Ataque[] ataques = new Ataque[4];

        // Método constructor
        public Pokemon(int numero, string nombre, string tipo1, string tipo2, int vida, int ataque, int defensa, int velAtaque, int velDefensa, int velocidad, string estado, string imagenFrente, string imagenEspalda, string imagen, Ataque[] ataques)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.tipo1 = tipo1;
            this.tipo2 = tipo2;
            this.vida = vida;
            this.ataque = ataque;
            this.defensa = defensa;
            this.velAtaque = velAtaque;
            this.velDefensa = velDefensa;
            this.velocidad = velocidad;
            this.estado = estado;
            this.imagenFrente = imagenFrente;
            this.imagenEspalda = imagenEspalda;
            this.imagen = imagen;
            this.ataques = ataques;
        }

        // Métodos Getters y Setters
        public int getNumero()
        {
            return numero;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getTipo1()
        {
            return tipo1;
        }

        public void setTipo1(string tipo1)
        {
            this.tipo1 = tipo1;
        }

        public string getTipo2()
        {
            return tipo2;
        }

        public void setTipo2(string tipo2)
        {
            this.tipo2 = tipo2;
        }

        public int getVida()
        {
            return vida;
        }

        public void setVida(int vida)
        {
            this.vida = vida;
        }

        public int getAtaque()
        {
            return ataque;
        }

        public void setAtaque(int ataque)
        {
            this.ataque = ataque;
        }

        public int getDefensa()
        {
            return defensa;
        }

        public void setDefensa(int defensa)
        {
            this.defensa = defensa;
        }

        public int getVelAtaque()
        {
            return velAtaque;
        }

        public void setVelAtaque(int velAtaque)
        {
            this.velAtaque = velAtaque;
        }

        public int getVelDefensa()
        {
            return velDefensa;
        }

        public void setVelDefensa(int velDefensa)
        {
            this.velDefensa = velDefensa;
        }

        public int getVelocidad()
        {
            return velocidad;
        }

        public void setVelocidad(int velocidad)
        {
            this.velocidad = velocidad;
        }

        public string getEstado()
        {
            return estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public string getImagenFrente()
        {
            return imagenFrente;
        }

        public void setImagenFrente(string imagenFrente)
        {
            this.imagenFrente = imagenFrente;
        }

        public string getImagenEspalda()
        {
            return imagenEspalda;
        }

        public void setImagenEspalda(string imagenEspalda)
        {
            this.imagenEspalda = imagenEspalda;
        }

        public string getImagen()
        {
            return imagen;
        }

        public void setImagen(string imagen)
        {
            this.imagen = imagen;
        }

        public Ataque[] getAtaques()
        {
            return ataques;
        }

        public void setAtaques(Ataque[] ataques)
        {
            this.ataques = ataques;
        }
    }
}