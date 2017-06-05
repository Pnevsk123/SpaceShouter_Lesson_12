using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMovement : MonoBehaviour {

    public float speed = 500f;
  
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed, ForceMode2D.Force);
        Destroy(gameObject, 3.0f);  
    }

    private void Update()
    {
       
    }

    // Update is called once per frame

}
