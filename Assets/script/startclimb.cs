
using UnityEngine;

public class startclimb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        self=GetComponent<Transform>();
    }

    // Update is called once per frame
    private Transform self;
    public GameObject[] actibut;
    public GameObject slider;
    void Update()
    {
        if (self.position.x>=35)
        {
            foreach (GameObject obj in actibut){
                obj.GetComponent<SpriteRenderer>().enabled=true;
                actibut[0].GetComponent<butaction>().enabled=true;
                actibut[1].GetComponent<butaction>().enabled=false;
                actibut[2].GetComponent<butaction>().enabled=false;
                actibut[3].GetComponent<butaction>().enabled=false;
            }
            slider.SetActive(true);
            
            
        }
    }
}
