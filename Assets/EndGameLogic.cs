using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGameLogic : MonoBehaviour
{
    void OnTriggerEnter (Collider Player)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
