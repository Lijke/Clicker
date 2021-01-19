using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gunnerAttack : MonoBehaviour
{
    healthSystem enemyhealth;
    public static float GunnerAttack;
    public static float levelGunner;
    public float baseDmg;
    public float spell;
    public Text gunnerDamage;
    Save save;

    private void Start()
    {
        enemyhealth = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        save = GameObject.Find("SaveSystem").GetComponent<Save>();
        levelGunner = 1;
        GunnerAttack = 1;
        spell = 1;
        baseDmg = 40;
    }
    private void Update()
    {
        gunnerDamage.text = GunnerAttack + "dps";
        //Save
        save.Guner_Level = levelGunner;
        save.Gunner_Attack_Save = GunnerAttack;
        GunnerAttack = baseDmg * levelGunner * spell;
    }
}
