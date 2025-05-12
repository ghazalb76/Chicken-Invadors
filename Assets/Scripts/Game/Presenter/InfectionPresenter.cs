using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionPresenter : MonoBehaviour {
	public InfectionModel model = new InfectionModel();
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = -transform.up * model.speed;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
