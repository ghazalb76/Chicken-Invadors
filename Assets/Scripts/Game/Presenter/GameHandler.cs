using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {
	
	public GameObject EnemyPrefab;
	private GameObject[] enemy ;
	public ScorePresenter scorePresenter = new ScorePresenter();
	public GameObject InfectionPrefab;
	
	void GenerateEnemy(){
		enemy = new GameObject[10];
			for(int i=0;i<10; i++){
				if(i<5){
					enemy[i] = Instantiate(EnemyPrefab, new Vector2(i*2+1, 15), Quaternion.identity) as GameObject ;
					enemy[i].transform.SetParent(GameObject.FindGameObjectWithTag("L1").transform, false);
				}
				else{
					enemy[i] = Instantiate(EnemyPrefab, new Vector2((10-i)*-2+1, 15), Quaternion.identity) as GameObject ;
					enemy[i].transform.SetParent(GameObject.FindGameObjectWithTag("L1").transform, false);
				}
			}
	}

	 public IEnumerator GenerateInfection()
    {
        //because we want to generate it repeatedly
        while (true)
        {
            var randValue = Random.Range(0, 10);
			if(enemy[randValue] != null){
                Instantiate(InfectionPrefab, enemy[randValue].transform);
			}


            //wait for gameConfig.cactusGenerationInterval seconds...
            yield return new WaitForSeconds(5);
        }
    }

	



	// Use this for initialization
	void Start () {
		GenerateEnemy();
		StartCoroutine(GenerateInfection());
	}
	void Update () {
		
	}
	public void DestroyBullet(){

	}
}
