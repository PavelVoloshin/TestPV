using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    public GameObject Panel, Content;
    public Button MainBtn, CloseBtn;
    public void onPlayClicks()
    {
        Panel.GetComponent<Image>().enabled = true;
        foreach (Transform child in Panel.transform)
        {
            child.GetComponent<Image>().enabled = true;
        }
        foreach (Transform child in Content.transform)
        {
            child.GetComponent<Image>().enabled = true;
        }
        CloseBtn.interactable = true;
    }
    public void onCloseClicks()
    {
        Panel.GetComponent<Image>().enabled = false;
        foreach (Transform child in Panel.transform)
        {
            child.GetComponent<Image>().enabled = false;
        }
        foreach (Transform child in Content.transform)
        {
            child.GetComponent<Image>().enabled = false;
        }
        CloseBtn.interactable = false;
    }
}
