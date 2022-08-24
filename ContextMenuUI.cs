public static class ContextMenuUI // TypeDefIndex: 10844
{	public static ContextMenuUI.MenuType type; // 0x2B117D0


	public static void Start(ContextMenuUI.MenuType menuType) { }

	public static void AddOption(string name, string desc, Sprite icon, Action<BasePlayer> action, int order = 0, bool disabled = False, bool selected = False, string requirements = "", bool allowMerge = False, Nullable<PieMenu.MenuOption.ColorMode> colorMode) { }

	public static void End() { }

	public static bool IsOpen() { }

	public static void Cancel(bool playSound = True) { }

	public static void DoSelect() { }

	public static void Open(List<Option> options, ContextMenuUI.MenuType menuType) { }

	public static void FrameUpdate(BasePlayer player) { }

	public static bool IsButtonDownRaw(string bind) { }

}

public enum ContextMenuUI.MenuType // TypeDefIndex: 10845
{	public int value__; // 0x0
	public const ContextMenuUI.MenuType Use = 0;
	public const ContextMenuUI.MenuType RightClick = 1;
	public const ContextMenuUI.MenuType Reload = 2;
	public const ContextMenuUI.MenuType Gesture = 3;
	public const ContextMenuUI.MenuType Pet = 4;

}

