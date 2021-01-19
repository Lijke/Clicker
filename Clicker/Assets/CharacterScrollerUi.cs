using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScrollerUi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scrollerCharacter;
    ShowingUiSystem showuisystem;
    public void Start()
    {
        showuisystem = GameObject.Find("ShowingUiSystem").GetComponent<ShowingUiSystem>();
    }
    public void ShowScroleler()
    {
        showuisystem.currentUi = "Character";
    }
}
