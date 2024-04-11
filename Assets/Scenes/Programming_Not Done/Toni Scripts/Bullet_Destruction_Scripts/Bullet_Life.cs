using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Life : MonoBehaviour
{
    private GameObject Enemy;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}

