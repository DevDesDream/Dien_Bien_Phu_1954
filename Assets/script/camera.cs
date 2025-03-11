
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Male=FindObjectOfType<male>();
    }

    // Update is called once per frame
     public male Male;
    public Animator Camera;
    public float timeevent=0;
    void Update()
    {
      if (Male.eventtime==false)
      {
       Camera.SetInteger("scenedetect",-1);
      }
      else
      {
      
       //event scene 1
       if (SceneManager.GetActiveScene().buildIndex==1)
       {
        Camera.SetInteger("scenedetect",1);
        if (timeevent==0)
        {
          timeevent=Time.time;
        }
        if (Time.time-timeevent>5)
        {
          SceneManager.LoadScene("scene 2");
        }
       }
      }
    }
}
