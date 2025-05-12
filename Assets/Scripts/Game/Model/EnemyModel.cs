using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel {

	public float speed = 10;
	public float first_pos;
	public int health = 2;

	public void decreaseHealth(){
		health -=1;
	}

}
