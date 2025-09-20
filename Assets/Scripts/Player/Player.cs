using UnityEngine;

[RequireComponent(typeof(MoveController))]
[RequireComponent(typeof(JumpController))]
public class Player : MonoBehaviour
{
    private IMovable _moveController;
    private IJumper _jumpController;

    private void Start()
    {
        _moveController = GetComponent<MoveController>();
        _jumpController = GetComponent<JumpController>();
    }

    public void Move()
    {
        _moveController.Move();
    }

    public void Jump()
    {
        _jumpController.Jump();
    }
}
