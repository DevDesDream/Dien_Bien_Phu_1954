
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;


public class timecd : MonoBehaviour
{
    private float time;
    
    public float duration;
    public Color[] change;
    public GameObject heartbeat;
    public GameObject[] but;
    public PlayableDirector next;
    public Sprite[] aswd;
    public canonwarning canon;
    public Transform canonobj;
    public Slider value;
    public SpriteRenderer but4;
    public pullcanon pullcanon;
    // Start is called before the first frame update
    public void setup()
    {
        pullcanon.timecount=pullcanon.starttime;
        foreach(GameObject butl in but){
                    but[0].GetComponent<butaction>().enabled=true;
                    but[1].GetComponent<butaction>().enabled=false;
                    but[2].GetComponent<butaction>().enabled=false;
                    but[3].GetComponent<butaction>().enabled=false;
                    time=0;
                    butl.GetComponent<SpriteRenderer>().sprite=aswd[Random.Range(0,3)];
                    butl.GetComponent<SpriteRenderer>().color=change[1];
                }
        canon.enabled=false;
    }
     public GameObject space;
    // Update is called once per frame
    void Update()
    {
        if  (canonobj.position.x>50){
            canon.turnoff();
            next.Play();
    
        }
        canon.time=0;
        if (time>duration&&but4.color!=GameObject.Find("but4").GetComponent<butaction>().change[0]){
            time=0;
            canon.live--;
            heartbeat.SetActive(true);
            canon.enabled=true;
            space.SetActive(true);
            canon.turnoff();
        }
        else{
            time+=Time.deltaTime;
        value.value=1-time/duration;
        }
        if (but4.color==GameObject.Find("but4").GetComponent<butaction>().change[0]){
                foreach(GameObject butl in but){
                    but[0].GetComponent<butaction>().enabled=true;
                    but[1].GetComponent<butaction>().enabled=false;
                    but[2].GetComponent<butaction>().enabled=false;
                    but[3].GetComponent<butaction>().enabled=false;
                    time=0;
                    butl.GetComponent<SpriteRenderer>().sprite=aswd[Random.Range(0,4)];
                    butl.GetComponent<SpriteRenderer>().color=change[1];
                }
            }
    }
}
