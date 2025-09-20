using UnityEngine;

public class MoveController : MonoBehaviour, IMovable
{
    private readonly string _horizontal = "Horizontal";
    private readonly int Run = Animator.StringToHash(nameof(Run));


    [SerializeField] private Animator _animator;
    [SerializeField, Range(0, 10f)] private float _speed;

    private Rigidbody2D _rigidbody2D;

    private float _horizontalInput;
    private bool _isFacingRight = true;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (_horizontalInput > 0 && !_isFacingRight)
            Flip();

        if (_horizontalInput < 0 && _isFacingRight)
            Flip();

        Move();
    }

    public void Move()
    {
        _horizontalInput = Input.GetAxis(_horizontal);

        Vector2 move = new Vector2(_horizontalInput * _speed, _rigidbody2D.velocity.y);
        _rigidbody2D.velocity = move;
        _animator.SetFloat(Run, Mathf.Abs(_horizontalInput));
    }

    private void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;

        _isFacingRight = !_isFacingRight;
    }
}
