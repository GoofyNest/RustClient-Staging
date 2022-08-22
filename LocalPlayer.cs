public static class LocalPlayer // TypeDefIndex: 9665
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static BasePlayer <Entity>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static ulong <LastAttackerSteamID>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FD710 Offset: 0x4FBD10 VA: 0x1804FD710
	public static BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FE140 Offset: 0x4FC740 VA: 0x1804FE140
	public static void set_Entity(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FD7D0 Offset: 0x4FBDD0 VA: 0x1804FD7D0
	public static ulong get_LastAttackerSteamID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FE210 Offset: 0x4FC810 VA: 0x1804FE210
	public static void set_LastAttackerSteamID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FD770 Offset: 0x4FBD70 VA: 0x1804FD770
	public static string get_LastAttackerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FE1A0 Offset: 0x4FC7A0 VA: 0x1804FE1A0
	public static void set_LastAttackerName(string value) { }

	// RVA: 0x4FDD10 Offset: 0x4FC310 VA: 0x1804FDD10
	public static float get_TimeSinceLastDeath() { }

	// RVA: 0x4FB940 Offset: 0x4F9F40 VA: 0x1804FB940
	public static void EndLooting() { }

	// RVA: 0x4FBCD0 Offset: 0x4FA2D0 VA: 0x1804FBCD0
	internal static ItemContainer GetContainer(PlayerInventory.Type type) { }

	// RVA: 0x4FC370 Offset: 0x4FA970 VA: 0x1804FC370
	internal static ItemContainer GetLootContainer(int i) { }

	// RVA: 0x4FD300 Offset: 0x4FB900 VA: 0x1804FD300
	public static void OnInventoryChanged() { }

	// RVA: 0x4FD4A0 Offset: 0x4FBAA0 VA: 0x1804FD4A0
	public static void OnItemAmountChanged() { }

	// RVA: 0x4FCB80 Offset: 0x4FB180 VA: 0x1804FCB80
	internal static bool HasUnlocked(ItemDefinition targetItem) { }

	// RVA: 0x4FBEE0 Offset: 0x4FA4E0 VA: 0x1804FBEE0
	internal static float GetCraftLevel() { }

	// RVA: 0x4FC5A0 Offset: 0x4FABA0 VA: 0x1804FC5A0
	internal static bool HasCraftLevel(int levelReq) { }

	// RVA: 0x4FD180 Offset: 0x4FB780 VA: 0x1804FD180
	public static void MoveItem(uint itemid, uint targetContainer, int targetSlot, int amount) { }

	// RVA: 0x4FB6F0 Offset: 0x4F9CF0 VA: 0x1804FB6F0
	public static void DropItemStack(uint itemid) { }

	// RVA: 0x4FB8D0 Offset: 0x4F9ED0 VA: 0x1804FB8D0
	public static void DropItem(uint itemid, int count) { }

	// RVA: 0x4FCCD0 Offset: 0x4FB2D0 VA: 0x1804FCCD0
	public static void ItemCommand(uint itemid, string command) { }

	// RVA: -1 Offset: -1
	public static void ItemCommandEx<T1>(uint itemid, string command, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573F50 Offset: 0x1572550 VA: 0x181573F50
	|-LocalPlayer.ItemCommandEx<int>
	|
	|-RVA: 0x1574100 Offset: 0x1572700 VA: 0x181574100
	|-LocalPlayer.ItemCommandEx<object>
	*/

	// RVA: 0x4FE000 Offset: 0x4FC600 VA: 0x1804FE000
	public static bool get_isSleeping() { }

	// RVA: 0x4FDD80 Offset: 0x4FC380 VA: 0x1804FDD80
	public static bool get_isAdmin() { }

	// RVA: 0x4FDEC0 Offset: 0x4FC4C0 VA: 0x1804FDEC0
	public static bool get_isDeveloper() { }

	// RVA: 0x4FBB50 Offset: 0x4FA150 VA: 0x1804FBB50
	public static void FindAmmo(List<Item> list, AmmoTypes ammo) { }

	// RVA: 0x4FD010 Offset: 0x4FB610 VA: 0x1804FD010
	public static void ModifyCamera() { }

	// RVA: 0x4FC930 Offset: 0x4FAF30 VA: 0x1804FC930
	public static bool HasItems(List<ItemAmount> list, int amount = 1) { }

	// RVA: 0x4FC150 Offset: 0x4FA750 VA: 0x1804FC150
	public static int GetItemAmount(ItemDefinition item) { }

	// RVA: 0x4FB030 Offset: 0x4F9630 VA: 0x1804FB030
	public static string BuildItemRequiredString(List<ItemAmount> list) { }

	// RVA: 0x4FC600 Offset: 0x4FAC00 VA: 0x1804FC600
	public static bool HasInventoryItem(int id) { }

	// RVA: 0x4FD4F0 Offset: 0x4FBAF0 VA: 0x1804FD4F0
	public static void ResetCraftCounts() { }

	// RVA: 0x4FCE70 Offset: 0x4FB470 VA: 0x1804FCE70
	public static void ListCraftCounts() { }

	// RVA: 0x4FBD80 Offset: 0x4FA380 VA: 0x1804FBD80
	public static int GetCraftCount(ItemBlueprint x) { }

	// RVA: 0x4FAF50 Offset: 0x4F9550 VA: 0x1804FAF50
	public static void AddCraftCount(ItemBlueprint x) { }

	// RVA: 0x4FD830 Offset: 0x4FBE30 VA: 0x1804FD830
	public static BasePlayer get_LocalOrSpectatePlayer() { }

	// RVA: 0x4FD950 Offset: 0x4FBF50 VA: 0x1804FD950
	public static BasePlayer get_SpectatePlayer() { }

	// RVA: 0x4FD660 Offset: 0x4FBC60 VA: 0x1804FD660
	private static void .cctor() { }

}

public class LocalPlayer.ItemBlueprintComparer : IComparer<ItemBlueprint> // TypeDefIndex: 9666
{	// Methods

	// RVA: 0x4EF350 Offset: 0x4ED950 VA: 0x1804EF350 Slot: 4
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

	// RVA: 0x50BF00 Offset: 0x50A500 VA: 0x18050BF00
	internal bool <HasInventoryItem>b__0(IPlayerItem x) { }

}

