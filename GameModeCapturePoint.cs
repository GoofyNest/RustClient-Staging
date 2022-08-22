public class GameModeCapturePoint : BaseEntity // TypeDefIndex: 9882
{	// Fields
	public CapturePointTrigger captureTrigger; // 0x168
	public float timeToCapture; // 0x170
	public int scorePerSecond; // 0x174
	public string scoreName; // 0x178
	private float captureFraction; // 0x180
	private int captureTeam; // 0x184
	private int capturingTeam; // 0x188
	public EntityRef capturingPlayer; // 0x190
	public EntityRef capturedPlayer; // 0x1A0
	public const BaseEntity.Flags Flag_Contested = 8192;
	public RustText capturePointText; // 0x1B0
	public RustText captureOwnerName; // 0x1B8
	public Image captureProgressImage; // 0x1C0
	public GameObjectRef progressBeepEffect; // 0x1C8
	public GameObjectRef progressCompleteEffect; // 0x1D0
	public Transform computerPoint; // 0x1D8

	// Methods

	// RVA: 0x532980 Offset: 0x530F80 VA: 0x180532980
	public bool IsContested() { }

	// RVA: 0x758A10 Offset: 0x757010 VA: 0x180758A10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x758AF0 Offset: 0x7570F0 VA: 0x180758AF0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x758CF0 Offset: 0x7572F0 VA: 0x180758CF0
	public void .ctor() { }

}

