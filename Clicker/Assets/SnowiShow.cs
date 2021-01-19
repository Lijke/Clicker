using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowiShow : MonoBehaviour
{
    public GameObject character;
    public static bool SnowiBuy;

    private void Update()
    {
        if (SnowiBuy == true)
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
        SnowiBuy = false;
    }
}
