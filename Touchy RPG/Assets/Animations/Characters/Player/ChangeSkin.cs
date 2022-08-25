using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public AnimatorOverrideController blueAnim;
    // Start is called before the first frame update

    public void BlueSkin() 
    {
        GetComponent<Animator>().runtimeAnimatorController = blueAnim as RuntimeAnimatorController;
    }
}
