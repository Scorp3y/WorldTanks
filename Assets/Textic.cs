using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Textic : MonoBehaviour
{
    public Text textGO;
    public Text textGO2;

    public int HP = 3;
    public int HP2 = 2;
    void Start()
    {
        
        HideText();
    }

    void Update()
    {
        GameOver();
        
    }

   
    void HideText()
    {
        textGO.gameObject.SetActive(false);
        textGO2.gameObject.SetActive(false);
    }

    void ShowText()
    {
        textGO.gameObject.SetActive(true);
    }

    void ShowText2()
    {
        textGO2.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        if (HP <= 0)
        {
            ShowText();

        }
        if (HP2 <= 0)
        {
            ShowText2();
        }

    }
    public void TakeDamage(int amount)
    {
        HP -= amount;
    }

    public void TakeDamage2(int amount)
    {
        HP2 -= amount;
    }
}
