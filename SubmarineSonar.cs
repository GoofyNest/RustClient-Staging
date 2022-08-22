public class SubmarineSonar : FacepunchBehaviour // TypeDefIndex: 11679
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float range; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem sonarPS; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem blipPS; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SonarObject us; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color greenBlip; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color redBlip; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color whiteBlip; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SubmarineAudio submarineAudio; // 0x68
	private List<SubmarineSonar.SonarBlip> currentlyInRange; // 0x70
	private float rangeSqr; // 0x78
	private const float SWEEP_DURATION = 1;
	private TimeSince timeSinceLastRefresh; // 0x7C
	private float sonarAngle; // 0x80
	private int blipIndex; // 0x84
	private float scale; // 0x88
	private float blipSize; // 0x8C
	private Vector3 ourRefreshHeading; // 0x90
	private ParticleSystem.EmitParams emitParams; // 0x9C
	private const float MOONPOOL_MIN = 2;
	private const float MOONPOOL_MAX = 6;

	// Methods

	// RVA: 0x5C35D0 Offset: 0x5C1BD0 VA: 0x1805C35D0
	protected void Awake() { }

	// RVA: 0x5C4190 Offset: 0x5C2790 VA: 0x1805C4190
	public void UpdateTick() { }

	// RVA: 0x5C3680 Offset: 0x5C1C80 VA: 0x1805C3680
	private float GetAngleChangeSinceRefresh() { }

	// RVA: 0x5C3980 Offset: 0x5C1F80 VA: 0x1805C3980
	private void Refresh(List<SubmarineSonar.SonarBlip> extras) { }

	// RVA: 0x5C3780 Offset: 0x5C1D80 VA: 0x1805C3780
	private Color GetBlipColour(SonarObject.SType type, float distance) { }

	// RVA: 0x5C38B0 Offset: 0x5C1EB0 VA: 0x1805C38B0
	private static float GetBlipScale(SonarObject.SType type, float distance) { }

	// RVA: 0x5C4510 Offset: 0x5C2B10 VA: 0x1805C4510
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3E60 Offset: 0x5C2460 VA: 0x1805C3E60
	private float <UpdateTick>g__GetCurrentBlipAngle|20_0(SubmarineSonar.SonarBlip nextBlip) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3F90 Offset: 0x5C2590 VA: 0x1805C3F90
	private void <UpdateTick>g__ShowBlip|20_1(SubmarineSonar.SonarBlip nextBlip, float nextAngle) { }

}

private struct SubmarineSonar.SonarBlip : IComparable<SubmarineSonar.SonarBlip> // TypeDefIndex: 11680
{	// Fields
	public readonly Color colour; // 0x0
	public readonly float dist; // 0x10
	public readonly float scale; // 0x14
	public float angle; // 0x18
	public bool orphan; // 0x1C

	// Methods

	// RVA: 0xF34B0 Offset: 0xF28B0 VA: 0x1800F34B0
	public void .ctor(float dist, float angle, Color colour, float scale = 1) { }

	// RVA: 0xF3490 Offset: 0xF2890 VA: 0x1800F3490 Slot: 4
	public int CompareTo(SubmarineSonar.SonarBlip other) { }

}

