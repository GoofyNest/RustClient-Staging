public static class ContextMenuUI // TypeDefIndex: 10840
{	// Fields
	public static ContextMenuUI.MenuType type; // 0x2E61

	// Methods

	// RVA: 0x6BA0C0 Offset: 0x6B86C0 VA: 0x1806BA0C0
	public static void Start(ContextMenuUI.MenuType menuType) { }

	// RVA: 0x6B92A0 Offset: 0x6B78A0 VA: 0x1806B92A0
	public static void AddOption(string name, string desc, Sprite icon, Action<BasePlayer> action, int order = 0, bool disabled = False, bool selected = False, string requirements = "", bool allowMerge = False, Nullable<PieMenu.MenuOption.ColorMode> colorMode) { }

	// RVA: 0x6B9690 Offset: 0x6B7C90 VA: 0x1806B9690
	public static void End() { }

	// RVA: 0x6B9CF0 Offset: 0x6B82F0 VA: 0x1806B9CF0
	public static bool IsOpen() { }

	// RVA: 0x6B94A0 Offset: 0x6B7AA0 VA: 0x1806B94A0
	public static void Cancel(bool playSound = True) { }

	// RVA: 0x6B95D0 Offset: 0x6B7BD0 VA: 0x1806B95D0
	public static void DoSelect() { }

	// RVA: 0x6B9D60 Offset: 0x6B8360 VA: 0x1806B9D60
	public static void Open(List<Option> options, ContextMenuUI.MenuType menuType) { }

	// RVA: 0x6B9700 Offset: 0x6B7D00 VA: 0x1806B9700
	public static void FrameUpdate(BasePlayer player) { }

	// RVA: 0x6B9B10 Offset: 0x6B8110 VA: 0x1806B9B10
	public static bool IsButtonDownRaw(string bind) { }

}

public enum ContextMenuUI.MenuType // TypeDefIndex: 10841
{	// Fields
	public int value__; // 0x0
	public const ContextMenuUI.MenuType Use = 0;
	public const ContextMenuUI.MenuType RightClick = 1;
	public const ContextMenuUI.MenuType Reload = 2;
	public const ContextMenuUI.MenuType Gesture = 3;
	public const ContextMenuUI.MenuType Pet = 4;

}

