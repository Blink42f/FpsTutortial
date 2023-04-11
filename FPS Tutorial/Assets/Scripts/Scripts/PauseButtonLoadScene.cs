using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseButtonLoadScene : MonoBehaviour
{
    public string  scene = string.Empty;

    private ButtonLoadScene _button;

    private void Awake()
    {
        _button = GetComponent<ButtonLoadScene>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel(scene);
            return;
        }
       
    }
}
