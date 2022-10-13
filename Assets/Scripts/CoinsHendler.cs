using System;
using System.Collections.Generic;
using UnityEngine;

public class CoinsHendler : MonoBehaviour
{   
    private List<Coin> _coins;

    public Action<int> CoinsChanched;
    public Action CoinsEnded;

    private void Start()
    {
        var coinsOnScene = GetComponentsInChildren<Coin>();

        if (coinsOnScene.Length == 0)
            return;

        _coins = new List<Coin>(coinsOnScene.Length);

        foreach (Coin coin in coinsOnScene)
        {
            coin.OnCollect += DestroyCoin;
            _coins.Add(coin);
        }
    }

    private void DestroyCoin(Coin coin)
    {
        CoinsChanched?.Invoke(coin.Reward);
        _coins.Remove(coin);
        Destroy(coin.gameObject);

        if (_coins.Count == 0)
            CoinsEnded?.Invoke();
    }


}

