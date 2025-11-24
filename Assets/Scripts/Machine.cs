using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject pressE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector2.Distance(player.transform.position, pressE.transform.position));
        if (Vector2.Distance(player.transform.position, pressE.transform.position) < 1.5f)
        {
            pressE.SetActive(true);
        }
        else
        {
            pressE.SetActive(false);
        }
    }
}
