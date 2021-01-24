﻿using UnityEngine;
using UnityEngine.Localization;
// Created with collaboration from:
// https://forum.unity.com/threads/inventory-system.980646/

public enum TabType
{
	customization,
	cookingItem,
	recipe,
	none

}
[CreateAssetMenu(fileName = "tabType", menuName = "Inventory/tabType", order = 51)]
public class InventoryTabType : ScriptableObject
{
	[Tooltip("The tab Name that will be displayed in the inventory")]
	[SerializeField]
	private LocalizedString _tabName;


	[Tooltip("The tab type used to reference the item")]
	[SerializeField] private TabType _tabType;

	public LocalizedString TabName => _tabName;
	public TabType TabType => _tabType;
}
