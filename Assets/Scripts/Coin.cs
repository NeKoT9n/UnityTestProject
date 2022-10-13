using System;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour, ICollectable
{
    public int Reward { get; private set; } = 1;

    public Action<Coin> OnCollect;

    public void Collect()
    {
        OnCollect?.Invoke(this);
    }
}
