
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {self=GetComponent<SpriteRenderer>();
        box=FindAnyObjectByType<textbox>();
    }

    // Update is called once per frame
    private textbox box;
    private SpriteRenderer self;
    void Update()
    {
        box.main+=show;
        box.maindisable+=hide;
    }
    void show()
    {
        self.enabled=true;
        self.sprite=box.dialogue.dialoguelines[box.num].mainavt;
    }
    void hide()
    {
        self.enabled=false;
    }
    
}
