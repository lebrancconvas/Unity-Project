using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Rigidbody rd;
    public float speed;
    public float attack;
	// Use this for initialization
	void Start () {
        rd = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);
        rd.AddForce(movement*speed*attack);
	}
}
