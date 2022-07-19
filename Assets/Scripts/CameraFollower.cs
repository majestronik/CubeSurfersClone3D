using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public GameObject target;
    public Vector3 distance;
    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + distance, Time.deltaTime);
    }
}
