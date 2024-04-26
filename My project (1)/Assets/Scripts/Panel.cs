using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class Panel : MonoBehaviour
{
    public Image pan;
    public List<GameObject> buttons;
    void Start()
    {
        buttons = new List<GameObject> {GameObject.Find("1"), GameObject.Find("2") , GameObject.Find("3") };
    }
    public void OnPointerClick()
    {
        Destroy(EventSystem.current.currentSelectedGameObject);
        for (int i = buttons.Count ; i > int.Parse(EventSystem.current.currentSelectedGameObject.name); i--)
        {
            string nextelem = (i - 1).ToString();
            Debug.Log(nextelem);
            pan = GameObject.Find(nextelem).GetComponent<Image>();
            string curel = i.ToString();
            Debug.Log(curel);
            GameObject.Find(curel).GetComponent<Image>().transform.position = pan.transform.position;
        }
    }
}
