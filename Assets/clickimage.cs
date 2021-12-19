using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickimage : MonoBehaviour
{
    // Start is called before the first frame update
    public string click;

    void Start()
    {
        
    }
    bool isclick=false;
    public void clickimz(){
        isclick=true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isclick)
        {
            ScreenCapture.CaptureScreenshot(click);
            isclick=false;
        }
       
    }
}
