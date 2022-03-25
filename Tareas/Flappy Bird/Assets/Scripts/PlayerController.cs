using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float velocidad = 1;
    private Rigidbody2D rb;

    public EscenaController controladorEscena;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up * velocidad;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        controladorEscena.Perdiste();
    }
}
