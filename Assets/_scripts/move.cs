using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 5f;
	public float speedRotation = 3f;
	float curspeed;
	private Rigidbody rb;
	public Transform player;
	public GameObject light;
	Light myLight;
	private float timeCount = 0f;

	// Use this for initialization
	void Start () {
		curspeed = speed;
		rb = GetComponent<Rigidbody>();
		myLight = light.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (Input.GetKey(KeyCode.W)) rb.AddForce(transform.right * speed * rb.mass);
		if (Input.GetKey(KeyCode.S)) rb.AddForce(-transform.right * speed * rb.mass);
		if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.forward * speedRotation);
		if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.back * speedRotation);
		if (Input.GetKeyDown(KeyCode.F)) myLight.enabled = !myLight.enabled;
		if (Input.GetKey(KeyCode.Q))
		{
			rb.velocity = Vector3.Lerp(rb.velocity, new Vector3(0, 0, 0), Time.deltaTime * speedRotation);
			transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, transform.rotation.z), Time.deltaTime * speedRotation);
		}
	}
}
