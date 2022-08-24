public class ShoutcastStreamer : MonoBehaviour, IClientComponent // TypeDefIndex: 9019
{	public string Host; // 0x18
	public AudioSource Source; // 0x20
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static int MaxAudioStreams; // 0x0
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static bool DebugStreams; // 0x4
	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static bool StreamingAnalytics; // 0x5
	private static bool _allowInternetStreams; // 0x6
	private static HashSet<ShoutcastStreamer> activeStreams; // 0x8
	public RadioPlaylist[] BuiltinRadios; // 0x28
	public ShoutcastStream Stream; // 0x30
	private bool _readingData; // 0x38
	private AudioClip streamClip; // 0x40
	private int sampleRate; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private uint <CurrentReadIndex>k__BackingField; // 0x4C
	private const uint BufferStartCutOff = 81920;
	private bool canUpdate; // 0x50
	private bool wantsShutdown; // 0x51
	private RadioPlaylist currentPlaylist; // 0x58
	private TimeUntil nextStatLog; // 0x60
	private const float StatLogInterval = 60;
	private bool waitAudio; // 0x64
	private float waitUntilBuffer; // 0x68

	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static bool AllowInternetStreams { get; set; }
	public static int ActiveStreamCount { get; }
	public uint CurrentReadIndex { get; set; }
	public bool IsConnected { get; }
	public bool IsPlayingBuiltinAudio { get; }
	private uint BufferedData { get; }
	private float BufferedPercentage { get; }


	public static bool get_AllowInternetStreams() { }

	public static void set_AllowInternetStreams(bool value) { }

	public static int get_ActiveStreamCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public uint get_CurrentReadIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_CurrentReadIndex(uint value) { }

	public bool get_IsConnected() { }

	public bool get_IsPlayingBuiltinAudio() { }

	public void Connect(string host, bool localPlayer = False) { }

	private RadioPlaylist GetPlaylistforUrl(string url) { }

	private void PlayPlaylist() { }

	public void OnStreamsAllowedToggled(bool allowed) { }

	public void Disconnect(bool playSafeAfterDisconnect = False) { }

	private void OnAudioRead(float[] data) { }

	public static int ProcessStreamData(float[] data, float[] floatSamples, ref uint readIndex, uint writeIndex) { }

	protected void Update() { }

	public void ResetSample(uint read) { }

	private uint get_BufferedData() { }

	private float get_BufferedPercentage() { }

	[AsyncStateMachineAttribute] // RVA: 0xCC200 Offset: 0xCB600 VA: 0x1800CC200
	private void ReadData() { }

	private void OnDisable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct ShoutcastStreamer.<ReadData>d__46 : IAsyncStateMachine // TypeDefIndex: 9020
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ShoutcastStreamer <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

