using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textic : MonoBehaviour
{
    public Text textGO;
    
    public int HP = 3;
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
    }

    void ShowText()
    {
        textGO.gameObject.SetActive(true);
    }

    void ToggleTextVisibility()
    {
        
        if (!textGO.gameObject.activeSelf)
        {
            ShowText();
        }
        else
        {
            HideText();
        }
    }

    public void GameOver()
    {
        if (HP <= 0)
        {
            ShowText();

        }

    }
    public void TakeDamage(int amount)
    {
        HP -= amount;
    }
}
