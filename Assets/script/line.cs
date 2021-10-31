using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
   public GameObject p1,p2,p3;
   public LineRenderer l;
   public void dr()
    {
        l.SetPosition(0,p1.transform.position);
        l.SetPosition(1,p2.transform.position);
        l.SetPosition(2,p3.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
