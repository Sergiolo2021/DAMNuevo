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
public class Objeto {
    /*  (Orbes)
                    (20% de vida)                   (40% de vida)                       (70% de vida)
    
            Basico -> (Ind.) 5 runas,       Normal -> (Ind.) 10 runas,           Grande -> (Ind.) 20 runas
                      (Grup.) 10 runas                (Grup.) 20 runas                     (Grup.) 40 runas
    
    
        (Resurrectores)
            Basico -> (Ind.) 7 runas,       Normal -> (Ind.) 12 runas,           Grande -> (Ind.) 22 runas
                      (Grup.) 14 runas                (Grup.) 24 runas                     (Grup.) 44 runas
    */
    int precio;
    String tipo;
    boolean basico;
    boolean normal; 
    boolean grande; 
    
    boolean individual;
    boolean grupal;

    public Objeto() {
        
    }

    public Objeto(int precio, boolean grupal, boolean individual) {
        this.precio = precio;
        this.grupal = grupal;
        this.individual = individual;
        
    }

    
    
    
}
