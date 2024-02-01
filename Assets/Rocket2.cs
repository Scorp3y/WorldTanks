using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Rocket2 : MonoBehaviour
{

    private float speed = 10f;
    public float damage = 1f;

    private Textic textic;
    private TankControle1 tankconrole1;
    private TankControle2 tankconrole2;
    private Heartsystem heartsystem;
    void Start()
    {
        textic = FindObjectOfType<Textic>();
        tankconrole1 = FindObjectOfType<TankControle1>();
        tankconrole2 = FindObjectOfType<TankControle2>();
        heartsystem = FindObjectOfType<Heartsystem>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            textic.TakeDamage2(1);
            tankconrole2.TakeDamage(1);
            tankconrole1.TakeDamage(1);
            heartsystem.TakeDamage2(1);
        }
        
        
    }

   

    private void OnBecameInvisible()
    {
      
        Destroy(gameObject);
    }


}
