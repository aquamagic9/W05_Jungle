using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindNormalVector();
    }

    void FindNormalVector()
    {
        float distance = 10f;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, distance))
        {
            this.transform.up = hit.normal;
        }
    }
}
