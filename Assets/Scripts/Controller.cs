using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
    private static float BaseMovementSpeed = 5;
    private float bonusMovementSpeed;
    private float totalMovementSpeed;
    private Vector3 currentVelocity;
    private bool useWASD;

	void Start()
    { 
        bonusMovementSpeed = 0;
        totalMovementSpeed = BaseMovementSpeed + bonusMovementSpeed;
        useWASD = true;
	}
	
	void Update () {
        if(useWASD)
            WASDMovement();
        else
            RightClickMovement();

        GetComponent<Rigidbody>().velocity = currentVelocity;
	}

    private void WASDMovement()
    {
        currentVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            currentVelocity += new Vector3(0.0f, 0.0f, totalMovementSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentVelocity -= new Vector3(0.0f, 0.0f, totalMovementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            currentVelocity -= new Vector3(totalMovementSpeed, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            currentVelocity += new Vector3(totalMovementSpeed, 0.0f, 0.0f);
        }
    }

    private void RightClickMovement()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Vector3 mousePosition = Input.mousePosition;
            currentVelocity = Vector3.zero;
            currentVelocity = (mousePosition - gameObject.transform.position).normalized * totalMovementSpeed;
        }
    }
}
