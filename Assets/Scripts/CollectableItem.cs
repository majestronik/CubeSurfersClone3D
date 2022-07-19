using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    private bool isCollected;
    int index;
    void Start()
    {
        isCollected = false;
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

    public bool getIsCollected()
    {
        return isCollected;
    }

    public void collected()
    {
        isCollected = true;
    }
    public void setIndex(int index)
    {
        this.index = index;
    }
}
