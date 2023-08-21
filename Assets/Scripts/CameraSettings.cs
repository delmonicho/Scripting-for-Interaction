using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script creates a new menu item Edit>SceneView Settings>Update Camera Settings in the main menu.
// Use it to update the Camera settings in the Scene view.

using UnityEditor;

public class CameraSettings : MonoBehaviour
{
    [MenuItem("Edit/SceneView Settings/Update Camera Settings")]
    static void UpdateCameraSettings()
    {
        SceneView.CameraSettings settings = new SceneView.CameraSettings();
        settings.accelerationEnabled = false;
        settings.speedMin = 1f;
        settings.speedMax = 10f;
        settings.speed = 5f;
        settings.easingEnabled = true;
        settings.easingDuration = 0.6f;
        settings.dynamicClip = false;
        // settings.fieldOfView = 120f;
        // settings.nearClip = 0.01f;
        // settings.farClip = 1000f;
        settings.occlusionCulling = true;
        SceneView sceneView = SceneView.lastActiveSceneView;
        sceneView.cameraSettings = settings;
    }
}