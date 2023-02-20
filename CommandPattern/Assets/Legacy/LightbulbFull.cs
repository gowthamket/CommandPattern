using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightbulbFull : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // if we press button -- do hardcoded logic
        if (Input.GetKeyDown(KeyCode.Space)) {
            TurnOnLight();
        } else if (Input.GetKeyDown(KeyCode.LeftAlt)) {
            TurnOnLight();
        } else if (Input.GetKeyDown(KeyCode.LeftApple)) {
            setRandomLightColor();
        }
    }

    public void TurnOffLight() {
        // turn off the light
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        transform.GetChild(0).gameObject.SetActive(false);
    }
    public void TurnOnLight() {
        // turn off the light
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        transform.GetChild(0).gameObject.SetActive(true);
    }

    void setLightColor(Color newColor) {
        Material material = GetComponent<Renderer>().material;
        material.color = newColor;
        material.SetColor("_EmissionColor", newColor);
        transform.GetChild(0).gameObject.GetComponent<Light>().color = newColor;
    }

    void setRandomLightColor() {
        Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        Material material = GetComponent<Renderer>().material;
        material.color = randomColor;
        material.SetColor("_EmissionColor", randomColor);
        transform.GetChild(0).gameObject.GetComponent<Light>().color = randomColor;
    }
}
   