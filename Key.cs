using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{

    public GameObject poof;
    public GameObject key;
    public Door door;



	void Update()
	{
        // occilate the key's Y position

        transform.position = new Vector3(transform.position.x, 3 + Mathf.Sin(Time.time * 2), transform.position.z);


    }

    public void OnKeyClicked()
	{
        
        // Instatiate the Poof Prefab where this key is located

        Object.Instantiate(poof, new Vector3(3.5f, 0, 52), Quaternion.Euler(-90, 0, 0));

        //unlock the door
        door.Unlock();
        
        // Destroy the keyprefab

        Destroy(key);
        
    }
     
}
