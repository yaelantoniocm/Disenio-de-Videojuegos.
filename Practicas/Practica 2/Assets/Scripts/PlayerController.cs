using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    bool canJump;
    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
     void Update(){
        if (Input.GetKey(KeyCode.D)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(400f* Time.deltaTime, 0 ));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.A)){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400f* Time.deltaTime, 0 ));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)){
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if (Input.GetKeyDown(KeyCode.W) && canJump){
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100f));
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.tag == "suelo") {
            canJump = true;
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
        }
    }
        

}
