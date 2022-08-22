public class RaySerialized // TypeDefIndex: 6286
{	// Methods

	// RVA: 0x1E49E50 Offset: 0x1E48450 VA: 0x181E49E50
	public static void ResetToPool(Ray instance) { }

	// RVA: 0x1E49B80 Offset: 0x1E48180 VA: 0x181E49B80
	public static Ray Deserialize(byte[] buffer, ref Ray instance, bool isDelta = False) { }

	// RVA: 0x1E49950 Offset: 0x1E47F50 VA: 0x181E49950
	public static Ray Deserialize(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E49350 Offset: 0x1E47950 VA: 0x181E49350
	public static Ray DeserializeLengthDelimited(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E49660 Offset: 0x1E47C60 VA: 0x181E49660
	public static Ray DeserializeLength(Stream stream, int length, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E49EB0 Offset: 0x1E484B0 VA: 0x181E49EB0
	public static void SerializeDelta(Stream stream, Ray instance, Ray previous) { }

	// RVA: 0x1E4A580 Offset: 0x1E48B80 VA: 0x181E4A580
	public static void Serialize(Stream stream, Ray instance) { }

	// RVA: 0x1E4A450 Offset: 0x1E48A50 VA: 0x181E4A450
	public static byte[] SerializeToBytes(Ray instance) { }

	// RVA: 0x1E4A340 Offset: 0x1E48940 VA: 0x181E4A340
	public static void SerializeLengthDelimited(Stream stream, Ray instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

