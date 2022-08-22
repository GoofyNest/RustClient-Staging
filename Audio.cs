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
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x2B1047C

	// Properties
	public static AudioSpeakerMode speakerMode { get; }
	public static double dspTime { get; }
	public static int outputSampleRate { get; }

	// Methods

	// RVA: 0x22FA680 Offset: 0x22F8C80 VA: 0x1822FA680
	private static AudioSpeakerMode GetSpeakerMode() { }

	[NativeThrowsAttribute] // RVA: 0xB3F50 Offset: 0xB3350 VA: 0x1800B3F50
	[NativeMethodAttribute] // RVA: 0xB3F50 Offset: 0xB3350 VA: 0x1800B3F50
	// RVA: 0x22FA780 Offset: 0x22F8D80 VA: 0x1822FA780
	private static bool SetConfiguration(AudioConfiguration config) { }

	[NativeMethodAttribute] // RVA: 0xB4030 Offset: 0xB3430 VA: 0x1800B4030
	// RVA: 0x22FA650 Offset: 0x22F8C50 VA: 0x1822FA650
	private static int GetSampleRate() { }

	// RVA: 0x22FA680 Offset: 0x22F8C80 VA: 0x1822FA680
	public static AudioSpeakerMode get_speakerMode() { }

	[NativeMethodAttribute] // RVA: 0xB41C0 Offset: 0xB35C0 VA: 0x1800B41C0
	// RVA: 0x22FA7C0 Offset: 0x22F8DC0 VA: 0x1822FA7C0
	public static double get_dspTime() { }

	// RVA: 0x22FA650 Offset: 0x22F8C50 VA: 0x1822FA650
	public static int get_outputSampleRate() { }

	[NativeMethodAttribute] // RVA: 0xB42D0 Offset: 0xB36D0 VA: 0x1800B42D0
	// RVA: 0x22FA600 Offset: 0x22F8C00 VA: 0x1822FA600
	public static void GetDSPBufferSize(out int bufferLength, out int numBuffers) { }

	// RVA: 0x22FA5B0 Offset: 0x22F8BB0 VA: 0x1822FA5B0
	public static AudioConfiguration GetConfiguration() { }

	// RVA: 0x22FA700 Offset: 0x22F8D00 VA: 0x1822FA700
	public static bool Reset(AudioConfiguration config) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FA6B0 Offset: 0x22F8CB0 VA: 0x1822FA6B0
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x22FA740 Offset: 0x22F8D40 VA: 0x1822FA740
	private static bool SetConfiguration_Injected(ref AudioConfiguration config) { }

	// RVA: 0x22FA570 Offset: 0x22F8B70 VA: 0x1822FA570
	private static void GetConfiguration_Injected(out AudioConfiguration ret) { }

}

