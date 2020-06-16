using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonBorrar : MonoBehaviour
{
    public Manager llamarManager;

    public void clickBorrar()
    {
        llamarManager.eraseBlock();
    }
}
