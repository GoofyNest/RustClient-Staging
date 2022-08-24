public class VersionInfo // TypeDefIndex: 11571
{	public const byte Major = 2;
	public const byte Minor = 0;
	public const byte Release = 0;
	private static string StageSuffix; // 0x0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int m_major; // 0x10
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int m_minor; // 0x14
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int m_release; // 0x18

	public int Number { get; }


	public static string StaticToString() { }

	public override string ToString() { }

	public int get_Number() { }

	private void .ctor() { }

	private void .ctor(byte major, byte minor, byte release) { }

	public static VersionInfo Current() { }

	public static bool Matches(VersionInfo version) { }

	private static void .cctor() { }

}

