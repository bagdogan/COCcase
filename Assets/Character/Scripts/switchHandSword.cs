using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class switchHandSword : MonoBehaviour
{

    public MultiParentConstraint swordCons;

   
    public void rightToLeft()
    {
        StartCoroutine(switchHand(true));
    }

    IEnumerator switchHand (bool RtoL)
    {
        yield return new WaitForFixedUpdate();
        var sources = swordCons.data.sourceObjects;

        if (RtoL)
        {
            sources.SetWeight(0, 0);
            sources.SetWeight(1, 1);
        }

        swordCons.data.sourceObjects = sources;
    }
}