public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 4005
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E6940 Offset: 0x9E4F40 VA: 0x1809E6940 Slot: 12
	public virtual void Invoke(bool deviceWasChanged) { }

	// RVA: 0x22F9730 Offset: 0x22F7D30 VA: 0x1822F9730 Slot: 13
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

	// RVA: 0x22F92F0 Offset: 0x22F78F0 VA: 0x1822F92F0
	private void .ctor() { }

	// RVA: 0x22F8F10 Offset: 0x22F7510 VA: 0x1822F8F10
	private static bool GetData(AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset) { }

	// RVA: 0x22F9240 Offset: 0x22F7840 VA: 0x1822F9240
	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	// RVA: 0x22F89D0 Offset: 0x22F6FD0 VA: 0x1822F89D0
	private static AudioClip Construct_Internal() { }

	// RVA: 0x22F8F80 Offset: 0x22F7580 VA: 0x1822F8F80
	private string GetName() { }

	// RVA: 0x22F8A00 Offset: 0x22F7000 VA: 0x1822F8A00
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x22F9530 Offset: 0x22F7B30 VA: 0x1822F9530
	public float get_length() { }

	// RVA: 0x22F95B0 Offset: 0x22F7BB0 VA: 0x1822F95B0
	public int get_samples() { }

	// RVA: 0x22F94B0 Offset: 0x22F7AB0 VA: 0x1822F94B0
	public int get_channels() { }

	// RVA: 0x22F94F0 Offset: 0x22F7AF0 VA: 0x1822F94F0
	public int get_frequency() { }

	// RVA: 0x22F9000 Offset: 0x22F7600 VA: 0x1822F9000
	public bool LoadAudioData() { }

	// RVA: 0x22F92B0 Offset: 0x22F78B0 VA: 0x1822F92B0
	public bool UnloadAudioData() { }

	[NativeMethodAttribute] // RVA: 0xB4750 Offset: 0xB3B50 VA: 0x1800B4750
	// RVA: 0x22F9570 Offset: 0x22F7B70 VA: 0x1822F9570
	public AudioDataLoadState get_loadState() { }

	// RVA: 0x22F8DB0 Offset: 0x22F73B0 VA: 0x1822F8DB0
	public bool GetData(float[] data, int offsetSamples) { }

	// RVA: 0x22F9040 Offset: 0x22F7640 VA: 0x1822F9040
	public bool SetData(float[] data, int offsetSamples) { }

	// RVA: 0x22F8AA0 Offset: 0x22F70A0 VA: 0x1822F8AA0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x22F8A70 Offset: 0x22F7070 VA: 0x1822F8A70
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	// RVA: 0x22F8AD0 Offset: 0x22F70D0 VA: 0x1822F8AD0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F9370 Offset: 0x22F7970 VA: 0x1822F9370
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F95F0 Offset: 0x22F7BF0 VA: 0x1822F95F0
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F9410 Offset: 0x22F7A10 VA: 0x1822F9410
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F9690 Offset: 0x22F7C90 VA: 0x1822F9690
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8FC0 Offset: 0x22F75C0 VA: 0x1822F8FC0
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F8FE0 Offset: 0x22F75E0 VA: 0x1822F8FE0
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 4007
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E9640 Offset: 0x12E7C40 VA: 0x1812E9640 Slot: 12
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

	// RVA: 0x1A74550 Offset: 0x1A72B50 VA: 0x181A74550 Slot: 12
	public virtual void Invoke(int position) { }

	// RVA: 0x22FB730 Offset: 0x22F9D30 VA: 0x1822FB730 Slot: 13
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

	// RVA: 0x22FA850 Offset: 0x22F8E50 VA: 0x1822FA850
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x22FAF90 Offset: 0x22F9590 VA: 0x1822FAF90
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x22FABF0 Offset: 0x22F91F0 VA: 0x1822FABF0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x22FAEF0 Offset: 0x22F94F0 VA: 0x1822FAEF0
	private void Play(double delay) { }

	// RVA: 0x22FAC40 Offset: 0x22F9240 VA: 0x1822FAC40
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x22FB020 Offset: 0x22F9620 VA: 0x1822FB020
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x22FAF40 Offset: 0x22F9540 VA: 0x1822FAF40
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x22FA7F0 Offset: 0x22F8DF0 VA: 0x1822FA7F0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x22FA890 Offset: 0x22F8E90 VA: 0x1822FA890
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x22FB2B0 Offset: 0x22F98B0 VA: 0x1822FB2B0
	public float get_volume() { }

	// RVA: 0x22FB6E0 Offset: 0x22F9CE0 VA: 0x1822FB6E0
	public void set_volume(float value) { }

	// RVA: 0x22FA850 Offset: 0x22F8E50 VA: 0x1822FA850
	public float get_pitch() { }

	// RVA: 0x22FAF90 Offset: 0x22F9590 VA: 0x1822FAF90
	public void set_pitch(float value) { }

	// RVA: 0x22FB270 Offset: 0x22F9870 VA: 0x1822FB270
	public float get_time() { }

	// RVA: 0x22FB690 Offset: 0x22F9C90 VA: 0x1822FB690
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22FB230 Offset: 0x22F9830 VA: 0x1822FB230
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22FB650 Offset: 0x22F9C50 VA: 0x1822FB650
	public void set_timeSamples(int value) { }

	// RVA: 0x22FB0B0 Offset: 0x22F96B0 VA: 0x1822FB0B0
	public AudioClip get_clip() { }

	// RVA: 0x22FB2F0 Offset: 0x22F98F0 VA: 0x1822FB2F0
	public void set_clip(AudioClip value) { }

	// RVA: 0x22FB170 Offset: 0x22F9770 VA: 0x1822FB170
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x22FB480 Offset: 0x22F9A80 VA: 0x1822FB480
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FAEB0 Offset: 0x22F94B0 VA: 0x1822FAEB0
	public void Play() { }

	// RVA: 0x22FAB80 Offset: 0x22F9180 VA: 0x1822FAB80
	public void PlayDelayed(float delay) { }

	// RVA: 0x22FAE50 Offset: 0x22F9450 VA: 0x1822FAE50
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FAD80 Offset: 0x22F9380 VA: 0x1822FAD80
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x22FACA0 Offset: 0x22F92A0 VA: 0x1822FACA0
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x22FAFE0 Offset: 0x22F95E0 VA: 0x1822FAFE0
	public void Stop() { }

	// RVA: 0x22FA900 Offset: 0x22F8F00 VA: 0x1822FA900
	public void Pause() { }

	// RVA: 0x22FB070 Offset: 0x22F9670 VA: 0x1822FB070
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xB8780 Offset: 0xB7B80 VA: 0x1800B8780
	// RVA: 0x22FB0F0 Offset: 0x22F96F0 VA: 0x1822FB0F0
	public bool get_isPlaying() { }

	// RVA: 0x22FA940 Offset: 0x22F8F40 VA: 0x1822FA940
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x22FB390 Offset: 0x22F9990 VA: 0x1822FB390
	public void set_loop(bool value) { }

	// RVA: 0x22FB520 Offset: 0x22F9B20 VA: 0x1822FB520
	public void set_playOnAwake(bool value) { }

	// RVA: 0x22FB1B0 Offset: 0x22F97B0 VA: 0x1822FB1B0
	public float get_panStereo() { }

	// RVA: 0x22FB4D0 Offset: 0x22F9AD0 VA: 0x1822FB4D0
	public void set_panStereo(float value) { }

	// RVA: 0x22FB5B0 Offset: 0x22F9BB0 VA: 0x1822FB5B0
	public void set_spatialBlend(float value) { }

	// RVA: 0x22FAF40 Offset: 0x22F9540 VA: 0x1822FAF40
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x22FB340 Offset: 0x22F9940 VA: 0x1822FB340
	public void set_dopplerLevel(float value) { }

	// RVA: 0x22FB1F0 Offset: 0x22F97F0 VA: 0x1822FB1F0
	public float get_spread() { }

	// RVA: 0x22FB600 Offset: 0x22F9C00 VA: 0x1822FB600
	public void set_spread(float value) { }

	// RVA: 0x22FB570 Offset: 0x22F9B70 VA: 0x1822FB570
	public void set_priority(int value) { }

	// RVA: 0x22FB430 Offset: 0x22F9A30 VA: 0x1822FB430
	public void set_mute(bool value) { }

	// RVA: 0x22FB130 Offset: 0x22F9730 VA: 0x1822FB130
	public float get_maxDistance() { }

	// RVA: 0x22FB3E0 Offset: 0x22F99E0 VA: 0x1822FB3E0
	public void set_maxDistance(float value) { }

	// RVA: 0x22FA7F0 Offset: 0x22F8DF0 VA: 0x1822FA7F0
	public void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x22FA890 Offset: 0x22F8E90 VA: 0x1822FA890
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

	// RVA: 0x22F9E90 Offset: 0x22F8490 VA: 0x1822F9E90
	public float get_minDistance() { }

	// RVA: 0x22FA2C0 Offset: 0x22F88C0 VA: 0x1822FA2C0
	public void set_minDistance(float value) { }

	// RVA: 0x22F9E50 Offset: 0x22F8450 VA: 0x1822F9E50
	public float get_maxDistance() { }

	// RVA: 0x22FA270 Offset: 0x22F8870 VA: 0x1822FA270
	public void set_maxDistance(float value) { }

	// RVA: 0x22FA3F0 Offset: 0x22F89F0 VA: 0x1822FA3F0
	public void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x22FA050 Offset: 0x22F8650 VA: 0x1822FA050
	public int get_room() { }

	// RVA: 0x22FA4F0 Offset: 0x22F8AF0 VA: 0x1822FA4F0
	public void set_room(int value) { }

	// RVA: 0x22F9FD0 Offset: 0x22F85D0 VA: 0x1822F9FD0
	public int get_roomHF() { }

	// RVA: 0x22FA470 Offset: 0x22F8A70 VA: 0x1822FA470
	public void set_roomHF(int value) { }

	// RVA: 0x22FA010 Offset: 0x22F8610 VA: 0x1822FA010
	public int get_roomLF() { }

	// RVA: 0x22FA4B0 Offset: 0x22F8AB0 VA: 0x1822FA4B0
	public void set_roomLF(int value) { }

	// RVA: 0x22F9D90 Offset: 0x22F8390 VA: 0x1822F9D90
	public float get_decayTime() { }

	// RVA: 0x22FA180 Offset: 0x22F8780 VA: 0x1822FA180
	public void set_decayTime(float value) { }

	// RVA: 0x22F9D50 Offset: 0x22F8350 VA: 0x1822F9D50
	public float get_decayHFRatio() { }

	// RVA: 0x22FA130 Offset: 0x22F8730 VA: 0x1822FA130
	public void set_decayHFRatio(float value) { }

	// RVA: 0x22F9F10 Offset: 0x22F8510 VA: 0x1822F9F10
	public int get_reflections() { }

	// RVA: 0x22FA360 Offset: 0x22F8960 VA: 0x1822FA360
	public void set_reflections(int value) { }

	// RVA: 0x22F9ED0 Offset: 0x22F84D0 VA: 0x1822F9ED0
	public float get_reflectionsDelay() { }

	// RVA: 0x22FA310 Offset: 0x22F8910 VA: 0x1822FA310
	public void set_reflectionsDelay(float value) { }

	// RVA: 0x22F9F90 Offset: 0x22F8590 VA: 0x1822F9F90
	public int get_reverb() { }

	// RVA: 0x22FA430 Offset: 0x22F8A30 VA: 0x1822FA430
	public void set_reverb(int value) { }

	// RVA: 0x22F9F50 Offset: 0x22F8550 VA: 0x1822F9F50
	public float get_reverbDelay() { }

	// RVA: 0x22FA3A0 Offset: 0x22F89A0 VA: 0x1822FA3A0
	public void set_reverbDelay(float value) { }

	// RVA: 0x22F9CD0 Offset: 0x22F82D0 VA: 0x1822F9CD0
	public float get_HFReference() { }

	// RVA: 0x22FA090 Offset: 0x22F8690 VA: 0x1822FA090
	public void set_HFReference(float value) { }

	// RVA: 0x22F9D10 Offset: 0x22F8310 VA: 0x1822F9D10
	public float get_LFReference() { }

	// RVA: 0x22FA0E0 Offset: 0x22F86E0 VA: 0x1822FA0E0
	public void set_LFReference(float value) { }

	// RVA: 0x22F9E10 Offset: 0x22F8410 VA: 0x1822F9E10
	public float get_diffusion() { }

	// RVA: 0x22FA220 Offset: 0x22F8820 VA: 0x1822FA220
	public void set_diffusion(float value) { }

	// RVA: 0x22F9DD0 Offset: 0x22F83D0 VA: 0x1822F9DD0
	public float get_density() { }

	// RVA: 0x22FA1D0 Offset: 0x22F87D0 VA: 0x1822FA1D0
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

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23E170 Offset: 0x23D570 VA: 0x18023E170 Slot: 4
	public bool Equals(AudioClipPlayable other) { }

}

