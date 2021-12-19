using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.SceneManagement;
public class colorchane : MonoBehaviour
{
    // Start is called before the first frame update
    public Material line;
    public Dropdown Dd;
    public void dropdd()
    {
        if (Dd.value == 1)
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#18F152", out mycolor);
            line.color = mycolor;
        }
        else if (Dd.value == 0)
        {
           Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#DC2DF1", out mycolor);
            line.color = mycolor;
        }
        else if(Dd.value==2)
        {
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#2D2D2D", out mycolor);
            line.color = mycolor;

        }
        else
        {
           Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#FFFFFF", out mycolor);
            line.color = mycolor;

        }
    }
    // public void colorchnge()
    // {
    //     Color mycolor = new Color();
    //     ColorUtility.TryParseHtmlString("#01FFFF", out mycolor);
    //     line.color = mycolor;

    // }
    void Start()
    {
        Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#01FFFF", out mycolor);
            line.color = mycolor;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
