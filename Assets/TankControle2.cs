using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankControle2 : MonoBehaviour
{
    
    public float speed = 5f;
    


    public int h = 3;
    public int n = 3;
    public Image[] he;
    public Sprite fH;
    public Sprite eH;
    void Start()
    {
       
    }

    void Update()
    {
        MoveTank();
        
        
    }

    private void FixedUpdate()
    {
        if (h > n)
        {
            h = n;
        }
        for (int i = 0; i < he.Length; i++)
        {
            if (i < Mathf.RoundToInt(h))
            {
                he[i].sprite = fH;
            }
            else
            {
                he[i].sprite = eH;
            }
            if (i < n)
            {
                he[i].enabled = true;
            }
            else
            {
                he[i].enabled = false;
            }
        }
    }
    void MoveTank()
    {
        float verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            verticalInput = -1f;
        }
        else
        {
            verticalInput = 0f;
        }

        Vector3 newPosition = transform.position + new Vector3(0f, verticalInput * speed * Time.deltaTime, 0f);
        transform.position = newPosition;

    }
    
}
