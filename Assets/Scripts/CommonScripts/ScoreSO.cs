/**
 * Creating a Score Scriptable object
 * Scriptable objects are preserved across scenes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ScoreSO : ScriptableObject
{
    public int curScore = 0;
}