public class AudioMixer : Object // TypeDefIndex: 4015
{	// Methods

	// RVA: 0x22F9C70 Offset: 0x22F8270 VA: 0x1822F9C70
	internal void .ctor() { }

	// RVA: 0x22F99D0 Offset: 0x22F7FD0 VA: 0x1822F99D0
	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0xB9220 Offset: 0xB8620 VA: 0x1800B9220
	// RVA: 0x22F9970 Offset: 0x22F7F70 VA: 0x1822F9970
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F9910 Offset: 0x22F7F10 VA: 0x1822F9910
	public bool SetFloat(string name, float value) { }

	[NativeMethodAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22F98B0 Offset: 0x22F7EB0 VA: 0x1822F98B0
	public bool GetFloat(string name, out float value) { }

}

public class AudioMixerGroup : Object // TypeDefIndex: 4016
{	// Methods

	// RVA: 0x22F97B0 Offset: 0x22F7DB0 VA: 0x1822F97B0
	internal void .ctor() { }

}

public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 4017
{	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23E200 Offset: 0x23D600 VA: 0x18023E200 Slot: 4
	public bool Equals(AudioMixerPlayable other) { }

}

public class AudioMixerSnapshot : Object // TypeDefIndex: 4018
{	// Properties
	[NativePropertyAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public AudioMixer audioMixer { get; }

	// Methods

	// RVA: 0x22F9870 Offset: 0x22F7E70 VA: 0x1822F9870
	public AudioMixer get_audioMixer() { }

	// RVA: 0x22F9810 Offset: 0x22F7E10 VA: 0x1822F9810
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
	// RVA: 0x22FA530 Offset: 0x22F8B30 VA: 0x1822FA530
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FA550 Offset: 0x22F8B50 VA: 0x1822FA550
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 4021
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22FB840 Offset: 0x22F9E40 VA: 0x1822FB840 Slot: 12
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	// RVA: 0x22FB7B0 Offset: 0x22F9DB0 VA: 0x1822FB7B0 Slot: 13
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

	// RVA: 0x1FF9350 Offset: 0x1FF7950 VA: 0x181FF9350
	public static void ResetToPool(AudioEntity instance) { }

	// RVA: 0x1FF92B0 Offset: 0x1FF78B0 VA: 0x181FF92B0
	public void ResetToPool() { }

	// RVA: 0x1FF8F60 Offset: 0x1FF7560 VA: 0x181FF8F60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07AD0 Offset: 0x1C060D0 VA: 0x181C07AD0
	public void CopyTo(AudioEntity instance) { }

	// RVA: 0x1FF7DD0 Offset: 0x1FF63D0 VA: 0x181FF7DD0
	public AudioEntity Copy() { }

	// RVA: 0x1FF8A20 Offset: 0x1FF7020 VA: 0x181FF8A20
	public static AudioEntity Deserialize(Stream stream) { }

	// RVA: 0x1FF7E50 Offset: 0x1FF6450 VA: 0x181FF7E50
	public static AudioEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF81B0 Offset: 0x1FF67B0 VA: 0x181FF81B0
	public static AudioEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF8710 Offset: 0x1FF6D10 VA: 0x181FF8710
	public static AudioEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1FF9080 Offset: 0x1FF7680 VA: 0x181FF9080
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF9930 Offset: 0x1FF7F30 VA: 0x181FF9930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF9950 Offset: 0x1FF7F50 VA: 0x181FF9950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AudioEntity previous) { }

