
using UnityEngine;

public class SWbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        self=this.gameObject;
        male.sitdown+=sit;
        male.standup+=stand;
        male.disable+=disablebutton;
    }

    // Update is called once per frame
    public Transform player;
    private GameObject self;
    public male1 male;
    public Sprite w;
    public Sprite s;
    public textbox box;
    public GameObject[] obj;
    public int i;
    void Update()
    {
        
    }
    void sit()
    {
     self.SetActive(true);
     self.GetComponent<SpriteRenderer>().sprite=s;
    }
    void stand()
    {
     self.SetActive(true);
     self.GetComponent<SpriteRenderer>().sprite=w;
    }
    void disablebutton()
    {
        self.SetActive(false);
    }
    
     
}
