using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

	public float carSpeed;
	public float minpos=-2f;
	public float maxpos=2.2f;
	Vector3 position;
    public uiManager ui;

	// Use this for initialization
	void Start () {
        //ui = GetComponent<uiManager>();
		position = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

		position.x += (Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime);
		position.x=Mathf.Clamp (position.x, -2f, 2.2f);
		transform.position = position;
		}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "enemyCar")
			Destroy(gameObject);
        ui.gameover();
	}
}
