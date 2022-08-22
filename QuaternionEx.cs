public static class QuaternionEx // TypeDefIndex: 11705
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FE830 Offset: 0x9FCE30 VA: 0x1809FE830
	public static Quaternion AlignToNormal(Quaternion rot, Vector3 normal) { }

	// RVA: 0x9FF0F0 Offset: 0x9FD6F0 VA: 0x1809FF0F0
	public static Quaternion LookRotationWithOffset(Vector3 offset, Vector3 forward, Vector3 up) { }

	// RVA: 0x9FEA00 Offset: 0x9FD000 VA: 0x1809FEA00
	public static Quaternion LookRotationForcedUp(Vector3 forward, Vector3 up) { }

	// RVA: 0x9FEBD0 Offset: 0x9FD1D0 VA: 0x1809FEBD0
	public static Quaternion LookRotationGradient(Vector3 normal, Vector3 up) { }

	// RVA: 0x9FED90 Offset: 0x9FD390 VA: 0x1809FED90
	public static Quaternion LookRotationNormal(Vector3 normal, Vector3 up) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FE940 Offset: 0x9FCF40 VA: 0x1809FE940
	public static Quaternion EnsureValid(Quaternion rot, float epsilon = 1,401298E-45) { }

}

