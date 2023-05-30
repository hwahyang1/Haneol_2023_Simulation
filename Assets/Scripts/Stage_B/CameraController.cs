using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Stage_B
{
	public class CameraController : MonoBehaviour
	{
		[Header("Target")]
		[SerializeField]
		private Transform player;

		[Header("Position")]
		[SerializeField]
		private float height;

		[SerializeField]
		private float distance;

		private float distanceFinal;

		private void Start()
		{
			if (player == null)
			{
				GameObject target = GameObject.FindGameObjectWithTag("Player");
				if (target == null)
				{
					Debug.LogError("Cannot find TargetPlayer!!!");
				}
				else
				{
					player = target.GetComponent<Transform>();
				}
			}
		}

		private void Update()
		{
			distanceFinal = distance;
			
			float angle = Mathf.LerpAngle(transform.eulerAngles.y, player.eulerAngles.y, 0.5f);

			Quaternion rotation = Quaternion.Euler(0, angle, 0);
			
			if (Physics.Raycast(player.transform.position, rotation * Vector3.back, out RaycastHit hitData, distance))
			{
				if (hitData.collider.CompareTag("Wall"))
				{
					distanceFinal = hitData.distance - 0.25f;
				}
			}

			transform.position = player.transform.position - (rotation * Vector3.forward * distanceFinal) + (Vector3.up * height);

			transform.LookAt(player);
		}
	}
}
