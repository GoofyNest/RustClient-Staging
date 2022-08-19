public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 3872
{	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x18FA850 Offset: 0x18F8E50 VA: 0x1818FA850
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x2172E0 Offset: 0x2166E0 VA: 0x1802172E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18FA8C0 Offset: 0x18F8EC0 VA: 0x1818FA8C0
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x2174A0 Offset: 0x2168A0 VA: 0x1802174A0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x217400 Offset: 0x216800 VA: 0x180217400 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x18FA500 Offset: 0x18F8B00 VA: 0x1818FA500
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x18FA810 Offset: 0x18F8E10 VA: 0x1818FA810
	private static void .cctor() { }

}

