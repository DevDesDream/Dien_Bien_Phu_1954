
using UnityEngine;
using UnityEngine.SceneManagement;

public class thaoday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public canonwarning canon;
    public bool incutscene=false;
    public bool nextscene=false;

    // Update is called once per frame
    void Update()
    {
        if (incutscene==true){
            foreach (GameObject obj in canon.grab){
                  obj.GetComponent<grabRope>().enabled=false;
                  obj.GetComponent<BoxCollider2D>().enabled=true;
                  obj.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Dynamic;
                }
        }
        if (nextscene==true){
            SceneManager.LoadScene("scene 5");
        }
    }
}
