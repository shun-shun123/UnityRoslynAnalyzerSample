using MessagePack;
using UnityEngine;

public class MpcSampleCode : MonoBehaviour
{
}

[MessagePackObject]
public class MyClass
{
    [Key(0)]
    public int _MyProperty;
}
