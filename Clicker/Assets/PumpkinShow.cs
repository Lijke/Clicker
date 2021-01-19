using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinShow : MonoBehaviour
{
    public GameObject character;
    public static bool PumpkinBuy;

    private void Update()
    {
        if (PumpkinBuy == true)
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
        PumpkinBuy = false;
    }
}
