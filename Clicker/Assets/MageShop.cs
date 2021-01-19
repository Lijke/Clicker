using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MageShop : MonoBehaviour
{
    public Text mageShop;
    mageAttack mageAttack;
    
    public GameObject mage;
    public Text mageLevel;
    
    public float Levelup;
    healthSystem HealthSystem;
    float calc;
    float basecost;
    characterSystem charactersystem;
    void Start()
    {
        mageShop.text = "";
        mageAttack = GameObject.Find("MageChar").GetComponent<mageAttack>();
        HealthSystem = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        
        basecost = 250;
        //(basecost*1,07^Level-1

        Levelup = basecost;
        mageLevel.text = "Lvl" + mageAttack.levelMage;
        mageShop.text = Levelup + "G";
       
        mage.SetActive(false);
        
        
    }


    public void LevelUpMage()
    {
        if (healthSystem.gold >= Levelup)
        {
          
            characterSystem.currentCharacterBuy = 1;
            healthSystem.gold -= Levelup;
            mageAttack.levelMage += 1;
            Levelup += basecost*(float)1.23;
            mageLevel.text = "Lvl" + mageAttack.levelMage;
            
            mageShop.text = (int)Levelup + "G";
            
        }
        else
        {
            Debug.Log("za mało siana");
        }
    }
}
