using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneChanger: MonoBehaviour {  
  
    public void horizantal() {  
        SceneManager.LoadScene("horizantal sence");  
    }  
    public void vertical() {  
        SceneManager.LoadScene("verticalsence");  
    }  
    // public void Scene3() {  
    //     SceneManager.LoadScene("Scene3");  
    // }  
}