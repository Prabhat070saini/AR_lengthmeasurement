using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panalcontroler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panal;
   public void panalopen()
   {
       panal.SetActive(true);
   }
   public void panaloff()
   {
       panal.SetActive(false);
   }
}
