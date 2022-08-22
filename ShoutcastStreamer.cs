public class ShoutcastStreamer : MonoBehaviour, IClientComponent // TypeDefIndex: 9019
{	// Fields
	public string Host; // 0x18
	public AudioSource Source; // 0x20
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int MaxAudioStreams; // 0x0
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool DebugStreams; // 0x4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool StreamingAnalytics; // 0x5
	private static bool _allowInternetStreams; // 0x6
	private static HashSet<ShoutcastStreamer> activeStreams; // 0x8
	public RadioPlaylist[] BuiltinRadios; // 0x28
	public ShoutcastStream Stream; // 0x30
	private bool _readingData; // 0x38
	private AudioClip streamClip; // 0x40
	private int sampleRate; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <CurrentReadIndex>k__BackingField; // 0x4C
	private const uint BufferStartCutOff = 81920;
	private bool canUpdate; // 0x50
	private bool wantsShutdown; // 0x51
	private RadioPlaylist currentPlaylist; // 0x58
	private TimeUntil nextStatLog; // 0x60
	private const float StatLogInterval = 60;
	private bool waitAudio; // 0x64
	private float waitUntilBuffer; // 0x68

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool AllowInternetStreams { get; set; }
	public static int ActiveStreamCount { get; }
	public uint CurrentReadIndex { get; set; }
	public bool IsConnected { get; }
	public bool IsPlayingBuiltinAudio { get; }
	private uint BufferedData { get; }
	private float BufferedPercentage { get; }

	// Methods

	// RVA: 0x599C10 Offset: 0x598210 VA: 0x180599C10
	public static bool get_AllowInternetStreams() { }

	// RVA: 0x599D60 Offset: 0x598360 VA: 0x180599D60
	public static void set_AllowInternetStreams(bool value) { }

	// RVA: 0x599BA0 Offset: 0x5981A0 VA: 0x180599BA0
	public static int get_ActiveStreamCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	public uint get_CurrentReadIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59A080 Offset: 0x598680 VA: 0x18059A080
	public void set_CurrentReadIndex(uint value) { }

	// RVA: 0x599CE0 Offset: 0x5982E0 VA: 0x180599CE0
	public bool get_IsConnected() { }

	// RVA: 0x599D00 Offset: 0x598300 VA: 0x180599D00
	public bool get_IsPlayingBuiltinAudio() { }

	// RVA: 0x5983D0 Offset: 0x5969D0 VA: 0x1805983D0
	public void Connect(string host, bool localPlayer = False) { }

	// RVA: 0x598CB0 Offset: 0x5972B0 VA: 0x180598CB0
	private RadioPlaylist GetPlaylistforUrl(string url) { }

	// RVA: 0x5990B0 Offset: 0x5976B0 VA: 0x1805990B0
	private void PlayPlaylist() { }

	// RVA: 0x598FB0 Offset: 0x5975B0 VA: 0x180598FB0
	public void OnStreamsAllowedToggled(bool allowed) { }

	// RVA: 0x5989B0 Offset: 0x596FB0 VA: 0x1805989B0
	public void Disconnect(bool playSafeAfterDisconnect = False) { }

	// RVA: 0x598D40 Offset: 0x597340 VA: 0x180598D40
	private void OnAudioRead(float[] data) { }

	// RVA: 0x599210 Offset: 0x597810 VA: 0x180599210
	public static int ProcessStreamData(float[] data, float[] floatSamples, ref uint readIndex, uint writeIndex) { }

	// RVA: 0x5994A0 Offset: 0x597AA0 VA: 0x1805994A0
	protected void Update() { }

	// RVA: 0x599440 Offset: 0x597A40 VA: 0x180599440
	public void ResetSample(uint read) { }

	// RVA: 0x599C70 Offset: 0x598270 VA: 0x180599C70
	private uint get_BufferedData() { }

	// RVA: 0x599C90 Offset: 0x598290 VA: 0x180599C90
	private float get_BufferedPercentage() { }

	[AsyncStateMachineAttribute] // RVA: 0xCC050 Offset: 0xCB450 VA: 0x1800CC050
	// RVA: 0x599370 Offset: 0x597970 VA: 0x180599370
	private void ReadData() { }

	// RVA: 0x598FA0 Offset: 0x5975A0 VA: 0x180598FA0
	private void OnDisable() { }

	// RVA: 0x599B50 Offset: 0x598150 VA: 0x180599B50
	public void .ctor() { }

	// RVA: 0x599AA0 Offset: 0x5980A0 VA: 0x180599AA0
	private static void .cctor() { }

}

private struct ShoutcastStreamer.<ReadData>d__46 : IAsyncStateMachine // TypeDefIndex: 9020
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ShoutcastStreamer <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3400 Offset: 0xF2800 VA: 0x1800F3400 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

