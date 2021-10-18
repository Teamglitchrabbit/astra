using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAbility", menuName = "Ability Tag")]
public class MenuTag1 : ScriptableObject
{
    public string abilityName;
    public string abilityDescription;

    public Sprite abilitySprite;
}
