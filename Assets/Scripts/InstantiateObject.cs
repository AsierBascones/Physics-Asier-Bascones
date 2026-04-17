using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject robot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(robot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
