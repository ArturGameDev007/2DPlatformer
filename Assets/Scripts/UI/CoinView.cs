using TMPro;
using UnityEngine;

public class CoinView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        CoinManager.CoinChanged += OnCoinChanged;
    }

    private void OnDisable()
    {
        CoinManager.CoinChanged -= OnCoinChanged;
    }

    private void OnCoinChanged(int value)
    {
        _text.text = value.ToString();
    }

}
