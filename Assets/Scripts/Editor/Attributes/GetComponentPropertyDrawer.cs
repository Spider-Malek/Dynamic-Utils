﻿using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(GetComponentAttribute))]
public class GetComponentPropertyDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		GUI.enabled = false;
		EditorGUI.PropertyField(position, property, label);
		GUI.enabled = true;
	}
}
