public class RaySerialized // TypeDefIndex: 6286
{	// Methods

	// RVA: 0x1E49530 Offset: 0x1E47B30 VA: 0x181E49530
	public static void ResetToPool(Ray instance) { }

	// RVA: 0x1E49260 Offset: 0x1E47860 VA: 0x181E49260
	public static Ray Deserialize(byte[] buffer, ref Ray instance, bool isDelta = False) { }

	// RVA: 0x1E49030 Offset: 0x1E47630 VA: 0x181E49030
	public static Ray Deserialize(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E48A30 Offset: 0x1E47030 VA: 0x181E48A30
	public static Ray DeserializeLengthDelimited(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E48D40 Offset: 0x1E47340 VA: 0x181E48D40
	public static Ray DeserializeLength(Stream stream, int length, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E49590 Offset: 0x1E47B90 VA: 0x181E49590
	public static void SerializeDelta(Stream stream, Ray instance, Ray previous) { }

	// RVA: 0x1E49C60 Offset: 0x1E48260 VA: 0x181E49C60
	public static void Serialize(Stream stream, Ray instance) { }

	// RVA: 0x1E49B30 Offset: 0x1E48130 VA: 0x181E49B30
	public static byte[] SerializeToBytes(Ray instance) { }

	// RVA: 0x1E49A20 Offset: 0x1E48020 VA: 0x181E49A20
	public static void SerializeLengthDelimited(Stream stream, Ray instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

