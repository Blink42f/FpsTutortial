using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ButtonLoadScene : MonoBehaviour
{
    public string Game = string.Empty;

    public void OnButtonPressed()
    {
        Application.LoadLevel(Game);

    }
}
