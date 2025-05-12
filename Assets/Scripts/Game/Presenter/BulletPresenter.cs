using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPresenter : MonoBehaviour {

	public Rigidbody2D rb;
	private int score;
	public BulletModel model = new BulletModel(); // new nakon - too manager bokon

	// public void Setup(BulletModel model)
    // {
    //     this.model = model;
    // }

	// Use this for initialization


	public int getScore(){
		return score;
		
	}
	void Start () {
		rb.velocity = transform.up * model.speed;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
 
        if (collision.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);

        }

    }

	// public void Collision()
    // {
    //     model.EnableCollision();
    // }
}
