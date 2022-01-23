using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.SceneManagement;



public class updateControler : MonoBehaviour
{
    public ARRaycastManager arraycastmanager;
    public ARCameraManager arcamera;
    public LineRenderer line;

    private LineRenderer lines;
    private List<ARRaycastHit> hitpoint = new List<ARRaycastHit>();
    public GameObject mark, point, canvax;
    private GameObject p1, p2, startpoint, endpoint;
    public Text D;
    public Dropdown Dd;
    float distanceR, Distance;
    string unit;
    public GameObject panal;
    Animation panalanimation;

    public TMP_Text Tlength1;
    public TMP_Text Tlength;

    private GameObject marks;

    private GameObject start, end;
    bool iscomplete = false, ispalce = false;
    // panal control variable
    public panalcontroler Panalcontrolscript;
    void Start()
    {
        unit = " m";
        distanceR = 1f;
        panalanimation = panal.GetComponent<Animation>();
    }

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
            Distance = Vector3.Distance(start.transform.position, end.transform.position);
            //  Debug.Log(Distance); 
            //  length1.transform.SetParent(lines.transform);
            Tlength1.transform.rotation = arcamera.transform.rotation;
            Tlength1.transform.position = (start.transform.position + end.transform.position) / 2;
            Tlength1.text = (Distance * distanceR).ToString("F2") + unit;
            // length1.text = "jhfdskhkhkhjgfhfjhhfg";
            D.text= (Distance * distanceR).ToString("F2") + unit;
        }


    }
    public void horizantalrst()
    {
        SceneManager.LoadScene("horizantal sence");
        //  Egginstiate.SetActive(true);
    }
     public void vrticalrst()
    {
        SceneManager.LoadScene("verticalsence");
        //  Egginstiate.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void btn()
    {
        if (ispalce == false)
        {
            p1 = Instantiate(point, mark.transform.position, Quaternion.identity);
            lines = Instantiate(line);
            lines.SetPosition(0, p1.transform.position);
            ispalce = true;
            iscomplete = true;
            start = p1;

            Tlength1 = Instantiate(Tlength, start.transform.position, Quaternion.identity);


        }
        else
        {
            p2 = Instantiate(point, mark.transform.position, Quaternion.identity);
            lines.SetPosition(1, p2.transform.position);
            iscomplete = false;
            ispalce = false;
            end.transform.position = p2.transform.position;

        }
    }
    int onof = 0;
    public void cancle(){
         Panalcontrolscript.panaloff();
            onof--;

    }
    public void settingbtn()
    {
        if (onof == 0)
        {
            panalanimation["useanimation"].speed = 1;
            panalanimation.Play();
            Panalcontrolscript.panalopen();
            onof++;
        }
        else
        {
            Panalcontrolscript.panaloff();
            onof--;
        }


    }
    public void drop()
    {
        if (Dd.value == 1)
        {
            distanceR = 100f;
            unit = " cm";
        }
        else if (Dd.value == 0)
        {
            distanceR = 1f;
            unit = " m";
        }
        else
        {
            distanceR = 39.3701f;
            unit = " inch";

        }
    }
}
