using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;



public class management : MonoBehaviour
{
    public ARRaycastManager arraycastmanager;
    public ARCameraManager arcamera;
    public LineRenderer line;
    private List<ARRaycastHit> hitpoint = new List<ARRaycastHit>();
    public GameObject mark,point,canvax;
    private GameObject p;
    public Text D;
    
    private GameObject marks;
    int index=0;
    private GameObject start,end;
  bool ischeck=false;
    // void Start()
    // {
    //      marks= Instantiate(mark,new Vector2(Screen.width/2,Screen.height/2),Quaternion.identity);
    //      marks.transform.SetParent(canvax.transform);
    // }

    // Update is called once per frame
    void Update()
    {
        arraycastmanager.Raycast(new Vector2(Screen.width/2,Screen.height/2),hitpoint,TrackableType.Planes);
        if (hitpoint.Count>0)
        {
            mark.transform.position=hitpoint[0].pose.position;
            mark.transform.rotation=hitpoint[0].pose.rotation;
        }
        if (ischeck==true)
        {
            float Distance=Vector3.Distance(start.transform.position,end.transform.position)*100;
             Debug.Log( Distance);
              D.text=Distance.ToString();
        }
      
       
    }
  
    public void btn() {
        {
           p= Instantiate(point,mark.transform.position,Quaternion.identity);
            line.SetPosition(index,p.transform.position);
            index++;
            if (index==1)
            {
                start = p;
            }
            if (index==2)
            {
                end = p;
                ischeck=true;
            }
        }
    }
}
