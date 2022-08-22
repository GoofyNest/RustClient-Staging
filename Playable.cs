public struct Playable : IEquatable<Playable> // TypeDefIndex: 3864
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x18FAA80 Offset: 0x18F9080 VA: 0x1818FAA80
	public static Playable get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E410 Offset: 0x19D810 VA: 0x18019E410
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x2175F0 Offset: 0x2169F0 VA: 0x1802175F0 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x18FA9D0 Offset: 0x18F8FD0 VA: 0x1818FA9D0
	private static void .cctor() { }

}

