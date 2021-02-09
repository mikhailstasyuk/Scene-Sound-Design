using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingState : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        AkSoundEngine.SetState("allSounds", "off");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
