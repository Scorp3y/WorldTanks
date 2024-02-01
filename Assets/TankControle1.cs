using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankControle1 : MonoBehaviour
{
    public float speed = 5f;
    public float boundaryPadding = 0.5f;
    public int HP = 3;

    [SerializeField] private Transform shootPos;
    [SerializeField] private GameObject rocket;

    private bool canMoveAndShoot = true;

    void Start()
    {
        
    }

    void Update()
    {
        if (canMoveAndShoot)
        {
            MoveTank();

            if (Input.GetKey(KeyCode.Space))
            {
                StartCoroutine(Shoot());
            }
        }
    }

    private IEnumerator Shoot()
    {
        canMoveAndShoot = false;
        Instantiate(rocket, shootPos.position, shootPos.rotation);
        yield return new WaitForSeconds(0.5f);
        canMoveAndShoot = true;
    }

    void MoveTank()
    {
        if (HP > 0)
        {
            float verticalInput = Input.GetAxis("Vertical");
            if (Input.GetKey(KeyCode.W))
            {
                verticalInput = 1f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                verticalInput = -1f;
            }
            else
            {
                verticalInput = 0f;
            }

            Vector3 newPosition = transform.position + new Vector3(0f, verticalInput * speed * Time.deltaTime, 0f);
            float clampedY = Mathf.Clamp(newPosition.y, GetMinYBound(), GetMaxYBound());
            transform.position = new Vector3(transform.position.x, clampedY, transform.position.z);
        }
    }

    float GetMinYBound()
    {
        return Camera.main.ViewportToWorldPoint(Vector3.zero).y + boundaryPadding;
    }

    float GetMaxYBound()
    {
        return Camera.main.ViewportToWorldPoint(Vector3.one).y - boundaryPadding;
    }


    public void TakeDamage(int amount)
    {
        HP -= amount;
    }
}
