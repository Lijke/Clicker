using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsUi : MonoBehaviour
{
    ShowingUiSystem showuisystem;
    void Start()
    {
        showuisystem = GameObject.Find("ShowingUiSystem").GetComponent<ShowingUiSystem>();
    }

    // Update is called once per frame
    public void showscroller()
    {
        showuisystem.currentUi = "Stats";
    }
}
