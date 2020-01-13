using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class VectorValue : ScriptableObject, ISerializationCallbackReceiver
{
    [Header("Value in Running")]
    public Vector2 initialValue;
    [Header("Value by Default when starting")]
    public Vector2 defaultValue;

    public void OnAfterDeserialize() { initialValue = defaultValue; }
    public void OnBeforeSerialize() { }
}
