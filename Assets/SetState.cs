using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetState : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter()
    {
        AkSoundEngine.SetState("whereInHouse", "firstFloor");
        print("firstFloor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
