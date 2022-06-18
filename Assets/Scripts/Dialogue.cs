using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Sentence
{
    public string name;
    public string text;
}

public class Dialogue
{
    public Sentence[] Sentences;
}
