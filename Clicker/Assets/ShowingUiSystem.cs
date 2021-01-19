using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingUiSystem : MonoBehaviour
{
    public GameObject charactersui;
    public GameObject foodui;
    public GameObject statsui;
    public string currentUi;
    // Start is called before the first frame update
    void Start()
    {
        charactersui.SetActive(true);
        foodui.SetActive(false);
        statsui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentUi == "Stats")
        {
            charactersui.SetActive(false);
            statsui.SetActive(true);
            foodui.SetActive(false);
        }
        else if (currentUi == "Character" )
        {
            foodui.SetActive(false);
            statsui.SetActive(false);
            charactersui.SetActive(true);

        }
        else if (currentUi == "Spell")
        {
            foodui.SetActive(true);
            statsui.SetActive(false);
            charactersui.SetActive(false);

        }
    }
}
