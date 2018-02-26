using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public string logText = "Kill Me Now :D";
    public float speed = 2;
    public float health = 10;

    // Use this for initialization
    void Start () {
        
        Debug.Log(logText);
        ApplyDamage(1); 
        
    }
	
	// Update is called once per frame    
	void Update () {

        
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        
       rigidbody.velocity = Vector2.right *speed;

    }

    //Damage to mario
    void ApplyDamage (float DamageToDeal)
    {

        health = health - DamageToDeal;
            }

}
