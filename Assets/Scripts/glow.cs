using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glow : MonoBehaviour {

    public Material glow1;
    public Material glow2;
    public float duration = 2.0F;
    public Renderer rend;


    // Use this for initialization
    void Start () {

        rend = GetComponent<Renderer>();
        rend.material = glow1;

    }
	
	// Update is called once per frame
	void Update () {


        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.Lerp(glow1, glow2, lerp);




    }
}
