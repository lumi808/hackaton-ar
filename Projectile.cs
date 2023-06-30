using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 _direction;

    public void Setup(Vector3 direction)
    {
        GetComponent<Rigidbody>().velocity = direction;
    }

}