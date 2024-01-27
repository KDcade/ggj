using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextCollider : MonoBehaviour
{

    private void OnTriggerEnter()
    {
        FindObjectOfType<gameManager>().LoadNextScene();
    }
}
