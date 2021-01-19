using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;   
public class Admanager : MonoBehaviour
{
   
    public void Ad()
    {
       
            if(Advertisement.IsReady("video"))
            {
                Advertisement.Show("video");
            }
       
    }
}
