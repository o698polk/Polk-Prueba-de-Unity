using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{   
    

    public float Velocidad=4f,Salto=5f,puntos=0f,vida;
    private Rigidbody2D rb;
    private Transform trm;
    public bool InicarPartida=false,Muerto=false,PlayGa=false;
    private bool Run=false,suelo=true,doblesalto;
    private float gravedad;
    private GameManager gamemanager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trm = GetComponent<Transform>();
        gamemanager= Object.FindObjectOfType<GameManager>();
      
    }
     
    // Update is called once per frame
    void Update()
    {
       
       if(Muerto==false){
         if(PlayGa&& Run==false){
             InicarPartida=true;
             Run=true;
         }

        if(Run){
            PlayerCont();
        }
       }
    
    }
     void FixedUpdate(){
      if(Muerto==false){
       
        if(Run){
             Velocidad+=Time.deltaTime*10;
         rb.gravityScale=10;
         rb.velocity= new Vector2(Velocidad*Time.deltaTime,rb.velocity.y);
        }
       }
     }

    public void PlayerCont(){
     
     if(Input.GetButtonDown("Fire1")){
         if(suelo||doblesalto){
        
         rb.velocity= new Vector2(rb.velocity.x,Salto);
         if(doblesalto==false){
           doblesalto=true;
         }else{
           doblesalto=false;
         }
          suelo=false;
          gamemanager.SaltarSonido();
         }

        
     }else if(Input.GetButtonDown("Fire2")){
          
          
          rb.velocity= new Vector2(rb.velocity.x,-Salto);
     }
     
     
    }

 
     void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="puntos"){
             gamemanager.CoinSonido();
            puntos++;
        }
         if(col.tag=="Muerto"){
         Muerto=true; 
         gamemanager.MuertoSonido();
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="suelo"){
           
                  suelo=true; 
                  doblesalto=false;      
        }
       
    }

   

}
