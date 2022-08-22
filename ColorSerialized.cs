public class ColorSerialized // TypeDefIndex: 6288
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Color instance) { }

	// RVA: 0x1E460C0 Offset: 0x1E446C0 VA: 0x181E460C0
	public static Color Deserialize(byte[] buffer, ref Color instance, bool isDelta = False) { }

	// RVA: 0x1E45D60 Offset: 0x1E44360 VA: 0x181E45D60
	public static Color Deserialize(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E45530 Offset: 0x1E43B30 VA: 0x181E45530
	public static Color DeserializeLengthDelimited(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E45960 Offset: 0x1E43F60 VA: 0x181E45960
	public static Color DeserializeLength(Stream stream, int length, ref Color instance, bool isDelta) { }

	// RVA: 0x1E461F0 Offset: 0x1E447F0 VA: 0x181E461F0
	public static void SerializeDelta(Stream stream, Color instance, Color previous) { }

	// RVA: 0x1E46740 Offset: 0x1E44D40 VA: 0x181E46740
	public static void Serialize(Stream stream, Color instance) { }

	// RVA: 0x1E46520 Offset: 0x1E44B20 VA: 0x181E46520
	public static byte[] SerializeToBytes(Color instance) { }

	// RVA: 0x1E46420 Offset: 0x1E44A20 VA: 0x181E46420
	public static void SerializeLengthDelimited(Stream stream, Color instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

