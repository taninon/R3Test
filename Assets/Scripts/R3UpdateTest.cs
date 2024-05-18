using R3;
using R3.Triggers;
using UnityEngine;

public class R3UpdateTest : MonoBehaviour
{
	[SerializeField] private float speed;
	[SerializeField] private float jumpPower;
	[SerializeField] private Rigidbody _rigidbody;

	void Start()
	{
		this.UpdateAsObservable()
			.Subscribe(_ => Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))));

		this.UpdateAsObservable()
			.Where(_ => Input.GetKeyDown(KeyCode.Space))
			.Subscribe(_ => Jump());
	}

	private void Move(Vector3 direction)
	{
		_rigidbody.velocity = direction * Time.deltaTime * speed;
	}

	private void Jump()
	{
		_rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
	}

}
