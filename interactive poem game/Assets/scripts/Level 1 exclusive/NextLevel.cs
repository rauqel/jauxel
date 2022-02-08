using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    float levelTimer;

    public ObstacleMovement2 death;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        levelTimer += Time.deltaTime;
        Debug.Log(levelTimer);
        if((levelTimer >= 20.0f && levelTimer <= 20.5f) && !death.isDead)
        {
            SceneManager.LoadScene("Level 2");
            FadeToLevel(2);
        }
    }

    public void FadeToLevel (int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }
}
