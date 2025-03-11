
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class NextSceneScene3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        nextscene.stopped+=next;
    }

    // Update is called once per frame
    public PlayableDirector nextscene;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
           nextscene.Play();
        }
        
    }
    void next(PlayableDirector director)
    {
     SceneManager.LoadScene("scene 4");
    }
}
