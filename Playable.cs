public struct Playable : IEquatable<Playable> // TypeDefIndex: 3864
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x18FAAC0 Offset: 0x18F90C0 VA: 0x1818FAAC0
	public static Playable get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E490 Offset: 0x19D890 VA: 0x18019E490
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x217670 Offset: 0x216A70 VA: 0x180217670 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x18FAA10 Offset: 0x18F9010 VA: 0x1818FAA10
	private static void .cctor() { }

}

