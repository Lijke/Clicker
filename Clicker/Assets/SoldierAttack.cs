using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoldierAttack : MonoBehaviour
{
    healthSystem enemyhealth;
    public static float soldierAttack;
    public static int levelSoldier;
    public int baseDmg;
    public float spell;
    public Text soldierDamage;
    Save save;

    void Start()
    {
        enemyhealth = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        levelSoldier = 1;
        soldierAttack = 45;
        spell = 1;
        baseDmg = 25;
        save = GameObject.Find("SaveSystem").GetComponent<Save>();
        gameObject.SetActive(false);
    }
    private void Update()
    {
        soldierDamage.text = soldierAttack + "dps";
        save.soldier_Level = levelSoldier;
        soldierAttack = baseDmg * levelSoldier * spell;
    }
}
