using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    GameObject _lightBulb;
    [SerializeField]
    Light _light;

    // Update is called once per frame
    void Update()
    {
        // if we press button -- do hardcoded logic
        if (Input.GetKeyDown(KeyCode.Space)) {
            // turn off the light
            _lightBulb.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            _light.enabled = false;
        } else if (Input.GetKeyDown(KeyCode.LeftControl)) {
            // turn on the light
            _lightBulb.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            _light.enabled = true; 
        }
    }
}
