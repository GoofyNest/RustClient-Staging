public static class ContextMenuUI // TypeDefIndex: 10840
{	// Fields
	public static ContextMenuUI.MenuType type; // 0x2B111F4

	// Methods

	// RVA: 0x6BA130 Offset: 0x6B8730 VA: 0x1806BA130
	public static void Start(ContextMenuUI.MenuType menuType) { }

	// RVA: 0x6B9310 Offset: 0x6B7910 VA: 0x1806B9310
	public static void AddOption(string name, string desc, Sprite icon, Action<BasePlayer> action, int order = 0, bool disabled = False, bool selected = False, string requirements = "", bool allowMerge = False, Nullable<PieMenu.MenuOption.ColorMode> colorMode) { }

	// RVA: 0x6B9700 Offset: 0x6B7D00 VA: 0x1806B9700
	public static void End() { }

	// RVA: 0x6B9D60 Offset: 0x6B8360 VA: 0x1806B9D60
	public static bool IsOpen() { }

	// RVA: 0x6B9510 Offset: 0x6B7B10 VA: 0x1806B9510
	public static void Cancel(bool playSound = True) { }

	// RVA: 0x6B9640 Offset: 0x6B7C40 VA: 0x1806B9640
	public static void DoSelect() { }

	// RVA: 0x6B9DD0 Offset: 0x6B83D0 VA: 0x1806B9DD0
	public static void Open(List<Option> options, ContextMenuUI.MenuType menuType) { }

	// RVA: 0x6B9770 Offset: 0x6B7D70 VA: 0x1806B9770
	public static void FrameUpdate(BasePlayer player) { }

	// RVA: 0x6B9B80 Offset: 0x6B8180 VA: 0x1806B9B80
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

