using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public List<Node> children = new List<Node>();

    public enum Result { SUCCESS, RUNNING, FAILED, READY};

	public Result currentState = Result.READY;

    public void Start()
    {
        if(currentState == Result.READY)
        {
            Debug.Log("CURRENT STATE = READ");
        }
    }

    public virtual void Execute()
    {
        Debug.Log("IM A NODE");
    }
}
