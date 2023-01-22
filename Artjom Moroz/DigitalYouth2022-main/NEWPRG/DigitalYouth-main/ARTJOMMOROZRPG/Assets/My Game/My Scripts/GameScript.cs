using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public EnemySpawner enemyspawner;
	public int enemiesToSpawn;
	public int waveCount;
	public int wavetoWin;

	// Use this for initialization
	protected void Start () {
		for (int i = 0; i < 10; i++)
		{
			enemyspawner.Spawn();
		}

	}

	// Update is called once per frame
	protected void Update () {

		if (enemyspawner.transform.childCount == 0 && EnemySpawner.activated &&!IsInvoking())
		{ 
		 if (waveCount > wavetoWin)

            {
				enemyspawner.gameObject.SetActive(false);
            }
			waveCount++;
			HUD.Message("Wave number " + waveCount);
			enemiesToSpawn = Random.Range(waveCount * 3, waveCount * 2);

		}
		
	}
	
}