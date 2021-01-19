using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public Image healthBar;
    public float currentHealth;
    public float maxHealthTest;
    public GameObject[] enemies;
    public GameObject[] bosses;
    public Transform spawnPoint;
    public bool isdead;
    public static float level;
    public static float currentLevel;
    public static float gold;
    public float goldtodrop;
    public Text goldText;
    Save save;
    void Start()
    {
        save = GameObject.Find("SaveSystem").GetComponent<Save>();
        StartCoroutine(respawnmonster());
        isdead = false;
        level = 1;
        gold = 9999999999;
    }

    // Update is called once per frame
    void Update()
    {
        if(isdead ==true)
        {
            if ( level % 25 == 0)
            {
                StartCoroutine(respawnBoss());
                isdead = false;
                save.gold = gold;
                save.level = level;
                save.currentlevel = currentLevel;
            }
            else
            {
                StartCoroutine(respawnmonster());
                isdead = false;
                gold += (int)goldtodrop;
                save.gold = gold;
                save.level = level;
                save.currentlevel = currentLevel;
            }
            
            
        }
        healthBar.fillAmount = currentHealth / maxHealthTest;
        goldText.text = (int)gold + "G";
     

    }

    private IEnumerator respawnmonster()
    {
        yield return new WaitForSeconds(0);
        if (currentLevel >= 10)
        {
            float mx;
            mx = Mathf.Pow(level, -1f);
            float rmin, rmax;
            rmin = (float)1.00;
            rmax = (float)1.24;
            maxHealthTest = (10 * ((level - 1) + mx) * 15)*Random.Range(rmin,rmax);
            goldtodrop = maxHealthTest / 15;
            currentHealth = (int)maxHealthTest;
            Instantiate(enemies[Random.Range(0, 24)], spawnPoint.position, Quaternion.identity);
            level += 1;
            currentLevel = 0;
        }
        else
        {
            float mx;
            float rmin, rmax;
            rmin = (float)1.00;
            rmax = (float)1.24;
            mx = Mathf.Pow(level, -1f);
            maxHealthTest = 10 * ((level - 1) + mx) * 10+Random.Range(0,50)* Random.Range(rmin, rmax);
            goldtodrop = maxHealthTest / 15;
            currentHealth = (int)maxHealthTest;
            Instantiate(enemies[Random.Range(0, 24)], spawnPoint.position, Quaternion.identity);
            currentLevel += 1;
        }
    }
    private IEnumerator respawnBoss()
    {
        yield return new WaitForSeconds(0);
        float mx;
        mx = Mathf.Pow(level, -1f);
        float rmin, rmax;
        rmin = (float)1.00;
        rmax = (float)1.24;
        maxHealthTest = (100 * ((level - 1) + mx) * 10) * Random.Range(rmin, rmax);
        goldtodrop = maxHealthTest / 15;
        currentHealth = (int)maxHealthTest;
        Instantiate(bosses[Random.Range(0, 4)], spawnPoint.position, Quaternion.identity);
        level += 1;
    }

}
