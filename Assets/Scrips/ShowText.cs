using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider Player)
    {
        if(Player.tag == "Player")
        {
            transform.position += new Vector3(0, 2, 0);
    }   }
}
