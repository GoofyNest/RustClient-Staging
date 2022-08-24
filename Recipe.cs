public class Recipe : ScriptableObject // TypeDefIndex: 10756
{	[HeaderAttribute] // RVA: 0x78600 Offset: 0x77A00 VA: 0x180078600
	public ItemDefinition ProducedItem; // 0x18
	public int ProducedItemCount; // 0x20
	public bool CanQueueMultiple; // 0x24
	[HeaderAttribute] // RVA: 0x787B0 Offset: 0x77BB0 VA: 0x1800787B0
	public GameObjectRef SpawnedItem; // 0x28
	public string SpawnedItemName; // 0x30
	public string SpawnedItemDescription; // 0x38
	public Sprite SpawnedItemIcon; // 0x40
	[HeaderAttribute] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
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

public struct Recipe.RecipeIngredient // TypeDefIndex: 10757
{	public ItemDefinition Ingredient; // 0x0
	public int Count; // 0x8

}

