using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-6f, -1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
