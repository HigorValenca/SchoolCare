using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    [Header("CharConfig")]
    public float speed;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        //atribuindo  direção para movimento

        if (y == 1){
            transform.position += new Vector3(0,speed,0);//w
            anim.SetInteger("dir",2); //animação para cima
            
        }
        else if(x == 1) {
            transform.position += new Vector3(speed,0,0);//d
            anim.SetInteger("dir",1);//animção para direita
            
        }
        else if(y == -1) {
            transform.position += new Vector3(0,-speed,0);//s
            anim.SetInteger("dir",0);//animação para baixo
            
        }
        else if(x == -1){ 
            transform.position += new Vector3(-speed,0,0);//a
            anim.SetInteger("dir",3);//animação para esquerda
            
        }

        
    }
}
