using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeGame : MonoBehaviour {
    int waitTime;
    float startTime;
    float delay = 3;
    bool roundStarted;

    // Start is called before the first frame update
    void Start() {
        print("Press the spacebar once you think time is up.");
        GenerateTime();
    }

    // Update is called once per frame
    void Update() {
        if (roundStarted && Input.GetKeyDown(KeyCode.Space)) {
            InputResponse();
        }
    }

    // Determine if player won game.
    void InputResponse() {
        roundStarted = false;
        float playerWaitTime = Time.time - startTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        string message = "";
        if (error < 0.15f) {
            message = "Awesome!";
        } else if (error < 0.75f) {
            message = "Decent.";
        } else if (error < 1.25f) {
            message = "Okay.";
        } else if (error < 1.75f) {
            message = "Quite bad.";
        } else {
            message = "Awful. :(";
        }

        print(message + " You waited " + playerWaitTime + " seconds. This is " + error + " seconds off.");
        Invoke("GenerateTime", delay);
    }

    // Choose a random time
    void GenerateTime() {
        waitTime = Random.Range(0, 21);
        startTime = Time.time;
        roundStarted = true;

        print(waitTime + " seconds.");

    }
}
