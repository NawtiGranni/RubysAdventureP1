using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    //a trigger to trigger damage
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
    }
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
