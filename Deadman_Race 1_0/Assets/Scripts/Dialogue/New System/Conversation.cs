﻿
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(2, 5)]
    public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation/Intros")]
public class Conversation : ScriptableObject
{
    public Character speakerLeft;
    public Character speakerRight;
    public Line[] lines;
    public Question question;
    public Conversation nextConversation;
}
