public class RaySerialized // TypeDefIndex: 6286
{	// Methods

	// RVA: 0x1E49370 Offset: 0x1E47970 VA: 0x181E49370
	public static void ResetToPool(Ray instance) { }

	// RVA: 0x1E490A0 Offset: 0x1E476A0 VA: 0x181E490A0
	public static Ray Deserialize(byte[] buffer, ref Ray instance, bool isDelta = False) { }

	// RVA: 0x1E48E70 Offset: 0x1E47470 VA: 0x181E48E70
	public static Ray Deserialize(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E48870 Offset: 0x1E46E70 VA: 0x181E48870
	public static Ray DeserializeLengthDelimited(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E48B80 Offset: 0x1E47180 VA: 0x181E48B80
	public static Ray DeserializeLength(Stream stream, int length, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E493D0 Offset: 0x1E479D0 VA: 0x181E493D0
	public static void SerializeDelta(Stream stream, Ray instance, Ray previous) { }

	// RVA: 0x1E49AA0 Offset: 0x1E480A0 VA: 0x181E49AA0
	public static void Serialize(Stream stream, Ray instance) { }

	// RVA: 0x1E49970 Offset: 0x1E47F70 VA: 0x181E49970
	public static byte[] SerializeToBytes(Ray instance) { }

	// RVA: 0x1E49860 Offset: 0x1E47E60 VA: 0x181E49860
	public static void SerializeLengthDelimited(Stream stream, Ray instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

