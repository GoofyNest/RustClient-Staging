public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 3872
{	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x18FAAD0 Offset: 0x18F90D0 VA: 0x1818FAAD0
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x217260 Offset: 0x216660 VA: 0x180217260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18FAB40 Offset: 0x18F9140 VA: 0x1818FAB40
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x217420 Offset: 0x216820 VA: 0x180217420 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x217380 Offset: 0x216780 VA: 0x180217380 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x18FA780 Offset: 0x18F8D80 VA: 0x1818FA780
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x18FAA90 Offset: 0x18F9090 VA: 0x1818FAA90
	private static void .cctor() { }

}

