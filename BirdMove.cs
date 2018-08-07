using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdMove : MonoBehaviour {

    public float speed;
    public float jumpspeed;
    public float downspeed;
    float down;
    float num = 1;
    float point;
    public Text textpoint;

    public void OnCLick()
    {
        down = -jumpspeed;
    }

    void Die()
    {
        SceneManager.LoadScene("Game");
    }

    void FixedUpdate () {
		if(num == 1)
        {
            down = down + downspeed;
        }
        else if (num == 2)
        {
            down = 0;
        }
        transform.Translate(speed, -down, 0);
    }
    public void OnCollisionEnter2D(Collision2D bird)
    {
        if(bird.gameObject.tag == "Ground")
        {
            Die();
            num = 0;
        }
        if (bird.gameObject.tag == "Pipe")
        {
            Die();
            num = 0;
        }
        if (bird.gameObject.tag == "Point")
        {
            point++;
            textpoint.text = "" + point;
        }
    }
}
