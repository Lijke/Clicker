using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScrollerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scrollerFood;
    ShowingUiSystem showuisystem;
    public void Start()
    {
        showuisystem = GameObject.Find("ShowingUiSystem").GetComponent<ShowingUiSystem>();
    }
    public void ShowScroleler()
    {
        showuisystem.currentUi = "Food";
    }
    
}
