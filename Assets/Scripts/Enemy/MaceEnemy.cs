using UnityEngine;

public class MaceEnemy : MonoBehaviour, IEnemyMovable
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    [SerializeField] private Transform _groundDetection;
    [SerializeField] private bool _movingLeft = true;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        RaycastHit2D groundInfo = Physics2D.Raycast(_groundDetection.position, Vector2.down, _distance);

        if (groundInfo.collider == false)
        {
            transform.eulerAngles = _movingLeft == true ? new Vector3(0, -180, 0) : new Vector3(0, 0, 0);
            _movingLeft = _movingLeft == true ? false : true;
        }

        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
