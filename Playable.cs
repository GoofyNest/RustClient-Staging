public struct Playable : IEquatable<Playable> // TypeDefIndex: 3864
{	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	public static Playable Null { get; }


	public static Playable get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(Playable other) { }

	private static void .cctor() { }

}

