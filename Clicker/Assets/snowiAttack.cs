using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snowiAttack : MonoBehaviour
{
    healthSystem enemyhealth;
    public static float SnowiAttack;
    public static float levelSnowi;
    public float baseDmg;
    public float spell;
    public Text snowiDamage;
    dmgManager dmgmanager;
    Save save;
    private void Start()
    {
        enemyhealth = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
        save = GameObject.Find("SaveSystem").GetComponent<Save>();
        levelSnowi = 0;
        SnowiAttack = 1;
        spell = 1;
        baseDmg = 100;
    }
    private void Update()
    {
        snowiDamage.text = SnowiAttack + "dps";
        dmgmanager.snowiDamage = SnowiAttack;
        save.snowi_Level = levelSnowi;
        save.snowi_Attack = SnowiAttack;
        SnowiAttack = baseDmg * levelSnowi * spell;
    }
}
