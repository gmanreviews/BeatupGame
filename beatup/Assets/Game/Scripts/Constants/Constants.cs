using UnityEngine;

[CreateAssetMenu(fileName = "Constants", menuName = "Constants")]
public class Constants : ScriptableObject
{
    [Header("Animator Triggers")]
    public string LeftTrigger = "left";
    public string RightTrigger = "right";
    public string UpTrigger = "up";
    public string DownTrigger = "down";
}
