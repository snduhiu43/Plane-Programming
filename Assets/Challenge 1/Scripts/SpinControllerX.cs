using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinControllerX : MonoBehaviour
{
    // Make the propeller spin per frame
	private float propellorSpeed = 1000;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
