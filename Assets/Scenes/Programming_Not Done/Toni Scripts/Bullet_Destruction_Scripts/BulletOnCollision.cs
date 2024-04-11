using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
        Destroy(collision.gameObject);
        }
    }
}
