using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
    public Animator transition;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadLevel(int level) 
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        switch (level)
        {
            case 2:
                SceneManager.LoadScene("Tutorial");
                break;
            case 3:
                SceneManager.LoadScene("AnimTutorial");
                break;
            case 4:
                SceneManager.LoadScene("ColorPick");
                break;
            case 5:
                SceneManager.LoadScene("Painter");
                break;
        }

    }

    public void TransitionAn(int level)
    {
        StartCoroutine(LoadLevel(level));
    }
}
