using System;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class GoToCheese : MonoBehaviour
{
    public Transform destination;
    public IAstarAI ai;

    private void Start()
    {
        ai = GetComponent<IAstarAI>();
        ai.destination = destination.position;
    }
}
