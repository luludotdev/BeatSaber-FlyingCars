using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;
using IllusionPlugin;

namespace FlyingCarEnabler
{
    public class Enabler : MonoBehaviour
    {
        public static Enabler Instance = null;
        float carTime = 0;

        public static void OnLoad()
        {
            if (Instance != null) return;
            new GameObject("Flying Car Enabler").AddComponent<Enabler>();
        }
    }

    public void Update()
    {
        Debug.Log("Whee");
    }
}