	// RVA: 0x1FF9290 Offset: 0x1FF7890 VA: 0x181FF9290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF8C70 Offset: 0x1FF7270 VA: 0x181FF8C70
	public static AudioEntity Deserialize(byte[] buffer, AudioEntity instance, bool isDelta = False) { }

	// RVA: 0x1FF8500 Offset: 0x1FF6B00 VA: 0x181FF8500
	public static AudioEntity Deserialize(Stream stream, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF7ED0 Offset: 0x1FF64D0 VA: 0x181FF7ED0
	public static AudioEntity DeserializeLengthDelimited(Stream stream, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF8240 Offset: 0x1FF6840 VA: 0x181FF8240
	public static AudioEntity DeserializeLength(Stream stream, int length, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF93F0 Offset: 0x1FF79F0 VA: 0x181FF93F0
	public static void SerializeDelta(Stream stream, AudioEntity instance, AudioEntity previous) { }

	// RVA: 0x1FF97D0 Offset: 0x1FF7DD0 VA: 0x181FF97D0
	public static void Serialize(Stream stream, AudioEntity instance) { }

	// RVA: 0x1FF9920 Offset: 0x1FF7F20 VA: 0x181FF9920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF9930 Offset: 0x1FF7F30 VA: 0x181FF9930
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF96C0 Offset: 0x1FF7CC0 VA: 0x181FF96C0
	public static byte[] SerializeToBytes(AudioEntity instance) { }

	// RVA: 0x1FF9610 Offset: 0x1FF7C10 VA: 0x181FF9610
	public static void SerializeLengthDelimited(Stream stream, AudioEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x837770 Offset: 0x835D70 VA: 0x180837770 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x838900 Offset: 0x836F00 VA: 0x180838900 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x837D30 Offset: 0x836330 VA: 0x180837D30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8389D0 Offset: 0x836FD0 VA: 0x1808389D0
	public AudioVisualisationEntity.LightColour get_currentColour() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838A10 Offset: 0x837010 VA: 0x180838A10
	private void set_currentColour(AudioVisualisationEntity.LightColour value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838A00 Offset: 0x837000 VA: 0x180838A00
	public AudioVisualisationEntity.VolumeSensitivity get_currentVolumeSensitivity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838A40 Offset: 0x837040 VA: 0x180838A40
	private void set_currentVolumeSensitivity(AudioVisualisationEntity.VolumeSensitivity value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8389F0 Offset: 0x836FF0 VA: 0x1808389F0
	public AudioVisualisationEntity.Speed get_currentSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838A30 Offset: 0x837030 VA: 0x180838A30
	private void set_currentSpeed(AudioVisualisationEntity.Speed value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8389E0 Offset: 0x836FE0 VA: 0x1808389E0
	public int get_currentGradient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838A20 Offset: 0x837020 VA: 0x180838A20
	private void set_currentGradient(int value) { }

	// RVA: 0x837B90 Offset: 0x836190 VA: 0x180837B90 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x838370 Offset: 0x836970 VA: 0x180838370
	private void UpdateInvoke() { }

	// RVA: 0x838240 Offset: 0x836840 VA: 0x180838240 Slot: 27
	public override void ResetState() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 159
	protected virtual void UpdateVisualisation(float volume, bool force = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x837680 Offset: 0x835C80 VA: 0x180837680
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

	// RVA: 0x8388A0 Offset: 0x836EA0 VA: 0x1808388A0
	protected bool get_HasAudioSource() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 165
	protected virtual void UpdateVisualSettings() { }

	[BaseEntity.Menu] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	[BaseEntity.Menu.Description] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	[BaseEntity.Menu.Icon] // RVA: 0xB20B0 Offset: 0xB14B0 VA: 0x1800B20B0
	// RVA: 0x837580 Offset: 0x835B80 VA: 0x180837580
	public void ChangeLightSettings(BasePlayer player) { }

	// RVA: 0x8382D0 Offset: 0x8368D0 VA: 0x1808382D0
	public void SendNewLightSettings(int newColour, int newVolumeRange, int newSpeed, int newGradient) { }

	// RVA: 0x55C070 Offset: 0x55A670 VA: 0x18055C070
	private bool CanChangeLightSettings(BasePlayer player) { }

	// RVA: 0x2FA9A0 Offset: 0x2F8FA0 VA: 0x1802FA9A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x837A90 Offset: 0x836090 VA: 0x180837A90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x838830 Offset: 0x836E30 VA: 0x180838830
	public void .ctor() { }

	// RVA: 0x8387E0 Offset: 0x836DE0 VA: 0x1808387E0
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

	// RVA: 0x835D90 Offset: 0x834390 VA: 0x180835D90
	public void .ctor() { }

}

public class AudioSettings : MonoBehaviour // TypeDefIndex: 9122
{	// Fields
	public AudioMixer mixer; // 0x18

	// Methods

	// RVA: 0x836140 Offset: 0x834740 VA: 0x180836140
	private void Update() { }

	// RVA: 0x8360C0 Offset: 0x8346C0 VA: 0x1808360C0
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

	// RVA: 0x836700 Offset: 0x834D00 VA: 0x180836700 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x837200 Offset: 0x835800 VA: 0x180837200 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x8368B0 Offset: 0x834EB0 VA: 0x1808368B0
	private float GetCurrentSpeedValue() { }

	// RVA: 0x8368F0 Offset: 0x834EF0 VA: 0x1808368F0
	private void GetCurrentVolumeRange(out float min, out float max) { }

	// RVA: 0x836CA0 Offset: 0x8352A0 VA: 0x180836CA0
	private void UpdateLightComponentSettings() { }

	// RVA: 0x8367D0 Offset: 0x834DD0 VA: 0x1808367D0
	private AudioVisualisationEntityLight.LightColourSet EnumToColour(AudioVisualisationEntity.LightColour colour) { }

	// RVA: 0x836D90 Offset: 0x835390 VA: 0x180836D90
	private void UpdateRenderer(float volumeNormalised) { }

	// RVA: 0x837100 Offset: 0x835700 VA: 0x180837100 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 160
	public override bool get_ShowColourOption() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x836940 Offset: 0x834F40 VA: 0x180836940 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x8374C0 Offset: 0x835AC0 VA: 0x1808374C0
	public void .ctor() { }

	// RVA: 0x837460 Offset: 0x835A60 VA: 0x180837460
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

	// RVA: 0x835DF0 Offset: 0x8343F0 VA: 0x180835DF0
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

	// RVA: 0x6CB0B0 Offset: 0x6C96B0 VA: 0x1806CB0B0
	public static int get_speakers() { }

	// RVA: 0x6CC470 Offset: 0x6CAA70 VA: 0x1806CC470
	public static void set_speakers(int value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CC220 Offset: 0x6CA820 VA: 0x1806CC220
	public static void printSounds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x89390 Offset: 0x88790 VA: 0x180089390
	// RVA: 0x6CB0C0 Offset: 0x6C96C0 VA: 0x1806CB0C0
	public static void printEngineSounds(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CB050 Offset: 0x6C9650 VA: 0x1806CB050
	public void .ctor() { }

	// RVA: 0x6CAF20 Offset: 0x6C9520 VA: 0x1806CAF20
	private static void .cctor() { }

}

