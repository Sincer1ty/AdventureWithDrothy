using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayItem : MonoBehaviour
{
	//public enum Type { }//������
	//public int hay=1;//��¤

	//[SerializeField] float speed = 7f;
	float moveX, moveY;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}


	void Update()
	{
		moveX = Input.GetAxis("Horizontal");
		moveY = Input.GetAxis("Vertical");
		//rb.velocity = new Vector2(moveX * speed, moveY * speed);
	}


}
