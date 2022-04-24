using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecterCube : MonoBehaviour
{
    [SerializeField] public GameObject mainCube;
    int heightOfCubes;

    void Start()
    {

    }

    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, heightOfCubes + 1, transform.position.z);

        transform.localPosition = new Vector3(0, -heightOfCubes, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CollectableCube" && !other.GetComponent<CollectableCube>().GetIsCollected())
        {
            heightOfCubes++;

            //Debug.Log(new { t = "plus", heightOfCubes });

            other.gameObject.GetComponent<CollectableCube>().SetTrueIsCollected();
            other.gameObject.GetComponent<CollectableCube>().SetIndex(heightOfCubes);

            other.gameObject.transform.parent = mainCube.transform;
        }
    }

    public void DescreaseHeightOfCubes()
    {
        if (heightOfCubes > 0)
        {
            heightOfCubes--;

            //Debug.Log(new { t = "minus", heightOfCubes } );
        }
    }
}
