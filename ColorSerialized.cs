public class ColorSerialized // TypeDefIndex: 6288
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Color instance) { }

	// RVA: 0x1E46380 Offset: 0x1E44980 VA: 0x181E46380
	public static Color Deserialize(byte[] buffer, ref Color instance, bool isDelta = False) { }

	// RVA: 0x1E46020 Offset: 0x1E44620 VA: 0x181E46020
	public static Color Deserialize(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E457F0 Offset: 0x1E43DF0 VA: 0x181E457F0
	public static Color DeserializeLengthDelimited(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E45C20 Offset: 0x1E44220 VA: 0x181E45C20
	public static Color DeserializeLength(Stream stream, int length, ref Color instance, bool isDelta) { }

	// RVA: 0x1E464B0 Offset: 0x1E44AB0 VA: 0x181E464B0
	public static void SerializeDelta(Stream stream, Color instance, Color previous) { }

	// RVA: 0x1E46A00 Offset: 0x1E45000 VA: 0x181E46A00
	public static void Serialize(Stream stream, Color instance) { }

	// RVA: 0x1E467E0 Offset: 0x1E44DE0 VA: 0x181E467E0
	public static byte[] SerializeToBytes(Color instance) { }

	// RVA: 0x1E466E0 Offset: 0x1E44CE0 VA: 0x181E466E0
	public static void SerializeLengthDelimited(Stream stream, Color instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

