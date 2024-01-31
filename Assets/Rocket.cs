using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Rocket : MonoBehaviour
{

    private float speed = 10f;
    public float damage = 1f;
    
    private Textic textic;
    private TankControle1 tankconrole1;
    void Start()
    {
        
        textic = FindObjectOfType<Textic>();
        tankconrole1 = FindObjectOfType<TankControle1>();
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("player2"))
        {
            Destroy(gameObject);
            Debug.Log("Попал");   
            textic.TakeDamage(1);
            tankconrole1.TakeDamage(1);
        }
        
        
    }

   

    private void OnBecameInvisible()
    {
      
        Destroy(gameObject);
    }


}
