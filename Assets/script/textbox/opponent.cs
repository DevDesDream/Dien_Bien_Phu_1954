
using UnityEngine;

public class opponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     self=GetComponent<SpriteRenderer>();
     box=FindAnyObjectByType<textbox>();   
    }
    private SpriteRenderer self;
    private textbox box;

    // Update is called once per frame
    void Update()
    {
        box.opponent+=show;
        box.opponentdisable+=hide;
    }
    void show()
    {
        self.enabled=true;
        self.sprite=box.dialogue.dialoguelines[box.num].opponentavt;
    }
    void hide()
    {
        self.enabled=false;
    }
}
