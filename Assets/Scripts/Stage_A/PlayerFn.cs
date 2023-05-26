using UnityEngine;

namespace Stage_A
{
	public class PlayerFn : MonoBehaviour
	{
		[SerializeField]
		[Header("Config")]
		private Vector3 initalPoint;

		[SerializeField]
		private Quaternion initalRotation;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
				transform.position = initalPoint;
				transform.rotation = initalRotation;
			}
		}
	}
}
