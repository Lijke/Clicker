using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanelUi : MonoBehaviour
{
    public GameObject panel;
    public void showPanel()
    {
        panel.SetActive(true);
    }
}
