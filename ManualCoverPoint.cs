public class ManualCoverPoint : FacepunchBehaviour // TypeDefIndex: 12132
{	// Fields
	public bool IsDynamic; // 0x18
	public float Score; // 0x1C
	public CoverPointVolume Volume; // 0x20
	public Vector3 Normal; // 0x28
	public CoverPoint.CoverType NormalCoverType; // 0x34

	// Properties
	public Vector3 Position { get; }
	public float DirectionMagnitude { get; }

	// Methods

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 get_Position() { }

	// RVA: 0x4BF220 Offset: 0x4BD820 VA: 0x1804BF220
	public float get_DirectionMagnitude() { }

	// RVA: 0x4BEED0 Offset: 0x4BD4D0 VA: 0x1804BEED0
	private void Awake() { }

	// RVA: 0x4BEFA0 Offset: 0x4BD5A0 VA: 0x1804BEFA0
	public CoverPoint ToCoverPoint(CoverPointVolume volume) { }

	// RVA: 0x4BF210 Offset: 0x4BD810 VA: 0x1804BF210
	public void .ctor() { }

}

