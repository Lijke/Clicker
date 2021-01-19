using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageShow : MonoBehaviour
{
    public GameObject character;
    public static bool MageBuy;

    private void Update()
    {
        if (MageBuy == true)
        {
            ActiveCharacter();

        }
        if(character.activeSelf)
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
        MageBuy = false;
    }
}
