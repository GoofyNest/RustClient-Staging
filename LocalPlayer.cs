public static class LocalPlayer // TypeDefIndex: 9665
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static BasePlayer <Entity>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static ulong <LastAttackerSteamID>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static string <LastAttackerName>k__BackingField; // 0x10
	public static float LastDeathTime; // 0x18
	public static PetCommandList.PetCommandDesc CurrentPetCommandDesc; // 0x20
	private static Dictionary<int, int> CraftCounts; // 0x50
	public static LocalPlayer.ItemBlueprintComparer ItemBluePrintOrdered; // 0x58

	// Properties
	public static BasePlayer Entity { get; set; }
	public static ulong LastAttackerSteamID { get; set; }
	public static string LastAttackerName { get; set; }
	public static float TimeSinceLastDeath { get; }
	public static bool isSleeping { get; }
	public static bool isAdmin { get; }
	public static bool isDeveloper { get; }
	public static BasePlayer LocalOrSpectatePlayer { get; }
	public static BasePlayer SpectatePlayer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4FD780 Offset: 0x4FBD80 VA: 0x1804FD780
	public static BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4FE1B0 Offset: 0x4FC7B0 VA: 0x1804FE1B0
	public static void set_Entity(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4FD840 Offset: 0x4FBE40 VA: 0x1804FD840
	public static ulong get_LastAttackerSteamID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4FE280 Offset: 0x4FC880 VA: 0x1804FE280
	public static void set_LastAttackerSteamID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4FD7E0 Offset: 0x4FBDE0 VA: 0x1804FD7E0
	public static string get_LastAttackerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4FE210 Offset: 0x4FC810 VA: 0x1804FE210
	public static void set_LastAttackerName(string value) { }

	// RVA: 0x4FDD80 Offset: 0x4FC380 VA: 0x1804FDD80
	public static float get_TimeSinceLastDeath() { }

	// RVA: 0x4FB9B0 Offset: 0x4F9FB0 VA: 0x1804FB9B0
	public static void EndLooting() { }

	// RVA: 0x4FBD40 Offset: 0x4FA340 VA: 0x1804FBD40
	internal static ItemContainer GetContainer(PlayerInventory.Type type) { }

	// RVA: 0x4FC3E0 Offset: 0x4FA9E0 VA: 0x1804FC3E0
	internal static ItemContainer GetLootContainer(int i) { }

	// RVA: 0x4FD370 Offset: 0x4FB970 VA: 0x1804FD370
	public static void OnInventoryChanged() { }

	// RVA: 0x4FD510 Offset: 0x4FBB10 VA: 0x1804FD510
	public static void OnItemAmountChanged() { }

	// RVA: 0x4FCBF0 Offset: 0x4FB1F0 VA: 0x1804FCBF0
	internal static bool HasUnlocked(ItemDefinition targetItem) { }

	// RVA: 0x4FBF50 Offset: 0x4FA550 VA: 0x1804FBF50
	internal static float GetCraftLevel() { }

	// RVA: 0x4FC610 Offset: 0x4FAC10 VA: 0x1804FC610
	internal static bool HasCraftLevel(int levelReq) { }

	// RVA: 0x4FD1F0 Offset: 0x4FB7F0 VA: 0x1804FD1F0
	public static void MoveItem(uint itemid, uint targetContainer, int targetSlot, int amount) { }

	// RVA: 0x4FB760 Offset: 0x4F9D60 VA: 0x1804FB760
	public static void DropItemStack(uint itemid) { }

	// RVA: 0x4FB940 Offset: 0x4F9F40 VA: 0x1804FB940
	public static void DropItem(uint itemid, int count) { }

	// RVA: 0x4FCD40 Offset: 0x4FB340 VA: 0x1804FCD40
	public static void ItemCommand(uint itemid, string command) { }

	// RVA: -1 Offset: -1
	public static void ItemCommandEx<T1>(uint itemid, string command, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1574BC0 Offset: 0x15731C0 VA: 0x181574BC0
	|-LocalPlayer.ItemCommandEx<int>
	|
	|-RVA: 0x1574D70 Offset: 0x1573370 VA: 0x181574D70
	|-LocalPlayer.ItemCommandEx<object>
	*/

	// RVA: 0x4FE070 Offset: 0x4FC670 VA: 0x1804FE070
	public static bool get_isSleeping() { }

	// RVA: 0x4FDDF0 Offset: 0x4FC3F0 VA: 0x1804FDDF0
	public static bool get_isAdmin() { }

	// RVA: 0x4FDF30 Offset: 0x4FC530 VA: 0x1804FDF30
	public static bool get_isDeveloper() { }

	// RVA: 0x4FBBC0 Offset: 0x4FA1C0 VA: 0x1804FBBC0
	public static void FindAmmo(List<Item> list, AmmoTypes ammo) { }

	// RVA: 0x4FD080 Offset: 0x4FB680 VA: 0x1804FD080
	public static void ModifyCamera() { }

	// RVA: 0x4FC9A0 Offset: 0x4FAFA0 VA: 0x1804FC9A0
	public static bool HasItems(List<ItemAmount> list, int amount = 1) { }

	// RVA: 0x4FC1C0 Offset: 0x4FA7C0 VA: 0x1804FC1C0
	public static int GetItemAmount(ItemDefinition item) { }

	// RVA: 0x4FB0A0 Offset: 0x4F96A0 VA: 0x1804FB0A0
	public static string BuildItemRequiredString(List<ItemAmount> list) { }

	// RVA: 0x4FC670 Offset: 0x4FAC70 VA: 0x1804FC670
	public static bool HasInventoryItem(int id) { }

	// RVA: 0x4FD560 Offset: 0x4FBB60 VA: 0x1804FD560
	public static void ResetCraftCounts() { }

	// RVA: 0x4FCEE0 Offset: 0x4FB4E0 VA: 0x1804FCEE0
	public static void ListCraftCounts() { }

	// RVA: 0x4FBDF0 Offset: 0x4FA3F0 VA: 0x1804FBDF0
	public static int GetCraftCount(ItemBlueprint x) { }

	// RVA: 0x4FAFC0 Offset: 0x4F95C0 VA: 0x1804FAFC0
	public static void AddCraftCount(ItemBlueprint x) { }

	// RVA: 0x4FD8A0 Offset: 0x4FBEA0 VA: 0x1804FD8A0
	public static BasePlayer get_LocalOrSpectatePlayer() { }

	// RVA: 0x4FD9C0 Offset: 0x4FBFC0 VA: 0x1804FD9C0
	public static BasePlayer get_SpectatePlayer() { }

	// RVA: 0x4FD6D0 Offset: 0x4FBCD0 VA: 0x1804FD6D0
	private static void .cctor() { }

}

public class LocalPlayer.ItemBlueprintComparer : IComparer<ItemBlueprint> // TypeDefIndex: 9666
{	// Methods

	// RVA: 0x4EF3C0 Offset: 0x4ED9C0 VA: 0x1804EF3C0 Slot: 4
	public int Compare(ItemBlueprint a, ItemBlueprint b) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class LocalPlayer.<>c__DisplayClass40_0 // TypeDefIndex: 9667
{	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x50BF70 Offset: 0x50A570 VA: 0x18050BF70
	internal bool <HasInventoryItem>b__0(IPlayerItem x) { }

}

