using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    // Use this for initialization
    public float speed;
    private Rigidbody rb;
    public Text countText;
    public Text wintext;

    private int score;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        setCountText();
        wintext.text = "";
    }
    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0,moveVertical);
        rb.AddForce(movement*speed);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) {
            score = score + 1;
            other.gameObject.SetActive(false);
            setCountText();
        }
    }
    void setCountText() {
        countText.text = "Score: " + score.ToString();
        if (score >= 13) {
            wintext.text = "You Win";
        }
    }
}
