
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        start=Time.time;
        layer=GetComponent<SpriteRenderer>();
        layer.sortingOrder=-2;
    }
    public float timeeventenable;
    private float start;
    private SpriteRenderer layer;

    // Update is called once per frame
    void Update()
    {
        if(Time.time-start>timeeventenable)
        {
         if (Input.GetKeyDown(KeyCode.F))
         {
              SceneManager.LoadScene("scene 3");
         }
         layer.sortingOrder=10;
        }
    }
}
