using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    float jumpForce = 20.0f;
    float speed = 2.0f;
    float maxSpeed = 8.0f;

    public bool grounded = false;

    bool right = false;
    bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
            CheckInputs();

        if (right)
        {
            if (rb.velocity.x < maxSpeed)
            {
                rb.velocity += new Vector2(speed, 0);
            }
        }
        else if (left)
        {
            if (rb.velocity.x > -maxSpeed)
            {
                rb.velocity += new Vector2(-speed, 0);
            }
        }
    }
    
    void OnDestroy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void CheckInputs()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        if (Input.GetButtonDown("Left"))
        {
            LeftDown();
        }
        if (Input.GetButtonUp("Left"))
        {
            LeftUp();
        }
        if (Input.GetButtonDown("Right"))
        {
            RightDown();
        }
        if (Input.GetButtonUp("Right"))
        {
            RightUp();
        }
    }

    public void RightDown()
    {
        right = true;
    }

    public void RightUp()
    {
        right = false;
    }

    public void LeftDown()
    {
        left = true;
    }

    public void LeftUp()
    {
        left = false;
    }

    public void Jump()
    {
        if (grounded)
        {
            rb.velocity += new Vector2(0, jumpForce);
            grounded = false;
        }
    }
}
