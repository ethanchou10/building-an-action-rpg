using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedObjectiveTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        Messenger.Broadcast(GameEvent.LEVEL_FAILED);
    }
}
