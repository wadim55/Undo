using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity : MonoBehaviour
{
    public Vector2 SaveTarget;

    public Activity(Vector2 saveTarget)
    {
        SaveTarget = saveTarget;
    }
}
