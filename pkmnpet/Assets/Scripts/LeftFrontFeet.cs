using UnityEngine;

public class LeftFrontFeet : MonoBehaviour
{
    private Animator anim;
    private string state;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        state = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (state == "RAISE")
        {
            anim.SetBool("Raise", true);
            anim.SetBool("Open", false);
            state = "";

        }
        else if (state == "OPEN")
        {
            anim.SetBool("Open", true);
            anim.SetBool("Raise", false);
            state = "";

        }

    }

    void OnMouseDown()
    {
        Debug.Log("uhh");
        if (state == "")
        {
            state = "RAISE";
        }
        else if (state == "RAISE")
        {
            state = "OPEN";
        }
        
    }
    

}
