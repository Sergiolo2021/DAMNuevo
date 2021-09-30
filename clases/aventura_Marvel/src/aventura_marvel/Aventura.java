package aventura_Marvel;

import java.util.Scanner;

public class Aventura {
/*
        Se debe crear una clase personaje que describa qué atributos tienen los personajes.

        Se debe crear una clase de pruebas que describa cómo son los obstáculos que se
        deben superar.


        Se debe crear una clase de aventura en el que se desarrollen los acontecimientos y
        los personajes tengan que interactuar y superar las pruebas.

        */
    
    
    public void IniciarAventura() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Avanza con tus personajes mas fuertes hasta derrotar al jefe!!!");
        
        
        
        do {            
            System.out.println("En primer lugar, abre los 5 cristales que se te ofrecen para avanzar en la historia. (1 para abrir)");
            int abrir=Integer.parseInt(sc.nextLine());
            
            if(abrir==1){
                AbrirCristales();
            }else{
                System.out.println("Para avanzar en la historia, es necesario abrir los cristales.");
            }
        } while (true);
        
        
        
    }

    private void AbrirCristales() {
        //necesito tener 10 personajes creados y de esos 10 5 seran para el jugador y 5 para el camino
        
    }
    
    
}
