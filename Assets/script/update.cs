using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;



public class update : MonoBehaviour
{
    public ARRaycastManager arraycastmanager;
    public ARCameraManager arcamera;
    public LineRenderer line;
    
    private LineRenderer lines;
    private List<ARRaycastHit> hitpoint = new List<ARRaycastHit>();
    public GameObject mark, point, canvax;
    private GameObject p1, p2, startpoint, endpoint;
    public Text D;


    private GameObject marks;
    
    private GameObject start, end;
    bool iscomplete = false, ispalce = false;
    // void Start()
    // {
    //      marks= Instantiate(mark,new Vector2(Screen.width/2,Screen.height/2),Quaternion.identity);
    //      marks.transform.SetParent(canvax.transform);
    // }

    // Update is called once per frame
    void Update()
    {
        arraycastmanager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hitpoint, TrackableType.Planes);
        if (hitpoint.Count > 0)
        {
            mark.transform.position = hitpoint[0].pose.position;
            mark.transform.rotation = hitpoint[0].pose.rotation;
        }
        if (ispalce == true)
        {

            lines.SetPosition(1, mark.transform.position);
            end = mark;
        }
        if (iscomplete == true)
        {
            float Distance = Vector3.Distance(start.transform.position, end.transform.position) * 100;
            Debug.Log(Distance);
            D.text = Distance.ToString("F2");
        }


    }

    public void btn()
    {
        if (ispalce==false)
        {
            p1=Instantiate(point,mark.transform.position,Quaternion.identity);
            lines=Instantiate(line);
            lines.SetPosition(0,p1.transform.position);
            ispalce=true;
            iscomplete=true;
            start=p1;

        }
        else
        {
            p2=Instantiate(point,mark.transform.position,Quaternion.identity);
             lines.SetPosition(1,p1.transform.position);
             iscomplete=false;
             ispalce=false;
             end.transform.position=p2.transform.position;

        }
    }
}
