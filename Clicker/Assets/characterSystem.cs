using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSystem : MonoBehaviour
{
    public GameObject[] character;
    public bool[] characterBuy;
    public static int currentCharacterBuy;
    private void Start()
    {
        characterBuy[0] = true;
    }
    private void Update()
    {
        characterBuy[currentCharacterBuy] = true;

        if (  characterBuy[currentCharacterBuy] == true)
        {
                 ActiveCharacter();
        }
        

    }
    public void ActiveCharacter()
    {
        character[currentCharacterBuy].SetActive(true);
    }
}
