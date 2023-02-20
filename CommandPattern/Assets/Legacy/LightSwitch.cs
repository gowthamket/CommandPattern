using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField]
    GameObject _light;
    [SerializeField]


    // Update is called once per frame
    void Update()
    {
        // if we press button -- do hardcoded logic
        if (Input.GetKeyDown(KeyCode.Space)) {
            TurnOffLight();
        } else if (Input.GetKeyDown(KeyCode.LeftAlt)) {
            TurnOnLight();
        } else if (Input.GetKeyDown(KeyCode.LeftApple)) {
            ChangeLightColor();
        }
    }

    void TurnOffLight() {
        // turn off the light
        _light.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        _light.transform.GetChild(0).gameObject.SetActive(false);
    }
    void TurnOnLight() {
        // turn off the light
        _light.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        _light.transform.GetChild(0).gameObject.SetActive(true);
    }

    void ChangeLightColor() {
        Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        _light.GetComponent<Renderer>().material.color = randomColor;
        _light.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        _light.transform.GetChild(0).gameObject.GetComponent<Light>().color = randomColor;
    }
}

// using System.Collections.Generic;

// public class Lightswitch
// {
//     public Lightbulb _lightbulb;
//     Stack<ICommand> commandList;

//     void AddCommand() {
//         commandList.Push(new TurnOnCommand(_lightbulb));
//     }
// }
