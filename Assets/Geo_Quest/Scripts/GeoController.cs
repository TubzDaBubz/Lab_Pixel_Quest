using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D RB;
    public int SPD = 7;
    public string nextLevel = "L2";
    public string falseLevel = "L1";

    // Start is called before the first frame update
    void Start()
    {
         RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(xinput*SPD, RB.velocity.y);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "FalseCheck":
                {
                    SceneManager.LoadScene(falseLevel);
                    break;
                }
        }
    }
}