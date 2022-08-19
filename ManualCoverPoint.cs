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

	// RVA: 0x4BF290 Offset: 0x4BD890 VA: 0x1804BF290
	public float get_DirectionMagnitude() { }

	// RVA: 0x4BEF40 Offset: 0x4BD540 VA: 0x1804BEF40
	private void Awake() { }

	// RVA: 0x4BF010 Offset: 0x4BD610 VA: 0x1804BF010
	public CoverPoint ToCoverPoint(CoverPointVolume volume) { }

	// RVA: 0x4BF280 Offset: 0x4BD880 VA: 0x1804BF280
	public void .ctor() { }

}

