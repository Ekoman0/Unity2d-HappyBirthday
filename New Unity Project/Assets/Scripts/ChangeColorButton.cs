using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ChangeColorButton : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(routine: InitiBox());
    }
    IEnumerator InitiBox()
    {
        for (int i = 0; i < 1;)
        {
            yield return new WaitForSeconds(1);
            Color coloor = new Color(r: Random.Range(0F, 1F), g: Random.Range(0F, 1F), b: Random.Range(0F, 1F));
            //this.GetComponent<Renderer>().material.color = coloor;
            GetComponent<Button>().image.color = coloor;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
