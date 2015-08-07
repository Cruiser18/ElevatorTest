using UnityEngine;
using System.Collections;

public interface Observer {

    void onNotify(GameObject gameObject, Event myEvent);
}
