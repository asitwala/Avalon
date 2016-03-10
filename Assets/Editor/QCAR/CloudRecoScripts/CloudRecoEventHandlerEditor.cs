/*==============================================================================
Copyright (c) 2015 PTC Inc. All Rights Reserved.

Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.  
==============================================================================*/

using UnityEditor;
using UnityEngine;
using Vuforia;

/// <summary>
/// This editor class renders the custom inspector for the CloudRecoEventHandler MonoBehaviour
/// </summary>
[CustomEditor(typeof(CloudRecoEventHandler))]
public class CloudRecoEventHandlerEditor : Editor
{
    #region UNITY_EDITOR_METHODS

    /// <summary>
    /// Draws a custom UI for the cloud reco event handler inspector
    /// </summary>
    public override void OnInspectorGUI()
    {
        // record potential changes for this object
        Undo.RecordObject(target, "Inspector Change");

        CloudRecoEventHandler crehb = (CloudRecoEventHandler)target;

        EditorGUILayout.HelpBox("Here you can set the ImageTargetBehaviour from the scene that will be used to augment new cloud reco search results.", MessageType.Info);
        bool allowSceneObjects = !EditorUtility.IsPersistent(target);
        crehb.ImageTargetTemplate = (ImageTargetBehaviour)EditorGUILayout.ObjectField("Image Target Template",
                                                    crehb.ImageTargetTemplate, typeof(ImageTargetBehaviour), allowSceneObjects);



        if (GUI.changed)
            EditorUtility.SetDirty(crehb);
    }

    #endregion // UNITY_EDITOR_METHODS
}
