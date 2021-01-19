using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierShow : MonoBehaviour
{
    public GameObject character;
    public static bool soldierBuy;

    private void Update()
    {
        if (soldierBuy == true)
        {
            ActiveCharacter();
        }


    }
    public void ActiveCharacter()
    {
        character.SetActive(true);
    }
}
