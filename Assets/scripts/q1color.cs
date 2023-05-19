using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q1color : MonoBehaviour
{ 
 public Material material;
 public GameObject camera1;
 public GameObject camera2;
 public GameObject camera3;
 public GameObject camerap;
 public GameObject cameraf;
 private Renderer renderer;
 
void Awake()
{
    cameraf.SetActive(false);
        camera1.SetActive(false);
        camera3.SetActive(false);
        camera2.SetActive(false);
        camerap.SetActive(false); 
}
    void Start()
    {
        camera1.SetActive(true);
        renderer = GetComponent<Renderer>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Change the color to green
           renderer.material.color = Color.green ;
           StartCoroutine(Pause());
           
           
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            // Change the color to red
            renderer.material.color = Color.red;
            StartCoroutine(Pause2());
             
             
        }
        
    }
IEnumerator Pause()
    {
        // Wait for one second
        yield return new WaitForSeconds(0.5f);
        CameraOne ();
    }
    IEnumerator Pause2()
    {
        // Wait for one second
        yield return new WaitForSeconds(0.5f);
        Camerawrong();
    }

    void CameraOne()
    {
        camera2.SetActive(true);
        camera1.SetActive(false);
        camera3.SetActive(false);
        cameraf.SetActive(false);
        camerap.SetActive(false);  
    }

    void Camerawrong()
    {
        cameraf.SetActive(true);
        camera1.SetActive(false);
        camera3.SetActive(false);
        camera2.SetActive(false);
        camerap.SetActive(false); 
          
    }

}
  

    
