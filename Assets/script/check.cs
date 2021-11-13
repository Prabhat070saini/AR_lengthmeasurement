using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;

public class check : MonoBehaviour
{
    public ARRaycastManager arRaycastManager;
    public ARCameraManager ARCameraManager;
    public LineRenderer line;
    private List<ARRaycastHit> hitpoint = new List<ARRaycastHit>();
    public GameObject Mark;
    public GameObject point;
    private GameObject p1;
    private GameObject p2;
    private GameObject startPoint;
    private GameObject endPoint;
    private LineRenderer line1;
    bool isComplete = false;
    bool isPlace = false;
    public TMP_Text distanceText;

    void Update()
    {
        arRaycastManager.Raycast(new Vector2(Screen.width/2,Screen.height/2),hitpoint,TrackableType.Planes);
        if(hitpoint.Count >0)
        {
        Mark.transform.position = hitpoint[0].pose.position;
        Mark.transform.rotation = hitpoint[0].pose.rotation;
        }
        if(isPlace==true)
        {
            line1.SetPosition(1,Mark.transform.position);
            endPoint = Mark;
        }
        if(isComplete == true)
        {
            distanceText.text = Vector3.Distance(startPoint.transform.position,endPoint.transform.position).ToString();
        }

    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Btn_pressed()
    {
       if(isPlace == false)
       {
        p1 = Instantiate(point,Mark.transform.position,Quaternion.identity);
        line1 = Instantiate(line);
        line1.SetPosition(0,p1.transform.position);
        isPlace = true;
        startPoint = p1;
        isComplete =true;
       }
       else
       {
           p2 = Instantiate(point,Mark.transform.position,Quaternion.identity);
           line1.SetPosition(1,p2.transform.position);
           isPlace = false;
           isComplete = false;
           endPoint.transform.position = p2.transform.position;
       }
    }
}