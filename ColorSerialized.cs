public class ColorSerialized // TypeDefIndex: 6288
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Color instance) { }

	// RVA: 0x1E46280 Offset: 0x1E44880 VA: 0x181E46280
	public static Color Deserialize(byte[] buffer, ref Color instance, bool isDelta = False) { }

	// RVA: 0x1E45F20 Offset: 0x1E44520 VA: 0x181E45F20
	public static Color Deserialize(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E456F0 Offset: 0x1E43CF0 VA: 0x181E456F0
	public static Color DeserializeLengthDelimited(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E45B20 Offset: 0x1E44120 VA: 0x181E45B20
	public static Color DeserializeLength(Stream stream, int length, ref Color instance, bool isDelta) { }

	// RVA: 0x1E463B0 Offset: 0x1E449B0 VA: 0x181E463B0
	public static void SerializeDelta(Stream stream, Color instance, Color previous) { }

	// RVA: 0x1E46900 Offset: 0x1E44F00 VA: 0x181E46900
	public static void Serialize(Stream stream, Color instance) { }

	// RVA: 0x1E466E0 Offset: 0x1E44CE0 VA: 0x181E466E0
	public static byte[] SerializeToBytes(Color instance) { }

	// RVA: 0x1E465E0 Offset: 0x1E44BE0 VA: 0x181E465E0
	public static void SerializeLengthDelimited(Stream stream, Color instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

