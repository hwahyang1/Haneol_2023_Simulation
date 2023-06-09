using UnityEngine;

namespace Stage_A
{
	public class PlayerController : MonoBehaviour
	{
		[Header("Config")]
		[SerializeField]
		private float moveSpeed;

		private Rigidbody rb;

		public GameObject head;
		
		private void Start()
		{
			rb = GetComponent<Rigidbody>();
		}

		private void Update()
		{
			float h = Input.GetAxis("Horizontal");
			float v = Input.GetAxis("Vertical");
			float power = moveSpeed * Time.deltaTime;

			Vector3 moveDir = new Vector3(h * power, 0f, v * power);

			rb.MovePosition(rb.position + transform.TransformDirection(moveDir));
		}
	}
}
