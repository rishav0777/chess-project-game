using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void Awake()
    {
        gameObject.AddComponent<initialise_player>();
    }
}
