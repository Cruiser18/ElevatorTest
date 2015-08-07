using UnityEngine;
using System.Collections;

public class Event : ScriptableObject {

    public int eventType { get; set; }

    public enum events
    {
        buttonClicked
    }
}
