using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heartsystem : MonoBehaviour
{
    
    
    public int HP = 3;
    public int NumHP = 3;
    public Image[] health;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    
    void Update()
    {
        if (HP > NumHP)
        {
            HP = NumHP;
        }
        for (int i = 0; i < health.Length; i++)
        {
            
            if (i < HP)
            {
                
                health[i].sprite = fullHeart;
            }
            else
            {
                
                health[i].sprite = emptyHeart;
            }
        }
    }

    public void TakeDamage(int amount)
    {
        HP -= amount;
    }
}
