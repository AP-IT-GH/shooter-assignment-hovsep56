using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float upspeed = 1f;
    public float spinspeed = 50F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinspeed * Time.deltaTime);
        transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * upspeed * Time.deltaTime);
    }
}
