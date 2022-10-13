using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Thorn : MonoBehaviour, IDamageDealer
{
    private int _damage = 1;
    public int Damage() => _damage;

}
