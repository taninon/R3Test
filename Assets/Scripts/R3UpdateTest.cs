using R3;
using R3.Triggers;
using UnityEngine;
using UnityEngine.InputSystem;

public class R3UpdateTest : MonoBehaviour
{
	[SerializeField] private float speed;
	[SerializeField] private float jumpPower;
	[SerializeField] private Rigidbody _rigidbody;

	Vector2 moveValue;
	public void OnMove(InputValue value)
	{
		moveValue = value.Get<Vector2>();
	}

	void Start()
	{
		this.UpdateAsObservable()
			.Where(_ => moveValue.sqrMagnitude > 0.1)
			.Subscribe(_ => Move(new Vector3(moveValue.x, 0, moveValue.y)))
			.AddTo(this);
	}

	private void Move(Vector3 direction)
	{
		_rigidbody.linearVelocity = direction * Time.deltaTime * speed;
	}
}
