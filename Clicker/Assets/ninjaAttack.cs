using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ninjaAttack : MonoBehaviour
{
    // Start is called before the first frame update
    healthSystem enemyhealth;
    public static float ninjaDamage;
    public static int levelNinja;
    public int baseDmg;
    public float spell;
    public Text ninjaLevel;
    public Text ninjaDamagee;
    Save save;

    void Start()
    {
        enemyhealth = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        save = GameObject.Find("SaveSystem").GetComponent<Save>();
        baseDmg = 5;
        spell = 1;

    }


    private void Update()
    {
        save.ninja_Level = levelNinja;
        ninjaLevel.text = "Lvl" + levelNinja;
        ninjaDamagee.text = ninjaDamage + "dps";
        ninjaDamage = baseDmg + levelNinja * baseDmg;
    }

}
