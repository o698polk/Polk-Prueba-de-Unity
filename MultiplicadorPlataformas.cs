using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicadorPlataformas : MonoBehaviour
{
    public GameObject[] plataformas;
    private float tiempo;
    private PlayerController Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Player= Object.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.InicarPartida){
            MultiplicarPlataformas();
            Player.InicarPartida=false;
        }
            TiempoCreacion();
       
    }

    public void MultiplicarPlataformas(){
       
				 Instantiate(plataformas[Random.Range(0,plataformas.Length)], transform.position, Quaternion.identity);

			     Invoke("MultiplicarPlataformas",tiempo);
				
    }

    public void TiempoCreacion(){
         if(Player.Velocidad>=1000&&Player.Velocidad<=1600){
        tiempo=5f;
        }
        if(Player.Velocidad>=1601&&Player.Velocidad<=2200){
        tiempo=4.5f;
        }if(Player.Velocidad>=2201&&Player.Velocidad<=2800){
        tiempo=4f;
        }if(Player.Velocidad>=2801&&Player.Velocidad<=3400){
        tiempo=3f;
        }if(Player.Velocidad>=3401&&Player.Velocidad<=4000){
        tiempo=2f;
        }
        if(Player.Velocidad>=4001&&Player.Velocidad<=4600){
        tiempo=1.5f;
        }
        if(Player.Velocidad>=4601&&Player.Velocidad<=5200){
        tiempo=1f;
        }
        if(Player.Velocidad>=5201&&Player.Velocidad<=5800){
        tiempo=0.5f;
        }if(Player.Velocidad>=5801){
        tiempo=0f;
        }
    }
}
