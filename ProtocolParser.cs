public static class ProtocolParser // TypeDefIndex: 6280
{	// Fields
	private static byte[] staticBuffer; // 0x36EE

	// Methods

	// RVA: 0x1E473D0 Offset: 0x1E459D0 VA: 0x181E473D0
	public static float ReadSingle(Stream stream) { }

	// RVA: 0x1E48530 Offset: 0x1E46B30 VA: 0x181E48530
	public static void WriteSingle(Stream stream, float f) { }

	// RVA: 0x1E46EE0 Offset: 0x1E454E0 VA: 0x181E46EE0
	public static double ReadDouble(Stream stream) { }

	// RVA: 0x1E48000 Offset: 0x1E46600 VA: 0x181E48000
	public static void WriteDouble(Stream stream, double f) { }

	// RVA: 0x1E47520 Offset: 0x1E45B20 VA: 0x181E47520
	public static string ReadString(Stream stream) { }

	// RVA: 0x1E46E20 Offset: 0x1E45420 VA: 0x181E46E20
	public static byte[] ReadBytes(Stream stream) { }

	// RVA: 0x1E47200 Offset: 0x1E45800 VA: 0x181E47200
	public static ArraySegment<byte> ReadPooledBytes(Stream stream) { }

	// RVA: 0x1E46C70 Offset: 0x1E45270 VA: 0x181E46C70
	private static void ReadBytesInto(Stream stream, byte[] buffer, int length) { }

	// RVA: 0x1E47BA0 Offset: 0x1E461A0 VA: 0x181E47BA0
	public static void SkipBytes(Stream stream) { }

	// RVA: 0x1E485F0 Offset: 0x1E46BF0 VA: 0x181E485F0
	public static void WriteString(Stream stream, string val) { }

	// RVA: 0x1E47F20 Offset: 0x1E46520 VA: 0x181E47F20
	public static void WriteBytes(Stream stream, byte[] val) { }

	// RVA: 0x1E48390 Offset: 0x1E46990 VA: 0x181E48390
	public static void WritePooledBytes(Stream stream, ArraySegment<byte> segment) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E46FD0 Offset: 0x1E455D0 VA: 0x181E46FD0
	public static ulong ReadFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E473A0 Offset: 0x1E459A0 VA: 0x181E473A0
	public static long ReadSFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E46FA0 Offset: 0x1E455A0 VA: 0x181E46FA0
	public static uint ReadFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E47370 Offset: 0x1E45970 VA: 0x181E47370
	public static int ReadSFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E48120 Offset: 0x1E46720 VA: 0x181E48120
	public static void WriteFixed64(BinaryWriter writer, ulong val) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E48500 Offset: 0x1E46B00 VA: 0x181E48500
	public static void WriteSFixed64(BinaryWriter writer, long val) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E480F0 Offset: 0x1E466F0 VA: 0x181E480F0
	public static void WriteFixed32(BinaryWriter writer, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E484D0 Offset: 0x1E46AD0 VA: 0x181E484D0
	public static void WriteSFixed32(BinaryWriter writer, int val) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E47000 Offset: 0x1E45600 VA: 0x181E47000
	public static float ReadFloat(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E46EB0 Offset: 0x1E454B0 VA: 0x181E46EB0
	public static double ReadDouble(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1DD2CD0 Offset: 0x1DD12D0 VA: 0x181DD2CD0
	public static void WriteFloat(BinaryWriter writer, float val) { }

	[ObsoleteAttribute] // RVA: 0xB0710 Offset: 0xAFB10 VA: 0x1800B0710
	// RVA: 0x1E480C0 Offset: 0x1E466C0 VA: 0x181E480C0
	public static void WriteDouble(BinaryWriter writer, double val) { }

	// RVA: 0x1E47190 Offset: 0x1E45790 VA: 0x181E47190
	public static Key ReadKey(Stream stream) { }

	// RVA: 0x1E470F0 Offset: 0x1E456F0 VA: 0x181E470F0
	public static Key ReadKey(byte firstByte, Stream stream) { }

	// RVA: 0x1E482D0 Offset: 0x1E468D0 VA: 0x181E482D0
	public static void WriteKey(Stream stream, Key key) { }

	// RVA: 0x1E47CE0 Offset: 0x1E462E0 VA: 0x181E47CE0
	public static void SkipKey(Stream stream, Key key) { }

	// RVA: 0x1E47930 Offset: 0x1E45F30 VA: 0x181E47930
	public static byte[] ReadValueBytes(Stream stream, Key key) { }

	// RVA: 0x1E47490 Offset: 0x1E45A90 VA: 0x181E47490
	public static void ReadSkipVarInt(Stream stream) { }

	// RVA: 0x1E47990 Offset: 0x1E45F90 VA: 0x181E47990
	public static byte[] ReadVarIntBytes(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB1F60 Offset: 0xB1360 VA: 0x1800B1F60
	// RVA: 0x1E47030 Offset: 0x1E45630 VA: 0x181E47030
	public static int ReadInt32(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2150 Offset: 0xB1550 VA: 0x1800B2150
	// RVA: 0x1E48150 Offset: 0x1E46750 VA: 0x181E48150
	public static void WriteInt32(Stream stream, int val) { }

	// RVA: 0x1E47AD0 Offset: 0x1E460D0 VA: 0x181E47AD0
	public static int ReadZInt32(Stream stream) { }

	// RVA: 0x1E48850 Offset: 0x1E46E50 VA: 0x181E48850
	public static void WriteZInt32(Stream stream, int val) { }

	// RVA: 0x1E476D0 Offset: 0x1E45CD0 VA: 0x181E476D0
	public static uint ReadUInt32(Stream stream) { }

	// RVA: 0x1E48750 Offset: 0x1E46D50 VA: 0x181E48750
	public static void WriteUInt32(Stream stream, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB2270 Offset: 0xB1670 VA: 0x1800B2270
	// RVA: 0x1E47090 Offset: 0x1E45690 VA: 0x181E47090
	public static int ReadInt64(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB23C0 Offset: 0xB17C0 VA: 0x1800B23C0
	// RVA: 0x1E48210 Offset: 0x1E46810 VA: 0x181E48210
	public static void WriteInt64(Stream stream, int val) { }

	// RVA: 0x1E47B30 Offset: 0x1E46130 VA: 0x181E47B30
	public static long ReadZInt64(Stream stream) { }

	// RVA: 0x1E48910 Offset: 0x1E46F10 VA: 0x181E48910
	public static void WriteZInt64(Stream stream, long val) { }

	// RVA: 0x1E47800 Offset: 0x1E45E00 VA: 0x181E47800
	public static ulong ReadUInt64(Stream stream) { }

	// RVA: 0x1E487D0 Offset: 0x1E46DD0 VA: 0x181E487D0
	public static void WriteUInt64(Stream stream, ulong val) { }

	// RVA: 0x1E46BB0 Offset: 0x1E451B0 VA: 0x181E46BB0
	public static bool ReadBool(Stream stream) { }

	// RVA: 0x1E47EF0 Offset: 0x1E464F0 VA: 0x181E47EF0
	public static void WriteBool(Stream stream, bool val) { }

	// RVA: 0x1E489E0 Offset: 0x1E46FE0 VA: 0x181E489E0
	private static void .cctor() { }

}

