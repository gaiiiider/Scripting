using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolinScript : MonoBehaviour
{
    public float jumpStrentghFactor = 10;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpStrentghFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpStrentghFactor;
    }
}
