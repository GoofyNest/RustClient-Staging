public static class ProtocolParser // TypeDefIndex: 6280
{	// Fields
	private static byte[] staticBuffer; // 0x36EE

	// Methods

	// RVA: 0x1E47210 Offset: 0x1E45810 VA: 0x181E47210
	public static float ReadSingle(Stream stream) { }

	// RVA: 0x1E48370 Offset: 0x1E46970 VA: 0x181E48370
	public static void WriteSingle(Stream stream, float f) { }

	// RVA: 0x1E46D20 Offset: 0x1E45320 VA: 0x181E46D20
	public static double ReadDouble(Stream stream) { }

	// RVA: 0x1E47E40 Offset: 0x1E46440 VA: 0x181E47E40
	public static void WriteDouble(Stream stream, double f) { }

	// RVA: 0x1E47360 Offset: 0x1E45960 VA: 0x181E47360
	public static string ReadString(Stream stream) { }

	// RVA: 0x1E46C60 Offset: 0x1E45260 VA: 0x181E46C60
	public static byte[] ReadBytes(Stream stream) { }

	// RVA: 0x1E47040 Offset: 0x1E45640 VA: 0x181E47040
	public static ArraySegment<byte> ReadPooledBytes(Stream stream) { }

	// RVA: 0x1E46AB0 Offset: 0x1E450B0 VA: 0x181E46AB0
	private static void ReadBytesInto(Stream stream, byte[] buffer, int length) { }

	// RVA: 0x1E479E0 Offset: 0x1E45FE0 VA: 0x181E479E0
	public static void SkipBytes(Stream stream) { }

	// RVA: 0x1E48430 Offset: 0x1E46A30 VA: 0x181E48430
	public static void WriteString(Stream stream, string val) { }

	// RVA: 0x1E47D60 Offset: 0x1E46360 VA: 0x181E47D60
	public static void WriteBytes(Stream stream, byte[] val) { }

	// RVA: 0x1E481D0 Offset: 0x1E467D0 VA: 0x181E481D0
	public static void WritePooledBytes(Stream stream, ArraySegment<byte> segment) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E46E10 Offset: 0x1E45410 VA: 0x181E46E10
	public static ulong ReadFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E471E0 Offset: 0x1E457E0 VA: 0x181E471E0
	public static long ReadSFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E46DE0 Offset: 0x1E453E0 VA: 0x181E46DE0
	public static uint ReadFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E471B0 Offset: 0x1E457B0 VA: 0x181E471B0
	public static int ReadSFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47F60 Offset: 0x1E46560 VA: 0x181E47F60
	public static void WriteFixed64(BinaryWriter writer, ulong val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48340 Offset: 0x1E46940 VA: 0x181E48340
	public static void WriteSFixed64(BinaryWriter writer, long val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47F30 Offset: 0x1E46530 VA: 0x181E47F30
	public static void WriteFixed32(BinaryWriter writer, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48310 Offset: 0x1E46910 VA: 0x181E48310
	public static void WriteSFixed32(BinaryWriter writer, int val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E46E40 Offset: 0x1E45440 VA: 0x181E46E40
	public static float ReadFloat(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E46CF0 Offset: 0x1E452F0 VA: 0x181E46CF0
	public static double ReadDouble(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1DD2B10 Offset: 0x1DD1110 VA: 0x181DD2B10
	public static void WriteFloat(BinaryWriter writer, float val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47F00 Offset: 0x1E46500 VA: 0x181E47F00
	public static void WriteDouble(BinaryWriter writer, double val) { }

	// RVA: 0x1E46FD0 Offset: 0x1E455D0 VA: 0x181E46FD0
	public static Key ReadKey(Stream stream) { }

	// RVA: 0x1E46F30 Offset: 0x1E45530 VA: 0x181E46F30
	public static Key ReadKey(byte firstByte, Stream stream) { }

	// RVA: 0x1E48110 Offset: 0x1E46710 VA: 0x181E48110
	public static void WriteKey(Stream stream, Key key) { }

	// RVA: 0x1E47B20 Offset: 0x1E46120 VA: 0x181E47B20
	public static void SkipKey(Stream stream, Key key) { }

	// RVA: 0x1E47770 Offset: 0x1E45D70 VA: 0x181E47770
	public static byte[] ReadValueBytes(Stream stream, Key key) { }

	// RVA: 0x1E472D0 Offset: 0x1E458D0 VA: 0x181E472D0
	public static void ReadSkipVarInt(Stream stream) { }

	// RVA: 0x1E477D0 Offset: 0x1E45DD0 VA: 0x181E477D0
	public static byte[] ReadVarIntBytes(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2010 Offset: 0xB1410 VA: 0x1800B2010
	// RVA: 0x1E46E70 Offset: 0x1E45470 VA: 0x181E46E70
	public static int ReadInt32(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2240 Offset: 0xB1640 VA: 0x1800B2240
	// RVA: 0x1E47F90 Offset: 0x1E46590 VA: 0x181E47F90
	public static void WriteInt32(Stream stream, int val) { }

	// RVA: 0x1E47910 Offset: 0x1E45F10 VA: 0x181E47910
	public static int ReadZInt32(Stream stream) { }

	// RVA: 0x1E48690 Offset: 0x1E46C90 VA: 0x181E48690
	public static void WriteZInt32(Stream stream, int val) { }

	// RVA: 0x1E47510 Offset: 0x1E45B10 VA: 0x181E47510
	public static uint ReadUInt32(Stream stream) { }

	// RVA: 0x1E48590 Offset: 0x1E46B90 VA: 0x181E48590
	public static void WriteUInt32(Stream stream, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB2360 Offset: 0xB1760 VA: 0x1800B2360
	// RVA: 0x1E46ED0 Offset: 0x1E454D0 VA: 0x181E46ED0
	public static int ReadInt64(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2460 Offset: 0xB1860 VA: 0x1800B2460
	// RVA: 0x1E48050 Offset: 0x1E46650 VA: 0x181E48050
	public static void WriteInt64(Stream stream, int val) { }

	// RVA: 0x1E47970 Offset: 0x1E45F70 VA: 0x181E47970
	public static long ReadZInt64(Stream stream) { }

	// RVA: 0x1E48750 Offset: 0x1E46D50 VA: 0x181E48750
	public static void WriteZInt64(Stream stream, long val) { }

	// RVA: 0x1E47640 Offset: 0x1E45C40 VA: 0x181E47640
	public static ulong ReadUInt64(Stream stream) { }

	// RVA: 0x1E48610 Offset: 0x1E46C10 VA: 0x181E48610
	public static void WriteUInt64(Stream stream, ulong val) { }

	// RVA: 0x1E469F0 Offset: 0x1E44FF0 VA: 0x181E469F0
	public static bool ReadBool(Stream stream) { }

	// RVA: 0x1E47D30 Offset: 0x1E46330 VA: 0x181E47D30
	public static void WriteBool(Stream stream, bool val) { }

	// RVA: 0x1E48820 Offset: 0x1E46E20 VA: 0x181E48820
	private static void .cctor() { }

}

