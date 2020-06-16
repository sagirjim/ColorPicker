using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAnadir : MonoBehaviour
{
    public Manager llamarManager;

    public void clickAnadir()
    {       
        llamarManager.colorBlockSpawn();       
    }
}
