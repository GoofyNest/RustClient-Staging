public enum AudioSpeakerMode // TypeDefIndex: 3998
{
// Namespace: UnityEngine
public enum AudioSpeakerMode // TypeDefIndex: 3998
	// Fields
	public int value__; // 0x0
	[ObsoleteAttribute] // RVA: 0xB3AD0 Offset: 0xB2ED0 VA: 0x1800B3AD0
	public const AudioSpeakerMode Raw = 0;
	public const AudioSpeakerMode Mono = 1;
	public const AudioSpeakerMode Stereo = 2;
	public const AudioSpeakerMode Quad = 3;
	public const AudioSpeakerMode Surround = 4;
	public const AudioSpeakerMode Mode5point1 = 5;
	public const AudioSpeakerMode Mode7point1 = 6;
	public const AudioSpeakerMode Prologic = 7;

}

public enum AudioDataLoadState // TypeDefIndex: 3999
{	// Fields
	public int value__; // 0x0
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;

}

public struct AudioConfiguration // TypeDefIndex: 4000
{	// Fields
	public AudioSpeakerMode speakerMode; // 0x0
	public int dspBufferSize; // 0x4
	public int sampleRate; // 0x8
	public int numRealVoices; // 0xC
	public int numVirtualVoices; // 0x10

}

public enum AudioSourceCurveType // TypeDefIndex: 4002
{	// Fields
	public int value__; // 0x0
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;

}

public enum AudioReverbPreset // TypeDefIndex: 4003
{	// Fields
	public int value__; // 0x0
	public const AudioReverbPreset Off = 0;
	public const AudioReverbPreset Generic = 1;
	public const AudioReverbPreset PaddedCell = 2;
	public const AudioReverbPreset Room = 3;
	public const AudioReverbPreset Bathroom = 4;
	public const AudioReverbPreset Livingroom = 5;
	public const AudioReverbPreset Stoneroom = 6;
	public const AudioReverbPreset Auditorium = 7;
	public const AudioReverbPreset Concerthall = 8;
	public const AudioReverbPreset Cave = 9;
	public const AudioReverbPreset Arena = 10;
	public const AudioReverbPreset Hangar = 11;
	public const AudioReverbPreset CarpetedHallway = 12;
	public const AudioReverbPreset Hallway = 13;
	public const AudioReverbPreset StoneCorridor = 14;
	public const AudioReverbPreset Alley = 15;
	public const AudioReverbPreset Forest = 16;
	public const AudioReverbPreset City = 17;
	public const AudioReverbPreset Mountains = 18;
	public const AudioReverbPreset Quarry = 19;
	public const AudioReverbPreset Plain = 20;
	public const AudioReverbPreset ParkingLot = 21;
	public const AudioReverbPreset SewerPipe = 22;
	public const AudioReverbPreset Underwater = 23;
	public const AudioReverbPreset Drugged = 24;
	public const AudioReverbPreset Dizzy = 25;
	public const AudioReverbPreset Psychotic = 26;
	public const AudioReverbPreset User = 27;

}

public sealed class AudioSettings // TypeDefIndex: 4004
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x13450

	// Properties
	public static AudioSpeakerMode speakerMode { get; }
	public static double dspTime { get; }
	public static int outputSampleRate { get; }

	// Methods

	// RVA: 0x22F9BA0 Offset: 0x22F81A0 VA: 0x1822F9BA0
	private static AudioSpeakerMode GetSpeakerMode() { }

	[NativeThrowsAttribute] // RVA: 0xB3F50 Offset: 0xB3350 VA: 0x1800B3F50
	[NativeMethodAttribute] // RVA: 0xB3F50 Offset: 0xB3350 VA: 0x1800B3F50
	// RVA: 0x22F9CA0 Offset: 0x22F82A0 VA: 0x1822F9CA0
	private static bool SetConfiguration(AudioConfiguration config) { }

	[NativeMethodAttribute] // RVA: 0xB4030 Offset: 0xB3430 VA: 0x1800B4030
	// RVA: 0x22F9B70 Offset: 0x22F8170 VA: 0x1822F9B70
	private static int GetSampleRate() { }

	// RVA: 0x22F9BA0 Offset: 0x22F81A0 VA: 0x1822F9BA0
	public static AudioSpeakerMode get_speakerMode() { }

	[NativeMethodAttribute] // RVA: 0xB41C0 Offset: 0xB35C0 VA: 0x1800B41C0
	// RVA: 0x22F9CE0 Offset: 0x22F82E0 VA: 0x1822F9CE0
	public static double get_dspTime() { }

	// RVA: 0x22F9B70 Offset: 0x22F8170 VA: 0x1822F9B70
	public static int get_outputSampleRate() { }

	[NativeMethodAttribute] // RVA: 0xB42D0 Offset: 0xB36D0 VA: 0x1800B42D0
	// RVA: 0x22F9B20 Offset: 0x22F8120 VA: 0x1822F9B20
	public static void GetDSPBufferSize(out int bufferLength, out int numBuffers) { }

	// RVA: 0x22F9AD0 Offset: 0x22F80D0 VA: 0x1822F9AD0
	public static AudioConfiguration GetConfiguration() { }

	// RVA: 0x22F9C20 Offset: 0x22F8220 VA: 0x1822F9C20
	public static bool Reset(AudioConfiguration config) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F9BD0 Offset: 0x22F81D0 VA: 0x1822F9BD0
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x22F9C60 Offset: 0x22F8260 VA: 0x1822F9C60
	private static bool SetConfiguration_Injected(ref AudioConfiguration config) { }

	// RVA: 0x22F9A90 Offset: 0x22F8090 VA: 0x1822F9A90
	private static void GetConfiguration_Injected(out AudioConfiguration ret) { }

}

