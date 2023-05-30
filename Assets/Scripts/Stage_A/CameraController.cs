using UnityEngine;

namespace Stage_A
{
	public class CameraController : MonoBehaviour
	{
		[Header("Config")]
		[SerializeField]
		private float rotationMin;
		[SerializeField]
		private float rotationMax;

		[Header("Option")]
		[SerializeField]
		private float mouseSensitivity;

		// init at Start
		private GameObject Player;
		private float rotX;
		private float rotY;

		void Start ()
		{
			Player = GameObject.FindWithTag("Player");
			rotX = transform.eulerAngles.x;
			rotY = transform.eulerAngles.y;
		}

		void Update()
		{
			rotX += Input.GetAxis("Mouse Y") * mouseSensitivity * -1f;
			rotY += Input.GetAxis("Mouse X") * mouseSensitivity;

			// 화면 회전 제한
			rotX = Mathf.Clamp(rotX, rotationMin, rotationMax);

			// 플레이어 좌우 회전
			Player.transform.localEulerAngles = new Vector3(0f, rotY, 0f);

			// 카메라   상하 회전
			transform.localEulerAngles = new Vector3(rotX, 0f, 0f);
		}
	}
}
