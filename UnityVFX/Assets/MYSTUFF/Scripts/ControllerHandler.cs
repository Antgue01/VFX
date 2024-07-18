using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerHandler : MonoBehaviour
{
    public Controller Controller { get; private set; }
    private void Awake()
    {
        Controller = new Controller();
        Controller.Enable();
    }
    
}
