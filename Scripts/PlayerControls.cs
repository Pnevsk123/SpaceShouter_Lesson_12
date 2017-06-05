using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    public float Speed;
    private Rigidbody2D _rb;
    public Borders _borders;
    public GameObject Shot;
    public Transform SpaunShotPoint;
    public float FireRate;
    private float NextFire;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>NextFire)
        {
            NextFire = Time.time + FireRate;
            Instantiate(Shot,new Vector3(SpaunShotPoint.position.x, SpaunShotPoint.position.y,0),Quaternion.Euler(0,0,0));




        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveHorizontal, moveVertical, 0f);
        transform.position += direction * Speed*Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,_borders.minx,_borders.maxx),
           Mathf.Clamp(transform.position.y, _borders.miny, _borders.maxy),
            transform.position.z);
    }

}



[System.Serializable]
public class Borders {

    public float miny, maxy, minx, maxx;
    
}