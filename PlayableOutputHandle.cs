public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 3872
{	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x18FA1F0 Offset: 0x18F87F0 VA: 0x1818FA1F0
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x217930 Offset: 0x216D30 VA: 0x180217930 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18FA260 Offset: 0x18F8860 VA: 0x1818FA260
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x217AF0 Offset: 0x216EF0 VA: 0x180217AF0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x217A50 Offset: 0x216E50 VA: 0x180217A50 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x18F9EA0 Offset: 0x18F84A0 VA: 0x1818F9EA0
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x18FA1B0 Offset: 0x18F87B0 VA: 0x1818FA1B0
	private static void .cctor() { }

}

