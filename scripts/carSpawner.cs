using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour {

	public GameObject[] cars;
    int carNo;
	public float minpos=-2f;
	public float maxpos=2.2f;
	float timer;
	public float delayTimer= 1f;

	// Use this for initialization
	void Start () {
		
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPos = new Vector3(Random.Range(-2f, 2.2f), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 4);
            Instantiate (cars[carNo],carPos,transform.rotation);
			timer = delayTimer;
		
		}

	}
}
