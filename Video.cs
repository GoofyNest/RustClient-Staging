public class Video : RustControl // TypeDefIndex: 7043
{	// Fields
	public RawImage VideoCanvas; // 0x30
	public VideoPlayer VideoPlayer; // 0x38
	public CanvasGroup CanvasGroup; // 0x40
	[RangeAttribute] // RVA: 0x75A70 Offset: 0x74E70 VA: 0x180075A70
	public float FadeIn; // 0x48
	private uint textureWidth; // 0x4C
	private uint textureHeight; // 0x50
	private Vector2 playerSize; // 0x54

	// Methods

	// RVA: 0xFDA320 Offset: 0xFD8920 VA: 0x180FDA320 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFDAFC0 Offset: 0xFD95C0 VA: 0x180FDAFC0
	private void VideoPlayer_errorReceived(VideoPlayer source, string message) { }

	// RVA: 0xFDAEF0 Offset: 0xFD94F0 VA: 0x180FDAEF0
	public void PlayUrl(string video) { }

	// RVA: 0xFDAC30 Offset: 0xFD9230 VA: 0x180FDAC30
	public void LateUpdate() { }

	// RVA: 0xFDA3B0 Offset: 0xFD89B0 VA: 0x180FDA3B0
	private void Cover() { }

	// RVA: 0xFDAF60 Offset: 0xFD9560 VA: 0x180FDAF60
	public void Stop() { }

	// RVA: 0xFDB030 Offset: 0xFD9630 VA: 0x180FDB030
	public void .ctor() { }

}

