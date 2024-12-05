using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Target[] targets;
    private int[] hpValues;

    // finds the objects with the target 
    private void Start()
    {
        targets = FindObjectsOfType<Target>();
        hpValues = new int[targets.Length];
        for (int i = 0; i < targets.Length; i++)
        {
            hpValues[i] = targets[i].GetHealthPoints();
        }

        BubbleSortArray(hpValues);
    }
    // sorts enemies from the lowest to hieghtest health
        void BubbleSortArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - i; i++)
            {
                for (int j = 0; j < n - i - 1; i++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
        }
    // allows for the serach of a specfic value
        public int[] GetSortHPValues()
        {
            return hpValues; 
        }

    }

