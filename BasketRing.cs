using System;
using UnityEngine;

public class BasketRing : MonoBehaviour
{
    public event Action ProjectileInsideRing;

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (!projectile)
            return;

        Rigidbody rb = other.GetComponent<Rigidbody>();
        if(rb.velocity.y < 0)
        {
            Debug.Log("Error");
            ProjectileInsideRing?.Invoke();
        }
    }
}
