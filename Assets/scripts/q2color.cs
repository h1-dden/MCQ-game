using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q2color : MonoBehaviour
{ 
 public Material material;
 public GameObject camera1;
 public GameObject camera2;
 public GameObject camera3;
 public GameObject camerap;
 public GameObject cameraf;
private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
       
        
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // Change the color to green
           renderer.material.color = Color.green ;
           StartCoroutine(Pause());
           
           
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha8))
        {
            // Change the color to red
            renderer.material.color = Color.red;
            StartCoroutine(Pause2());
             
             
        }
    
        
    }
IEnumerator Pause()
    {
        // Wait for half second
        yield return new WaitForSeconds(0.5f);
        CameraOne ();
    }
    IEnumerator Pause2()
    {
        // Wait for half second
        yield return new WaitForSeconds(0.5f);
        Camerawrong();
    }

    void CameraOne()
    {
        camera3.SetActive(true);
        camera2.SetActive(false);
        camera1.SetActive(false);
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
  

    
