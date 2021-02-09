using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unmuteSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestCoroutine());
    }


    IEnumerator TestCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            AkSoundEngine.SetState("allSounds", "on");
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
