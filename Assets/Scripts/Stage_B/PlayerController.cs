using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Stage_B
{
	public class PlayerController : MonoBehaviour
	{
		[Header("Config")]
		[SerializeField]
		private float moveSpeed;
		[SerializeField]
		private float rotationSpeed;

		private Rigidbody rb;
		
		private void Start()
		{
			rb = GetComponent<Rigidbody>();
		}

		private void Update()
		{
			float h = Input.GetAxis("Horizontal");
			float v = Input.GetAxis("Vertical");
			float mouseX = Input.GetAxisRaw("Mouse X");
			
			Vector3 moveDir = new Vector3(h * moveSpeed * Time.deltaTime, 0f, v * moveSpeed * Time.deltaTime);

			rb.MovePosition(rb.position + transform.TransformDirection(moveDir));
			rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, mouseX * rotationSpeed, 0f));
		}
	}
}
