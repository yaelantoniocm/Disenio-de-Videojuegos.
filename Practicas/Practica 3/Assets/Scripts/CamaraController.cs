using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour{   
    public Transform personaje;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        CalcularPosicionCamara();
    }

    void CalcularPosicionCamara(){
        transform.position = new Vector3(personaje.position.x, personaje.position.y + 6, -10);

    }
}
