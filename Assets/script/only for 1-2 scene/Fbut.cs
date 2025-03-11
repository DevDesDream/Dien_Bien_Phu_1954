
using UnityEngine;

public class Fbut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        self=this.gameObject;
        male.disable+=disablebutton;
        male.canoninterract+=canon;
    }

    // Update is called once per frame
    public Transform player;
    private GameObject self;
    public male1 male;
    public textbox box;
    public GameObject[] obj;
    public int i;
    void Update()
    {
        Debug.Log(box.dialogue.dialoguelines.Count+" " +box.num);
        
    }
    void disablebutton()
    {
        self.SetActive(false);
    }
    void canon()
    {
     self.SetActive(true);
     if(box.dialogue.dialoguelines.Count<=box.num)
        {
            male.eventtime=false;
            box.num=0;
            obj[i].SetActive(false);
        }
    }
     
}
