using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public GameObject Enemy;

    private bool isSpawning = true;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {

            Debug.Log("This code is running");

            if (MovingObstacle.turnOver)
            {
                MovingObstacle.turnOver = false;
            }
            else
            {
                MovingObstacle.turnOver = true;
            }
        }

        if (isSpawning)
        {
            isSpawning = false;
            StartCoroutine(spawnEnemy());            
        }

    }

    IEnumerator spawnEnemy()
    {
        yield return new WaitForSeconds(5f);
        isSpawning = true;
        Instantiate(Enemy);
    }

}
