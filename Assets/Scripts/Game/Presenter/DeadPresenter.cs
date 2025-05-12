using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPresenter : MonoBehaviour {
	public Rigidbody2D rb;
	public GameObject DeadPrefab;
	private DeadModel model = new DeadModel();

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = -transform.up * model.speed;
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Ship"){
			Destroy(DeadPrefab);	
		}
    }
}
