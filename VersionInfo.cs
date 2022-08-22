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

	// RVA: 0x83CF10 Offset: 0x83B510 VA: 0x18083CF10
	public static string StaticToString() { }

	// RVA: 0x83CFF0 Offset: 0x83B5F0 VA: 0x18083CFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x83D190 Offset: 0x83B790 VA: 0x18083D190
	public int get_Number() { }

	// RVA: 0x83D160 Offset: 0x83B760 VA: 0x18083D160
	private void .ctor() { }

	// RVA: 0x83D110 Offset: 0x83B710 VA: 0x18083D110
	private void .ctor(byte major, byte minor, byte release) { }

	// RVA: 0x83CE90 Offset: 0x83B490 VA: 0x18083CE90
	public static VersionInfo Current() { }

	// RVA: 0x83CEE0 Offset: 0x83B4E0 VA: 0x18083CEE0
	public static bool Matches(VersionInfo version) { }

	// RVA: 0x83D0D0 Offset: 0x83B6D0 VA: 0x18083D0D0
	private static void .cctor() { }

}

