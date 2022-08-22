public class Megaphone : HeldEntity // TypeDefIndex: 8604
{	// Fields
	[HeaderAttribute] // RVA: 0xB04C0 Offset: 0xAF8C0 VA: 0x1800B04C0
	public VoiceProcessor voiceProcessor; // 0x1F8
	public float VoiceDamageMinFrequency; // 0x200
	public float VoiceDamageAmount; // 0x204
	public AudioSource VoiceSource; // 0x208
	public SoundDefinition StartBroadcastingSfx; // 0x210
	public SoundDefinition StopBroadcastingSfx; // 0x218
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static float <MegaphoneVoiceRange>k__BackingField; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool IgnorePushToTalk; // 0x4
	private static int BroadcastBoolAnim; // 0x8
	private float talkingLayerWeight; // 0x220

	// Properties
	[ReplicatedVar] // RVA: 0xB07E0 Offset: 0xAFBE0 VA: 0x1800B07E0
	public static float MegaphoneVoiceRange { get; set; }

	// Methods

	// RVA: 0x95D240 Offset: 0x95B840 VA: 0x18095D240 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95D560 Offset: 0x95BB60 VA: 0x18095D560
	public static float get_MegaphoneVoiceRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95D620 Offset: 0x95BC20 VA: 0x18095D620
	public static void set_MegaphoneVoiceRange(float value) { }

	// RVA: 0x95D330 Offset: 0x95B930 VA: 0x18095D330
	public bool Receive(byte[] data) { }

	// RVA: 0x95CE10 Offset: 0x95B410 VA: 0x18095CE10 Slot: 138
	public override void OnInput() { }

	// RVA: 0x95D440 Offset: 0x95BA40 VA: 0x18095D440
	private void Update() { }

	// RVA: 0x95CC30 Offset: 0x95B230 VA: 0x18095CC30 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x95D4F0 Offset: 0x95BAF0 VA: 0x18095D4F0
	public void .ctor() { }

	// RVA: 0x95D480 Offset: 0x95BA80 VA: 0x18095D480
	private static void .cctor() { }

}

