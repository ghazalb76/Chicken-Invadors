using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPresenter : MonoBehaviour {
	public Rigidbody2D PlayerRigid;
	public Transform firePoint;
	public GameObject bulletPrefab;
	// public GameObject RedPowerPrefab;
	// public GameObject MenuCanvas;
	// public GameObject GameCanvas;
	// private AudioSource shoot_audio;
	// Use this for initialization
	public PlayerCollisionDetector collisionDetector ;

	void Awake(){
		collisionDetector.Setup(collisionDetected);
	}
	public ShipModel model = new ShipModel();
	void Start () {
		PlayerRigid = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

		PlayerRigid.velocity = new Vector3(Input.GetAxis("Horizontal")*model.speed, 0, 0);
		firePoint.position = PlayerRigid.position;
		if(Input.GetKeyUp(KeyCode.Space)){
			shoot();
		}

	}


	void shoot(){
		GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation) ;
		bullet.transform.SetParent(GameObject.FindGameObjectWithTag("L1").transform, false);
	}
	void collisionDetected(){
		model.decreaseHealth();
	}
}
