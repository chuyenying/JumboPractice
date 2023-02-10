using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour // Reference to UI
{
    [Header("Class")]   //另一個model
    private Player player = new Player();
    private People people = new People();
    private Monster monster = new Monster();

    [Header("PlayerButton")]
    public Button Player_Talk;
    [SerializeField] public  Button Player_Hurt;
    [SerializeField] public  Button Player_Attack;
    [SerializeField] public Button Player_Conversaction;

    [Header("PeopleButton")]
    [SerializeField] private Button people_Talk;
    [SerializeField] private Button people_Hurt;
    [SerializeField] private Button people_Conversaction;

    [Header("PlayerButton")]
    [SerializeField] private Button monster_Talk;
    [SerializeField] private Button monster_Hurt;
    [SerializeField] private Button monster_Attack;

}
