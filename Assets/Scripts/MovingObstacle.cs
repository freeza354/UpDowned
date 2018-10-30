using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour {

    public static bool turnOver = true;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (turnOver)
        {
            transform.Translate(new Vector2(-3f, -1) * Time.deltaTime);
        }
        else if (turnOver == false)
        {
            transform.Translate(new Vector2(-3f, 1) * Time.deltaTime);
        }

        if (transform.position.x <= -24f)
        {
            Destroy(gameObject);
        }
    }
}
