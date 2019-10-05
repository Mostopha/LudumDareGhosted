using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class BottomBar : MonoBehaviour
{
    public static BottomBar bottomBar;

    public Text text;

    public string textBarString;
    
    // Start is called before the first frame update
    void Start()
    {
        bottomBar = this;
    }

}
