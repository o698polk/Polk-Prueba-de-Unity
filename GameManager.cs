using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public   GameObject[] panel;
    public   GameObject PlayBt;
    public Text TextPunto,PassRecorText,NewRecoorText,ActualRecoorText,PuntuciaonActual;
    public float  puntos;
    private PlayerController Player;
    
    public  AudioClip salto,coin,muerto;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        PanelClose(100);
        Player= Object.FindObjectOfType<PlayerController>();
        audio= GetComponent<AudioSource>();
        PlayBt.SetActive(true);
        if (PlayerPrefs.HasKey("Puntos"))
        {
            puntos = PlayerPrefs.GetFloat("Puntos");
        }else{
            PlayerPrefs.SetFloat("Puntos",0);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
         TextPunto.text=  Player.puntos.ToString("0");
        
       if(Player.Muerto){
       if(Player.puntos>puntos){
         PanelClose(1);
         NewRecoorText.text= Player.puntos.ToString("0");
         PassRecorText.text=puntos.ToString("0"); 
         PlayerPrefs.SetFloat("Puntos",Player.puntos);
       }else{

         PanelClose(0);
         PuntuciaonActual.text= Player.puntos.ToString("0");
         ActualRecoorText.text=puntos.ToString("0"); 
       }
         
         
       }
    }
    public void PanelClose(int x){

        if(x==100){
            for(int i=0;i<panel.Length;i++){
           panel[i].SetActive(false);
            }
        }else{
        for(int i=0;i<panel.Length;i++){
            if(i==x){
            panel[i].SetActive(true);
            }else{
            panel[i].SetActive(false);
            }
         
            }
        }

    }
    public void Recargar(){
      SceneManager.LoadScene("Main");
    }
     public void PlayGame(){
      Player.PlayGa=true;
      PlayBt.SetActive(false);
    }
    public void SaltarSonido(){
         audio.clip = salto;
          audio.Play();
    }
    public void  CoinSonido(){
         audio.clip = coin;
          audio.Play();
    }
    public void  MuertoSonido(){
         audio.clip = muerto;
          audio.Play();
    }
}
