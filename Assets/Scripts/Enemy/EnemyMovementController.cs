using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    private IEnemyMovable _sawEnemy;
    private IEnemyMovable _maceEnemy;

    public void MoveEnemies()
    {
        _sawEnemy.Move();
        _maceEnemy.Move();
    }
}
