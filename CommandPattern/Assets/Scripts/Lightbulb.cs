using UnityEngine;

public class Lightbulb : MonoBehaviour
{
    // current lightbulb state
    bool isPowerOn = false;

    public void TogglePower() {        
        if (isPowerOn == false) {
            // this logic turns the light ON and sets the lightbulb state
            GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            transform.GetChild(0).gameObject.SetActive(true);
            isPowerOn = true;
        } else {
            // this logic turns the light OFF and sets the lightbulb state
            GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            transform.GetChild(0).gameObject.SetActive(false);
            isPowerOn = false;
        }
    }

    public void SetLightColor(Color newColor) {
        Material material = GetComponent<Renderer>().material;
        material.color = newColor;
        material.SetColor("_EmissionColor", newColor);
        transform.GetChild(0).gameObject.GetComponent<Light>().color = newColor;
    }

    public void SetRandomLightColor() {
        Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        Material material = GetComponent<Renderer>().material;
        material.color = randomColor;
        material.SetColor("_EmissionColor", randomColor);
        transform.GetChild(0).gameObject.GetComponent<Light>().color = randomColor;
    }
}



























