using UnityEngine;
using System.Collections;

public class Gumba : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collison!");
}
