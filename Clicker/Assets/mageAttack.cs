using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mageAttack : MonoBehaviour
{
    // Start is called before the first frame update
    healthSystem enemyhealth;
    public static float MageAttack;
    public static float levelMage;
    public int baseDmg;
    public float spell;
    public Text mageDamage;
    dmgManager dmgmanager;
    Save save;
    void Start()
    {
        enemyhealth = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();

        MageAttack = 1;
        spell = 1;
        baseDmg = 15;
        save = GameObject.Find("SaveSystem").GetComponent<Save>();
        gameObject.SetActive(false);
    }
    private void Update()
    {
        MageAttack = baseDmg * levelMage * spell;
        mageDamage.text = MageAttack + "dps";
        dmgmanager.mageDamage = MageAttack;
        //Save
        save.mage_Level = levelMage;
    }


}
