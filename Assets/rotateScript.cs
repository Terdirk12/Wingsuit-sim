using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 90f, 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
