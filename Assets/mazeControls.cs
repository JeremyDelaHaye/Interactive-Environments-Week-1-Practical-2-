using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class mazeControls : MonoBehaviour
{
    public int rotationSpeed = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Rotate(y * 10 * Time.deltaTime,0,x * -10 * Time.deltaTime);   
    }
}
