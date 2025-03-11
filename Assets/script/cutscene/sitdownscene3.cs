
using UnityEngine;
using UnityEngine.Playables;

public class sitdownscene3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sitdownscene.stopped+=onstopcutscene;
    }

    // Update is called once per frame
    public PlayableDirector sitdownscene;
    public float first=1;
    public male1 male;
    void Update()
    {
        if (first>0)
        {
        male.standup+=playcutscene;
        }
        else{
            male.standup-=playcutscene;
        }
    }
    void playcutscene()
    {
        male.enabled=false;
        sitdownscene.Play();
        first-=1;
    }
    void onstopcutscene(PlayableDirector director)
    {
      male.enabled=true;

    }
}
