using UnityEngine;

public class ThrowUI : MonoBehaviour
{
    public int selected;
    public GameObject higlightRed;
    public GameObject higlightBlue;
    public GameObject higlightGreen;

    public GameObject UiTest;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selected += (int)Input.mouseScrollDelta.y;
        print("Selected" + selected);



        if (selected > 2)
        {
            selected = 0;
        }

        if (selected < 0)
        {
            selected = 2;
        }



        switch (selected)
        {



            case 0:
                higlightRed.SetActive(true);
                higlightGreen.SetActive(false);
                higlightBlue.SetActive(false);
                break;
            case 1:
                higlightRed.SetActive(false);
                higlightGreen.SetActive(true);
                higlightBlue.SetActive(false);
                break;
            case 2:
                higlightRed.SetActive(false);
                higlightGreen.SetActive(false);
                higlightBlue.SetActive(true);
                break;





        }
    }
    public void ShowUITest()
    {
        UiTest.SetActive(true);
    }
    public void HideUITest()
    {
        UiTest.SetActive(false);
    }
}

