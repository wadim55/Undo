using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector2 Target;
    private Activity _activity;
    void Move(int x, int y)
    { 
       transform.position = new Vector2(transform.position.x + x,
           transform.position.y + y);
    }

    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { 
            Target = new Vector2(-1, 0);
           Move(-1,0);
           _activity = new Activity(Target);
           GetComponent<ActivitySaver>().Activitys.Add(_activity);
      
           
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Target = new Vector2(1, 0);
            Move(1,0);
            _activity = new Activity(Target);
            GetComponent<ActivitySaver>().Activitys.Add(_activity);
         
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Target = new Vector2(0, -1);
            Move(0,-1);
            _activity = new Activity(Target);
            GetComponent<ActivitySaver>().Activitys.Add(_activity);
           
            
        }
        
    }
    [ContextMenu("Undo")]
    void Undo()
    {
        var Vec = GetComponent<ActivitySaver>().Activitys[GetComponent<ActivitySaver>().Activitys.Count - 2].SaveTarget;

        Vector2 Vec2 = transform.position;

        transform.position = Vec2 - Vec;
        GetComponent<ActivitySaver>().Activitys.RemoveAt(GetComponent<ActivitySaver>().Activitys.Count - 1);


    }
}
