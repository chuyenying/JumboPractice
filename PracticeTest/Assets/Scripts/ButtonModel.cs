using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonModel : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private Button Player_Talk;
    [SerializeField] private Button Player_Hurt;
    [SerializeField] private Button Player_Attack;
    [SerializeField] private Button Player_Conversaction;

    [Header("People")]
    [SerializeField] private Button People_Talk;
    [SerializeField] private Button People_Hurt;
    [SerializeField] private Button People_Conversaction;

    [Header("Monster")]
    [SerializeField] private Button Monster_Talk;
    [SerializeField] private Button Monster_Hurt;
    [SerializeField] private Button Monster_Attack;


}
