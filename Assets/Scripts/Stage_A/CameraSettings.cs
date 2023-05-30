using UnityEngine;

namespace Stage_A
{
	public class CameraSettings : MonoBehaviour
	{
		void Start()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}
	}
}
