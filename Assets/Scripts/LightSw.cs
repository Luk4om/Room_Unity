using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSw : MonoBehaviour
{
    public GameObject targetGameObject;
    public KeyCode keyCodeSwitch;
    void Update()
    {
        if(Input.GetKeyDown(keyCodeSwitch))
        {
            targetGameObject.SetActive(!targetGameObject.activeSelf);
        }
    }

    void OnMouseDown()
    {
        targetGameObject.SetActive(!targetGameObject.activeSelf);
    }
}
