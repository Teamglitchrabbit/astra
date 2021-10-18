using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AbilityDisplay1 : MonoBehaviour
{
    public MenuTag1 Tag1;
    public MenuTag1 Tag2;
    public MenuTag1 Tag3;
    public MenuTag1 Tag4;
    public MenuTag1 Tag5;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI desText;
    public Image AbilityImage;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = Tag1.abilityName;
        desText.text = Tag1.abilityDescription;

        AbilityImage.sprite = Tag1.abilitySprite;
    }

    public void Set1()
    {
        nameText.text = Tag1.abilityName;
        desText.text = Tag1.abilityDescription;

        AbilityImage.sprite = Tag1.abilitySprite;
    }

    public void Set2()
    {
        nameText.text = Tag2.abilityName;
        desText.text = Tag2.abilityDescription;

        AbilityImage.sprite = Tag2.abilitySprite;
    }

    public void Set3()
    {
        nameText.text = Tag3.abilityName;
        desText.text = Tag3.abilityDescription;

        AbilityImage.sprite = Tag3.abilitySprite;
    }

    public void Set4()
    {
        nameText.text = Tag4.abilityName;
        desText.text = Tag4.abilityDescription;

        AbilityImage.sprite = Tag4.abilitySprite;
    }

    public void Set5()
    {
        nameText.text = Tag5.abilityName;
        desText.text = Tag5.abilityDescription;

        AbilityImage.sprite = Tag5.abilitySprite;
    }
}
