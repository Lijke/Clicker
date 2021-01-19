using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerShow : MonoBehaviour
{
    public GameObject character;
    public static bool GunnerBuy;

    private void Update()
    {
        if (GunnerBuy == true)
        {
            ActiveCharacter();
        }
        if (character.activeSelf)
        {
            StartCoroutine(CheckIfActive());
        }


    }
    public void ActiveCharacter()
    {
        character.SetActive(true);
    }
    private IEnumerator CheckIfActive()
    {
        yield return new WaitForSeconds(2f);
        GunnerBuy = false;
    }
}
