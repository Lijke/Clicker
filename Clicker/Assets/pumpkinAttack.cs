using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pumpkinAttack : MonoBehaviour
{
    healthSystem enemyhealth;
    public static float Attack;
    public static float level;
    public float baseDmg;
    public float spell;
    public Text Damage;
    dmgManager dmgmanager;
    Save save;

    private void Start()
    {
        enemyhealth = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
        save = GameObject.Find("SaveSystem").GetComponent<Save>();
        level = 1;
        Attack = 1;
        spell = 1;
        baseDmg = 250;
    }
    private void Update()
    {
        Damage.text = Attack + "dps";
        dmgmanager.pumpkinDamage = Attack;
        save.pumpkin_Level = level;
        save.pumpkin_Attack = Attack;
        Attack = baseDmg * level * spell;
    }
}