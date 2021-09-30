/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aventura_marvel;

/**
 *
 * @author Sergiolo
 */
public class Personaje {
    
    String nombre;
    int vida;
    int nivel;
    int singularidad;//sera un numero de veces que se haya duplicado (x20 cada vez que se dupliqie) cuanta mas duplica mas habilidades especiales
    int sinergias;//cuantas mas sinergias mas ataque tendra
    int danio;



    public Personaje() {
        super();
    }  

    public Personaje(String nombre, int vida, int nivel, int singularidad, int sinergias, int danio) {
        this.nombre = nombre;
        this.vida = vida;
        this.nivel = nivel;
        this.singularidad = singularidad;
        this.sinergias = sinergias;
        this.danio = danio;
    }

    
    

}
