using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;

    [SerializeField] private GameObject bala;

    private void update(){
        if(Input.GetMouseButtonDown(0)){
            //disparar
            Disparar();
            Debug.Log("Si estoy haciendo tus mamadas"); 
        }
    }

    public void Disparar(){
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
