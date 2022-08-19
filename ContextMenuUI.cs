public static class ContextMenuUI // TypeDefIndex: 10840
{	// Fields
	public static ContextMenuUI.MenuType type; // 0x2B11194

	// Methods

	// RVA: 0x6BA020 Offset: 0x6B8620 VA: 0x1806BA020
	public static void Start(ContextMenuUI.MenuType menuType) { }

	// RVA: 0x6B9200 Offset: 0x6B7800 VA: 0x1806B9200
	public static void AddOption(string name, string desc, Sprite icon, Action<BasePlayer> action, int order = 0, bool disabled = False, bool selected = False, string requirements = "", bool allowMerge = False, Nullable<PieMenu.MenuOption.ColorMode> colorMode) { }

	// RVA: 0x6B95F0 Offset: 0x6B7BF0 VA: 0x1806B95F0
	public static void End() { }

	// RVA: 0x6B9C50 Offset: 0x6B8250 VA: 0x1806B9C50
	public static bool IsOpen() { }

	// RVA: 0x6B9400 Offset: 0x6B7A00 VA: 0x1806B9400
	public static void Cancel(bool playSound = True) { }

	// RVA: 0x6B9530 Offset: 0x6B7B30 VA: 0x1806B9530
	public static void DoSelect() { }

	// RVA: 0x6B9CC0 Offset: 0x6B82C0 VA: 0x1806B9CC0
	public static void Open(List<Option> options, ContextMenuUI.MenuType menuType) { }

	// RVA: 0x6B9660 Offset: 0x6B7C60 VA: 0x1806B9660
	public static void FrameUpdate(BasePlayer player) { }

	// RVA: 0x6B9A70 Offset: 0x6B8070 VA: 0x1806B9A70
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

