using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RayCasting : MonoBehaviour
{
    [SerializeField] Transform gunAim;
    [SerializeField] LineRenderer lineRend;

    [SerializeField] LayerMask  LayerForRay;

    Camera cam;
    Ray ray;
    RaycastHit hit;

    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit, 100, LayerForRay))
        {
            lineRend.enabled = true;
            lineRend.SetPosition(0, gunAim.transform.position);
            lineRend.SetPosition(1, hit.point);
            Debug.DrawLine(ray.origin, hit.point, Color.red);

            print(hit.transform.name);

            if(hit.transform.CompareTag("Box"))
                hit.transform.gameObject.GetComponent<Renderer>().material.DOColor( Color.blue , .5f );
            
        }
        else
        {
            lineRend.enabled = false;
        }
    }


}
