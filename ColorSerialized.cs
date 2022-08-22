public class ColorSerialized // TypeDefIndex: 6288
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Color instance) { }

	// RVA: 0x1E46BA0 Offset: 0x1E451A0 VA: 0x181E46BA0
	public static Color Deserialize(byte[] buffer, ref Color instance, bool isDelta = False) { }

	// RVA: 0x1E46840 Offset: 0x1E44E40 VA: 0x181E46840
	public static Color Deserialize(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E46010 Offset: 0x1E44610 VA: 0x181E46010
	public static Color DeserializeLengthDelimited(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E46440 Offset: 0x1E44A40 VA: 0x181E46440
	public static Color DeserializeLength(Stream stream, int length, ref Color instance, bool isDelta) { }

	// RVA: 0x1E46CD0 Offset: 0x1E452D0 VA: 0x181E46CD0
	public static void SerializeDelta(Stream stream, Color instance, Color previous) { }

	// RVA: 0x1E47220 Offset: 0x1E45820 VA: 0x181E47220
	public static void Serialize(Stream stream, Color instance) { }

	// RVA: 0x1E47000 Offset: 0x1E45600 VA: 0x181E47000
	public static byte[] SerializeToBytes(Color instance) { }

	// RVA: 0x1E46F00 Offset: 0x1E45500 VA: 0x181E46F00
	public static void SerializeLengthDelimited(Stream stream, Color instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

