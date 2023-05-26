using UnityEngine;

namespace Stage_A
{
	public class CameraUpDown : MonoBehaviour
	{
		[SerializeField]
		PlayerController playerController;

		private float rotationSpeed;

		[SerializeField]
		private float rotationMin;
		[SerializeField]
		private float rotationMax;

		void Start()
		{
			rotationSpeed = playerController.RotationSpeed;
		}


		void Update()
		{
			float mouseY = Input.GetAxis("Mouse Y");

			if (mouseY < 0f)
			{
				if (transform.rotation.x > rotationMax)
				{
					return;
				}
			}
			else
			{
				if (transform.rotation.x < rotationMin)
				{
					return;
				}
			}


			// 카메라 회전
			transform.Rotate(new Vector3(-mouseY, 0, 0) * rotationSpeed);

		}
	}
}
