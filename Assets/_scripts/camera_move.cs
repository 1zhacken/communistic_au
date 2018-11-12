using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour {
public Transform target;
public float smooth= 5.0f;
public Vector3 offset = new Vector3(0, 0, -5);

void Start()
	{
		transform.position = target.position + offset;
	}
void  Update (){
    transform.position = Vector3.Lerp (transform.position, target.position + offset, Time.deltaTime * smooth);
} 
}
