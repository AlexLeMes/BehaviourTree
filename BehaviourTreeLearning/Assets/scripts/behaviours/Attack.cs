using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Leaf 
{
    public override void Execute()
    {
        currentState = Result.SUCCESS;
        Debug.Log("ATTACK");
    }
	
}
