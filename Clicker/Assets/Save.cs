using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.SceneManagement;
public class Save : MonoBehaviour
{
    //healthSystem
    public float gold,level,currentlevel;
    //dmgManager
    public float mage_Attack, ninja_Attack, soldier_Attack, Gunner_Attack_Save, snowi_Attack, pumpkin_Attack;
    //ninjaAttack,character...Attack
    public float mage_Level, ninja_Level, soldier_Level, Guner_Level, snowi_Level, pumpkin_Level;
    //:D
   
    public void save()
    {
        JSONObject goldJSON = new JSONObject();
        goldJSON.Add("Gold", gold);
        goldJSON.Add("Level", level);
        goldJSON.Add("CurrentLevel", currentlevel);
        goldJSON.Add("Mageattack", mage_Attack);
        goldJSON.Add("MageLevel", mage_Level);
        goldJSON.Add("NinjaAttack", ninja_Attack);
        goldJSON.Add("NinjaLevel", ninja_Level);
        goldJSON.Add("SoldierAttack", soldier_Attack);
        goldJSON.Add("GunnerAttack", Gunner_Attack_Save);
        goldJSON.Add("GunnerLevel", Guner_Level);
        goldJSON.Add("SnowiAttack", snowi_Attack);
        goldJSON.Add("SnowiLevel", snowi_Level);
        goldJSON.Add("PumpkinAttack", pumpkin_Attack);
        goldJSON.Add("PumpkinLevel", pumpkin_Level);
        goldJSON.Add("SoldierLevel", soldier_Level);

        Debug.Log(goldJSON.ToString());
        string path = Application.persistentDataPath + "/save.json";
        File.WriteAllText(path, goldJSON.ToString());
    }

    public void load()
    {
        string path = Application.persistentDataPath + "/save.json";
        string jsonstring = File.ReadAllText(path);
        JSONObject goldJSON = (JSONObject)JSON.Parse(jsonstring);
        //SetValues
        gold = goldJSON["Gold"];
        level = goldJSON["Level"];
        currentlevel = goldJSON["CurrentLevel"];
        mage_Attack = goldJSON["MageAttack"];
        mage_Level = goldJSON["MageLevel"];
        ninja_Attack = goldJSON["NinjaAttack"];
        soldier_Attack = goldJSON["SoldierAttack"];
        ninja_Level = goldJSON["NinjaLevel"];
        Gunner_Attack_Save = goldJSON["GunnerAttack"];
        Guner_Level = goldJSON["GunnerLevel"];
        snowi_Attack = goldJSON["SnowiAttack"];
        snowi_Level = goldJSON["SnowiLevel"];
        pumpkin_Attack = goldJSON["PumpkinAttack"];
        pumpkin_Level = goldJSON["PumpkinLevel"];
        soldier_Level = goldJSON["SoldierLevel"];

        Debug.Log(goldJSON.ToString());
        healthSystem.gold = gold;
        healthSystem.level = level;
        healthSystem.currentLevel = currentlevel;
        mageAttack.MageAttack = mage_Attack;
        mageAttack.levelMage = mage_Level;
        ninjaAttack.ninjaDamage = ninja_Attack;
        ninjaAttack.levelNinja = (int)ninja_Level;
        SoldierAttack.soldierAttack = soldier_Attack;
        SoldierAttack.levelSoldier = (int)soldier_Level;
        gunnerAttack.GunnerAttack = (int)Gunner_Attack_Save;
        gunnerAttack.levelGunner = (int)Guner_Level;
        snowiAttack.SnowiAttack = snowi_Attack;
        snowiAttack.levelSnowi = snowi_Level;
        pumpkinAttack.level = pumpkin_Level;
        pumpkinAttack.Attack = pumpkin_Attack;


            if (soldier_Level >= 1)
            {
            SoldierShow.soldierBuy = true;
            }
            if (mage_Level >= 1)
            {
            MageShow.MageBuy = true;
            }
            if(Guner_Level >= 1)
            {
            GunnerShow.GunnerBuy = true;
            }
        if (snowi_Level >= 1)
            SnowiShow.SnowiBuy = true;
        if (pumpkin_Level >= 1)
            PumpkinShow.PumpkinBuy = true;


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(Guner_Level);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) save();
        if (Input.GetKeyDown(KeyCode.N)) load();
    }
}
