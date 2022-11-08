using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{

    private STATE state = STATE.IDLE;
    private enum STATE
    {
        CHOPPING,
        SALTING,
        COOKING,
        PEELING,
        TENDERISING,
        IDLE
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
