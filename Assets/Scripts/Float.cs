using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour 
{

    private float randX;
    private float randY;
    private float randZ;
    public float Height;


    void Start()
    {

        

    }



    void Update()
	{
        // occilate the Y position
      

        transform.position = new Vector3(transform.position.x, (3.5f + Height) + (Mathf.Sin(Time.time * 2)/3), transform.position.z);
       

        /*transform.position = new Vector3(randX,randY,randZ);

        randX = Random.Range(32, 46);
        randY = Random.Range(3, 11);
        randZ = Random.Range(-62, -67);
        */

    }



}
