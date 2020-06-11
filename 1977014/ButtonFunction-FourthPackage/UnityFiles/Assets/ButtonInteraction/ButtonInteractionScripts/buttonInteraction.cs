using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonInteraction : MonoBehaviour
{
    public GameObject Cuby;

    public void CubeReveal ()
    {
        Cuby.SetActive(true);
    }
}
