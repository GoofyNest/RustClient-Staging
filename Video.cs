public class Video : RustControl // TypeDefIndex: 7043
{	// Fields
	public RawImage VideoCanvas; // 0x30
	public VideoPlayer VideoPlayer; // 0x38
	public CanvasGroup CanvasGroup; // 0x40
	[RangeAttribute] // RVA: 0x759D0 Offset: 0x74DD0 VA: 0x1800759D0
	public float FadeIn; // 0x48
	private uint textureWidth; // 0x4C
	private uint textureHeight; // 0x50
	private Vector2 playerSize; // 0x54

	// Methods

	// RVA: 0xFD95C0 Offset: 0xFD7BC0 VA: 0x180FD95C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFDA260 Offset: 0xFD8860 VA: 0x180FDA260
	private void VideoPlayer_errorReceived(VideoPlayer source, string message) { }

	// RVA: 0xFDA190 Offset: 0xFD8790 VA: 0x180FDA190
	public void PlayUrl(string video) { }

	// RVA: 0xFD9ED0 Offset: 0xFD84D0 VA: 0x180FD9ED0
	public void LateUpdate() { }

	// RVA: 0xFD9650 Offset: 0xFD7C50 VA: 0x180FD9650
	private void Cover() { }

	// RVA: 0xFDA200 Offset: 0xFD8800 VA: 0x180FDA200
	public void Stop() { }

	// RVA: 0xFDA2D0 Offset: 0xFD88D0 VA: 0x180FDA2D0
	public void .ctor() { }

}

