using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinjaShop : MonoBehaviour
{
    public Text ninjaShop;
    dmgManager dmgmanager;
   
    public float Levelup;
    healthSystem HealthSystem;
    float calc;
    // Start is called before the first frame update
    void Start()
    {
        HealthSystem = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
        calc = 2 * ninjaAttack.levelNinja;
        if (calc == 0)
        {
            calc = 1;
        }
        Levelup = (5 + ninjaAttack.levelNinja) * calc;
        
        ninjaShop.text = Levelup + "G";
        dmgmanager.ninjaDamage = ninjaAttack.ninjaDamage;
    }

    public void LevelUpNinja()
    {
        if (healthSystem.gold >= Levelup)
        {
            healthSystem.gold -= Levelup;
            ninjaAttack.levelNinja += 1;
            calc = 2 * Mathf.Pow(ninjaAttack.levelNinja - 1, 1f);
            if (calc == 0)
            {
                calc = 1;
            }
            Levelup = (5 + ninjaAttack.levelNinja) * calc;
            ninjaShop.text = Levelup + "G";
            dmgmanager.ninjaDamage = ninjaAttack.ninjaDamage;
        }
        else
        {
            Debug.Log("za mało siana");
        }
    }

}
