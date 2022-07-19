using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    int height;
    void Start()
    {
        mainCube = GameObject.Find("MainCube");

    }

    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 0.5f, transform.position.z);
        transform.localPosition = new Vector3(0, -height, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Friend")
        {
            height += 1;
            other.gameObject.GetComponent<CollectableItem>().collected();
            other.gameObject.GetComponent<CollectableItem>().setIndex(height);
            other.gameObject.transform.parent = mainCube.transform;


        }
    }
}
