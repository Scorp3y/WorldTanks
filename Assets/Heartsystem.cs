using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heartsystem : MonoBehaviour
{
    
    
    public int HP = 3;
    public int NumHP = 3;
    public int HP2 = 3;
    public int NumHP2 = 3;
    public Image[] health;
    public Image[] health2;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    
    void Update()
    {
        if (HP > NumHP)
        {
            HP = NumHP;
        }
        if (HP2 > NumHP2)
        {
            HP2 = NumHP2;
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
            if (i < HP2)
            {

                health2[i].sprite = fullHeart;
            }
            else
            {

                health2[i].sprite = emptyHeart;
            }
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
