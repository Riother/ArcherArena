using UnityEngine;
using System.Collections;

public class Archer : MonoBehaviour {

    private Controller controller;

	


	private bool isDead = false;
	private bool isSlowed = false;
	private bool isStunned = false;

	void Start () {
        controller = gameObject.AddComponent<Controller>();
	}
	
	void Update () {
        //Camera.main.transform.position = transform.position;
	}
}
