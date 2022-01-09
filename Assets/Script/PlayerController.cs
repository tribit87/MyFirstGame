using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    int cupsInTheSink = 4;
    private bool HasRedKey { get; set; }
    private bool HasBlueKey { get; set; }
    private bool HasGreenKey { get; set; }

    public void GetKey(DoorType key)
    {
        switch (key)
        {
            case DoorType.Red:
                HasRedKey = true;
                break;
            case DoorType.Blue:
                HasBlueKey = true;
                break;
            case DoorType.Green:
                HasGreenKey = true;
                break;
        }
    }

    public bool HasKey(DoorType door)
    {
        switch (door)
        {
            case DoorType.Red:
                return HasRedKey;
            case DoorType.Blue:
                return HasBlueKey;
            case DoorType.Green:
                return HasGreenKey;
            default:
                return false;
        }
    }

    private void Update()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log ("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}


public enum DoorType
{
    Red,
    Blue, 
    Green
}
