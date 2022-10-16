using System;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D), typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private int _hp = 1;
    public Action OnDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out ICollectable item))
        {
            item.Collect();
        }
        if(collision.gameObject.TryGetComponent(out IDamageDealer dealer))
        {
            _hp -= dealer.Damage();

            if (_hp <= 0)
                Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
        OnDeath?.Invoke();
    }
}
