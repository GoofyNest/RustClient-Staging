public class VersionInfo // TypeDefIndex: 11567
{	// Fields
	public const byte Major = 2;
	public const byte Minor = 0;
	public const byte Release = 0;
	private static string StageSuffix; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_major; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_minor; // 0x14
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_release; // 0x18

	// Properties
	public int Number { get; }

	// Methods

	// RVA: 0x83CE00 Offset: 0x83B400 VA: 0x18083CE00
	public static string StaticToString() { }

	// RVA: 0x83CEE0 Offset: 0x83B4E0 VA: 0x18083CEE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x83D080 Offset: 0x83B680 VA: 0x18083D080
	public int get_Number() { }

	// RVA: 0x83D050 Offset: 0x83B650 VA: 0x18083D050
	private void .ctor() { }

	// RVA: 0x83D000 Offset: 0x83B600 VA: 0x18083D000
	private void .ctor(byte major, byte minor, byte release) { }

	// RVA: 0x83CD80 Offset: 0x83B380 VA: 0x18083CD80
	public static VersionInfo Current() { }

	// RVA: 0x83CDD0 Offset: 0x83B3D0 VA: 0x18083CDD0
	public static bool Matches(VersionInfo version) { }

	// RVA: 0x83CFC0 Offset: 0x83B5C0 VA: 0x18083CFC0
	private static void .cctor() { }

}

