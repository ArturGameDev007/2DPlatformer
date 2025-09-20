using UnityEngine;

public class SawEnemy : MonoBehaviour, IEnemyMovable, IRotatable
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    [SerializeField] private Transform _groundDetection;
    [SerializeField] private bool _movingRight = true;

    [SerializeField] private Vector3 _spinAxis = new Vector3(0f, 0f, 1f);
    [SerializeField] private float _spinSpeed;
    //[SerializeField] private bool useLocalRotation = true;

    private void Update()
    {
        Move();
        Rotate();
    }

    public void Move()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
        RaycastHit2D groundInfo = Physics2D.Raycast(_groundDetection.position, Vector2.down, _distance);

        if (groundInfo.collider == false)
        {
            transform.eulerAngles = _movingRight == true ? new Vector3(0, -180, 0) : new Vector3(0, 0, 0);
            _movingRight = _movingRight == true ? false : true;
        }


    }

    public void Rotate()
    {
        //if (useLocalRotation)
        //    transform.localRotation *= Quaternion.Euler(spinAxis * spinSpeed * Time.deltaTime);
        //else
        //    transform.rotation *= Quaternion.Euler(spinAxis * spinSpeed * Time.deltaTime);

    }
}
