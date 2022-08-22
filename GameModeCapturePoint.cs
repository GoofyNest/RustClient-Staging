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

	// RVA: 0x5329F0 Offset: 0x530FF0 VA: 0x1805329F0
	public bool IsContested() { }

	// RVA: 0x758AC0 Offset: 0x7570C0 VA: 0x180758AC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x758BA0 Offset: 0x7571A0 VA: 0x180758BA0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x758DA0 Offset: 0x7573A0 VA: 0x180758DA0
	public void .ctor() { }

}

