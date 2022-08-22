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

	// RVA: 0xFD9880 Offset: 0xFD7E80 VA: 0x180FD9880 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFDA520 Offset: 0xFD8B20 VA: 0x180FDA520
	private void VideoPlayer_errorReceived(VideoPlayer source, string message) { }

	// RVA: 0xFDA450 Offset: 0xFD8A50 VA: 0x180FDA450
	public void PlayUrl(string video) { }

	// RVA: 0xFDA190 Offset: 0xFD8790 VA: 0x180FDA190
	public void LateUpdate() { }

	// RVA: 0xFD9910 Offset: 0xFD7F10 VA: 0x180FD9910
	private void Cover() { }

	// RVA: 0xFDA4C0 Offset: 0xFD8AC0 VA: 0x180FDA4C0
	public void Stop() { }

	// RVA: 0xFDA590 Offset: 0xFD8B90 VA: 0x180FDA590
	public void .ctor() { }

}

