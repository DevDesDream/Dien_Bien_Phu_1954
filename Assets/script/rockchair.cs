
using UnityEngine;

public class rockchair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        male=FindObjectOfType<male1>();
        self=GetComponent<SpriteRenderer>();
    }
    private male1 male;
    private SpriteRenderer self;

    // Update is called once per frame
    void Update()
    {
        male.sitdown+=sitdownlayer;
        male.standup+=standuplayer;
    }
    void sitdownlayer()
    {
      self.sortingOrder=10;
    }
    void standuplayer()
    {
       
        self.sortingOrder=2;
       
    }
}
