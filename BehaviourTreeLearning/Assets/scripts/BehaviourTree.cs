using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : MonoBehaviour
{
    Node root;

    public void Start()
    {
        root = new Selector();
        root.children.Add(new Selector());
        root.children.Add(new Sequencer());
        root.children[0] = new Attack();
        root.children[1] = new Patrol();
    }

    public void Update()
    {
        root.Execute();
    }

}
