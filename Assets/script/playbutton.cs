
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loading(string load)
    {
        SceneManager.LoadScene("scene 1");
    }
}
