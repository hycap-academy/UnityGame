using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed=20;
    public float firePause = 0.5f;
    private float lastFire;


    // Start is called before the first frame update
    void Start()
    {
        lastFire=Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")){
            if (Time.time - lastFire >  firePause){
             Rigidbody proj=Instantiate(projectile, transform.position + new Vector3(0,1,0)+transform.forward*1.5f+transform.right*0.25f, transform.rotation) as Rigidbody;
             proj.velocity = transform.TransformDirection(new Vector3(0,0, speed));
             lastFire = Time.time;
		        }		
	      }
    }
}