public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 4005
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E6190 Offset: 0x9E4790 VA: 0x1809E6190 Slot: 12
	public virtual void Invoke(bool deviceWasChanged) { }

	// RVA: 0x22F8C50 Offset: 0x22F7250 VA: 0x1822F8C50 Slot: 13
	public virtual IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip : Object // TypeDefIndex: 4006
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativePropertyAttribute] // RVA: 0xB4B70 Offset: 0xB3F70 VA: 0x1800B4B70
	public float length { get; }
	[NativePropertyAttribute] // RVA: 0xB4CA0 Offset: 0xB40A0 VA: 0x1800B4CA0
	public int samples { get; }
	[NativePropertyAttribute] // RVA: 0xB4DA0 Offset: 0xB41A0 VA: 0x1800B4DA0
	public int channels { get; }
	public int frequency { get; }
	public AudioDataLoadState loadState { get; }

	// Methods

	// RVA: 0x22F8810 Offset: 0x22F6E10 VA: 0x1822F8810
	private void .ctor() { }

	// RVA: 0x22F8430 Offset: 0x22F6A30 VA: 0x1822F8430
	private static bool GetData(AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset) { }

	// RVA: 0x22F8760 Offset: 0x22F6D60 VA: 0x1822F8760
	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	// RVA: 0x22F7EF0 Offset: 0x22F64F0 VA: 0x1822F7EF0
	private static AudioClip Construct_Internal() { }

	// RVA: 0x22F84A0 Offset: 0x22F6AA0 VA: 0x1822F84A0
	private string GetName() { }

	// RVA: 0x22F7F20 Offset: 0x22F6520 VA: 0x1822F7F20
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x22F8A50 Offset: 0x22F7050 VA: 0x1822F8A50
	public float get_length() { }

	// RVA: 0x22F8AD0 Offset: 0x22F70D0 VA: 0x1822F8AD0
	public int get_samples() { }

	// RVA: 0x22F89D0 Offset: 0x22F6FD0 VA: 0x1822F89D0
	public int get_channels() { }

	// RVA: 0x22F8A10 Offset: 0x22F7010 VA: 0x1822F8A10
	public int get_frequency() { }

	// RVA: 0x22F8520 Offset: 0x22F6B20 VA: 0x1822F8520
	public bool LoadAudioData() { }

	// RVA: 0x22F87D0 Offset: 0x22F6DD0 VA: 0x1822F87D0
	public bool UnloadAudioData() { }

	[NativeMethodAttribute] // RVA: 0xB4750 Offset: 0xB3B50 VA: 0x1800B4750
	// RVA: 0x22F8A90 Offset: 0x22F7090 VA: 0x1822F8A90
	public AudioDataLoadState get_loadState() { }

	// RVA: 0x22F82D0 Offset: 0x22F68D0 VA: 0x1822F82D0
	public bool GetData(float[] data, int offsetSamples) { }

	// RVA: 0x22F8560 Offset: 0x22F6B60 VA: 0x1822F8560
	public bool SetData(float[] data, int offsetSamples) { }

	// RVA: 0x22F7FC0 Offset: 0x22F65C0 VA: 0x1822F7FC0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x22F7F90 Offset: 0x22F6590 VA: 0x1822F7F90
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	// RVA: 0x22F7FF0 Offset: 0x22F65F0 VA: 0x1822F7FF0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8890 Offset: 0x22F6E90 VA: 0x1822F8890
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8B10 Offset: 0x22F7110 VA: 0x1822F8B10
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8930 Offset: 0x22F6F30 VA: 0x1822F8930
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8BB0 Offset: 0x22F71B0 VA: 0x1822F8BB0
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F84E0 Offset: 0x22F6AE0 VA: 0x1822F84E0
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8500 Offset: 0x22F6B00 VA: 0x1822F8500
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 4007
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E2ED0 Offset: 0x12E14D0 VA: 0x1812E2ED0 Slot: 12
	public virtual void Invoke(float[] data) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(float[] data, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 4008
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A463E0 Offset: 0x1A449E0 VA: 0x181A463E0 Slot: 12
	public virtual void Invoke(int position) { }

	// RVA: 0x22FAC50 Offset: 0x22F9250 VA: 0x1822FAC50 Slot: 13
	public virtual IAsyncResult BeginInvoke(int position, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 4011
{
// Namespace: UnityEngine
[StaticAccessorAttribute] // RVA: 0xB6270 Offset: 0xB5670 VA: 0x1800B6270
[RequireComponent] // RVA: 0xB6270 Offset: 0xB5670 VA: 0x1800B6270
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 4010

// Namespace: UnityEngine
[RequireComponent] // RVA: 0xB65F0 Offset: 0xB59F0 VA: 0x1800B65F0
[StaticAccessorAttribute] // RVA: 0xB65F0 Offset: 0xB59F0 VA: 0x1800B65F0
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 4011
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xB88D0 Offset: 0xB7CD0 VA: 0x1800B88D0
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xB89E0 Offset: 0xB7DE0 VA: 0x1800B89E0
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xB8A90 Offset: 0xB7E90 VA: 0x1800B8A90
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool loop { set; }
	public bool playOnAwake { set; }
	[NativePropertyAttribute] // RVA: 0xB8B10 Offset: 0xB7F10 VA: 0x1800B8B10
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xB8BA0 Offset: 0xB7FA0 VA: 0x1800B8BA0
	public float spatialBlend { set; }
	public float dopplerLevel { set; }
	public float spread { get; set; }
	public int priority { set; }
	public bool mute { set; }
	public float maxDistance { get; set; }

	// Methods

	// RVA: 0x22F9D70 Offset: 0x22F8370 VA: 0x1822F9D70
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x22FA4B0 Offset: 0x22F8AB0 VA: 0x1822FA4B0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x22FA110 Offset: 0x22F8710 VA: 0x1822FA110
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x22FA410 Offset: 0x22F8A10 VA: 0x1822FA410
	private void Play(double delay) { }

	// RVA: 0x22FA160 Offset: 0x22F8760 VA: 0x1822FA160
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x22FA540 Offset: 0x22F8B40 VA: 0x1822FA540
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x22FA460 Offset: 0x22F8A60 VA: 0x1822FA460
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x22F9D10 Offset: 0x22F8310 VA: 0x1822F9D10
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x22F9DB0 Offset: 0x22F83B0 VA: 0x1822F9DB0
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x22FA7D0 Offset: 0x22F8DD0 VA: 0x1822FA7D0
	public float get_volume() { }

	// RVA: 0x22FAC00 Offset: 0x22F9200 VA: 0x1822FAC00
	public void set_volume(float value) { }

	// RVA: 0x22F9D70 Offset: 0x22F8370 VA: 0x1822F9D70
	public float get_pitch() { }

	// RVA: 0x22FA4B0 Offset: 0x22F8AB0 VA: 0x1822FA4B0
	public void set_pitch(float value) { }

	// RVA: 0x22FA790 Offset: 0x22F8D90 VA: 0x1822FA790
	public float get_time() { }

	// RVA: 0x22FABB0 Offset: 0x22F91B0 VA: 0x1822FABB0
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22FA750 Offset: 0x22F8D50 VA: 0x1822FA750
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22FAB70 Offset: 0x22F9170 VA: 0x1822FAB70
	public void set_timeSamples(int value) { }

	// RVA: 0x22FA5D0 Offset: 0x22F8BD0 VA: 0x1822FA5D0
	public AudioClip get_clip() { }

	// RVA: 0x22FA810 Offset: 0x22F8E10 VA: 0x1822FA810
	public void set_clip(AudioClip value) { }

	// RVA: 0x22FA690 Offset: 0x22F8C90 VA: 0x1822FA690
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x22FA9A0 Offset: 0x22F8FA0 VA: 0x1822FA9A0
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FA3D0 Offset: 0x22F89D0 VA: 0x1822FA3D0
	public void Play() { }

	// RVA: 0x22FA0A0 Offset: 0x22F86A0 VA: 0x1822FA0A0
	public void PlayDelayed(float delay) { }

	// RVA: 0x22FA370 Offset: 0x22F8970 VA: 0x1822FA370
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FA2A0 Offset: 0x22F88A0 VA: 0x1822FA2A0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x22FA1C0 Offset: 0x22F87C0 VA: 0x1822FA1C0
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x22FA500 Offset: 0x22F8B00 VA: 0x1822FA500
	public void Stop() { }

	// RVA: 0x22F9E20 Offset: 0x22F8420 VA: 0x1822F9E20
	public void Pause() { }

	// RVA: 0x22FA590 Offset: 0x22F8B90 VA: 0x1822FA590
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xB8780 Offset: 0xB7B80 VA: 0x1800B8780
	// RVA: 0x22FA610 Offset: 0x22F8C10 VA: 0x1822FA610
	public bool get_isPlaying() { }

	// RVA: 0x22F9E60 Offset: 0x22F8460 VA: 0x1822F9E60
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x22FA8B0 Offset: 0x22F8EB0 VA: 0x1822FA8B0
	public void set_loop(bool value) { }

	// RVA: 0x22FAA40 Offset: 0x22F9040 VA: 0x1822FAA40
	public void set_playOnAwake(bool value) { }

	// RVA: 0x22FA6D0 Offset: 0x22F8CD0 VA: 0x1822FA6D0
	public float get_panStereo() { }

	// RVA: 0x22FA9F0 Offset: 0x22F8FF0 VA: 0x1822FA9F0
	public void set_panStereo(float value) { }

	// RVA: 0x22FAAD0 Offset: 0x22F90D0 VA: 0x1822FAAD0
	public void set_spatialBlend(float value) { }

	// RVA: 0x22FA460 Offset: 0x22F8A60 VA: 0x1822FA460
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x22FA860 Offset: 0x22F8E60 VA: 0x1822FA860
	public void set_dopplerLevel(float value) { }

	// RVA: 0x22FA710 Offset: 0x22F8D10 VA: 0x1822FA710
	public float get_spread() { }

	// RVA: 0x22FAB20 Offset: 0x22F9120 VA: 0x1822FAB20
	public void set_spread(float value) { }

	// RVA: 0x22FAA90 Offset: 0x22F9090 VA: 0x1822FAA90
	public void set_priority(int value) { }

	// RVA: 0x22FA950 Offset: 0x22F8F50 VA: 0x1822FA950
	public void set_mute(bool value) { }

	// RVA: 0x22FA650 Offset: 0x22F8C50 VA: 0x1822FA650
	public float get_maxDistance() { }

	// RVA: 0x22FA900 Offset: 0x22F8F00 VA: 0x1822FA900
	public void set_maxDistance(float value) { }

	// RVA: 0x22F9D10 Offset: 0x22F8310 VA: 0x1822F9D10
	public void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x22F9DB0 Offset: 0x22F83B0 VA: 0x1822F9DB0
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

}

public sealed class AudioReverbZone : Behaviour // TypeDefIndex: 4012
{	// Properties
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioReverbPreset reverbPreset { set; }
	public int room { get; set; }
	public int roomHF { get; set; }
	public int roomLF { get; set; }
	public float decayTime { get; set; }
	public float decayHFRatio { get; set; }
	public int reflections { get; set; }
	public float reflectionsDelay { get; set; }
	public int reverb { get; set; }
	public float reverbDelay { get; set; }
	public float HFReference { get; set; }
	public float LFReference { get; set; }
	public float diffusion { get; set; }
	public float density { get; set; }

	// Methods

	// RVA: 0x22F93B0 Offset: 0x22F79B0 VA: 0x1822F93B0
	public float get_minDistance() { }

	// RVA: 0x22F97E0 Offset: 0x22F7DE0 VA: 0x1822F97E0
	public void set_minDistance(float value) { }

	// RVA: 0x22F9370 Offset: 0x22F7970 VA: 0x1822F9370
	public float get_maxDistance() { }

	// RVA: 0x22F9790 Offset: 0x22F7D90 VA: 0x1822F9790
	public void set_maxDistance(float value) { }

	// RVA: 0x22F9910 Offset: 0x22F7F10 VA: 0x1822F9910
	public void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x22F9570 Offset: 0x22F7B70 VA: 0x1822F9570
	public int get_room() { }

	// RVA: 0x22F9A10 Offset: 0x22F8010 VA: 0x1822F9A10
	public void set_room(int value) { }

	// RVA: 0x22F94F0 Offset: 0x22F7AF0 VA: 0x1822F94F0
	public int get_roomHF() { }

	// RVA: 0x22F9990 Offset: 0x22F7F90 VA: 0x1822F9990
	public void set_roomHF(int value) { }

	// RVA: 0x22F9530 Offset: 0x22F7B30 VA: 0x1822F9530
	public int get_roomLF() { }

	// RVA: 0x22F99D0 Offset: 0x22F7FD0 VA: 0x1822F99D0
	public void set_roomLF(int value) { }

	// RVA: 0x22F92B0 Offset: 0x22F78B0 VA: 0x1822F92B0
	public float get_decayTime() { }

	// RVA: 0x22F96A0 Offset: 0x22F7CA0 VA: 0x1822F96A0
	public void set_decayTime(float value) { }

	// RVA: 0x22F9270 Offset: 0x22F7870 VA: 0x1822F9270
	public float get_decayHFRatio() { }

	// RVA: 0x22F9650 Offset: 0x22F7C50 VA: 0x1822F9650
	public void set_decayHFRatio(float value) { }

	// RVA: 0x22F9430 Offset: 0x22F7A30 VA: 0x1822F9430
	public int get_reflections() { }

	// RVA: 0x22F9880 Offset: 0x22F7E80 VA: 0x1822F9880
	public void set_reflections(int value) { }

	// RVA: 0x22F93F0 Offset: 0x22F79F0 VA: 0x1822F93F0
	public float get_reflectionsDelay() { }

	// RVA: 0x22F9830 Offset: 0x22F7E30 VA: 0x1822F9830
	public void set_reflectionsDelay(float value) { }

	// RVA: 0x22F94B0 Offset: 0x22F7AB0 VA: 0x1822F94B0
	public int get_reverb() { }

	// RVA: 0x22F9950 Offset: 0x22F7F50 VA: 0x1822F9950
	public void set_reverb(int value) { }

	// RVA: 0x22F9470 Offset: 0x22F7A70 VA: 0x1822F9470
	public float get_reverbDelay() { }

	// RVA: 0x22F98C0 Offset: 0x22F7EC0 VA: 0x1822F98C0
	public void set_reverbDelay(float value) { }

	// RVA: 0x22F91F0 Offset: 0x22F77F0 VA: 0x1822F91F0
	public float get_HFReference() { }

	// RVA: 0x22F95B0 Offset: 0x22F7BB0 VA: 0x1822F95B0
	public void set_HFReference(float value) { }

	// RVA: 0x22F9230 Offset: 0x22F7830 VA: 0x1822F9230
	public float get_LFReference() { }

	// RVA: 0x22F9600 Offset: 0x22F7C00 VA: 0x1822F9600
	public void set_LFReference(float value) { }

	// RVA: 0x22F9330 Offset: 0x22F7930 VA: 0x1822F9330
	public float get_diffusion() { }

	// RVA: 0x22F9740 Offset: 0x22F7D40 VA: 0x1822F9740
	public void set_diffusion(float value) { }

	// RVA: 0x22F92F0 Offset: 0x22F78F0 VA: 0x1822F92F0
	public float get_density() { }

	// RVA: 0x22F96F0 Offset: 0x22F7CF0 VA: 0x1822F96F0
	public void set_density(float value) { }

}

public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 4014
{
// Namespace: UnityEngine.Audio
[NativeHeaderAttribute] // RVA: 0xB8DE0 Offset: 0xB81E0 VA: 0x1800B8DE0
[NativeHeaderAttribute] // RVA: 0xB8DE0 Offset: 0xB81E0 VA: 0x1800B8DE0
[StaticAccessorAttribute] // RVA: 0xB8DE0 Offset: 0xB81E0 VA: 0x1800B8DE0
[NativeHeaderAttribute] // RVA: 0xB8DE0 Offset: 0xB81E0 VA: 0x1800B8DE0
[RequiredByNativeCodeAttribute] // RVA: 0xB8DE0 Offset: 0xB81E0 VA: 0x1800B8DE0
public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 4014
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23E170 Offset: 0x23D570 VA: 0x18023E170 Slot: 4
	public bool Equals(AudioClipPlayable other) { }

}

public class AudioMixer : Object // TypeDefIndex: 4015
{	// Methods

	// RVA: 0x22F9190 Offset: 0x22F7790 VA: 0x1822F9190
	internal void .ctor() { }

	// RVA: 0x22F8EF0 Offset: 0x22F74F0 VA: 0x1822F8EF0
	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0xB9220 Offset: 0xB8620 VA: 0x1800B9220
	// RVA: 0x22F8E90 Offset: 0x22F7490 VA: 0x1822F8E90
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8E30 Offset: 0x22F7430 VA: 0x1822F8E30
	public bool SetFloat(string name, float value) { }

	[NativeMethodAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8DD0 Offset: 0x22F73D0 VA: 0x1822F8DD0
	public bool GetFloat(string name, out float value) { }

}

public class AudioMixerGroup : Object // TypeDefIndex: 4016
{	// Methods

	// RVA: 0x22F8CD0 Offset: 0x22F72D0 VA: 0x1822F8CD0
	internal void .ctor() { }

}

public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 4017
{	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23E200 Offset: 0x23D600 VA: 0x18023E200 Slot: 4
	public bool Equals(AudioMixerPlayable other) { }

}

public class AudioMixerSnapshot : Object // TypeDefIndex: 4018
{	// Properties
	[NativePropertyAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public AudioMixer audioMixer { get; }

	// Methods

	// RVA: 0x22F8D90 Offset: 0x22F7390 VA: 0x1822F8D90
	public AudioMixer get_audioMixer() { }

	// RVA: 0x22F8D30 Offset: 0x22F7330 VA: 0x1822F8D30
	public void TransitionTo(float timeToReach) { }

}

public struct AudioPlayableOutput // TypeDefIndex: 4019
{	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

}

public class AudioSampleProvider // TypeDefIndex: 4020
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F9A50 Offset: 0x22F8050 VA: 0x1822F9A50
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F9A70 Offset: 0x22F8070 VA: 0x1822F9A70
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 4021
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22FAD60 Offset: 0x22F9360 VA: 0x1822FAD60 Slot: 12
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	// RVA: 0x22FACD0 Offset: 0x22F92D0 VA: 0x1822FACD0 Slot: 13
	public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class AudioEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6416
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int colourMode; // 0x14
	public int volumeRange; // 0x18
	public int speed; // 0x1C
	public int gradient; // 0x20

	// Methods

	// RVA: 0x1FF8870 Offset: 0x1FF6E70 VA: 0x181FF8870
	public static void ResetToPool(AudioEntity instance) { }

	// RVA: 0x1FF87D0 Offset: 0x1FF6DD0 VA: 0x181FF87D0
	public void ResetToPool() { }

	// RVA: 0x1FF8480 Offset: 0x1FF6A80 VA: 0x181FF8480 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07020 Offset: 0x1C05620 VA: 0x181C07020
	public void CopyTo(AudioEntity instance) { }

	// RVA: 0x1FF72F0 Offset: 0x1FF58F0 VA: 0x181FF72F0
	public AudioEntity Copy() { }

	// RVA: 0x1FF7F40 Offset: 0x1FF6540 VA: 0x181FF7F40
	public static AudioEntity Deserialize(Stream stream) { }

	// RVA: 0x1FF7370 Offset: 0x1FF5970 VA: 0x181FF7370
	public static AudioEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF76D0 Offset: 0x1FF5CD0 VA: 0x181FF76D0
	public static AudioEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF7C30 Offset: 0x1FF6230 VA: 0x181FF7C30
	public static AudioEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1FF85A0 Offset: 0x1FF6BA0 VA: 0x181FF85A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF8E50 Offset: 0x1FF7450 VA: 0x181FF8E50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF8E70 Offset: 0x1FF7470 VA: 0x181FF8E70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AudioEntity previous) { }

	// RVA: 0x1FF87B0 Offset: 0x1FF6DB0 VA: 0x181FF87B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF8190 Offset: 0x1FF6790 VA: 0x181FF8190
	public static AudioEntity Deserialize(byte[] buffer, AudioEntity instance, bool isDelta = False) { }

	// RVA: 0x1FF7A20 Offset: 0x1FF6020 VA: 0x181FF7A20
	public static AudioEntity Deserialize(Stream stream, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF73F0 Offset: 0x1FF59F0 VA: 0x181FF73F0
	public static AudioEntity DeserializeLengthDelimited(Stream stream, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF7760 Offset: 0x1FF5D60 VA: 0x181FF7760
	public static AudioEntity DeserializeLength(Stream stream, int length, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF8910 Offset: 0x1FF6F10 VA: 0x181FF8910
	public static void SerializeDelta(Stream stream, AudioEntity instance, AudioEntity previous) { }

	// RVA: 0x1FF8CF0 Offset: 0x1FF72F0 VA: 0x181FF8CF0
	public static void Serialize(Stream stream, AudioEntity instance) { }

	// RVA: 0x1FF8E40 Offset: 0x1FF7440 VA: 0x181FF8E40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF8E50 Offset: 0x1FF7450 VA: 0x181FF8E50
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF8BE0 Offset: 0x1FF71E0 VA: 0x181FF8BE0
	public static byte[] SerializeToBytes(AudioEntity instance) { }

	// RVA: 0x1FF8B30 Offset: 0x1FF7130 VA: 0x181FF8B30
	public static void SerializeLengthDelimited(Stream stream, AudioEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AudioVisualisationEntity : IOEntity // TypeDefIndex: 8307
{	// Fields
	private Option __menuOption_ChangeLightSettings; // 0x288
	private EntityRef<BaseEntity> connectedTo; // 0x2E0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AudioVisualisationEntity.LightColour <currentColour>k__BackingField; // 0x2F0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AudioVisualisationEntity.VolumeSensitivity <currentVolumeSensitivity>k__BackingField; // 0x2F4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AudioVisualisationEntity.Speed <currentSpeed>k__BackingField; // 0x2F8
	public GameObjectRef SettingsDialog; // 0x300
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <currentGradient>k__BackingField; // 0x308
	private IAudioConnectionSource currentSource; // 0x310
	private static float[] bands; // 0x0
	private float roughPeak; // 0x318

	// Properties
	public override bool HasMenuOptions { get; }
	public AudioVisualisationEntity.LightColour currentColour { get; set; }
	public AudioVisualisationEntity.VolumeSensitivity currentVolumeSensitivity { get; set; }
	public AudioVisualisationEntity.Speed currentSpeed { get; set; }
	public int currentGradient { get; set; }
	public virtual bool ShowColourOption { get; }
	public virtual bool ShowVolumeOption { get; }
	public virtual bool ShowSpeedOption { get; }
	public virtual bool ShowPatternOption { get; }
	public virtual bool ShowGradientOption { get; }
	protected bool HasAudioSource { get; }

	// Methods

	// RVA: 0x837110 Offset: 0x835710 VA: 0x180837110 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8382A0 Offset: 0x8368A0 VA: 0x1808382A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8376D0 Offset: 0x835CD0 VA: 0x1808376D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838370 Offset: 0x836970 VA: 0x180838370
	public AudioVisualisationEntity.LightColour get_currentColour() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8383B0 Offset: 0x8369B0 VA: 0x1808383B0
	private void set_currentColour(AudioVisualisationEntity.LightColour value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8383A0 Offset: 0x8369A0 VA: 0x1808383A0
	public AudioVisualisationEntity.VolumeSensitivity get_currentVolumeSensitivity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8383E0 Offset: 0x8369E0 VA: 0x1808383E0
	private void set_currentVolumeSensitivity(AudioVisualisationEntity.VolumeSensitivity value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838390 Offset: 0x836990 VA: 0x180838390
	public AudioVisualisationEntity.Speed get_currentSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8383D0 Offset: 0x8369D0 VA: 0x1808383D0
	private void set_currentSpeed(AudioVisualisationEntity.Speed value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838380 Offset: 0x836980 VA: 0x180838380
	public int get_currentGradient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8383C0 Offset: 0x8369C0 VA: 0x1808383C0
	private void set_currentGradient(int value) { }

	// RVA: 0x837530 Offset: 0x835B30 VA: 0x180837530 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x837D10 Offset: 0x836310 VA: 0x180837D10
	private void UpdateInvoke() { }

	// RVA: 0x837BE0 Offset: 0x8361E0 VA: 0x180837BE0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 159
	protected virtual void UpdateVisualisation(float volume, bool force = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x837020 Offset: 0x835620 VA: 0x180837020
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 160
	public virtual bool get_ShowColourOption() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 161
	public virtual bool get_ShowVolumeOption() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 162
	public virtual bool get_ShowSpeedOption() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 163
	public virtual bool get_ShowPatternOption() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 164
	public virtual bool get_ShowGradientOption() { }

	// RVA: 0x838240 Offset: 0x836840 VA: 0x180838240
	protected bool get_HasAudioSource() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 165
	protected virtual void UpdateVisualSettings() { }

	[BaseEntity.Menu] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	[BaseEntity.Menu.Description] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	[BaseEntity.Menu.Icon] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	// RVA: 0x836F20 Offset: 0x835520 VA: 0x180836F20
	public void ChangeLightSettings(BasePlayer player) { }

	// RVA: 0x837C70 Offset: 0x836270 VA: 0x180837C70
	public void SendNewLightSettings(int newColour, int newVolumeRange, int newSpeed, int newGradient) { }

	// RVA: 0x55C0E0 Offset: 0x55A6E0 VA: 0x18055C0E0
	private bool CanChangeLightSettings(BasePlayer player) { }

	// RVA: 0x2FA9A0 Offset: 0x2F8FA0 VA: 0x1802FA9A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x837430 Offset: 0x835A30 VA: 0x180837430 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8381D0 Offset: 0x8367D0 VA: 0x1808381D0
	public void .ctor() { }

	// RVA: 0x838180 Offset: 0x836780 VA: 0x180838180
	private static void .cctor() { }

}

public enum AudioVisualisationEntity.LightColour // TypeDefIndex: 8308
{	// Fields
	public int value__; // 0x0
	public const AudioVisualisationEntity.LightColour Red = 0;
	public const AudioVisualisationEntity.LightColour Green = 1;
	public const AudioVisualisationEntity.LightColour Blue = 2;
	public const AudioVisualisationEntity.LightColour Yellow = 3;
	public const AudioVisualisationEntity.LightColour Pink = 4;

}

public enum AudioVisualisationEntity.VolumeSensitivity // TypeDefIndex: 8309
{	// Fields
	public int value__; // 0x0
	public const AudioVisualisationEntity.VolumeSensitivity Small = 0;
	public const AudioVisualisationEntity.VolumeSensitivity Medium = 1;
	public const AudioVisualisationEntity.VolumeSensitivity Large = 2;

}

public enum AudioVisualisationEntity.Speed // TypeDefIndex: 8310
{	// Fields
	public int value__; // 0x0
	public const AudioVisualisationEntity.Speed Low = 0;
	public const AudioVisualisationEntity.Speed Medium = 1;
	public const AudioVisualisationEntity.Speed High = 2;

}

public class AudioAlarm : IOEntity // TypeDefIndex: 8699
{	// Methods

	// RVA: 0x835730 Offset: 0x833D30 VA: 0x180835730
	public void .ctor() { }

}

public class AudioSettings : MonoBehaviour // TypeDefIndex: 9122
{	// Fields
	public AudioMixer mixer; // 0x18

	// Methods

	// RVA: 0x835AE0 Offset: 0x8340E0 VA: 0x180835AE0
	private void Update() { }

	// RVA: 0x835A60 Offset: 0x834060 VA: 0x180835A60
	private float LinearToDecibel(float linear) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AudioVisualisationEntityLight : AudioVisualisationEntity // TypeDefIndex: 9435
{	// Fields
	public Light TargetLight; // 0x320
	public Light SecondaryLight; // 0x328
	public MeshRenderer[] TargetRenderer; // 0x330
	public AudioVisualisationEntityLight.LightColourSet RedColour; // 0x338
	public AudioVisualisationEntityLight.LightColourSet GreenColour; // 0x368
	public AudioVisualisationEntityLight.LightColourSet BlueColour; // 0x398
	public AudioVisualisationEntityLight.LightColourSet YellowColour; // 0x3C8
	public AudioVisualisationEntityLight.LightColourSet PinkColour; // 0x3F8
	public float lightMinIntensity; // 0x428
	public float lightMaxIntensity; // 0x42C
	private static MaterialPropertyBlock block; // 0x0
	private static int emissionColourId; // 0x8
	private float lastVolume; // 0x430

	// Properties
	public override bool ShowColourOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }

	// Methods

	// RVA: 0x8360A0 Offset: 0x8346A0 VA: 0x1808360A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x836BA0 Offset: 0x8351A0 VA: 0x180836BA0 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x836250 Offset: 0x834850 VA: 0x180836250
	private float GetCurrentSpeedValue() { }

	// RVA: 0x836290 Offset: 0x834890 VA: 0x180836290
	private void GetCurrentVolumeRange(out float min, out float max) { }

	// RVA: 0x836640 Offset: 0x834C40 VA: 0x180836640
	private void UpdateLightComponentSettings() { }

	// RVA: 0x836170 Offset: 0x834770 VA: 0x180836170
	private AudioVisualisationEntityLight.LightColourSet EnumToColour(AudioVisualisationEntity.LightColour colour) { }

	// RVA: 0x836730 Offset: 0x834D30 VA: 0x180836730
	private void UpdateRenderer(float volumeNormalised) { }

	// RVA: 0x836AA0 Offset: 0x8350A0 VA: 0x180836AA0 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 160
	public override bool get_ShowColourOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x8362E0 Offset: 0x8348E0 VA: 0x1808362E0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x836E60 Offset: 0x835460 VA: 0x180836E60
	public void .ctor() { }

	// RVA: 0x836E00 Offset: 0x835400 VA: 0x180836E00
	private static void .cctor() { }

}

public struct AudioVisualisationEntityLight.LightColourSet // TypeDefIndex: 9436
{	// Fields
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color LightColor; // 0x0
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color SecondaryLightColour; // 0x10
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color EmissionColour; // 0x20

}

public class AudioInterceptComponent : MonoBehaviour // TypeDefIndex: 9456
{	// Fields
	public OggEncoder Encoder; // 0x18
	private float[] strippedData; // 0x20
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debugChannels; // 0x0

	// Methods

	// RVA: 0x835790 Offset: 0x833D90 VA: 0x180835790
	private void OnAudioFilterRead(float[] data, int channels) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class Audio : ConsoleSystem // TypeDefIndex: 11883
{	// Fields
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static float master; // 0x0
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static float musicvolume; // 0x4
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static float musicvolumemenu; // 0x8
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static float game; // 0xC
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static float voices; // 0x10
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static float instruments; // 0x14
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static float voiceProps; // 0x18
	[ClientVar] // RVA: 0x88C40 Offset: 0x88040 VA: 0x180088C40
	public static bool ambience; // 0x1C
	[ClientVar] // RVA: 0x88EC0 Offset: 0x882C0 VA: 0x180088EC0
	public static float framebudget; // 0x20
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float minupdatefraction; // 0x24
	[ClientVar] // RVA: 0x89110 Offset: 0x88510 VA: 0x180089110
	public static bool advancedocclusion; // 0x28
	[ClientVar] // RVA: 0x89180 Offset: 0x88580 VA: 0x180089180
	public static bool hqsoundfade; // 0x29
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static bool debugVoiceLimiting; // 0x2A

	// Properties
	[ClientVar] // RVA: 0x88340 Offset: 0x87740 VA: 0x180088340
	public static int speakers { get; set; }

	// Methods

	// RVA: 0x6CB010 Offset: 0x6C9610 VA: 0x1806CB010
	public static int get_speakers() { }

	// RVA: 0x6CC3D0 Offset: 0x6CA9D0 VA: 0x1806CC3D0
	public static void set_speakers(int value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CC180 Offset: 0x6CA780 VA: 0x1806CC180
	public static void printSounds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x89390 Offset: 0x88790 VA: 0x180089390
	// RVA: 0x6CB020 Offset: 0x6C9620 VA: 0x1806CB020
	public static void printEngineSounds(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CAFB0 Offset: 0x6C95B0 VA: 0x1806CAFB0
	public void .ctor() { }

	// RVA: 0x6CAE80 Offset: 0x6C9480 VA: 0x1806CAE80
	private static void .cctor() { }

}

