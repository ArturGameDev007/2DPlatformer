using UnityEngine;

public class JumpController : MonoBehaviour, IJumper
{
    [SerializeField] private Animator _animator;

    [Header("Пыржок")]
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _jumpHoldMultiplier = 3f;
    [SerializeField] private float _jumpHoldTimeMax = 0.3f;

    [Header("Проверка на земле")]
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _groundCheckRadius = 0.2f;

    private Rigidbody2D _body;

    private bool _isJumping;
    private bool _isGrounded;

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Jump();
    }

    public void Jump()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _groundCheckRadius, _groundLayer);

        if (Input.GetKey(KeyCode.Space) && _isGrounded)
        {
            _isJumping = true;
            _body.velocity = new Vector2(_body.velocity.x, _jumpForce);
        }
        else
        {
            _isJumping = false;
        }

        if (_isGrounded == false)
            _animator.SetBool("Jump", true);
        else
            _animator.SetBool("Jump", false);
    }
}


