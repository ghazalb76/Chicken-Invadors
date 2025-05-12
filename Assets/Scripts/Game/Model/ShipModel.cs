using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipModel {
	
	[System.Serializable]
    public class ShipData
    {
        public int health = 3;
		public bool red_power = false;
		public int score = 0;
        
    }
    public int speed = 10;
    ShipData data = new ShipData();
    public void decreaseHealth(){
        data.health --;
        Debug.Log(data.health);
    }

}
