internal static class TraceInternal // TypeDefIndex: 2641
{	// Fields
	private static string appName; // 0x0
	private static TraceListenerCollection listeners; // 0x8
	private static bool autoFlush; // 0x10
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static int indentLevel; // 0x80000000
	private static int indentSize; // 0x14
	internal static readonly object critSec; // 0x18

	// Properties
	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static int IndentLevel { get; }
	public static int IndentSize { get; }

	// Methods

	// RVA: 0x1736730 Offset: 0x1734D30 VA: 0x181736730
	public static TraceListenerCollection get_Listeners() { }

	// RVA: 0x1736610 Offset: 0x1734C10 VA: 0x181736610
	public static bool get_AutoFlush() { }

	// RVA: 0x1736680 Offset: 0x1734C80 VA: 0x181736680
	public static int get_IndentLevel() { }

	// RVA: 0x17366D0 Offset: 0x1734CD0 VA: 0x1817366D0
	public static int get_IndentSize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void InitializeSettings() { }

	// RVA: 0x1736590 Offset: 0x1734B90 VA: 0x181736590
	private static void .cctor() { }

}

