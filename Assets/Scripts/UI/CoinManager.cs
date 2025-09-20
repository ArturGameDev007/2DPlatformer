using System;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _coin;

    public static Action<int> CoinChanged;
    public void Add()
    {
        _coin++;
        CoinChanged?.Invoke(_coin);
    }
}
