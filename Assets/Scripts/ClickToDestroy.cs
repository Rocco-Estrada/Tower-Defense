using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {

                BoxCollider bc = hit.collider as BoxCollider;
                if(bc.tag == "Enemy")
                {
                    Destroy(bc.gameObject);
                }
            }
        }
    }
}
