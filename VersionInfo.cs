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

	// RVA: 0x83D460 Offset: 0x83BA60 VA: 0x18083D460
	public static string StaticToString() { }

	// RVA: 0x83D540 Offset: 0x83BB40 VA: 0x18083D540 Slot: 3
	public override string ToString() { }

	// RVA: 0x83D6E0 Offset: 0x83BCE0 VA: 0x18083D6E0
	public int get_Number() { }

	// RVA: 0x83D6B0 Offset: 0x83BCB0 VA: 0x18083D6B0
	private void .ctor() { }

	// RVA: 0x83D660 Offset: 0x83BC60 VA: 0x18083D660
	private void .ctor(byte major, byte minor, byte release) { }

	// RVA: 0x83D3E0 Offset: 0x83B9E0 VA: 0x18083D3E0
	public static VersionInfo Current() { }

	// RVA: 0x83D430 Offset: 0x83BA30 VA: 0x18083D430
	public static bool Matches(VersionInfo version) { }

	// RVA: 0x83D620 Offset: 0x83BC20 VA: 0x18083D620
	private static void .cctor() { }

}

