using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet_Life : MonoBehaviour
{
    private GameObject Obstacle;
    private Rigidbody rb;
    public float damage = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Obstacle = GameObject.FindGameObjectWithTag("Obstacle");
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //   var health = collision.collider.GetComponent<Health>();
    //    if (health != null);
    //}

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<EnemyScript>().health -= damage;
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
        
    }
}

