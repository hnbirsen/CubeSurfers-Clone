using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool isCollected;
    int index;
    CollecterCube collecterCube;

    void Start()
    {
        isCollected = false;

        collecterCube = GameObject.Find("CollecterCube").GetComponent<CollecterCube>();
    }

    void Update()
    {
        if (isCollected)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    public bool GetIsCollected()
    {
        return isCollected;
    }

    public void SetTrueIsCollected()
    {
        isCollected = true;
    }

    public void SetIndex(int index)
    {
        this.index = index;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlockCube")
        {
            collecterCube.DescreaseHeightOfCubes();

            transform.parent = null;
            isCollected = false;
            transform.GetComponent<BoxCollider>().enabled = false;

            other.transform.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
