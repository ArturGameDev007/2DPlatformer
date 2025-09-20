using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out CoinManager player))
        {
            player.Add();
            Disable();
        }
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
