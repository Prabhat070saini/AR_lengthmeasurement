using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneChanger: MonoBehaviour {  
    public void Scene1() {  
        SceneManager.LoadScene("mainscence");  
    }  
    public void Scene2() {  
        SceneManager.LoadScene("HOME");  
    }  
    // public void Scene3() {  
    //     SceneManager.LoadScene("Scene3");  
    // }  
}