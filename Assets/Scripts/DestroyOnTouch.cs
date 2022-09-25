using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Destroy(hit.transform.gameObject);   
            }
        }
    }
}

