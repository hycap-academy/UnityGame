using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletexpire : MonoBehaviour
{
    private float startTime ;
    public float expireTime=2;
    // Start is called before the first frame update
    void Start()
    {
        startTime=Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > expireTime){
		      Destroy(gameObject);
	      }
    }
}
