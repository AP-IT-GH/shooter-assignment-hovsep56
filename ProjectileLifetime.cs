using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifetime: MonoBehaviour
{
    public float timer = 0;
    public float lifetime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < lifetime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
