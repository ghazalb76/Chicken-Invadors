using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPresenter : MonoBehaviour {
	public Rigidbody2D rb;
	// public GameObject EnemyPrefab;
	// public GameObject DeadPrefab;
	private GameObject dead_body;
	// public GameObject BulletPrefab;
	// private AudioSource collision_audio;
	public EnemyModel model = new EnemyModel(); // new nakon - too manager bokon
	public CollisionDetector collisionDetector ;
	public GameObject DeadPrefab;
	public ParticleSystem destroyParticle;


	void Awake(){
		collisionDetector.Setup(normalCollisionDetected);
	}


	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = -transform.up * model.speed;
		model.first_pos = rb.transform.localPosition.y;
	}
	

	void Update () {
		if(rb != null){
			if(model.first_pos - rb.transform.localPosition.y > 3){
				rb.velocity = new Vector2 (0,0);
			}
		}
	}


	public void normalCollisionDetected(){
		model.decreaseHealth();
		if (model.health == 0){
			Destroy(gameObject);
			Instantiate(destroyParticle, rb.transform.position, Quaternion.identity);
			generateDeadBody();
		}
	}
	public void generateDeadBody(){
		GameObject dead_body = Instantiate(DeadPrefab, rb.transform.position, Quaternion.identity) as GameObject ;
		//dead_body.transform.SetParent(GameObject.FindGameObjectWithTag("Dead").transform, false);
	}
}
