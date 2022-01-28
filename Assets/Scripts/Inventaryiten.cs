using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum type
{
    food,
    medicine,
    weapon,
}

public class Inventaryiten : ScriptableObject
{
    public string id;
    public string name;
    public Sprite icon;
    public string info;

    public type type;
    public bool isAFood;
    public bool isAcumulativeble;
    public int maxAcumulation;
    [HideInInspector] public int numberOf;
}
