public class ShoutcastStreamer : MonoBehaviour, IClientComponent // TypeDefIndex: 9019
{	// Fields
	public string Host; // 0x18
	public AudioSource Source; // 0x20
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int MaxAudioStreams; // 0x0
	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	public static bool DebugStreams; // 0x4
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool StreamingAnalytics; // 0x5
	private static bool _allowInternetStreams; // 0x6
	private static HashSet<ShoutcastStreamer> activeStreams; // 0x8
	public RadioPlaylist[] BuiltinRadios; // 0x28
	public ShoutcastStream Stream; // 0x30
	private bool _readingData; // 0x38
	private AudioClip streamClip; // 0x40
	private int sampleRate; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool AllowInternetStreams { get; set; }
	public static int ActiveStreamCount { get; }
	public uint CurrentReadIndex { get; set; }
	public bool IsConnected { get; }
	public bool IsPlayingBuiltinAudio { get; }
	private uint BufferedData { get; }
	private float BufferedPercentage { get; }

	// Methods

	// RVA: 0x599C80 Offset: 0x598280 VA: 0x180599C80
	public static bool get_AllowInternetStreams() { }

	// RVA: 0x599DD0 Offset: 0x5983D0 VA: 0x180599DD0
	public static void set_AllowInternetStreams(bool value) { }

	// RVA: 0x599C10 Offset: 0x598210 VA: 0x180599C10
	public static int get_ActiveStreamCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	public uint get_CurrentReadIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	public void set_CurrentReadIndex(uint value) { }

	// RVA: 0x599D50 Offset: 0x598350 VA: 0x180599D50
	public bool get_IsConnected() { }

	// RVA: 0x599D70 Offset: 0x598370 VA: 0x180599D70
	public bool get_IsPlayingBuiltinAudio() { }

	// RVA: 0x598440 Offset: 0x596A40 VA: 0x180598440
	public void Connect(string host, bool localPlayer = False) { }

	// RVA: 0x598D20 Offset: 0x597320 VA: 0x180598D20
	private RadioPlaylist GetPlaylistforUrl(string url) { }

	// RVA: 0x599120 Offset: 0x597720 VA: 0x180599120
	private void PlayPlaylist() { }

	// RVA: 0x599020 Offset: 0x597620 VA: 0x180599020
	public void OnStreamsAllowedToggled(bool allowed) { }

	// RVA: 0x598A20 Offset: 0x597020 VA: 0x180598A20
	public void Disconnect(bool playSafeAfterDisconnect = False) { }

	// RVA: 0x598DB0 Offset: 0x5973B0 VA: 0x180598DB0
	private void OnAudioRead(float[] data) { }

	// RVA: 0x599280 Offset: 0x597880 VA: 0x180599280
	public static int ProcessStreamData(float[] data, float[] floatSamples, ref uint readIndex, uint writeIndex) { }

	// RVA: 0x599510 Offset: 0x597B10 VA: 0x180599510
	protected void Update() { }

	// RVA: 0x5994B0 Offset: 0x597AB0 VA: 0x1805994B0
	public void ResetSample(uint read) { }

	// RVA: 0x599CE0 Offset: 0x5982E0 VA: 0x180599CE0
	private uint get_BufferedData() { }

	// RVA: 0x599D00 Offset: 0x598300 VA: 0x180599D00
	private float get_BufferedPercentage() { }

	[AsyncStateMachineAttribute] // RVA: 0xCBFF0 Offset: 0xCB3F0 VA: 0x1800CBFF0
	// RVA: 0x5993E0 Offset: 0x5979E0 VA: 0x1805993E0
	private void ReadData() { }

	// RVA: 0x599010 Offset: 0x597610 VA: 0x180599010
	private void OnDisable() { }

	// RVA: 0x599BC0 Offset: 0x5981C0 VA: 0x180599BC0
	public void .ctor() { }

	// RVA: 0x599B10 Offset: 0x598110 VA: 0x180599B10
	private static void .cctor() { }

}

private struct ShoutcastStreamer.<ReadData>d__46 : IAsyncStateMachine // TypeDefIndex: 9020
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ShoutcastStreamer <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3480 Offset: 0xF2880 VA: 0x1800F3480 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

