using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    public Text displayBox;
    public int qteGen;
    public int waitingForKey = 1;
    public int correctKey;
    public int countingDown;

    private void Update()
    {
        if (waitingForKey == 0)
        {
            countingDown = 1;

            StartCoroutine(CountingDown());

            switch (qteGen)
            {
                case 1:
                    waitingForKey = 1;
                    displayBox.text = "[Q]";
                    break;

                case 2:
                    waitingForKey = 1;
                    displayBox.text = "[W]";
                    break;

                case 3:
                    waitingForKey = 1;
                    displayBox.text = "[E]";
                    break;

                case 4:
                    waitingForKey = 1;
                    displayBox.text = "[R]";
                    break;

                case 5:
                    waitingForKey = 1;
                    displayBox.text = "[T]";
                    break;

                default:
                    break;
            }
        }

        if (Input.anyKeyDown)
        {
            switch (qteGen)
            {
                case 1:
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        correctKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        correctKey = 2;
                        StartCoroutine(KeyPressing());
                    }
                    break;

                case 2:
                    if (Input.GetKeyDown(KeyCode.W))
                    {
                        correctKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        correctKey = 2;
                        StartCoroutine(KeyPressing());
                    }
                    break;

                case 3:
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        correctKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        correctKey = 2;
                        StartCoroutine(KeyPressing());
                    }
                    break;

                case 4:
                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        correctKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        correctKey = 2;
                        StartCoroutine(KeyPressing());
                    }
                    break;

                case 5:
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        correctKey = 1;
                        StartCoroutine(KeyPressing());
                    }
                    else
                    {
                        correctKey = 2;
                        StartCoroutine(KeyPressing());
                    }
                    break;
            }
        }
    }

    public void StartQTE(KeyCode key)
    {
        switch (key)
        {
            case KeyCode.Q:
                qteGen = 1;
                break;

            case KeyCode.W:
                qteGen = 2;
                break;

            case KeyCode.E:
                qteGen = 3;
                break;

            case KeyCode.R:
                qteGen = 4;
                break;

            case KeyCode.T:
                qteGen = 5;
                break;
        }
    }

    IEnumerator KeyPressing()
    {
        StopCoroutine(CountingDown());
        qteGen = 4;

        if (correctKey == 1)
        {
            countingDown = 2;
            Debug.Log("Pass");
        }
        else if (correctKey == 2)
        {
            countingDown = 2;
            Debug.Log("Fail");
        }

        yield return new WaitForSeconds(1.5f);
        correctKey = 0;
        displayBox.text = "";
        yield return new WaitForSeconds(1.5f);
        waitingForKey = 1;
        countingDown = 1;
    }

    IEnumerator CountingDown()
    {
        yield return new WaitForSeconds(5f);

        if (countingDown == 1)
        {
            qteGen = 4;
            countingDown = 2;
            Debug.Log("Fail");
            yield return new WaitForSeconds(1.5f);
            correctKey = 0;
            displayBox.text = "";
            yield return new WaitForSeconds(1.5f);
            waitingForKey = 1;
            countingDown = 1;
        }
    }
}
