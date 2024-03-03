using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThePlayer : MonoBehaviour
{
    public static MoveThePlayer instance { get; private set; }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one CustomizeModel in the scene. Destroying newest one.");
            Destroy(this.gameObject);
            return;
        }
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }
}
