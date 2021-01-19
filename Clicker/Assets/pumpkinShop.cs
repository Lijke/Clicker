using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pumpkinShop : MonoBehaviour
{
    public Text pumpkinnShop;
    healthSystem HealthSystem;
    dmgManager dmgmanager;
    public GameObject pumpkinObject;
    public Text TextLevel;
    public Text TextDamage;
    public float Levelup;
    float calc;
    float basecost;
    characterSystem charactersystem;
    void Start()
    {
        HealthSystem = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        charactersystem = GameObject.Find("CharacterSystem").GetComponent<characterSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
        basecost = 100000;
        Levelup = basecost;
        TextLevel.text = "lvl" + pumpkinAttack.level;
        TextDamage.text = 0 + "dps";
        pumpkinnShop.text = Levelup + "g";
        pumpkinObject.SetActive(false);
    }
    public void Pumpkin()
    {

        if (healthSystem.gold >= Levelup)
        {
            characterSystem.currentCharacterBuy = 5;

            healthSystem.gold -= Levelup;
            pumpkinAttack.level += 1;


            Levelup = Levelup + basecost * (float)1.45;

            TextLevel.text = "Lvl" + pumpkinAttack.level;
            pumpkinnShop.text = (int)Levelup - 1 + "G";
            dmgmanager.pumpkinDamage = pumpkinAttack.Attack;
        }
        else
        {
            Debug.Log("za mało siana");
        }
    }
}
