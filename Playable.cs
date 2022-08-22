public struct Playable : IEquatable<Playable> // TypeDefIndex: 3864
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x18FA460 Offset: 0x18F8A60 VA: 0x1818FA460
	public static Playable get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E100 Offset: 0x19D500 VA: 0x18019E100
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x217CC0 Offset: 0x2170C0 VA: 0x180217CC0 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x18FA3B0 Offset: 0x18F89B0 VA: 0x1818FA3B0
	private static void .cctor() { }

}

