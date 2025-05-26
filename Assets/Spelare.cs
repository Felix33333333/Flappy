using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spelare : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField] GameObject loseScreen;
    [SerializeField] TMP_Text text;
    float points;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Hopp");
            rigidbody2D.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
        }
        points += 1 * Time.deltaTime;
        text.text = points.ToString("F0");
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -965, 5), transform.position.z);
        //hoppa
            //åker upp
        //gravitation
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Lose();
    }

    void Lose()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//ladda om samma scen igen
    }
}
