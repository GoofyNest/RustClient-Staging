public class Recipe : ScriptableObject // TypeDefIndex: 10752
{	[HeaderAttribute] // RVA: 0x78380 Offset: 0x77780 VA: 0x180078380
	public ItemDefinition ProducedItem; // 0x18
	public int ProducedItemCount; // 0x20
	public bool CanQueueMultiple; // 0x24
	[HeaderAttribute] // RVA: 0x784E0 Offset: 0x778E0 VA: 0x1800784E0
	public GameObjectRef SpawnedItem; // 0x28
	public string SpawnedItemName; // 0x30
	public string SpawnedItemDescription; // 0x38
	public Sprite SpawnedItemIcon; // 0x40
	[HeaderAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
	public bool RequiresBlueprint; // 0x48
	public Recipe.RecipeIngredient[] Ingredients; // 0x50
	public float MixingDuration; // 0x58

	public string DisplayName { get; }
	public string DisplayDescription { get; }
	public Sprite DisplayIcon { get; }


	public string get_DisplayName() { }

	public string get_DisplayDescription() { }

	public Sprite get_DisplayIcon() { }

	public bool ContainsItem(Item item) { }

	public void .ctor() { }

}

public struct Recipe.RecipeIngredient // TypeDefIndex: 10753
{	public ItemDefinition Ingredient; // 0x0
	public int Count; // 0x8

}

